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
   public static class UserSeed
    {
        public static EntityTypeBuilder<User> Seed(this EntityTypeBuilder<User>)
        {
            EntityTypeBuilder.HasData(new User()
            {
                Id = 1,
                Guid = new Guid(""),
                Name = "User",
                Password = "User",
                Role = RoleType.User.ToString(),
                Email = "test@gmail.com",
            });
        }
    }
}
