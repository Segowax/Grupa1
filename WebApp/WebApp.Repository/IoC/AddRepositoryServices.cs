﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Repository.DbContexts;

namespace WebApp.Repository.IoC
{
    public static class AddRepositoryServices
    {
        public static IServiceCollection RegisterRepositoryServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ShopDbContext"));
            });

            return services;
        }
    }
}