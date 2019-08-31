using Microsoft.Extensions.Options;
using RestSharp;
using System;
using TIKSN.Habitica.Settings;

namespace TIKSN.Habitica.Rest
{
    public class RestClientFactory : IRestClientFactory
    {
        private readonly ICredentialSettings _credentialSettings;
        private readonly IOptions<ClientOptions> _options;

        public RestClientFactory(IOptions<ClientOptions> options, ICredentialSettings credentialSettings)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _credentialSettings = credentialSettings ?? throw new ArgumentNullException(nameof(credentialSettings));
        }

        public RestClient Create()
        {
            var client = new RestClient(_options.Value.BaseAddress);
            client.AddDefaultHeader("x-api-user", _credentialSettings.UserID);
            client.AddDefaultHeader("x-api-key", _credentialSettings.ApiKey);

            return client;
        }
    }
}