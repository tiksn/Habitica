using RestSharp;

namespace TIKSN.Habitica
{
    public interface IRestClientFactory
    {
        RestClient Create();
    }
}