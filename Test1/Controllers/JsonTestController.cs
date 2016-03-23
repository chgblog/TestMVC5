using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Common.Models;

namespace Test1.Controllers
{
    public class JsonTestController : Controller
    {
        private clsConn.ConnDBContext db = new clsConn.ConnDBContext();

        //
        // GET: /Json/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCourses(string KeChengDaiMa)
        {
            var courses = db.Database.SqlQueryForDynamic(string.Format("SELECT * FROM Exam_e_CourseInfo WHERE CourseCode='{0}'", KeChengDaiMa));

            return Json(courses);
        }
	}
}