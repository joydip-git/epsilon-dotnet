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
            //CreateHostBuilder(args).Build().Run();
            IHostBuilder builder = CreateHostBuilder(args);
            IHost webHost = builder.Build();
            webHost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder builder = Host.CreateDefaultBuilder(args);
            Action<IWebHostBuilder> config = (hb) => hb.UseStartup<Startup>();
            builder = builder.ConfigureWebHostDefaults(config);
            return builder;
            //Host.CreateDefaultBuilder(args)
            //    .ConfigureWebHostDefaults(webBuilder =>
            //    {
            //        webBuilder.UseStartup<Startup>();
            //    });
        }
    }
}
