using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyAplication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationID(this IServiceCollection services)
        {
            // Register your dependencies here
            return services;
        }
    }
}
