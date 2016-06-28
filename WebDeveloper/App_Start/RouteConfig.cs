﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "RazorDate",
            //    url: "Razor/{date}",
            //    defaults: new
            //    {
            //        controller = "Razor",
            //        action = "EntryDate",
            //    }
            //);

            //routes.MapRoute(
            //    name: "RazorDate",
            //    url: "Razor/{id}",
            //    defaults: new
            //    {
            //        controller = "Razor",
            //        action = "EntryId",
            //    }
            //);

            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );            
        }
    }
}
