/*
 * Author: Brandon Cosh
 * Date: November 22, 2022
 * 
 * Description:
 *      View model used to display weather forecast information that inherits from BindableBase which implements INotifyPropertyChanged.
 */
using System.Collections.ObjectModel;
using AttireApp.Models.DataModels;
using AttireApp.WebServices;
using System.Threading.Tasks;
using System;

namespace AttireApp.Models.ViewModels
{
    class ForecastViewModel : BindableBase
    {
        private ObservableCollection<String> cityOptions = new()
        {
            "Nanaimo", "Duncan", "Victoria", "Courtenay", "Vancouver", "Toronto", "London"

        };

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetMyProperty(ref _isBusy, value);
        }

        private string _citySelected = string.Empty;
        public string CitySelected
        {
            get => _citySelected;
            set => SetMyProperty(ref _citySelected, value);
        }

        public ObservableCollection<String> CityOptions
        {
            get => cityOptions;
            set => SetMyProperty(ref cityOptions, value);
        }

        private RootWeatherData _weatherData = new();
        public RootWeatherData WeatherData
        {
            get => _weatherData;
            set => SetMyProperty(ref _weatherData, value);
        }

        // Insert constructor below here
        public ForecastViewModel()
        {
            if (LoggedInUser.CurrentUser != null)
            {
                CitySelected = LoggedInUser.CurrentUser.Location;
            } else
            {
                CitySelected = "Vancouver";
            }
           LoadWeather();
        }

        private async void LoadWeather()
        {
            await LoadWeatherData(CitySelected);
        }

        // calls to weather API using string city as API query
        public async Task LoadWeatherData(string city)
        {
            CitySelected = city;
            if (!string.IsNullOrWhiteSpace(_citySelected))
            {
                try
                {
                    IsBusy = true;
                    var result = await ForecastSearchApi.CreateApiUrl(_citySelected);
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
