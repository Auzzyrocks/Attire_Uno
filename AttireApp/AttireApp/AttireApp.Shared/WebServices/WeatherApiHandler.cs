/*
 * Author: Brandon Cosh
 * Date: November 22, 2022
 * 
 * Description:
 *      Class to access & request API calls to weatherAPI.com & store JSON result in RootWeatherData model class
 */
using System.Threading.Tasks;
using AttireApp.Models.DataModels;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;

namespace AttireApp.WebServices
{
    public static class ForecastSearchApi
    {
        private static HttpClient _client;                                      // There should only be one instance of HttpClient

        static ForecastSearchApi()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
        }

        static string apiKey = "0fa9f3b714ea42f8a2a235335222910";               // API key needed to access www.weatherapi.com
        static string daysForcast = "7";                                        // Number of days to request when making a forecast request
        static string additional = "yes";                                       // whether to include additional info, like air quality info & any alert notifications

        public static async Task<RootWeatherData> CreateApiUrl(string city)     // creates the url to send to API
        {
            RootWeatherData result = await GetAsync(
                $"https://api.weatherapi.com/v1/forecast.json?key={apiKey}" +
                $"&q={WebUtility.HtmlEncode(city)},Canada" +
                $"&days={daysForcast}" +
                $"&aqi={additional}" +
                $"&alerts={additional}");

            return result;
        }


        private static async Task<RootWeatherData> GetAsync(string url)         // Sends a get request to the API using the url created in CreateApiUrl
        {
            using var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                RootWeatherData result = await response.Content.ReadFromJsonAsync<RootWeatherData>();
                return result;
            }

            return null;                                                        // should include correct error handing here in the future
        }
    }
}
