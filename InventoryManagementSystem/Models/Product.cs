﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }           
        public string Name { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product() { }

        public Product(int id, string name, string sku, int quantity, decimal price)
        {
            Id = id;
            Name = name;
            SKU = sku;
            Quantity = quantity;
            Price = price;
        }
        public override string ToString() => Name;


    }
}
