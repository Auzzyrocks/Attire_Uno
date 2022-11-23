using AttireApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AttireApp.Models.DataModels
{
    public class RootWeatherData : BindableBase
    {
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("current")]
        public Current Current { get; set; }

        [JsonPropertyName("forecast")]
        public Forecast Forecast { get; set; }

        [JsonPropertyName("alerts")]
        public Alerts Alerts { get; set; }
    }
}
