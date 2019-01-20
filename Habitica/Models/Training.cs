using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Training
    {
        [JsonProperty("con")]
        public long Con { get; set; }

        [JsonProperty("int")]
        public long Int { get; set; }

        [JsonProperty("per")]
        public long Per { get; set; }

        [JsonProperty("str")]
        public long Str { get; set; }
    }
}