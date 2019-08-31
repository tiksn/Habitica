using System;

namespace TIKSN.Habitica.Settings
{
    public interface ITagSettings
    {
        bool HasImportantTag { get; }
        bool HasLessImportantTag { get; }
        bool HasLessUrgentTag { get; }
        bool HasUrgentTag { get; }
        Guid ImportantTag { get; set; }
        Guid LessImportantTag { get; set; }
        Guid LessUrgentTag { get; set; }
        Guid UrgentTag { get; set; }
    }
}