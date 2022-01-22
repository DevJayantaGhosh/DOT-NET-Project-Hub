using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySecuredApp.MyUserDB
{
  [Table("MyUser_tbl")]
    public class MyUser
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Display(Name ="User Name")]
        [Column("User_Name")]
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "User Email")]
        [Column("User_Email")]
        [EmailAddress]
        [MaxLength(250)]
        [MinLength(5)]
        public string EmailID { get; set; }

        [Display(Name = "User Password")]
        [Column("User_password")]
        [Required]
        [MaxLength(250)]
        [MinLength(5)]
        public string HashPassword { get; set; }
    }
}
