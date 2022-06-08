using Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IMetodoDidaticoParaInjecaoUnicaApp, MetodoDidaticoParaInjecaoUnicaApp>();
            services.AddTransient<IMetodoDidaticoParaInjecaoDuplaApp, MetodoDidaticoParaInjecaoDuplaTransientApp>();
            services.AddScoped<IValidaCpfApp, ValidaCpfApp>();

            return services;
        }
    }
}
