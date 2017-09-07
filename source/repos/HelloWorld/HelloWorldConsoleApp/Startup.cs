using HelloWorldConsoleApp.Interfaces;
using HelloWorldConsoleApp.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorldConsoleApp
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");
            Configuration = builder.Build();            

            var serviceProvider = new ServiceCollection()
                .AddSingleton(new LoggerFactory().AddConsole().AddDebug())
                .AddLogging()
                .Configure<AppSettings>(Configuration.GetSection("Configuration"))               
                .AddTransient<IHelloWorld,HelloWorldService>()
                .AddTransient<HelloWorldApp>()
                .BuildServiceProvider();

            serviceProvider.GetService<HelloWorldApp>().GetData();
        }
        

    }
}
