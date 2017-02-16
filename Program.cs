using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();
            //WebHostBuilder host = new WebHostBuilder(); Sådan ville man skrive det i Java.
            // var server = host.UseKestrel(); Chain the object to the above. 

            host.Run();

            // Console.WriteLine("Hello World!");
        }
    }
}
