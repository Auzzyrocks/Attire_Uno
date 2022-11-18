/*
 * Author: Brandon Cosh
 * Date: November 16, 2022
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ABI.System;
using System.Net.Http.Json;
using System.Collections.Specialized;
using AttireApp.Models;

namespace AttireApp.API
{
    // API KEY  0fa9f3b714ea42f8a2a235335222910
    static class WeatherHandlerAPI
    {
        public static HttpClient ApiClient;
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<WeatherDataModel> CallWeatherForecastAPI(string city = "Nanaimo")
        {
            string key = "0fa9f3b714ea42f8a2a235335222910";
            string location = city;
            string days = "7";
            string airQuality = "yes";
            string alerts = "yes";
            //string url = $"https://api.weatherapi.com/v1/current.json?key=0fa9f3b714ea42f8a2a235335222910&q={ location }&days={ days }&aqi={ airQuality }&alerts={ alerts }";
            //string url = "http://api.weatherapi.com/v1/forecast.json?key=0fa9f3b714ea42f8a2a235335222910&q=Nanaimo&days=7&aqi=yes&alerts=yes";
            string url = "http://api.weatherapi.com/v1/forecast.json?key=";
            url = url + key + "&q=" + location + "&days=" + days + "&aqi=" + airQuality + "&alerts=" + alerts;
            using (HttpResponseMessage response = await ApiClient.GetAsync(url))
            {

                if (response.IsSuccessStatusCode)
                {
                    WeatherDataModel result = await response.Content.ReadFromJsonAsync<WeatherDataModel>();
                    return result;
                }
                else
                {
                    Console.WriteLine("Could not reach API: " + response.ReasonPhrase);
                    return null;
                }
            }
        }
    }
}
