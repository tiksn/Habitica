using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Profile
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}