using AttireApp.Models.DataModels;
using AttireApp.WebServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AttireApp.Models.ViewModels
{
    class WeatherViewModelBase : BindableBase
    {
        // The main object that stores all weather information
        private RootWeatherData _weatherData = new();
        public RootWeatherData WeatherData
        {
            get => _weatherData;
            set => SetMyProperty(ref _weatherData, value);
        }

        // Constructor
        public WeatherViewModelBase()
        {
            LoadWeather(); // we want to reload all the weather data anytime a new WeatherViewModelBase is instantiated
        }

        // True when async Task LoadWeatherData has started but not yet finished
        // useful if we want to add a 'loading' or 'busy' icon/mouse
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetMyProperty(ref _isBusy, value);
        }

        // This [will] read in the user location preference from the Database
        public string LocationPreference
        {
            get => "Nanaimo"; // for now since the user database does not actually contain user info we set it to Nanaimo
        }

        private async void LoadWeather()
        {
            await LoadWeatherData();
        }

        // calls to weather API using LocationPreference got from Database as API query
        public async Task LoadWeatherData()
        {
            if (!string.IsNullOrWhiteSpace(LocationPreference))
            {
                try
                {
                    IsBusy = true;
                    var result = await ForecastSearchApi.CreateApiUrl(LocationPreference);
                    if (result != null)
                    {
                        WeatherData = result;
                    }
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }
    }
}
