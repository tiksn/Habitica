using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TIKSN.Habitica.EisenhowerMatrix;
using TIKSN.Habitica.Tests.Fixture;
using Xunit;

namespace TIKSN.Habitica.Tests.EisenhowerMatrix
{
    [Collection("ServiceProvider")]
    public class TagInitializerTests
    {
        private readonly ServiceProviderFixture _serviceProviderFixture;

        public TagInitializerTests(ServiceProviderFixture serviceProviderFixture)
        {
            _serviceProviderFixture = serviceProviderFixture ?? throw new ArgumentNullException(nameof(serviceProviderFixture));
        }

        [Fact]
        public async Task InitializeDefaults()
        {
            var tagInitializer = _serviceProviderFixture.ServiceProvider.GetRequiredService<ITagInitializer>();
            var applicationSettings = _serviceProviderFixture.ServiceProvider.GetRequiredService<IApplicationSettings>();

            await tagInitializer.InitializeDefaultsAsync(default);

            applicationSettings.HasImportantTag.Should().BeTrue();
            applicationSettings.HasUrgentTag.Should().BeTrue();
            applicationSettings.HasLessImportantTag.Should().BeTrue();
            applicationSettings.HasLessUrgentTag.Should().BeTrue();
        }
    }
}