using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.DTO
{
    public class ProductResponseListDTO
    {
        public ICollection<Product> Products { get; set; }
        public int SatatusCode { get; set; }
        public string Message { get; set; }
    }
}
