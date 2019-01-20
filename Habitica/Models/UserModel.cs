using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class UserModel : ISuccess
    {
        [JsonProperty("data")]
        public UserData Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}