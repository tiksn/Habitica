using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TIKSN.Habitica
{
    public class HabiticaClient : IHabiticaClient
    {
        private readonly IRestClientFactory _restClientFactory;

        public HabiticaClient(IRestClientFactory restClientFactory)
        {
            _restClientFactory = restClientFactory ?? throw new ArgumentNullException(nameof(restClientFactory));
        }

        public async Task GetUserProfileAsync(CancellationToken cancellationToken)
        {
            var request = new RestRequest("user", Method.GET);

            var restClient = _restClientFactory.Create();

            var response = await restClient.ExecuteTaskAsync(request, cancellationToken);

            EnsureSuccess(response);
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