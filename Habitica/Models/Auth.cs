using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class Auth
    {
        [JsonProperty("facebook")]
        public Facebook Facebook { get; set; }

        [JsonProperty("local")]
        public Local Local { get; set; }

        [JsonProperty("timestamps")]
        public Timestamps Timestamps { get; set; }

        //[JsonProperty("google")]
        //public Google Google { get; set; }
    }
}