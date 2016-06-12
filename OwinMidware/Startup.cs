using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OwinMidware.Models;
using Owin;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

//comment 1 
namespace OwinMidware
{
    public class Startup
    {
        public void Configuration(IAppBuilder app){
           //Configure Web API for self - host.
           HttpConfiguration config = new HttpConfiguration();
           config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
            //configure Odata
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<ProductsOdata>("ProductsOdatas");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "odata",
                model: builder.GetEdmModel());
            app.UseWebApi(config);

            app.Use((context, next) => context.Response.WriteAsync("Hello from Owin"));
        }
    }
}