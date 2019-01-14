using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class UserModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public UserData Data { get; set; }

        //[JsonProperty("notifications")]
        //public object[] Notifications { get; set; }

        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }
    }
}