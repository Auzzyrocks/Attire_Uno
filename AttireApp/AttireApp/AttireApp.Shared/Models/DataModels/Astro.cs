using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using AttireApp.Models.ViewModels;

namespace AttireApp.Models.DataModels
{
    public class Astro : BindableBase
    {
        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }

        [JsonPropertyName("moonrise")]
        public string Moonrise { get; set; }

        [JsonPropertyName("moonset")]
        public string Moonset { get; set; }

        [JsonPropertyName("moon_phase")]
        public string MoonPhase { get; set; }

        [JsonPropertyName("moon_illumination")]
        public string MoonIllumination { get; set; }
    }
}
