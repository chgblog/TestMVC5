using System.Web;
using System.Web.Mvc;
using Test1.Common;

namespace Test1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new JiShiAttribute());
            filters.Add(new ZiDingYiCache());
        }
    }
}
