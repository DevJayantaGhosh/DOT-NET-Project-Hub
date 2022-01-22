using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Experiment.DAL
{
    [Index(nameof(CategoryRefNo), Name = "IX_Products_CategoryRefNo")]
    public partial class Product
    {
        [Key]
        public int ProdId { get; set; }
        [Required]
        public string ProdName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProdPrice { get; set; }
        public int CategoryRefNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(CategoryRefNo))]
        [InverseProperty(nameof(Category.Products))]
        public virtual Category CategoryRefNoNavigation { get; set; }
    }
}
