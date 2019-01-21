using Newtonsoft.Json;
using System;

namespace TIKSN.Habitica.Models
{
    public class UserData
    {
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }

        [JsonProperty("auth")]
        public Auth Auth { get; set; }

        [JsonProperty("id")]
        public Guid DataId { get; set; }

        [JsonProperty("_id")]
        public Guid Id { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}