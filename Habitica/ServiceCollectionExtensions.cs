using Microsoft.Extensions.DependencyInjection;
using TIKSN.Habitica.EisenhowerMatrix;
using TIKSN.Habitica.Rest;
using TIKSN.Habitica.Settings;

namespace TIKSN.Habitica
{
    public static class ServiceCollectionExtensions
    {
        public static void AddHabitica(this IServiceCollection services)
        {
            services.AddScoped<IRestClientFactory, RestClientFactory>();
            services.AddScoped<ICredentialSettings, ApplicationSettings>();
            services.AddScoped<ITagSettings, ApplicationSettings>();
            services.AddScoped<IHabiticaClient, HabiticaClient>();
            services.AddScoped<ITagInitializer, TagInitializer>();
            services.AddScoped<IMatrixAndBacklogService, MatrixAndBacklogService>();
        }
    }
}