using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.Rest
{
    public interface IHabiticaClient
    {
        Task<TagsModel> CreateTagAsync(string name, CancellationToken cancellationToken);

        Task<TagsModel> GetTagsAsync(CancellationToken cancellationToken);

        Task<UserTaskModel> GetUserCompletedToDosAsync(CancellationToken cancellationToken);

        Task<UserModel> GetUserProfileAsync(CancellationToken cancellationToken);

        Task<UserTaskModel> GetUserTasksAsync(CancellationToken cancellationToken);

        Task<UserTaskModel> GetUserToDosAsync(CancellationToken cancellationToken);
    }
}