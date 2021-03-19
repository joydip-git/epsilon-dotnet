using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagementSystem.Container;
using ProductManagementSystem.Entities;
using ProductManagementSystem.BL.Contracts;
using ProductManagementSystem.BL.Implementation;

namespace ProductManagementSystem.UserInterface
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //you are asking to create a service (container) whose job is to create instance of Mvc middleware
            //services.AddMvc(options =>
            //{
            //    options.EnableEndpointRouting = false;                
            //});
            services.AddControllersWithViews();
            //services.AddControllers();
            //services.AddRazorPages();
            
            
            //services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //app.UseSession();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/",)
            //});
            //app.UseAuthentication();
            //app.UseAuthorization();
            /*
            app.UseEndpoints(endpoints =>
            {
                // {controller}/{action}/{id}
                // http://localhost:12345/Products/GetProduct/1
                endpoints.MapDefaultControllerRoute();
                //RequestDelegate del = async (context) =>
                // {
                //     Task t = context.Response.WriteAsync("Welcome to MVC");
                //     await t;
                // };
                //endpoints.MapGet("/getresult", del);
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Welcome to MVC");
                //});                
            });
            */
            /*
            app.UseMvc(configure =>
            {
                //configure.MapRoute(
                //    name: "HomeRoute",
                //    template: "{controller=Products}/{action=Index}/{data?}"
                //    );
                configure.MapRoute(
                   name: "HomeRoute",
                   template: "{controller}/{action}/{data?}",
                   defaults: new { controller = "Products", action = "Index" }
                   );
            });
            */

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                // endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                    name: "ProductsDefault",
                    pattern: "{controller}/{action}/{data?}",
                    defaults: new { controller = "Products", action = "Index" });
            });
        }
    }
}
