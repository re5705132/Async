using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace ShopDbContext
{
    public class ShopContext : DbContext, IContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"server=(localDb)\msSqlLocalDb;database=ShopDb;Trusted_Connection=True");
    }
}