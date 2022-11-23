using AttireApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AttireApp.Models.DataModels
{
    public class Alerts : BindableBase
    {
        [JsonPropertyName("alert")]
        public List<Alert> Alert { get; set; }
    }

    public class Alert : BindableBase
    {
        [JsonPropertyName("headline")]
        public string Headline { get; set; }

        [JsonPropertyName("msgtype")]
        public string Msgtype { get; set; }

        [JsonPropertyName("severity")]
        public string Severity { get; set; }

        [JsonPropertyName("urgency")]
        public string Urgency { get; set; }

        [JsonPropertyName("areas")]
        public string Areas { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("certainty")]
        public string Certainty { get; set; }

        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("effective")]
        public DateTime Effective { get; set; }

        [JsonPropertyName("expires")]
        public DateTime Expires { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        [JsonPropertyName("instruction")]
        public string Instruction { get; set; }
    }
}
