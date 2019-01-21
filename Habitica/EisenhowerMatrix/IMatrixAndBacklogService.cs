using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.EisenhowerMatrix.Models;

namespace TIKSN.Habitica.EisenhowerMatrix
{
    public interface IMatrixAndBacklogService
    {
        Task<MatrixAndBacklog> GetMatrixAndBacklogAsync(CancellationToken cancellationToken);
    }
}