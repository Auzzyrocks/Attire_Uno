// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
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

        void Image_Loaded(object sender, RoutedEventArgs e)
        {
           

            Image img = sender as Image;
            if (img != null)
            {
              

                if (true)
                {

                    BitmapImage bitmapImage = new BitmapImage();
                    img.Width = bitmapImage.DecodePixelWidth = 280;
                    bitmapImage.UriSource = new Uri("ms-appx:///pants_icon.png");
                    img.Source = bitmapImage;

                }
                else
                {

                    BitmapImage bitmapImage = new BitmapImage();
                    img.Width = bitmapImage.DecodePixelWidth = 280;
                    bitmapImage.UriSource = new Uri("ms-appx:///shorts_icon.png");
                    img.Source = bitmapImage;
                }
              
            }
        }
    }
}
