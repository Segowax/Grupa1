using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
    internal class OrderSeed
    {
        public static List<Order> GetSeedData()
        {
            return new List<Order>
           {
               new Order {Id = 1, Name = "First Order"},
               new Order {Id = 2, Name = "Second Order"}
           };
        }
    }
}
