using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.BaseEntity;

namespace WebApp.Domain
{
    public class User : Base
    {
        public required string Login { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Role { get; set; }
    }
}
