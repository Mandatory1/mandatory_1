using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;


namespace ConsoleApplication

{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            
            
            
           DefaultFilesOptions options = new DefaultFilesOptions();
           options.DefaultFileNames.Clear();
           options.DefaultFileNames.Add("index.html");
           app.UseDefaultFiles(options);
           app.UseStaticFiles();

           app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello, World!");
            });

                
        }
    }
}
