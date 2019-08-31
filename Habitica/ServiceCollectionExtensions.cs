﻿using Microsoft.Extensions.DependencyInjection;
using TIKSN.Habitica.EisenhowerMatrix;
using TIKSN.Habitica.Rest;
using TIKSN.Habitica.Settings;

namespace TIKSN.Habitica
{
    public static class ServiceCollectionExtensions
    {
        public static void AddHabitica(this IServiceCollection services)
        {
            services.AddSingleton<IRestClientFactory, RestClientFactory>();
            services.AddSingleton<IApplicationSettings, ApplicationSettings>();
            services.AddSingleton<IHabiticaClient, HabiticaClient>();
            services.AddSingleton<ITagInitializer, TagInitializer>();
            services.AddSingleton<IMatrixAndBacklogService, MatrixAndBacklogService>();
        }
    }
}