using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MonaLisaUWP
{
    public sealed partial class SocialMediaPage : Page
    {
        public SocialMediaPage()
        {
            this.InitializeComponent();
        }

        private void SocialMediaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void YoutubeButton_Click(object sender, RoutedEventArgs e)
        {
            var uriToLaunch = @"http://www.youtube.com";
            var uri = new Uri(uriToLaunch);
            Launcher.LaunchUriAsync(uri);
        }

        private void InstagramButton_Click(object sender, RoutedEventArgs e)
        {
            var uriToLaunch = @"http://www.instagram.com";
            var uri = new Uri(uriToLaunch);
            Launcher.LaunchUriAsync(uri);
        }

        private void LinkedinButton_Click(object sender, RoutedEventArgs e)
        {
            var uriToLaunch = @"http://www.linkedin.com";
            var uri = new Uri(uriToLaunch);
            Launcher.LaunchUriAsync(uri);
        }

        private void GooglePlusButton_Click(object sender, RoutedEventArgs e)
        {
            var uriToLaunch = @"https://plus.google.com/";
            var uri = new Uri(uriToLaunch);
            Launcher.LaunchUriAsync(uri);
        }

        private void FacebookButton_Click(object sender, RoutedEventArgs e)
        {
            var uriToLaunch = @"https://facebook.com/";
            var uri = new Uri(uriToLaunch);
            Launcher.LaunchUriAsync(uri);
        }
    }
}
