using System.Threading;
using System.Threading.Tasks;

namespace TIKSN.Habitica
{
    public interface IHabiticaClient
    {
        Task GetUserProfileAsync(CancellationToken cancellationToken);
    }
}