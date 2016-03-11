﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Common;
using Common.Models;

namespace Test1.Controllers
{
    public class DongTaiController : Controller
    {
        private clsConn.ConnDBContext db = new clsConn.ConnDBContext();
        //
        // GET: /DongTai/
        public ActionResult Index()
        {
            var courses = db.Database.SqlQueryForDynamic("SELECT * FROM Exam_e_CourseInfo");

            return View(courses);
        }
	}
}