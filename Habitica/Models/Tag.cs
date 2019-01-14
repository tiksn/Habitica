using Newtonsoft.Json;
using System;

namespace TIKSN.Habitica.Models
{
    public partial class Tag
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}