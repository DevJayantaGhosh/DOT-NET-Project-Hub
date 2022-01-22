using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.ModelViewDTO
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter Your UserName")]
        public string MyRegisterName { get; set; }
        [Required(ErrorMessage = "Please Enter Your PSW")]
        public string MyRegsterPass { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [EmailAddress(ErrorMessage ="Enter Valid Email")]
        public string MyRegsterEmail { get; set; }
    }
}
