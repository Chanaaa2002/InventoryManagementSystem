using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class OrderItem
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        
    }
}
