using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace InitiateAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{domain}/{user}",
                defaults: new {  action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );

            config.Routes.MapHttpRoute(
                name: "ApiProveedores",
                routeTemplate: "api/{controller}/{user}",
                defaults: new { action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );
        }
    }
}
