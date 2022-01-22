using Experiment.ModelViewDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Controllers
{
    public class DynamicPartialViewController : Controller
    {
        public IActionResult Index()
        {
            List<DynamicPartialViewModel> list = new List<DynamicPartialViewModel>();

            DynamicPartialViewModel d1 = new DynamicPartialViewModel();
            d1.ControllerName = "MyPartialViewActivity";
            d1.ActionName = "Index";
            d1.ValueName = "B1";
            DynamicPartialViewModel d2 = new DynamicPartialViewModel();
            d2.ControllerName = "SingleView";
            d2.ActionName = "Index";
            d2.ValueName = "B2";


            list.Add(d1);
            list.Add(d2);
            return View("Show", list);
        }


        
        public IActionResult DataPartial()
        {
            List<DynamicPartialViewModel> list = new List<DynamicPartialViewModel>();

            DynamicPartialViewModel d1 = new DynamicPartialViewModel();
            d1.ControllerName = "MyPartialViewActivity";
            d1.ActionName = "Index";
            d1.ValueName = "B1-MyPartialViewActivity";
            DynamicPartialViewModel d2 = new DynamicPartialViewModel();
            d2.ControllerName = "SingleView";
            d2.ActionName = "Index";
            d2.ValueName = "B2-SingleView";


            list.Add(d1);
            list.Add(d2);
            return PartialView("_DynamicListViewFromDB", list);
        }

    }
}
