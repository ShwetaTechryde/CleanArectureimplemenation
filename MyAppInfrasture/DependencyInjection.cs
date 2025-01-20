using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyAppInfrasture.Data;

namespace MyAppInfrasture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppInfraId(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(Options=>
            Options.UseSqlServer("Data Source =DESKTOP-APMVBAH; Initial Catalog = HealthCare; Integrated Security = True ; MultipleActiveResultSets=True; Encrypt =False\");"));
            return services;
        }
    }
}
