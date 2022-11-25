// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace AttireApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void SettingsPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }

        private void ForecastPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForecastPage));
        }

        public void ShowTwoWayBind_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
