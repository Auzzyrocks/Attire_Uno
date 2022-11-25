/*
 * Author: Brandon Cosh
 * Date: November 22, 2022
 * 
 * Description:
 *      The root 'model' to consume Json weather API from weatherAPI.com
 */
using AttireApp.Models.ViewModels;
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
