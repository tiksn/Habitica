using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class UserModel
    {
        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("data")]
        public UserData Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        //[JsonProperty("notifications")]
        //public object[] Notifications { get; set; }
    }
}