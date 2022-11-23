﻿using AttireApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AttireApp.Models.DataModels
{
    public class AirQuality : BindableBase
    {
        [JsonPropertyName("co")]
        public double Co { get; set; }

        [JsonPropertyName("no2")]
        public double No2 { get; set; }

        [JsonPropertyName("o3")]
        public double O3 { get; set; }

        [JsonPropertyName("so2")]
        public double So2 { get; set; }

        [JsonPropertyName("pm2_5")]
        public double Pm25 { get; set; }

        [JsonPropertyName("pm10")]
        public double Pm10 { get; set; }

        [JsonPropertyName("us-epa-index")]
        public int UsEpaIndex { get; set; }

        [JsonPropertyName("gb-defra-index")]
        public int GbDefraIndex { get; set; }
    }
}
