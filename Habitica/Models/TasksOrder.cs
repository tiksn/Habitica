using Newtonsoft.Json;

namespace TIKSN.Habitica.Models
{
    public class TasksOrder
    {
        [JsonProperty("habits")]
        public object[] Habits { get; set; }

        [JsonProperty("dailys")]
        public object[] Dailys { get; set; }

        [JsonProperty("todos")]
        public object[] Todos { get; set; }

        [JsonProperty("rewards")]
        public object[] Rewards { get; set; }
    }
}