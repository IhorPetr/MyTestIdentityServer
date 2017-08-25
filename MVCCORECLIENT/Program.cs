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
                .UseKestrel().UseUrls("http://localhost:5002")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
