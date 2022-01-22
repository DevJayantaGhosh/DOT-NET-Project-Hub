using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.DTO
{
    public class CategoryResponseDTO
    {
        public Category Category { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

    }
}
