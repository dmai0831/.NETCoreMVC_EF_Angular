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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Configure tells how to listen the web request
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //Any time a request come in, write a Hello World!
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("<html><body><h1>Hello World</h1></body></html>");
            //});


            //the order is matter
            app.UseDefaultFiles();
            //UseStaticFiles only deliver file in wwwRoot directory.
            app.UseStaticFiles();
            app.UseNodeModules(env);

        }
    }
}
