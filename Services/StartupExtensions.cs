using Microsoft.Extensions.DependencyInjection;
using Services.Interface;

namespace Services
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITesteClass1, TesteClass1>();
            services.AddTransient<ITesteClass2, TesteClass2>();

            return services;
        }
    }
}
