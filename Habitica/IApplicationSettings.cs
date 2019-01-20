namespace TIKSN.Habitica
{
    public interface IApplicationSettings
    {
        string ApiKey { get; set; }
        bool HasApiKey { get; }
        bool HasUserID { get; }
        string UserID { get; set; }
    }
}