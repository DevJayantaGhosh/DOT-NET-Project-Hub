using Experiment.Helper;
using Experiment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration c)
        {
            this.configuration = c;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Tophead:innerKey");
            string comp = configuration.GetSection("Developer:Comapany").Value;
            ViewBag.comdata = comp;

            Developer dev = new Developer();
            dev = configuration.GetSection("Developer").Get<Developer>();
            //DevName == devname only same name mappe to same property


            return View(dev);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
