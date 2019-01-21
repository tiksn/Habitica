using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TIKSN.Habitica.Models
{
    public class TaskData
    {
        [JsonProperty("checklist", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChecklistItem> Checklist { get; set; }

        [JsonProperty("collapseChecklist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CollapseChecklist { get; set; }

        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Completed { get; set; }

        [JsonProperty("counterDown", NullValueHandling = NullValueHandling.Ignore)]
        public long? CounterDown { get; set; }

        [JsonProperty("counterUp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CounterUp { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("id")]
        public Guid DatumId { get; set; }

        [JsonProperty("daysOfMonth", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> DaysOfMonth { get; set; }

        [JsonProperty("down", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Down { get; set; }

        [JsonProperty("everyX", NullValueHandling = NullValueHandling.Ignore)]
        public long? EveryX { get; set; }

        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequency { get; set; }

        [JsonProperty("_id")]
        public Guid Id { get; set; }

        [JsonProperty("isDue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDue { get; set; }

        [JsonProperty("nextDue", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTimeOffset> NextDue { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("priority")]
        public double Priority { get; set; }

        [JsonProperty("repeat", NullValueHandling = NullValueHandling.Ignore)]
        public Repeat Repeat { get; set; }

        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("streak", NullValueHandling = NullValueHandling.Ignore)]
        public long? Streak { get; set; }

        [JsonProperty("tags")]
        public List<Guid> Tags { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Up { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("weeksOfMonth", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> WeeksOfMonth { get; set; }

        [JsonProperty("yesterDaily", NullValueHandling = NullValueHandling.Ignore)]
        public bool? YesterDaily { get; set; }
    }
}