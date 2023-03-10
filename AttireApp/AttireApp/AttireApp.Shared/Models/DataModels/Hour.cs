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
    public class Hour : BindableBase
    {
        [JsonPropertyName("time_epoch")]
        public int TimeEpoch { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
        public DateTime RTime
        {
            get
            {
                DateTime date = DateTime.Parse(Time);
                // string formattedDate = date.ToString("MM/d/yyyy h:mm:ff tt");
                // DateTime dateTime = DateTime.Parse(formattedDate);
                return date;
            }
        }

        [JsonPropertyName("temp_c")]
        public double TempC { get; set; }

        [JsonPropertyName("temp_f")]
        public double TempF { get; set; }

        public string TempP
        {
            get
            {
                string temp = TempC.ToString();
                if(User.CurrentUser != null)
                {
                    temp = User.CurrentUser.TempUnit == 0? Math.Round(TempC) + "°C" : Math.Round(TempF) + "°F";
                }
                return temp;
            }
        }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("condition")]
        public Condition Condition { get; set; }

        [JsonPropertyName("wind_mph")]
        public double WindMph { get; set; }

        [JsonPropertyName("wind_kph")]
        public double WindKph { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; }

        [JsonPropertyName("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonPropertyName("pressure_in")]
        public double PressureIn { get; set; }

        [JsonPropertyName("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonPropertyName("precip_in")]
        public double PrecipIn { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloud")]
        public int Cloud { get; set; }

        [JsonPropertyName("feelslike_c")]
        public double FeelslikeC { get; set; }

        [JsonPropertyName("feelslike_f")]
        public double FeelslikeF { get; set; }

        [JsonPropertyName("windchill_c")]
        public double WindchillC { get; set; }

        [JsonPropertyName("windchill_f")]
        public double WindchillF { get; set; }

        [JsonPropertyName("heatindex_c")]
        public double HeatindexC { get; set; }

        [JsonPropertyName("heatindex_f")]
        public double HeatindexF { get; set; }

        [JsonPropertyName("dewpoint_c")]
        public double DewpointC { get; set; }

        [JsonPropertyName("dewpoint_f")]
        public double DewpointF { get; set; }

        [JsonPropertyName("will_it_rain")]
        public int WillItRain { get; set; }

        [JsonPropertyName("chance_of_rain")]
        public int ChanceOfRain { get; set; }

        [JsonPropertyName("will_it_snow")]
        public int WillItSnow { get; set; }

        [JsonPropertyName("chance_of_snow")]
        public int ChanceOfSnow { get; set; }

        [JsonPropertyName("vis_km")]
        public double VisKm { get; set; }

        [JsonPropertyName("vis_miles")]
        public double VisMiles { get; set; }

        [JsonPropertyName("gust_mph")]
        public double GustMph { get; set; }

        [JsonPropertyName("gust_kph")]
        public double GustKph { get; set; }

        [JsonPropertyName("uv")]
        public double Uv { get; set; }

        [JsonPropertyName("air_quality")]
        public AirQuality AirQuality { get; set; }
    }
}
