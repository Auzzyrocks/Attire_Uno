// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using AttireApp.API;
using AttireApp.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Threading.Tasks;

namespace AttireApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ForecastPage : Page
    {
        public static readonly DependencyProperty WeatherDataProperty =
            DependencyProperty.Register(nameof(WeatherDataInfo), typeof(WeatherDataModel), typeof(ForecastPage), new PropertyMetadata(default(WeatherDataModel)));
        public WeatherDataModel WeatherDataInfo
        {
            get => (WeatherDataModel)GetValue(WeatherDataProperty);
            set => SetValue(WeatherDataProperty, value);
        }

        public ForecastPage()
        {
         
            WeatherHandlerAPI.InitializeClient();
            
            LoadWeatherForecast();
        }

        public async Task LoadWeatherForecast(string city = "Nanaimo")
        {
            WeatherDataInfo = await WeatherHandlerAPI.CallWeatherForecastAPI(city);
            this.InitializeComponent();
        }

        private void LoadVancouver_Click(Object sender, RoutedEventArgs e)
        {
            LoadWeatherForecast("Vancouver");
        }

        private void LoadNanaimo_Click(Object sender, RoutedEventArgs e)
        {
            LoadWeatherForecast("Nanaimo");
        }
    }
}
