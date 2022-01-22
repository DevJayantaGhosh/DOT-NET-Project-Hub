using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.ModelViewDTO
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Enter Your UserName")]
        public string MyUserName { get; set; }
        [Required(ErrorMessage = "Please Enter Your PSW")]
        public string MyUserPass { get; set; }

    }
}
