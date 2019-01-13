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

        public string UserID { get => _settingsService.GetLocalSetting("habitica-user-id", string.Empty); set => _settingsService.SetLocalSetting("habitica-user-id", value); }
        public string ApiKey { get => _settingsService.GetLocalSetting("habitica-api-key", string.Empty); set => _settingsService.SetLocalSetting("habitica-api-key", value); }

        public bool HasUserID => !string.IsNullOrEmpty(UserID);

        public bool HasApiKey => !string.IsNullOrEmpty(ApiKey);
    }
}