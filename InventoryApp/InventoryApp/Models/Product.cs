using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Product : BaseModel
    {
        [Key]
        public int ProdId { get; set; }
        [Required]
        public string ProdName { get; set; }
        [Required]
        public decimal ProdPrice { get; set; }

       [ForeignKey("RefCategory")] //if you want to make different name of your foreign key "RefCategory" is same Line no 21
        public int CategoryRefNo { get; set; }
        public Category RefCategory { get; set; }
    }
}
