using Newtonsoft.Json;
using System.Collections.Generic;

namespace TIKSN.Habitica.Models
{
    public class TagsModel : ISuccess
    {
        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("data")]
        public List<TagData> Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        //[JsonProperty("notifications")]
        //public object[] Notifications { get; set; }

        [JsonProperty("userV")]
        public long UserV { get; set; }
    }
}