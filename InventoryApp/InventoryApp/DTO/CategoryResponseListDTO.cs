using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.DTO
{
    public class CategoryResponseListDTO
    {
        public ICollection<Category> Categorys { get; set; } = new List<Category>();
        public string Message { get; set; }
        public int StatusCode { get; set; }

    }
}
