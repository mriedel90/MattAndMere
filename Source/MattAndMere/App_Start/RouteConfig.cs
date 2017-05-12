using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MattAndMere
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute("accomodations", "accomodations", new { controller = "Home", action = "Accomodations" });
            routes.MapRoute("activities", "activities", new { controller = "Home", action = "Activities" });
            routes.MapRoute("details", "details", new { controller = "Home", action = "Details" });
            routes.MapRoute("registry", "registry", new { controller = "Home", action = "Registry" });
            routes.MapRoute("travel", "travel", new { controller = "Home", action = "Travel" });
            routes.MapRoute("map", "map", new { controller = "Home", action = "Map" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
