using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Test1.Models;

namespace Test1.Controllers
{
    public class Test1Controller : Controller
    {
        //
        // GET: /Test1/
        public ActionResult Index(string name, int id = 0)
        {
            var a = "aaa";
            a.PrintString();
            return View();
        }

        public ActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(CeShi modCeShi)
        {
            return View("SubmitResult", modCeShi);
        }
	}
}