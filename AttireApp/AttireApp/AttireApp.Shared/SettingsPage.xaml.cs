// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace AttireApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }
        
        private void ApplySettings_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(HomePage));
        }
        
        private void ForgotPasswordPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgotPasswordPage));
        }
        
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(MainPage));
        }


    }
}
