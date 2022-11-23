using System.Collections.ObjectModel;
using System.Linq;
using AttireApp.Models.DataModels;
using AttireApp.WebServices;
using Uno.Extensions.Specialized;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System;
using Microsoft.UI.Xaml.Data;

namespace AttireApp.Models.ViewModels
{
    class ForecastViewModel : BindableBase
    {
        private bool _isBusy;
        private string _citySelected = String.Empty; // = "Nanaimo";
        private ObservableCollection<String> cityOptions = new ObservableCollection<String>()
        {
            "Nanaimo", "Vancouver", "Toronto", "Sydney"

        };
        private RootWeatherData _weatherData = new RootWeatherData();

        public bool IsBusy
        {
            get => _isBusy;
            set => SetMyProperty(ref _isBusy, value);
        }

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

        public RootWeatherData WeatherData
        {
            get => _weatherData;
            set => SetMyProperty(ref _weatherData, value);
        }

        // Insert constructor below here
        public ForecastViewModel()
        {
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
                    var result = await ForecastSearchApi.CallWeatherApi(_citySelected); //.ConfigureAwait(false);
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
