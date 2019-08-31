namespace TIKSN.Habitica.Settings
{
    public interface ICredentialSettings
    {
        string ApiKey { get; set; }
        bool HasApiKey { get; }
        bool HasUserID { get; }
        string UserID { get; set; }
    }
}