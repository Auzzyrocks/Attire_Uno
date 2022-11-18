/*
 * Author: Brandon Cosh
 * Date: November 7, 2022
 */

using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AttireApp.API
{
    public class RootForecast : ObservableObject
    {
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        private Current current;
        [JsonPropertyName("current")]
        public Current Current
        {
            get => current;
            set => SetProperty(ref current, value);
        }

        [JsonPropertyName("forecast")]
        public Forecast Forecast { get; set; }

        [JsonPropertyName("alerts")]
        public Alerts Alerts { get; set; }
    }

    public class Forecast
    {
        [JsonPropertyName("forecastday")]
        public List<Forecastday> Forecastday { get; set; }
    }

    public class Forecastday
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

    public class Day
    {
        [JsonPropertyName("maxtemp_c")]
        public double MaxtempC { get; set; }

        [JsonPropertyName("maxtemp_f")]
        public double MaxtempF { get; set; }

        [JsonPropertyName("mintemp_c")]
        public double MintempC { get; set; }

        [JsonPropertyName("mintemp_f")]
        public double MintempF { get; set; }

        [JsonPropertyName("avgtemp_c")]
        public double AvgtempC { get; set; }

        [JsonPropertyName("avgtemp_f")]
        public double AvgtempF { get; set; }

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

    public class Hour
    {
        [JsonPropertyName("time_epoch")]
        public int TimeEpoch { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
        public DateTime RTime { get; set; }

        [JsonPropertyName("temp_c")]
        public double TempC { get; set; }

        [JsonPropertyName("temp_f")]
        public double TempF { get; set; }

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

    public class Astro
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

    public class Alerts
    {
        [JsonPropertyName("alert")]
        public List<Alert> Alert { get; set; }
    }

    public class Alert
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

    public class AirQuality
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
