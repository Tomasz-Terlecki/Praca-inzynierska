using CostsSettler.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CostsSettler.Repository
{
    public class CostsSettlerDbContext : DbContext
    {
        public CostsSettlerDbContext(DbContextOptions<CostsSettlerDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
