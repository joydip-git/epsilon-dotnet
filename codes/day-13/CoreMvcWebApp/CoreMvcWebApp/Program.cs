using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder builder = CreateHostBuilder(args);
            IHost host = builder.Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            //blank builder
            IHostBuilder builder = Host.CreateDefaultBuilder(args);

            //configured the blank builder with default configurations
            Action<IWebHostBuilder> builderConfig = (wb) => wb.UseStartup<Startup>();
            //update build
            builder = builder.ConfigureWebHostDefaults(builderConfig);
            return builder;
            //return Host.CreateDefaultBuilder(args)
            //      .ConfigureWebHostDefaults(webBuilder =>
            //      {
            //          webBuilder.UseStartup<Startup>();
            //      });
        }
    }
}
