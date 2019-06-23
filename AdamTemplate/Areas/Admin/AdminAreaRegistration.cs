using System.Web.Mvc;

namespace AdamTemplate.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {Controller="Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "AdamTemplate.Areas.Admin.Controllers" }

            );
        }
    }
}