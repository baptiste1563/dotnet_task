using Microsoft.EntityFrameworkCore;
using dotnet_tack.Models;

namespace dotnet_tack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<dotnet_tack.Models.Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Remplacez par votre chaîne de connexion MySQL
            var connectionString = "server=localhost;database=dotnet_tack;user=root;password=";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
           
        }
    }
}
