using System;
using TIKSN.Settings;

namespace TIKSN.Habitica
{
    public class ApplicationSettings : IApplicationSettings
    {
        private readonly ISettingsService _settingsService;

        public ApplicationSettings(ISettingsService settingsService)
        {
            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
        }

        public string ApiKey { get => _settingsService.GetLocalSetting("habitica-api-key", string.Empty); set => _settingsService.SetLocalSetting("habitica-api-key", value); }

        public bool HasApiKey => !string.IsNullOrEmpty(ApiKey);

        public bool HasImportantTag => Guid.Empty != ImportantTag;

        public bool HasLessImportantTag => Guid.Empty != LessImportantTag;

        public bool HasLessUrgentTag => Guid.Empty != LessUrgentTag;

        public bool HasUrgentTag => Guid.Empty != UrgentTag;

        public bool HasUserID => !string.IsNullOrEmpty(UserID);

        public Guid ImportantTag { get => _settingsService.GetLocalSetting("important-tag-id", Guid.Empty); set => _settingsService.SetLocalSetting("important-tag-id", value); }

        public Guid LessImportantTag { get => _settingsService.GetLocalSetting("less-important-tag-id", Guid.Empty); set => _settingsService.SetLocalSetting("less-important-tag-id", value); }

        public Guid LessUrgentTag { get => _settingsService.GetLocalSetting("less-urgent-tag-id", Guid.Empty); set => _settingsService.SetLocalSetting("less-urgent-tag-id", value); }

        public Guid UrgentTag { get => _settingsService.GetLocalSetting("urgent-tag-id", Guid.Empty); set => _settingsService.SetLocalSetting("urgent-tag-id", value); }

        public string UserID { get => _settingsService.GetLocalSetting("habitica-user-id", string.Empty); set => _settingsService.SetLocalSetting("habitica-user-id", value); }
    }
}