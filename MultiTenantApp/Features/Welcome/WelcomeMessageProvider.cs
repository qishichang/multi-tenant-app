using MultiTenantApp.Services;
using OrchardCore.Environment.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenantApp.Features.Welcome
{
    public class WelcomeMessageProvider : IMessageProvider
    {
        private ShellSettings _shellSettings;

        public WelcomeMessageProvider(ShellSettings shellSettings)
        {
            _shellSettings = shellSettings;
        }
        public Task<string> GetMessageAsync()
        {
            return Task.FromResult($"Hello {_shellSettings.Name}! {_shellSettings.Configuration["CustomSetting"]}");
        }
    }
}
