using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Facebook
    {
        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}