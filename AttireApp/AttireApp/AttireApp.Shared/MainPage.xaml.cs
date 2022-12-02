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

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }

        // Your Login_Click should look something like this
        private void Brandon_Login_Click(object sender, RoutedEventArgs e)
        {
            if(ViewModel.OnLogin()) // <-- do your validation in this function 
            {
                this.Frame.Navigate(typeof(HomePage));
            } else
            {
                // show invalid entry error and stay at login page

            }
        }

        //created basic functionality but its still not connected to the login fields
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //dont know how to get login fields for use in the validate login method
            string username = "user";
            string pass = "paswrd";
            int validate = Login.ValidateLogin(username, pass);
            if(validate == 1)
            {
                //if user & pass match, then navigate to homepage
                this.Frame.Navigate(typeof(HomePage));
            }
            else if(validate == 0)
            {
                //TODO:
                //(I dont know if this is the right method or how to use it but it sounded right)
                //when validate == 0, password is incorrect, update the homepage to display incorrect username/password prompt
                this.Frame.UpdateLayout();
            }
            else
            {
                //TODO:
                //user not found, update homepage to say "user not found, create account?"
                this.Frame.UpdateLayout();
            }
            
        }

        private void LinkForecast_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForecastPage));
        }
        
        private void CreateAccountPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateAccountPage));
        }

       
    }
}
