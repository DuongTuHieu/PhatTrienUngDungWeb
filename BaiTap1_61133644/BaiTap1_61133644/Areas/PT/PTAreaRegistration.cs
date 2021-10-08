using System.Web.Mvc;

namespace BaiTap1_61133644.Areas.PT
{
    public class PTAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PT";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PT_default",
                "PT/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}