using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Local
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("lowerCaseUsername")]
        public string LowerCaseUsername { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}