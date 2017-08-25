using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace MVCCORECLIENT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "MVCCoreClient";
            var host = new WebHostBuilder()
                .UseKestrel().UseUrls("https://localhost:44368/")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
