using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.BaseEntity;

namespace WebApp.Domain
{
    public class Order : Base
    {
        public string Name { get; set; } = string.Empty;

        public Order()
        {
        }
        public Order(int id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}
