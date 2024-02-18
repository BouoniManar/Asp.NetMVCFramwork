using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.Net_MVC_Framework
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name:
                "MoviesByDate",
                "movies/released/{year}/{month}",

                new { Controller = "Movie", Action = "byRelease" });
              routes.MapRoute(
                  name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
            name: "AuteursByMovie",
            url: "movies/auteurs/{id}",
            defaults: new { controller = "Movie", action = "Auteurs" }
);



        }

        
    }
}
