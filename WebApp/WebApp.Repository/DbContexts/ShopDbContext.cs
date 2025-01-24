using Microsoft.EntityFrameworkCore;
using WebApp.Domain;

namespace WebApp.Repository.DbContexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

       public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
