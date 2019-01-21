using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TIKSN.Habitica.Rest;
using TIKSN.Habitica.Tests.Fixture;
using Xunit;

namespace TIKSN.Habitica.Tests.Rest
{
    [Collection("ServiceProvider")]
    public class TagsTests
    {
        private readonly ServiceProviderFixture _serviceProviderFixture;

        public TagsTests(ServiceProviderFixture serviceProviderFixture)
        {
            _serviceProviderFixture = serviceProviderFixture ?? throw new ArgumentNullException(nameof(serviceProviderFixture));
        }

        [Fact]
        public async Task GetTags()
        {
            var habiticaClient = _serviceProviderFixture.ServiceProvider.GetRequiredService<IHabiticaClient>();
            var tags = await habiticaClient.GetTagsAsync(default);

            tags.Data.Should().NotBeNull();
            tags.Data.Should().NotBeEmpty();
        }
    }
}