using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Common
{
    public class JiShiAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
            string.Format("<div>执行时间: {0}</div>", timer.Elapsed.TotalSeconds));
        } 
    }
}