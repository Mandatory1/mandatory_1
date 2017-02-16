using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;




namespace ConsoleApplication

{
    public class Program
    {
       
        public static void Main(string[] args)
        {

        var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseStartup<Startup>()
        .Build();
        
        host.Run();


            //Console.WriteLine("Hello World!");
        }
    }
}
