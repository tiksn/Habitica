using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class UltimateGearSets
    {
        [JsonProperty("healer")]
        public bool Healer { get; set; }

        [JsonProperty("wizard")]
        public bool Wizard { get; set; }

        [JsonProperty("rogue")]
        public bool Rogue { get; set; }

        [JsonProperty("warrior")]
        public bool Warrior { get; set; }
    }
}