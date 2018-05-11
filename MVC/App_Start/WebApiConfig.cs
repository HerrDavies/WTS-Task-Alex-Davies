using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVC
{
    public class WebApiConfig
    {
        public static void RegisterRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute("ApiRoute", "api/{controller}/{action}");
            config.Routes.MapHttpRoute(
                name: "MainApi",
                routeTemplate: "api/{controller}/{action}"
            );
        }
    }
}