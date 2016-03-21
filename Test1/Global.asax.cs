using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Common.Models;
using Test1.Common;

namespace Test1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //使用自定义模型绑定器来过滤表单中的非法字符
            ModelBinders.Binders.DefaultBinder = new GuoLvModelBinder();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            /*
            ModelBinders.Binders.Add(typeof(Exam_e_CourseInfo), new GuoLvModelBinder());
            ModelBinders.Binders.Add(typeof(string), new GuoLvModelBinder());
            */
        }
    }
}
