using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<MyMiddleware>();
            //app.UseMiddleware<MySecondMiddleWare>();
            //app.Use(
            //    async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("AOA PAkistan...\n");
            //        next();
            //    }
            //    );
            //app.Use(
            //    async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("AOA PAkistan Again...\n");
            //        next();
            //    }
            //    );
            //app.Run(
            //    async (context) =>
            //    {
            //        await context.Response.WriteAsync("Allah Hafiz...\n");
            //    }
            //);
        }
    }
}
