using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Repeat
    {
        [JsonProperty("f")]
        public bool F { get; set; }

        [JsonProperty("m")]
        public bool M { get; set; }

        [JsonProperty("s")]
        public bool S { get; set; }

        [JsonProperty("su")]
        public bool Su { get; set; }

        [JsonProperty("t")]
        public bool T { get; set; }

        [JsonProperty("th")]
        public bool Th { get; set; }

        [JsonProperty("w")]
        public bool W { get; set; }
    }
}