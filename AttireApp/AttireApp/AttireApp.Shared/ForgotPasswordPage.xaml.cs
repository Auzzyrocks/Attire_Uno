// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace AttireApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ForgotPasswordPage : Page
    {
        public ForgotPasswordPage()
        {
            this.InitializeComponent();
        }
        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.ChangePass())
            {
                this.Frame.Navigate(typeof(HomePage));
            }
            else
            {
                //do something?
            }
            
        }
    }
}
