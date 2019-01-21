using Newtonsoft.Json;
using System.Collections.Generic;

namespace TIKSN.Habitica.Models
{
    public class TagsModel : ISuccess
    {
        [JsonProperty("data")]
        public List<TagData> Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}