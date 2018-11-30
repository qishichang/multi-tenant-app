using Microsoft.Extensions.DependencyInjection;
using MultiTenantApp.Services;
using OrchardCore.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: OrchardCore.Modules.Manifest.Feature(
    Id = "TimeOfDay",
    Name = "TimeOfDay"
)]


namespace MultiTenantApp.Features.TimeOfDay
{

    [Feature("TimeOfDay")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageProvider, TimeOfDayMessageProvider>();
        }
    }
}
