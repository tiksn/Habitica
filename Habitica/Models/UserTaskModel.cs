using Newtonsoft.Json;
using System.Collections.Generic;

namespace TIKSN.Habitica.Models
{
    public class UserTaskModel : ISuccess
    {
        [JsonProperty("data")]
        public List<TaskData> Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}