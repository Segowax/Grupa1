using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
    public static class ProductSeed
    {
        public static EntityTypeBuilder<Product> Seed(this EntityTypeBuilder<Product>)
        {
            EntityTypeBuilder.HasData(new Product()
            {
                Id = 1,
                Guid = new Guid(""),
                Name = "Product",

            
            