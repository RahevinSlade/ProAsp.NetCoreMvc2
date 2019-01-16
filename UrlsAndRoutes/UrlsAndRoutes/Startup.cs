using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => {
                options.ConstraintMap.Add("weekday", typeof(WeekDayConstraint));
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            //app.UseMvc();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller=Home}/{action=Index}"
                //    + "/{id:alpha:minlength(6)?}");//must have id with at least 6 alphabetical characters

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller=Home}/{action=Index}/{id:weekday?}");

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller}/{action}/{id?}",
                //    defaults: new { controller = "Home", action = "Index" },
                //    constraints: new { id = new WeekDayConstraint() });  //url must look like Consumer/Index/ {weekday}

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller}/{action}/{id?}",
                //    defaults: new { controller = "Home", action = "Index" },
                //    constraints: new
                //    {
                //        id = new CompositeRouteConstraint(
                //            new IRouteConstraint[] {
                //                new AlphaRouteConstraint(),
                //                new MinLengthRouteConstraint(6)
                //            })
                //    });

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller=Home}/{action=Index}/{id:range(10,20)?}"); //Only allows ids between 10 and 20

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller:regex(^H.*)=Home}/{action=Index}/{id?}"); //allows url with conroller that starts with an H

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller:regex(^H.*)=Home}/"
                //    + "{action:regex(^Index$|^About$)=Index}/{id?}"); //allows the actions to be either Index or About

                //routes.MapRoute(name: "MyRoute",
                //template: "{controller}/{action}/{id?}",
                //defaults: new { controller = "Home", action = "Index"},//matches a route with numbers for ID's
                //constraints: new { id = new IntRouteConstraint() });

                //routes.MapRoute(
                //    name: "MyRoute",
                //    template: "{controller=Home}/{action=Index}/{id?}/{*catchall}"); //catches all and any url that match the controller, action

                //routes.MapRoute(
                //    name: "ShopSchema2",
                //    template: "Shop/OldAction",
                //    defaults: new { controller = "Home", action = "Index" });

                //routes.MapRoute(
                //    name: "ShopSchema",
                //    template: "Shop/{action}",
                //    defaults: new { controller = "Home" });

                //routes.MapRoute(
                //    name: "", 
                //    template: "X{controller}/{action}");

                //routes.MapRoute(
                //    name: "NewRoute",
                //    template: "App/Do{action}",
                //    defaults: new { controller = "Home" });//changes url to /App/DoCustomVariable

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}");

                routes.Routes.Add(new LegacyRoute(
                    app.ApplicationServices,
                    "/articles/Windows_3.1_Overview.html",
                    "/old/.NET_1.0_Class_Libray"));

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "out",
                    template: "outbound/{controller=Home}/{action=Index}");

                //routes.MapRoute(
                //    name: "",
                //    template: "Public/{controller=Home}/{action=Index}");
            });
        }
    }
}
