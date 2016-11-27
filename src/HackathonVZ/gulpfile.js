"use strict";

// Requirements
var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    uglify = require("gulp-uglify"),
    rename = require('gulp-rename'),
    // postcss plugins
    postcss = require('gulp-postcss'),
    svgSprite = require('gulp-svg-sprite'),
    plumber = require('gulp-plumber'),
    mixins = require('postcss-mixins'),
    simplevars = require('postcss-simple-vars'),
    nested = require('postcss-nested'),
    customMedia = require('postcss-custom-media'),
    colorFunction = require('postcss-color-function'),
    calc = require('postcss-calc'),
    autoprefixer = require('autoprefixer'),
    atImport = require('postcss-import'),
    cssNano = require('cssnano'),
    lost = require('lost'),
    colorFunction = require('postcss-color-function');

// Define paths
var paths = {
    webroot: "./wwwroot/"
};

// Build source and destinations paths
    paths.js = paths.webroot + "js/**/*.js";
    paths.minJs = paths.webroot + "js/**/*.min.js";
    paths.css = paths.webroot + "css/**/*.css";
    paths.minCss = paths.webroot + "css/**/*.min.css";
    paths.postCss = paths.webroot + "src/css/app.css"
    paths.svg = paths.webroot + "src/sprites/**/*svg";
    paths.svgDest = paths.webroot + "images/sprites";
    paths.concatJsDest = paths.webroot + "js/site.min.js";
    paths.concatCssDest = paths.webroot + "css/site.min.css";

// Build an SVG sprite from singular .svg files
var svgConfig = {
    mode: {
        symbol: true
    }
};

gulp.task("svgBuild", function () {
    gulp.src(paths.svg)
        .pipe(svgSprite(svgConfig))
        .pipe(gulp.dest(paths.svgDest))
});

// Build CSS using PostCSS
gulp.task('cssBuild', function () {
    var postCSSPlugins = [
      // Import CSS file to be built with it's imports
      atImport({
          from: paths.postCss
      }),
      // Add mixin PostCSS support
      mixins,
      // Add variables PostCSS support
      simplevars,
      // Add nesting PostCSS support
      nested,
      // Add CSS color functions PostCSS support
      colorFunction,
      // Add calc PostCSS support
      calc,
      // Add custom media queries PostCSS support
      customMedia,
      // Add W3C CSS color function to more compatible CSS PostCSS support
      colorFunction,
      // Add lost grid support
      lost,
      // Add vendor prefixing PostCSS support
      autoprefixer({
          browsers: ['last 2 version']
      })
    ];
    return gulp.src(paths.postCss)
      // Prevent pipe breaking caused by errors from gulp plugins
      .pipe(plumber({
          errorHandler: function (err) {
              console.log(err);
              this.emit('end');
          }
      }))
      // Add PostCSS plugins to pipe
      .pipe(postcss(postCSSPlugins))
      // Processed folder file destination
      .pipe(rename('site.css'))
      .pipe(gulp.dest('wwwroot/dist/css'))
      // Minify the CSS
      .pipe(postcss([
          cssNano
      ]))
      // Rename
      .pipe(rename('site.min.css'))
      .pipe(gulp.dest('wwwroot/dist/css'))
});
gulp.task("min:js", function () {
    return gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

// Run all tasks and watchers
gulp.task('build', ['cssBuild', 'svgBuild', 'min:js'], function () {
    gulp.watch(paths.webroot + 'src/css/**/*.css', ['cssBuild']);
    gulp.watch(paths.webroot + 'src/sprites/**/*.svg', ['svgBuild']);
    });