using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Test1.Models;
using Common.Models;
using System.Net;
using System.Data.Entity;

namespace Test1.Controllers
{
    public class Test1Controller : Controller
    {
        private clsConn.ConnDBContext db = new clsConn.ConnDBContext();

        //
        // GET: /Test1/
        public ActionResult Index(string name, int id = 0)
        {
            var arrKeCheng = (from kecheng in db.Exam_e_CourseInfo select kecheng).Take(10);
            return View(arrKeCheng.ToList());
        }

        public ActionResult Modify(string KeChengDaiMa)
        {
            if (string.IsNullOrEmpty(KeChengDaiMa))
            {
                ViewBag.ErrorInfo = "参数错误";
                return View("Error");
            }
            var modKeCheng = db.Exam_e_CourseInfo.Where(KeCheng => KeCheng.CourseCode == KeChengDaiMa).FirstOrDefault();
            if (modKeCheng == null)
            {
                ViewBag.ErrorInfo = "没有找到该课程";
                return View("Error");
            }
            else
            {
                return View(modKeCheng);
            }
        }

        [HttpPost]
        public ActionResult Modify(Exam_e_CourseInfo modKeCheng)
        {
            if(ModelState.IsValid)
            {
                db.Entry(modKeCheng).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modKeCheng);
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