using System;

namespace TIKSN.Habitica
{
    public interface IApplicationSettings
    {
        string ApiKey { get; set; }
        bool HasApiKey { get; }
        bool HasImportantTag { get; }
        bool HasLessImportantTag { get; }
        bool HasLessUrgentTag { get; }
        bool HasUrgentTag { get; }
        bool HasUserID { get; }
        Guid ImportantTag { get; set; }
        Guid LessImportantTag { get; set; }
        Guid LessUrgentTag { get; set; }
        Guid UrgentTag { get; set; }
        string UserID { get; set; }
    }
}