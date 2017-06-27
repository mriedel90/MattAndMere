using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MattAndMere.App_Start;

namespace MattAndMere
{
    public class MvcApplication : System.Web.HttpApplication
    {        protected void Application_BeginRequest()
        {
            //if (!Context.Request.IsSecureConnection && 
            //    !Context.Request.Url.ToString().StartsWith("http://localhost") && 
            //    !Context.Request.Url.ToString().Contains("http://staging"))
            //    Response.Redirect(Context.Request.Url.ToString().Replace("http:", "https:"));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MapperConfig.ConfigureMappings();
        }
    }
}
