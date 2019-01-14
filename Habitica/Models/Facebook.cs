using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Facebook
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }
    }
}