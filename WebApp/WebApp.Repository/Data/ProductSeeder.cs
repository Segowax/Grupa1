using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.Data
{
    public static class ProductSeeding
    {
        public static void ProductSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Smartphone", Price = 4999, CategoryId = 1 },
                new Product { Id = 2, Name = "Laptop", Price = 6499, CategoryId = 1 }
                );
        }
    }
}
