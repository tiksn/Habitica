using Newtonsoft.Json;
using System;

namespace TIKSN.Habitica.Models
{
    public class Timestamps
    {
        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("loggedin")]
        public DateTimeOffset Loggedin { get; set; }
    }
}