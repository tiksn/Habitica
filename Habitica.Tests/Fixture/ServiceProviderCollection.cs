using Xunit;

namespace TIKSN.Habitica.Tests.Fixture
{
    [CollectionDefinition("ServiceProvider")]
    public class ServiceProviderCollection : ICollectionFixture<ServiceProviderFixture>
    {
    }
}