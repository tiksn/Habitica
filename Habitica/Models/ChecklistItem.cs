using Newtonsoft.Json;
using System;

namespace TIKSN.Habitica.Models
{
    public class ChecklistItem
    {
        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}