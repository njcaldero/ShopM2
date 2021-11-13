using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ShopM2.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            // Configuración y servicios de API web
            config.EnableCors(corsAttr);
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: ConfigurationManager.AppSettings.Get("DefaultApi"),
                routeTemplate: ConfigurationManager.AppSettings.Get("RouteTemplate"),
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
