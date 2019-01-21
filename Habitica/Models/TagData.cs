using Newtonsoft.Json;
using System;

namespace TIKSN.Habitica.Models
{
    public class TagData
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}