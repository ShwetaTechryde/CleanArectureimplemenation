using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppInfrasture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppInfraId(this IServiceCollection services)
        {
            return services;
        }
    }
}
