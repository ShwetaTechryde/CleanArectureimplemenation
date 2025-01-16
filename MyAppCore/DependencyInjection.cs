using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyAppCore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppCoreId(this IServiceCollection services)
        {
            return services;
        }
    }
}
