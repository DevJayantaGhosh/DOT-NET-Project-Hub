using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Category : BaseModel
    {
        private const string V = "max Length is 15";

        [Key]
        public int CategoryNo { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(50,ErrorMessage ="The max length is 50")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
