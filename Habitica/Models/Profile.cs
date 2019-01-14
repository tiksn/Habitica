using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public partial class Profile
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}