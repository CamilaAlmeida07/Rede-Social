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
                name: "InserirPost",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Postagem", action = "InserirPost", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "CurtirPost",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Postagem", action = "CurtirPost", id = UrlParameter.Optional }
            );
    
            routes.MapRoute(
                name: "Duelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Duelo", action = "Duelo", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "InserirDuelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Duelo", action = "InserirDuelo", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "VerDuelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Duelo", action = "VerDuelo", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "VerInscricaoDuelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Inscricao", action = "VerInscricaoDuelo", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "VotarDuelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Inscricao", action = "VotarDuelo", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ViewVotarDuelo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Inscricao", action = "ViewVotarDuelo", id = UrlParameter.Optional }
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