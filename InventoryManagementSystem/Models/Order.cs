﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
    }
}
