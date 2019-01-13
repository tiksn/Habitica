using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TIKSN.Habitica.Tests.Fakes;
using TIKSN.Settings;

namespace TIKSN.Habitica.Tests.Fixture
{
    public class ServiceProviderFixture
    {
        public ServiceProviderFixture()
        {
            var configurationRoot = new ConfigurationBuilder()
                .AddUserSecrets<ServiceProviderFixture>()
                .Build();

            var services = new ServiceCollection();
            services.AddHabitica();
            services.AddOptions();
            services.AddSingleton<ISettingsService>(new TestSettingsService(configurationRoot));
            ServiceProvider = services.BuildServiceProvider();
        }

        public IServiceProvider ServiceProvider { get; }
    }
}