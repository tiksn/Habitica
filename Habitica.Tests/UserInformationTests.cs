using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TIKSN.Habitica.Tests.Fixture;
using Xunit;

namespace TIKSN.Habitica.Tests
{
    [Collection("ServiceProvider")]
    public class UserInformationTests
    {
        private readonly ServiceProviderFixture _serviceProviderFixture;

        public UserInformationTests(ServiceProviderFixture serviceProviderFixture)
        {
            _serviceProviderFixture = serviceProviderFixture ?? throw new ArgumentNullException(nameof(serviceProviderFixture));
        }

        [Fact]
        public async Task GetUserProfile()
        {
            var habiticaClient = _serviceProviderFixture.ServiceProvider.GetRequiredService<IHabiticaClient>();
        }
    }
}