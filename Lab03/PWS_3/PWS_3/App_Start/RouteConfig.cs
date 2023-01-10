using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace PWS_3
{
    public class RouteConfig
    {
        public static void RegisterHttpRoutes(HttpConfiguration config)
        {
            config.Formatters.XmlFormatter.Indent = true;
            config.Formatters.JsonFormatter.Indent = true;

            config.Routes.MapHttpRoute(
                name: "HomeApi",
                routeTemplate: "api",
                defaults: new { controller = "Home" }
            );

            config.Routes.MapHttpRoute(
                name: "StudentsApi",
                routeTemplate: "api/students/{id}",
                defaults: new { controller = "Students", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "StudentsApi1",
                routeTemplate: "api/{root}",
                defaults: new { controller = "Students", root = typeof(RouteParameter) }
            );

            config.Routes.MapHttpRoute(
                name: "ErrorsApi",
                routeTemplate: "api/errors/{code}",
                defaults: new { controller = "Errors", code = RouteParameter.Optional }
            );
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
