using System.Threading;
using System.Threading.Tasks;

namespace TIKSN.Habitica.EisenhowerMatrix
{
    public interface ITagInitializer
    {
        Task InitializeDefaultsAsync(CancellationToken cancellationToken);
    }
}