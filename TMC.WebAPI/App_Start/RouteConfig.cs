using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TMC.WebAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            "LocalBoard",                                              // Route name
            "{controller}/{action}/{cityName}/{categoryName}/{cityId}/{categoryId}",                           // URL with parameters
            new { controller = "LocalBoard", action = "Index", cityName = "", categoryName = "", cityId = "", categoryId = "" }  // Parameter defaults
        );
        }
    }
}
