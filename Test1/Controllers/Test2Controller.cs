using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class Test2Controller : Controller
    {
        //
        // GET: /Test2/
        public ActionResult Index()
        {
            int i = 5;
            return View(i);
        }
	}
}