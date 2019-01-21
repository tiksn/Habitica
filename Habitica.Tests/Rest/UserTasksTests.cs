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
    public class UserTasksTests
    {
        private readonly ServiceProviderFixture _serviceProviderFixture;

        public UserTasksTests(ServiceProviderFixture serviceProviderFixture)
        {
            _serviceProviderFixture = serviceProviderFixture ?? throw new ArgumentNullException(nameof(serviceProviderFixture));
        }

        [Fact]
        public async Task GetUserTasks()
        {
            var habiticaClient = _serviceProviderFixture.ServiceProvider.GetRequiredService<IHabiticaClient>();

            var allUserTasks = await habiticaClient.GetUserTasksAsync(default);

            allUserTasks.Data.Should().NotBeEmpty();
        }
    }
}