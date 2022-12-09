/*
 * Author: Brandon Cosh
 * Date: November 22, 2022
 * 
 * Description:
 *      A 'model' to consume Json weather API from weatherAPI.com
 */
using AttireApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AttireApp.Models.DataModels
{
    public class Forecast : BindableBase
    {
        [JsonPropertyName("forecastday")]
        public List<Forecastday> Forecastday { get; set; }
    }

    public class Forecastday : BindableBase
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("date_epoch")]
        public int DateEpoch { get; set; }

        [JsonPropertyName("day")]
        public Day Day { get; set; }

        [JsonPropertyName("astro")]
        public Astro Astro { get; set; }

        [JsonPropertyName("hour")]
        public List<Hour> Hour { get; set; }
    }
}
