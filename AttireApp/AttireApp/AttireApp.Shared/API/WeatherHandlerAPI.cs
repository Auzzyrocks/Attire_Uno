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

namespace AttireApp.API
{
    class WeatherHandlerAPI
    {
        public static HttpClient ApiClient;
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<RootForecast> CallWeatherForecastAPI()
        {
            string location = "nanaimo";
            string url = $"https://api.weatherapi.com/v1/current.json?key=0fa9f3b714ea42f8a2a235335222910&q={ location }&aqi=yes";
            using (HttpResponseMessage response = await ApiClient.GetAsync(url))
            {

                if (response.IsSuccessStatusCode)
                {
                    RootForecast result = await response.Content.ReadFromJsonAsync<RootForecast>();
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
