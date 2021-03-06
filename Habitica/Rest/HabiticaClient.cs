﻿using RestSharp;
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
            var request = new RestRequest("tags", Method.POST)
                .AddJsonBody(new TagCreationModel { name = name });

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync<TagsModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public async Task<TagsModel> GetTagsAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("tags", Method.GET);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync<TagsModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public Task<UserTaskModel> GetUserCompletedToDosAsync(CancellationToken cancellationToken)
        {
            return GetUserTasksAsync("completedTodos", cancellationToken);
        }

        public async Task<UserModel> GetUserProfileAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("user?userFields=achievements,auth,profile,stats", Method.GET);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync<UserModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public async Task<UserTaskModel> GetUserTasksAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("tasks/user", Method.GET);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync<UserTaskModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }

        public Task<UserTaskModel> GetUserToDosAsync(CancellationToken cancellationToken)
        {
            return GetUserTasksAsync("todos", cancellationToken);
        }

        private void EnsureSuccess(IRestResponse response, ISuccess success)
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
            var request = new RestRequest($"tasks/user?type={type}", Method.GET);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync<UserTaskModel>(request, cancellationToken);

            EnsureSuccess(response, response.Data);

            return response.Data;
        }
    }
}