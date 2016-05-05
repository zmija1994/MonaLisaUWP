using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MonaLisaUWP
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PlanObiektuButton_Click(object sender, RoutedEventArgs e)
        {
            PlanObiektuButton.Style = (Style)Resources["PlanObiektuButtonStyleBlack"];
        }

        private void SkanerQRButton_Click(object sender, RoutedEventArgs e)
        {
            SkanerQRButton.Style = (Style)Resources["SkanerQRButtonStyleBlack"];
        }

        private void AktualnosciButton_Click(object sender, RoutedEventArgs e)
        {
            if (ActualWidth >= 0 && ActualWidth <= 320)
            {
                AktualnosciButton.Style = (Style)Resources["AktualnosciButtonStyleBlack4Inch"];
            }
            if (ActualWidth >= 321 && ActualWidth <= 341.33)
            {
                AktualnosciButton.Style = (Style)Resources["AktualnosciButtonStyleBlack45Inch"];
            }
            if (ActualWidth >= 342 && ActualWidth <= 360)
            {
                AktualnosciButton.Style = (Style)Resources["AktualnosciButtonStyleBlack5Inch"];
            }
            if (ActualWidth >= 361 && ActualWidth <= 432)
            {
                AktualnosciButton.Style = (Style)Resources["AktualnosciButtonStyleBlack6Inch"];
            }
        }

        private void WystawyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ActualWidth >= 0 && ActualWidth <= 320)
            {
                WystawyButton.Style = (Style)Resources["WystawyButtonStyleBlack4Inch"];
            }
            if (ActualWidth >= 321 && ActualWidth <= 341.33)
            {
                WystawyButton.Style = (Style)Resources["WystawyButtonStyleBlack45Inch"];
            }
            if (ActualWidth >= 342 && ActualWidth <= 360)
            {
                WystawyButton.Style = (Style)Resources["WystawyButtonStyleBlack5Inch"];
            }
            if (ActualWidth >= 361 && ActualWidth <= 432)
            {
                WystawyButton.Style = (Style)Resources["WystawyButtonStyleBlack6Inch"];
            }
        }

        private void KalendarzButton_Click(object sender, RoutedEventArgs e)
        {
            if (ActualWidth >= 0 && ActualWidth <= 320)
            {
                KalendarzButton.Style = (Style)Resources["KalendarzButtonStyleBlack4Inch"];
            }
            if (ActualWidth >= 321 && ActualWidth <= 341.33)
            {
                KalendarzButton.Style = (Style)Resources["KalendarzButtonStyleBlack45Inch"];
            }
            if (ActualWidth >= 342 && ActualWidth <= 360)
            {
                KalendarzButton.Style = (Style)Resources["KalendarzButtonStyleBlack5Inch"];
            }
            if (ActualWidth >= 361 && ActualWidth <= 432)
            {
                KalendarzButton.Style = (Style)Resources["KalendarzButtonStyleBlack6Inch"];
            }
        }

        private void SocialMediaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SocialMediaPage));
        }

        private void MyMainPage_Unloaded(object sender, RoutedEventArgs e)
        {
            MyMainPage.Style = (Style)Resources["MyMainPageStyle"];
        }
    }
}