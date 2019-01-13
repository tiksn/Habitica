namespace TIKSN.Habitica
{
    public interface IApplicationSettings
    {
        string UserID { get; set; }

        string ApiKey { get; set; }

        bool HasUserID { get; }

        bool HasApiKey { get; }
    }
}