using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Models;
using Common;

namespace Test1.Controllers
{
    public class TestModelController : Controller
    {
        //
        // GET: /TestModel/
        public ActionResult Index()
        {
            Model1 model1 = new Model1();
            model1.Name = "test1";
            TestModel<Model1> testModel1 = new TestModel<Model1>();
            testModel1.Add(model1);

            Model2 model2 = new Model2();
            model2.Name = "test2";
            model2.Age = 11;
            TestModel<Model2> testModel2 = new TestModel<Model2>();
            testModel2.Add(model2);

            Model3 model3 = new Model3();
            model3.Name = "test3";
            model3.Sex = "男";
            TestModel<Model3> testModel3 = new TestModel<Model3>();
            testModel3.Add(model3);

            

            return View();
        }
	}
}