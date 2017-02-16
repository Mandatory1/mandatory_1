using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
                var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<StartUp>()
                .Build(); //chain objects i stedet for var server = host.UseKestrel();    

//            Console.WriteLine("Hello World!");
                host.Run();
        }
    }
}
