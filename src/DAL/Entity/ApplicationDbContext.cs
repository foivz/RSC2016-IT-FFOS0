using DAL.Models;
using DAL.Models.Lookup;
using HackathonVZ.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HackathonVZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        #region Lookup Tables

        public DbSet<Country> Country { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<QuestionType> QuestionType { get; set; }
        public DbSet<Modifier> Modifier { get; set; }

        #endregion Lookup Tables

        #region Data tables

        public DbSet<Image> Image { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<QuizRound> QuizRound { get; set; }
        public DbSet<QuizTeam> QuizTeam { get; set; }
        public DbSet<RoundQuestion> RoundQuestion { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamAnswer> TeamAnswer { get; set; }
        public DbSet<TeamMember> TeamMember { get; set; }

        #endregion Data tables
    }
}