using Newtonsoft.Json;
using System.Collections.Generic;

namespace TIKSN.Habitica.Models
{
    public class Facebook
    {
        [JsonProperty("emails")]
        public List<string> Emails { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}