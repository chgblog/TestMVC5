using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class Test1Controller : Controller
    {
        //
        // GET: /Test1/
        public ActionResult Index(string name, int id = 0)
        {
            return View();
        }

        public ActionResult Submit(string name, int id = 0)
        {
            ViewBag.Name = name;
            ViewBag.ID = id;
            //return string.Format("<b>Hello {0}，你{1}岁了</b>", name, id);
            return View();
        }
	}
}