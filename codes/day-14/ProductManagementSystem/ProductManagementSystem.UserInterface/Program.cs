using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem.UserInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IBusinessManager<Product> businessManager = new IOCContainer().Create<IBusinessManager<Product>, ProductBusinessManager>();
            //var result = businessManager.FetchAll().First();
            CreateHostBuilder(args).Build().Run();            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
