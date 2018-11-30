using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Shell;

namespace MultiTenantApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCore()
                .WithTenants();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOrchardCore(a => a.Run(async context =>
            {
                // ShellSettings provide the tenant's configuration.
                var shellSettings = context.RequestServices.GetRequiredService<ShellSettings>();

                // Read the tenant-specific custom settings.
                var customSetting = shellSettings.Configuration["CustomSetting"];

                // Write the value of the custom setting to the response stream.
                await context.Response.WriteAsync(customSetting);
            }));
        }
    }
}
