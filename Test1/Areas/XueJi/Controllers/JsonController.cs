using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Models;

namespace Test1.Areas.XueJi.Controllers
{
    public class JsonController : Controller
    {
        //
        // GET: /XueJi/Json/
        public ActionResult Index()
        {
            Student studentModel = new Student();
            studentModel.XueHao = "001";
            studentModel.XingMing = "张三";
            studentModel.NianLing = 25;

            return View(studentModel);
        }

        public ActionResult SaveStudent(Student studentModel)
        {
            //保存数据

            //保存成功后返回保存的数据
            return Json(studentModel);
        }

        public ActionResult GetNewStudent()
        {
            Student studentModel = new Student();
            studentModel.XueHao = "002";
            studentModel.XingMing = "王五";
            studentModel.NianLing = 26;

            //返回Json格式
            return Json(studentModel);
        }

	}
}