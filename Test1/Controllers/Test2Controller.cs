using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Test1.Common;

namespace Test1.Controllers
{
    public class Test2Controller : Controller
    {
        [OutputCache(Duration = 60, Location = OutputCacheLocation.Client)]
        public ActionResult Index()
        {
            int i = 5;
            return View(i);
        }

        [ActionName("View")]
        public ActionResult ViewController()
        {
            //Thread.Sleep(1000);
            this.ViewBag.Title = "------------------View------------------";
            return View();
        }
	}
}