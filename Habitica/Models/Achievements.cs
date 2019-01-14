using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Achievements
    {
        [JsonProperty("ultimateGearSets")]
        public UltimateGearSets UltimateGearSets { get; set; }

        [JsonProperty("challenges")]
        public object[] Challenges { get; set; }

        [JsonProperty("perfect")]
        public long Perfect { get; set; }

        //[JsonProperty("quests")]
        //public Quests Quests { get; set; }

        [JsonProperty("partyUp")]
        public bool PartyUp { get; set; }

        [JsonProperty("partyOn")]
        public bool PartyOn { get; set; }

        [JsonProperty("habiticaDays")]
        public long HabiticaDays { get; set; }
    }
}