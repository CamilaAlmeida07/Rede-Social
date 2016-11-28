using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace redeSocial
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Postagem", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Duelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Duelo", action = "Duelo", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Ranking",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Ranking", action = "Ranking", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Conquista",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Conquista", action = "Conquista", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Sair",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Usuario", id = UrlParameter.Optional }
            );

     
        }
    }
}