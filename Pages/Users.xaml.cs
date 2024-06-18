using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Users.xaml
    /// </summary>
    public partial class Users : Page
    {
        public Users()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/bibonuwu/AfteReset/releases/"; // Укажите URL вашего сайта
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "https://wa.me/77081851433?text="; // Укажите URL вашего сайта
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://www.youtube.com/@abekenaibek"; // Укажите URL вашего сайта
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://www.instagram.com/abekenv/?utm_source=qr&r=nametag"; // Укажите URL вашего сайта
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://wa.me/77081851433"; // Укажите URL вашего сайта
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://t.me/bibon45232"; // Укажите URL вашего сайта
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Kaspi: 8 - 708 - 185 - 14 - 33", "Алдын ала рахмет!");
        }
    }
}
