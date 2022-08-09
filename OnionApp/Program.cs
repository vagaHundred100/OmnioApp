using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(config)
            //    .CreateLogger();

            //try
            //{
            //    Log.Information("Aplication Starting Up");
            //    CreateHostBuilder(args).Build().Run();
            //}
            //catch(Exception ex)
            //{
            //    Log.Fatal(ex, "Aplication failed to start corectly");
            //}
            //finally
            //{
            //    Log.CloseAndFlush();
            //}

            BuildWebHost(args).Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //Host.CreateDefaultBuilder(args)
        //    //.UseSerilog()
        //    .ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseStartup<Startup>();
        //    });

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
