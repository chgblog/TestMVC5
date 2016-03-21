using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Common;
using Common.Models;
using System.Collections;
using Common;

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

        public ActionResult Modify(string KeChengDaiMa)
        {
            string strSQL = "SELECT TOP 1 * FROM Exam_e_CourseInfo WHERE 1=1";
            if(!string.IsNullOrEmpty(KeChengDaiMa))
            {
                strSQL += string.Format(" AND CourseCode='{0}'", KeChengDaiMa);
            }
            IEnumerable objCourse = db.Database.SqlQueryForDynamic(strSQL);

            return View(objCourse);
        }
	}
}