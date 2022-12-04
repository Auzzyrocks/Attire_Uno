/*
 * Author: Brandon Cosh
 * Date: November 22, 2022
 * 
 * Description:
 *      A 'model' to consume Json weather API from weatherAPI.com
 */
using AttireApp.Database.DBUser;
using AttireApp.Models.ViewModels;
using System;
using System.Text.Json.Serialization;

namespace AttireApp.Models.DataModels
{
    public class Day : BindableBase
    {
        [JsonPropertyName("maxtemp_c")]
        public double MaxtempC { get; set; }

        [JsonPropertyName("maxtemp_f")]
        public double MaxtempF { get; set; }

        public string MaxtempP
        {
            get
            {
                string maxTemp = MaxtempC.ToString();
                if(User.CurrentUser != null)
                {
                    maxTemp = User.CurrentUser.TempUnit == 0 ? Math.Round(MaxtempC).ToString() + "°C" : Math.Round(MaxtempF) + "°F";
                }
                return maxTemp;
            }
        }

        [JsonPropertyName("mintemp_c")]
        public double MintempC { get; set; }

        [JsonPropertyName("mintemp_f")]
        public double MintempF { get; set; }

        public string MintempP
        {
            get
            {
                string minTemp = MintempC.ToString();
                if (User.CurrentUser != null)
                {
                    minTemp = User.CurrentUser.TempUnit == 0 ? Math.Round(MintempC) + "°C" : Math.Round(MintempF) + "°F";
                }
                return minTemp;
            }
        }

        [JsonPropertyName("avgtemp_c")]
        public double AvgtempC { get; set; }

        [JsonPropertyName("avgtemp_f")]
        public double AvgtempF { get; set; }

        public string AvgtempP
        {
            get
            {
                string avgTemp = AvgtempC.ToString();
                if (User.CurrentUser != null)
                {
                    avgTemp = User.CurrentUser.TempUnit == 0 ? Math.Round(AvgtempC) + "°C" : Math.Round(AvgtempF)    + "°F";
                }
                return avgTemp;
            }
        }

        [JsonPropertyName("maxwind_mph")]
        public double MaxwindMph { get; set; }

        [JsonPropertyName("maxwind_kph")]
        public double MaxwindKph { get; set; }

        [JsonPropertyName("totalprecip_mm")]
        public double TotalprecipMm { get; set; }

        [JsonPropertyName("totalprecip_in")]
        public double TotalprecipIn { get; set; }

        [JsonPropertyName("totalsnow_cm")]
        public double TotalsnowCm { get; set; }

        [JsonPropertyName("avgvis_km")]
        public double AvgvisKm { get; set; }

        [JsonPropertyName("avgvis_miles")]
        public double AvgvisMiles { get; set; }

        [JsonPropertyName("avghumidity")]
        public double Avghumidity { get; set; }

        [JsonPropertyName("daily_will_it_rain")]
        public int DailyWillItRain { get; set; }

        [JsonPropertyName("daily_chance_of_rain")]
        public int DailyChanceOfRain { get; set; }

        [JsonPropertyName("daily_will_it_snow")]
        public int DailyWillItSnow { get; set; }

        [JsonPropertyName("daily_chance_of_snow")]
        public int DailyChanceOfSnow { get; set; }

        [JsonPropertyName("condition")]
        public Condition Condition { get; set; }

        [JsonPropertyName("uv")]
        public double Uv { get; set; }

        [JsonPropertyName("air_quality")]
        public AirQuality AirQuality { get; set; }
    }
}
