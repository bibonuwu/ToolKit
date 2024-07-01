using Microsoft.Web.WebView2.Core;
using System.Windows;
using System;
using System.Windows.Controls;
using System.Diagnostics;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Analytics.xaml
    /// </summary>
    public partial class Analytics : Page
    {
        public Analytics()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                if (webView.CoreWebView2 == null)
                {
                    await webView.EnsureCoreWebView2Async(null);
                }

                webView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
                webView.Source = new Uri("https://sites.google.com/view/prototypea");
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, show error message)
                Debug.WriteLine($"Error initializing WebView2: {ex.Message}");

                // Open the URL in the default browser as a fallback
                OpenUrlInDefaultBrowser("https://sites.google.com/view/prototypea");
            }
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
            webView.CoreWebView2.Navigate(e.Uri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void OpenUrlInDefaultBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error opening URL in browser: {ex.Message}");
            }
        }
    }
}
