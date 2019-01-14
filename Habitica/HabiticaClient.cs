using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;
using TIKSN.Habitica.Models;

namespace TIKSN.Habitica
{
    public class HabiticaClient : IHabiticaClient
    {
        private readonly IRestClientFactory _restClientFactory;

        public HabiticaClient(IRestClientFactory restClientFactory)
        {
            _restClientFactory = restClientFactory ?? throw new ArgumentNullException(nameof(restClientFactory));
        }

        public async Task<UserModel> GetUserProfileAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("user?userFields=achievements,auth,profile,stats", Method.GET);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync<UserModel>(request, cancellationToken);

            EnsureSuccess(response);

            return response.Data;
        }

        private void EnsureSuccess(IRestResponse response)
        {
            if (response.ErrorException != null)
                throw response.ErrorException;

            if (!response.IsSuccessful)
                throw new InvalidOperationException("Request failed.");
        }
    }
}