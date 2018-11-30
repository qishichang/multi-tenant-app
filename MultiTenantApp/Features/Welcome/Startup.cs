using Microsoft.Extensions.DependencyInjection;
using MultiTenantApp.Services;
using OrchardCore.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: OrchardCore.Modules.Manifest.Feature(
    Id = "Welcome",
    Name = "Welcome",
    Priority = "1000"
)]

namespace MultiTenantApp.Features.Welcome
{
    [Feature("Welcome")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageProvider, WelcomeMessageProvider>();
        }
    }
}
