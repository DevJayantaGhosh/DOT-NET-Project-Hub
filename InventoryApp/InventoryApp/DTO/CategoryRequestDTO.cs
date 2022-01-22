using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.DTO
{
    public class CategoryRequestDTO
    {
        [Required]
        public String CategoryName { get; set; }
       
    }
}
