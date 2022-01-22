using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public Guid BookID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

       
        [MaxLength(2500)]
        public string Description { get; set; }

        public Guid AuthorID { get; set; }

        public Author Author { get; set; }
    }
}
