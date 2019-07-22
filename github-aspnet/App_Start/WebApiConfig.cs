using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace github_aspnet
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Enable CORS to this API: Install-Package Microsoft.AspNet.WebApi.Cors
            var cors = new EnableCorsAttribute("http://www.reactfibonaccicalc.rf.gd", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Config Web API to returns JSON format
            config.Formatters.JsonFormatter.SupportedMediaTypes
            .Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}