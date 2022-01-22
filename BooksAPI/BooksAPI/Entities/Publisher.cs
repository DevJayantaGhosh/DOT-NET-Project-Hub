using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Entities
{
    public class Publisher
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string PublisherName { get; set; }
    }
}
