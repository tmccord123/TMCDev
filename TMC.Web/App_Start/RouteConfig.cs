using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using LowercaseDashedRouting;

namespace TMC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
          /*  routes.Add(new LowercaseDashedRoute("{controller}/{action}/{id}",
            new RouteValueDictionary(
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }),
                new DashedRouteHandler()
          )*/


            routes.MapRoute(
                name: "seo",
                url: "Coupons/{permalink}",
                defaults: new { controller = "Coupons", action = "Index", permalink = "" }
            );
          routes.MapRoute(
           name: "Default",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
       );
           /* routes.MapRoute(
            name: "CmsRoute",
            url: "{*permalink}",
            defaults: new { controller = "Coupons", action = "Index" },
            constraints: new { permalink = new CmsUrlConstraint() }
            );*/
       
            routes.MapRoute("Coupons", "Coupons",
                new {Controller = "CouponBoard", action = "Index"});





        }

        public class CmsUrlConstraint : IRouteConstraint
        {
            public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
            {
               // var db = new MvcCMS.Models.MvcCMSContext();
                if (values[parameterName] != null)
                {
                    var permalink = values[parameterName].ToString();
                    return true;// db.CMSPages.Any(p => p.Permalink == permalink);
                }
                return false;
            }
        }
    }
}
