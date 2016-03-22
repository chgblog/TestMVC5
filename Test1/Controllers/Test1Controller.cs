using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Test1.Models;
using Common.ViewModels;
using System.Net;
using System.Data.Entity;

namespace Test1.Controllers
{
    public class Test1Controller : Controller
    {
        private clsConn.ConnDBContext db = new clsConn.ConnDBContext();
        private CeShiDBContext dbCeShi = new CeShiDBContext();

        //
        // GET: /Test1/
        public ActionResult Index(string name, int id = 0)
        {
            ViewBag.MachineName = Server.MachineName;
            ViewBag.DateStamp = HttpContext.Timestamp;
            ViewBag.Controller = RouteData.Values["controller"];
            ViewBag.Action = RouteData.Values["Action"];
            TempData["name"] = "Temp Session";

            /*
            var arrCeShi = dbCeShi.CeShis.ToList();
            */
            var arrKeCheng = (from kecheng in db.Exam_e_CourseInfo select kecheng).Take(10);
            return View(arrKeCheng);
            //return new RedirectResult("~/Test1/Submit");
        }

        [HandleError]
        public ActionResult Modify(string KeChengDaiMa)
        {
            if (string.IsNullOrEmpty(KeChengDaiMa))
            {
                ViewBag.ErrorInfo = "参数错误";
                return View("Error");
            }
            var modKeCheng = db.Exam_e_CourseInfo.Where(KeCheng => KeCheng.CourseCode == KeChengDaiMa).First();
            if (modKeCheng == null)
            {
                ViewBag.ErrorInfo = "没有找到该课程";
                return View("Error");
            }
            else
            {
                return View(modKeCheng);
            }
            return View();
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
            else
            {
                ViewBag.ErrorInfo = "信息验证失败";
                return View(modKeCheng);
            }
            return View(modKeCheng);
        }

        public ActionResult Submit()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Submit(CeShi modCeShi)
        {
            modCeShi = modCeShi ?? new CeShi();
            return View("SubmitResult", modCeShi);
        }
	}
}