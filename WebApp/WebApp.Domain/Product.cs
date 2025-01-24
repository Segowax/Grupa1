﻿
namespace WebApp.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string Category { get; set; }
        public Guid Guid { get; set; }
    }
}
