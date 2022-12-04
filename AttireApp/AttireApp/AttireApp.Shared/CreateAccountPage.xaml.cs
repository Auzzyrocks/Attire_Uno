// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using ABI.Windows.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using AttireApp.Database.DBUser;

namespace AttireApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateAccountPage : Page
    {
        public CreateAccountPage()
        {
            this.InitializeComponent();
        }
        private void LoginPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            ReadUIValues();

            if (ViewModel.ValidateAccountInfo())
            {
                Console.WriteLine("Validated");
                // User(string username, string password, string email, string firstname, string lastname, string location, int tempunit, int warmthpref)
                User newUser = new User(ViewModel.Username, ViewModel.Password, ViewModel.Username + "@mail.com", "First Name", "Last Name",
                    ViewModel.LocationSelected, ViewModel.TempUnitSelected, ViewModel.WarmthPreferenceSelected);

                User.CurrentUser = newUser;
                this.Frame.Navigate(typeof(HomePage));
            }
        }

        // stores all input box values into CreateAccountViewModel
        private void ReadUIValues()
        {
            ViewModel.Username = Textbox_Username.Text;
            ViewModel.Password = Passwordbox_Password.Password;
            ViewModel.PasswordConfirm = Passwordbox_PasswordConfirm.Password;
            ViewModel.LocationSelected = Combo_Location.SelectedItem == null ? string.Empty : Combo_Location.SelectedItem.ToString();
            ViewModel.WarmthPreferenceSelected = Combo_WarmthPref.SelectedItem == null ? -1 : Combo_WarmthPref.SelectedIndex;
            ViewModel.TempUnitSelected = Combo_TempUnitsPref == null ? -1 : Combo_TempUnitsPref.SelectedIndex;
        }
    }
}
