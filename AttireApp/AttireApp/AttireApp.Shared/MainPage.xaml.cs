using Attire.DataBase;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AttireApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LinkForecast_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForecastPage));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = e.ToString();
            string password = e.ToString();
            Login.ValidateLogin(username, password);
        }
    }
}
