using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica.Rest
{
    public class HabiticaClient : IHabiticaClient
    {
        private readonly IRestClientFactory _restClientFactory;

        public HabiticaClient(IRestClientFactory restClientFactory)
        {
            _restClientFactory = restClientFactory ?? throw new ArgumentNullException(nameof(restClientFactory));
        }

        public async Task<TagsModel> CreateTagAsync(string name, CancellationToken cancellationToken)
        {
            var request = new RestRequest("tags", Method.Post)
                .AddJsonBody(new TagCreationModel { name = name });

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteAsync<TagsModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public async Task<TagsModel> GetTagsAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("tags", Method.Get);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteAsync<TagsModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public Task<UserTaskModel> GetUserCompletedToDosAsync(CancellationToken cancellationToken)
        {
            return GetUserTasksAsync("completedTodos", cancellationToken);
        }

        public async Task<UserModel> GetUserProfileAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("user?userFields=achievements,auth,profile,stats", Method.Get);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteAsync<UserModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public async Task<UserTaskModel> GetUserTasksAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("tasks/user", Method.Get);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteAsync<UserTaskModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public Task<UserTaskModel> GetUserToDosAsync(CancellationToken cancellationToken)
        {
            return GetUserTasksAsync("todos", cancellationToken);
        }

        private void EnsureSuccess(RestResponse response, ISuccess success)
        {
            if (response.ErrorException != null)
                throw response.ErrorException;

            if (!response.IsSuccessful)
                throw new InvalidOperationException("Request failed.");

            if (!success.Success)
                throw new InvalidOperationException("Request's response was not successful.");
        }

        private async Task<UserTaskModel> GetUserTasksAsync(string type, CancellationToken cancellationToken)
        {
            var request = new RestRequest($"tasks/user?type={type}", Method.Get);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteAsync<UserTaskModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }
    }
}