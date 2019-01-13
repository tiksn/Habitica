using Microsoft.Extensions.Options;
using RestSharp;
using System;

namespace TIKSN.Habitica
{
    public class RestClientFactory : IRestClientFactory
    {
        private readonly IOptions<ClientOptions> _options;
        private readonly IApplicationSettings _applicationSettings;

        public RestClientFactory(IOptions<ClientOptions> options, IApplicationSettings applicationSettings)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _applicationSettings = applicationSettings ?? throw new ArgumentNullException(nameof(applicationSettings));
        }

        public RestClient Create()
        {
            var client = new RestClient(_options.Value.BaseAddress);
            client.AddDefaultHeader("x-api-user", _applicationSettings.UserID);
            client.AddDefaultHeader("x-api-key", _applicationSettings.ApiKey);

            return client;
        }
    }
}