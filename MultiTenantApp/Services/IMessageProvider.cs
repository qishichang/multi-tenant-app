using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenantApp.Services
{
    public interface IMessageProvider
    {
        Task<string> GetMessageAsync();
    }
}
