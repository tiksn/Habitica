﻿using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class TagCreationModel
    {
        [JsonProperty("name")]
        public string name { get; set; }
    }
}