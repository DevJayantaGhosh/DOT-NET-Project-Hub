using Experiment.ModelViewDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Controllers
{
    public class MyPartialViewActivityController : Controller
    {
        public IActionResult Index()
        {
            return View("Mymainpage");
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult MyLogin( LoginViewModel model)
        {
            return View("Mymainpage");
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult MyRegi(RegisterViewModel model)
        {
            return View("Mymainpage");
        }
    }
}
