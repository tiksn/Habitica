using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.Rest
{
    public interface IHabiticaClient
    {
        Task<TagsModel> CreateTagAsync(string name, CancellationToken cancellationToken);

        Task<TagsModel> GetTagsAsync(CancellationToken cancellationToken);

        Task<UserModel> GetUserProfileAsync(CancellationToken cancellationToken);
    }
}