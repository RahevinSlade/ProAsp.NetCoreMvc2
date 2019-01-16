using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace mywebapp
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration config) //Using "control + ." provides an extension to the Configuration
        {
            Configuration = config; //setting the value to the configuration
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //added all the models I would like to use from MVC, such as using bold when writing text
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();//This will tell me what is going on
            }

            app.UseMvc(); //

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<b>ThIs Is A cOlOr BlInD TeSt!</b>");
            });// This is called the default route!
        }
    }
}
