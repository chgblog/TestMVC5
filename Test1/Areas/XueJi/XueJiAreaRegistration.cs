using System.Web.Mvc;

namespace Test1.Areas.XueJi
{
    public class XueJiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "XueJi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "XueJi_default",
                "XueJi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}