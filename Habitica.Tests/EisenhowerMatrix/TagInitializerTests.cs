using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TIKSN.Habitica.EisenhowerMatrix;
using TIKSN.Habitica.Settings;
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
            var tagSettings = _serviceProviderFixture.ServiceProvider.GetRequiredService<ITagSettings>();
            await tagInitializer.InitializeDefaultsAsync(default);

            tagSettings.HasImportantTag.Should().BeTrue();
            tagSettings.HasUrgentTag.Should().BeTrue();
            tagSettings.HasLessImportantTag.Should().BeTrue();
            tagSettings.HasLessUrgentTag.Should().BeTrue();
        }
    }
}