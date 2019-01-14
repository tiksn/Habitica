using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Buffs
    {
        [JsonProperty("str")]
        public long Str { get; set; }

        [JsonProperty("int")]
        public long Int { get; set; }

        [JsonProperty("per")]
        public long Per { get; set; }

        [JsonProperty("con")]
        public long Con { get; set; }

        [JsonProperty("stealth")]
        public long Stealth { get; set; }

        [JsonProperty("streaks")]
        public bool Streaks { get; set; }

        [JsonProperty("snowball")]
        public bool Snowball { get; set; }

        [JsonProperty("spookySparkles")]
        public bool SpookySparkles { get; set; }

        [JsonProperty("shinySeed")]
        public bool ShinySeed { get; set; }

        [JsonProperty("seafoam")]
        public bool Seafoam { get; set; }
    }
}