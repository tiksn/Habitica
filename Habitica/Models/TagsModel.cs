using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class TagsModel : ISuccess
    {
        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("data")]
        public TagData[] Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        //[JsonProperty("notifications")]
        //public object[] Notifications { get; set; }

        [JsonProperty("userV")]
        public long UserV { get; set; }
    }
}