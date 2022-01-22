using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.DTO
{
    public class ProductRequestDTO
    {
        public Product Product { get; set; }
        public int SatatusCode { get; set; }
        public string Message { get; set; }
    }
}
