using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Net.Http;


namespace 项目结构UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
       

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //注册webapi路由
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //注册mvc路由
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
        }
    }
}
