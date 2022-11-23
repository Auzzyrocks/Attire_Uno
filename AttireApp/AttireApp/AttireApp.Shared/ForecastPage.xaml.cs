// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using AttireApp.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Threading.Tasks;

namespace AttireApp
{
    public sealed partial class ForecastPage : Page
    {
        public ForecastPage()
        {
            this.InitializeComponent();
        }

        private async void CityChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string city = e.AddedItems[0].ToString();
            await ViewModel.LoadWeatherData(city);
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }
    }
}
