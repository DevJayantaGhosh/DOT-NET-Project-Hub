using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Controllers
{
    public class MyConfigDemoController : Controller
    {
        private readonly IConfiguration config;
        

        public MyConfigDemoController(IConfiguration config)
        {
            this.config = config;
        }

        public IActionResult Index()
        {
            string x = config.GetValue<string>("MyData");
            Console.WriteLine("=--=-=-="+x);
            return View("Index",x);
        }
    }
}
