using Microsoft.EntityFrameworkCore;
using DotnetTask.Models;


namespace DotnetTask.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        // On ajoutera les autres plus tard (Commentaires, SousTâches, etc.)
    }
}