using RestSharp;

namespace TIKSN.Habitica.Rest
{
    public interface IRestClientFactory
    {
        RestClient Create();
    }
}