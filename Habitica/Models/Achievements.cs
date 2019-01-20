using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Achievements
    {
        [JsonProperty("habiticaDays")]
        public long HabiticaDays { get; set; }

        [JsonProperty("partyOn")]
        public bool PartyOn { get; set; }

        [JsonProperty("partyUp")]
        public bool PartyUp { get; set; }

        [JsonProperty("perfect")]
        public long Perfect { get; set; }

        [JsonProperty("ultimateGearSets")]
        public UltimateGearSets UltimateGearSets { get; set; }
    }
}