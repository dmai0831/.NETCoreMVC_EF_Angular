using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DutchTreat
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Asp.net Core required to have dependency injection
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Configure tells how to listen the web request
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //#if DEBUG
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //#endif

            //the order is matter
            //no longer serving html file
            //app.UseDefaultFiles();

            //UseStaticFiles only deliver file in wwwRoot directory.
            app.UseStaticFiles();
            app.UseNodeModules(env);
            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default", 
                    "/{controller}/{action}/{id?}", 
                    //if there is no matching controller, then default to AppController action index
                    new { controller = "App", Action = "Index" });
            });

        }
    }
}
