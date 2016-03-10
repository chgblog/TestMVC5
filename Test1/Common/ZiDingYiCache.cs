using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Common
{
    public class ZiDingYiCache : OutputCacheAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Duration = 600;
            this.Location = System.Web.UI.OutputCacheLocation.Any;
            filterContext.HttpContext.Response.Cache.SetOmitVaryStar(true);
        }
    }
}