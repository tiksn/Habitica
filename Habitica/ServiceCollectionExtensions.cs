using Microsoft.Extensions.DependencyInjection;

namespace TIKSN.Habitica
{
    public static class ServiceCollectionExtensions
    {
        public static void AddHabitica(this IServiceCollection services)
        {
            services.AddSingleton<IRestClientFactory, RestClientFactory>();
            services.AddSingleton<IApplicationSettings, ApplicationSettings>();
        }
    }
}
