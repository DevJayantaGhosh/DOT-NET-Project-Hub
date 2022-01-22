using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Controllers
{
    public class SingleViewController : Controller
    {
        public IActionResult Index()
        {
            return View("Singlemain");
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult MyLogin(IFormCollection loginData)
        {
            string username = loginData["myUName"];
            string password = loginData["myUPass"];
            return View("Singlemain");
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult MySignUp(IFormCollection registerData)
        {
            string username = registerData["myRegiUName"];
            string password =registerData["myRegiPass"];
            string email = registerData["myRegiEmail"];
            return View("Singlemain");
        }
    }
}
