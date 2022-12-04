// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using AttireApp.Database.DBUser;
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
            ViewModel.LocationSelected = Combo_Location.SelectedValue.ToString();
            ViewModel.WarmthPreferenceSelected = Combo_WarmthPref.SelectedIndex;
            ViewModel.WarmthPreferenceSelectedString = Combo_WarmthPref.SelectedValue.ToString();
            ViewModel.TempUnitSelected = Combo_TempUnits.SelectedIndex;
            ViewModel.TempUnitSelectedString = Combo_TempUnits.SelectedValue.ToString();

            ViewModel.SaveChanges();
            //this.Frame.Navigate(typeof(HomePage));
        }
        
        private void ForgotPasswordPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgotPasswordPage));
        }
        
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            User.CurrentUser = null;
            this.Frame.Navigate(typeof(MainPage));
        }


    }
}
