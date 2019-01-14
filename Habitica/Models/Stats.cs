using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Stats
    {
        [JsonProperty("buffs")]
        public Buffs Buffs { get; set; }

        [JsonProperty("training")]
        public Training Training { get; set; }

        [JsonProperty("hp")]
        public long Hp { get; set; }

        [JsonProperty("mp")]
        public long Mp { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("gp")]
        public long Gp { get; set; }

        [JsonProperty("lvl")]
        public long Lvl { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("str")]
        public long Str { get; set; }

        [JsonProperty("con")]
        public long Con { get; set; }

        [JsonProperty("int")]
        public long Int { get; set; }

        [JsonProperty("per")]
        public long Per { get; set; }
    }
}