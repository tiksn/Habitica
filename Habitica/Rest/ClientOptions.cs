namespace TIKSN.Habitica.Rest
{
    public class ClientOptions
    {
        public ClientOptions()
        {
            BaseAddress = "https://habitica.com/api/v3/";
        }

        public string BaseAddress { get; set; }
    }
}