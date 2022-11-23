using System.Threading.Tasks;
using AttireApp.Models.DataModels;
using Windows.Media.Protection.PlayReady;
using System.Net.Http;
using System.Net.Http.Json;
using Uno.Extensions.Specialized;
using System.Net.Http.Headers;
using System.Net;

namespace AttireApp.WebServices
{
    public static class ForecastSearchApi
    {
        private static HttpClient _client; // There should only be one instance of HttpClient

        static ForecastSearchApi()
        {
            _client = new HttpClient();
            //_client.DefaultRequestHeaders.Accept.Clear();
            //_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static string apiKey = "0fa9f3b714ea42f8a2a235335222910";
        static string daysForcast = "7";
        static string additional = "yes";

        public static async Task<RootWeatherData> CallWeatherApi(string city)
        {

            RootWeatherData result = await GetAsync(
                $"https://api.weatherapi.com/v1/forecast.json?key={apiKey}" +
                $"&q={WebUtility.HtmlEncode(city)}" +
                $"&days={daysForcast}" +
                $"&aqi={additional}" +
                $"&alerts={additional}");

            return result;
        }

        private static async Task<RootWeatherData> GetAsync(string url)
        {
            using (var response = await _client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    RootWeatherData result = await response.Content.ReadFromJsonAsync<RootWeatherData>();
                    return result;
                }

                return null;
            }
        }
    }
}
