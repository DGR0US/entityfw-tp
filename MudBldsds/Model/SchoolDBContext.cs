using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MudBldsds.Model
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appSettings.json"))
                        .Build();
            optionsBuilder.UseNpgsql(config["ConnectionStrings:ConStr1"])
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
