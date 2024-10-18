using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Database
{
    public class Item
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item(int id, Guid guid, string name, int quantity)
        {
            Id = id;
            Guid = guid;
            Name = name;
            Quantity = quantity;
        }
    }
}

