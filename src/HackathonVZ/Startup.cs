using HackathonVZ.Config;
using HackathonVZ.Data;
using HackathonVZ.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Repository.Implementation;
using Repository.Interface;
using Service.Implementation;
using Service.Interface;

namespace HackathonVZ
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }
            MapperConfig.RegisterMaps();
            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc(options =>
            {
                options.SslPort = 44375;
                options.Filters.Add(new RequireHttpsAttribute());
            });

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddSingleton<ILookupService, LookupService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IQuizService, QuizService>();

            // Add application repos.
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ILookupRepository, LookupRepository>();
            services.AddTransient<IQuizRepository, QuizRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IServiceScopeFactory scopeFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            scopeFactory.SeedData();

            app.UseStaticFiles();

            app.UseIdentity();

            app.UseFacebookAuthentication(new FacebookOptions()
            {
                AppId = "169540603512468",
                AppSecret = "9ccf3edf8d82c06a48323c3254e84cbb"
            });

            app.UseGoogleAuthentication(new GoogleOptions()
            {
                ClientId = "147724753456-eejmhtmcn4jolfu8prlohc7q82v71gqd.apps.googleusercontent.com",
                ClientSecret = "jisKl_0tccHPXHEEKSolYa8d"
            });

            app.UseTwitterAuthentication(new TwitterOptions()
            {
                ConsumerKey = "dzUeMvUvKALDyBRTlxXnHsMZX",
                ConsumerSecret = "wERuc6RFSiwp125gKR9p9ZKn0c5KQW9edBRgW7ZRa9t3pJaPoT"
            });

            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}