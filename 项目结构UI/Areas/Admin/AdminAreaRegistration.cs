using System.Web.Http;
using System.Web.Mvc;

namespace 项目结构UI.Areas.Admin
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

            context.Routes.MapHttpRoute(
                 name: "Default_Admin_Api",
                 routeTemplate: "Admin/api/{controller}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );


            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },

                namespaces: new string[] { "项目结构UI.Areas.Admin.Controllers" }
            );
        }
    }
}