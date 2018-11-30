using Microsoft.AspNetCore.Http;
using MultiTenantApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenantApp.Features.RemoteIp
{
    public class RemoteIpMessageProvider : IMessageProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RemoteIpMessageProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<string> GetMessageAsync()
        {
            var remoteIpAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress;
            return Task.FromResult($"Your IP Address: {remoteIpAddress}");
        }
    }
}
