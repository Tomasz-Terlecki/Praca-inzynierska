using Microsoft.EntityFrameworkCore;
using SqlServerConnectorTemplate.Models;

namespace SqlServerConnectorTemplate
{
    public class TestDbContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=toyotatest; Database=TestDb; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>()
                .HasMany(p => p.Children)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
