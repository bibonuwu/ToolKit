using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media;
using WPFUIKitProfessional.Pages.Loading;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            bool operationSuccess = true;
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo", "Enabled", 0);
                Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", 1);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_TrackProgs", 0);
            }
            catch (Exception)
            {
                operationSuccess = false;
            }
            bool flag = operationSuccess;
            if (flag)
            {
                this.q1.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q1.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            bool operationSuccess = true;
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Speech_OneCore\Settings\OnlineSpeechPrivacy", "HasAccepted", 0);
            }
            catch (Exception)
            {
                operationSuccess = false;
            }
            bool flag = operationSuccess;
            if (flag)
            {
                this.q2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            bool operationSuccess = true;
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Personalization\\Settings", "AcceptedPrivacyPolicy", 0);
            }
            catch (Exception)
            {
                operationSuccess = false;
            }
            bool flag = operationSuccess;
            if (flag)
            {
                this.q3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            bool operationSuccess = true;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Privacy"))
                {
                    if (key != null)
                    {
                        key.SetValue("TailoredExperiencesWithDiagnosticDataEnabled", 0, RegistryValueKind.DWord);
                    }
                }

                using (RegistryKey key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection"))
                {
                    if (key != null)
                    {
                        key.SetValue("AllowTelemetry", 0, RegistryValueKind.DWord);
                    }
                }
            }
            catch (Exception)
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                this.q4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications";
            string keyPath2 = "Software\\Microsoft\\Windows\\CurrentVersion\\Search";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("GlobalUserDisabled", 1, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("GlobalUserDisabled", 1, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
                using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true))
                {
                    bool flag2 = key2 != null;
                    if (flag2)
                    {
                        key2.SetValue("BackgroundAppGlobalToggle", 0, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey2 = Registry.CurrentUser.CreateSubKey(keyPath2))
                        {
                            if (newKey2 != null)
                            {
                                newKey2.SetValue("BackgroundAppGlobalToggle", 0, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }
            bool flag3 = operationSuccess;
            if (flag3)
            {
                this.q16.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q16.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            string keyPathLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics";
            bool operationSuccessLocation = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("Value", "Deny", RegistryValueKind.String);
                        operationSuccessLocation = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);
                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }
            bool flag3 = operationSuccessLocation;
            if (flag3)
            {
                this.q17.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q17.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("TaskbarGlomLevel", 1, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("TaskbarGlomLevel", 1, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }
            bool flag3 = operationSuccess;
            if (flag3)
            {
                this.q18.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q18.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("LaunchTo", 1, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            bool flag2 = operationSuccess;
            if (flag2)
            {
                this.q19.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q19.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("RotatingLockScreenEnabled", 0, RegistryValueKind.DWord);
                        key.SetValue("RotatingLockScreenOverlayEnabled ", 0, RegistryValueKind.DWord);
                        key.SetValue("SubscribedContent-338387Enabled", 0, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("RotatingLockScreenEnabled", 0, RegistryValueKind.DWord);
                                newKey.SetValue("RotatingLockScreenOverlayEnabled ", 0, RegistryValueKind.DWord);
                                newKey.SetValue("SubscribedContent-338387Enabled", 0, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }
            bool flag3 = operationSuccess;
            if (flag3)
            {
                this.q20.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q20.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("HubMode", 1, RegistryValueKind.DWord);
                        this.q21.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        this.q21.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                    }
                }
            }
            catch (Exception)
            {
                this.q21.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
            try
            {
                using (RegistryKey baseKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Desktop\\NameSpace_36354489", true))
                {
                    bool flag2 = baseKey != null && baseKey.GetSubKeyNames().Contains("{f874310e-b6b7-47dc-bc84-b9e6b38f5903}");
                    if (flag2)
                    {
                        baseKey.DeleteSubKey("{f874310e-b6b7-47dc-bc84-b9e6b38f5903}");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Clipboard";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("EnableClipboardHistory", 0, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("EnableClipboardHistory", 0, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }
            bool flag3 = operationSuccess;
            if (flag3)
            {
                this.q22.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q22.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private async void Button23_Click(object sender, RoutedEventArgs e)
        {
            GifWindow gifWindow = null;

            // Открываем GifWindow в отдельном потоке
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    gifWindow = new GifWindow();
                    gifWindow.Show();
                });
            });

            // Выполняем клики по кнопкам в отдельном потоке
            await Task.Run(async () =>
            {
                List<Button> buttons = new List<Button>
        {
            Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10,
            Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20,
            Button21, Button22, Button26, Button27, Button28, Button29, Button30, Button31, Button32
        };

                foreach (Button button in buttons)
                {
                    Application.Current.Dispatcher.Invoke(() => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent)));
                    await Task.Delay(100);
                }
            });

            // Закрываем GifWindow после выполнения операций
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    gifWindow.Close();
                });
            });

            // Изменяем фон после закрытия gifWindow
            this.q23.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
        }


        private void Button24_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("AppsUseLightTheme", 1, RegistryValueKind.DWord);
                        key.SetValue("SystemUsesLightTheme", 1, RegistryValueKind.DWord);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось открыть ключ реестра.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                operationSuccess = false;
            }
            bool flag2 = operationSuccess;
            if (flag2)
            {
                this.q24.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string wallpaperPath = System.IO.Path.Combine(appDirectory, "White.jpg");
            SetWallpaper(wallpaperPath);

        }

        public static void SetWallpaper(string imagePath)
        {
            string wallpaperDirectory = System.IO.Path.GetDirectoryName(imagePath);
            string wallpaperName = System.IO.Path.GetFileName(imagePath);

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true))
            {
                if (key != null)
                {
                    key.SetValue("WallpaperStyle", "2");
                    key.SetValue("TileWallpaper", "0");

                }
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, System.IO.Path.Combine(wallpaperDirectory, wallpaperName), SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }

        const int SPI_SETDESKWALLPAPER = 0x0014;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDCHANGE = 0x02;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);


        private void Button25_Click(object sender, RoutedEventArgs e)
        {

            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("AppsUseLightTheme", 0, RegistryValueKind.DWord);
                        key.SetValue("SystemUsesLightTheme", 0, RegistryValueKind.DWord);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось открыть ключ реестра.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                operationSuccess = false;
            }
            bool flag2 = operationSuccess;
            if (flag2)
            {
            }
            else
            {
            }
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string wallpaperPath = System.IO.Path.Combine(appDirectory, "Dark.jpg");
            SetWallpaper(wallpaperPath);
        }

        private void Button26_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "powercfg /s SCHEME_MIN",
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            bool operationSuccess = false;
            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                    bool flag = process.ExitCode == 0;
                    if (flag)
                    {
                        operationSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to execute command: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
                operationSuccess = false;
            }
            bool flag2 = operationSuccess;
            if (flag2)
            {
                this.q26.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q26.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button27_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Feeds";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true) ?? Registry.CurrentUser.CreateSubKey(keyPath))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("ShellFeedsTaskbarViewMode", 2, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("ShellFeedsTaskbarViewMode", 2, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }
            bool flag3 = operationSuccess;
            if (flag3)
            {
                this.q27.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q27.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button28_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search";
            bool operationSuccess = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    bool flag = key != null;
                    if (flag)
                    {
                        key.SetValue("SearchboxTaskbarMode", 1, RegistryValueKind.DWord);
                        key.SetValue("SearchboxTaskbarModePrevious", 2, RegistryValueKind.DWord);
                        key.SetValue("TraySearchBoxVisible", 0, RegistryValueKind.DWord);
                        key.SetValue("TraySearchBoxVisibleOnAnyMonitor", 0, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            bool flag2 = newKey != null;
                            if (flag2)
                            {
                                newKey.SetValue("SearchboxTaskbarMode", 1, RegistryValueKind.DWord);
                                newKey.SetValue("SearchboxTaskbarModePrevious", 2, RegistryValueKind.DWord);
                                newKey.SetValue("TraySearchBoxVisible", 0, RegistryValueKind.DWord);
                                newKey.SetValue("TraySearchBoxVisibleOnAnyMonitor", 0, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }
            bool flag3 = operationSuccess;
            if (flag3)
            {
                this.q28.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q28.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button29_Click(object sender, RoutedEventArgs e)
        {
            string[] keysToDelete = new string[]
            {
                "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\MyComputer\\NameSpace\\{24ad3ad4-a569-4530-98e1-ab02f9417aa8}",
                "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\MyComputer\\NameSpace\\{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}",
                "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\MyComputer\\NameSpace\\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}"
            };
            bool allDeleted = true;
            foreach (string keyPath in keysToDelete)
            {
                try
                {
                    using (RegistryKey baseKey = Registry.LocalMachine)
                    {
                        RegistryKey key = baseKey.OpenSubKey(keyPath, true);
                        bool flag = key != null;
                        if (flag)
                        {
                            baseKey.DeleteSubKey(keyPath);
                        }
                        else
                        {
                            allDeleted = false;
                        }
                    }
                }
                catch (Exception)
                {
                    allDeleted = false;
                }
            }
            bool flag2 = allDeleted;
            if (flag2)
            {
                this.q29.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.q29.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
        }

        private void Button30_Click(object sender, RoutedEventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string scriptPath = System.IO.Path.Combine(appDirectory, "StartMenuLayout.ps1");
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-ExecutionPolicy Bypass -File \"" + scriptPath + "\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            Process process = new Process
            {
                StartInfo = psi
            };
            process.Start();
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            string errors = process.StandardError.ReadToEnd();
            bool flag = !string.IsNullOrEmpty(errors);
            if (flag)
            {
                this.q30.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
            else
            {
                this.q30.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
        }

        private void Button31_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "Software\\Classes\\CLSID\\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}";
            RegistryKey baseKey = Registry.CurrentUser;
            RegistryKey registryKey = baseKey.CreateSubKey(keyPath);
            bool flag = registryKey != null;
            if (flag)
            {
                try
                {
                    registryKey.SetValue("System.IsPinnedToNameSpaceTree", 0, RegistryValueKind.DWord);
                    this.q31.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                }
                catch (Exception ex)
                {
                    this.q31.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                }
                finally
                {
                    registryKey.Close();
                }
            }
            else
            {
                this.q31.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Button32_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
            RegistryKey baseKey = Registry.CurrentUser;
            RegistryKey registryKey = baseKey.CreateSubKey(keyPath);
            bool flag = registryKey != null;
            if (flag)
            {
                try
                {
                    object existingValue = registryKey.GetValue("ShowTaskViewButton");
                    int newValue = 0;
                    bool flag2 = existingValue != null && (int)existingValue != newValue;
                    if (flag2)
                    {
                    }
                    registryKey.SetValue("ShowTaskViewButton", newValue, RegistryValueKind.DWord);
                    this.q32.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                }
                catch (Exception ex)
                {
                    this.q32.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                }
                finally
                {
                    registryKey.Close();
                }
            }
            else
            {
                this.q32.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }



        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------




        private void Buon1_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "AdobeSystemsIncorporated.AdobePhotoshopExpress";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border_Microsoft_BingWeather.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border_Microsoft_BingWeather.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border_Microsoft_BingWeather.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border_Microsoft_BingWeather.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon2_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "CandyCrush";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon3_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Duolingo";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon4_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "EclipseManager";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon5_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Facebook";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon6_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "king.com.FarmHeroesSaga";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon7_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Flipboard";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon8_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "HiddenCityMysteryofShadows";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon9_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "HuluLLC.HuluPlus";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon10_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Pandora";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon11_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Plex";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon12_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "ROBLOXCORPORATION.ROBLOX";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon13_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Spotify";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon14_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Twitter";
            string checkCommand = "Get-AppxPackage -Name *" + packageName + "*";
            string removeCommand = "Get-AppxPackage -Name *" + packageName + "* | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Buon15_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.549981C3F5F10";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }











        private void Butto1_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.BingWeather";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Border_Microsoft_BingWeather1.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Border_Microsoft_BingWeather1.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Border_Microsoft_BingWeather1.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Border_Microsoft_BingWeather1.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto2_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.GetHelp";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde2.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto3_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.Microsoft3DViewer";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde3.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto4_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftOfficeHub";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Bordo4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Bordo4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Bordo4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Bordo4.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto5_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftStickyNotes";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde5.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto6_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.Office.OneNote";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde6.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto7_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.People";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde7.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto8_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.ScreenSketch";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde8.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto9_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.Wallet";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde9.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto10_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.WindowsFeedbackHub";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde10.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto11_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.WindowsMaps";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde11.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto12_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.YourPhone";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde12.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto13_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.SkypeApp";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde13.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto14_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "microsoft.windowscommunicationsapps";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde14.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto15_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MixedReality.Portal";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde15.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto16_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftSolitaireCollection";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde16.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde16.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde16.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde16.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto17_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.549981C3F5F10";
            string checkCommand = "Get-AppxPackage -Name " + packageName;
            string removeCommand = "Get-AppxPackage -Name " + packageName + " | Remove-AppxPackage";
            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + checkCommand + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();
                    bool flag = string.IsNullOrWhiteSpace(output);
                    if (flag)
                    {
                        this.Borde17.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                    }
                    else
                    {
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + removeCommand + "\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            bool flag2 = processRemove.ExitCode == 0;
                            if (flag2)
                            {
                                this.Borde17.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
                            }
                            else
                            {
                                this.Borde17.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.Borde17.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private void Butto18_Click(object sender, RoutedEventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-WindowStyle Hidden -Command \"& {Start-Process 'C:\\Windows\\SysWOW64\\OneDriveSetup.exe' -ArgumentList '/uninstall' -Verb RunAs -WindowStyle Hidden}\""
            });
            process.WaitForExit();
            bool flag = process.ExitCode == 0;
            if (flag)
            {
                this.Borde18.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
            }
            else
            {
                this.Borde18.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 153, 164));
            }
        }

        private async void Butt19_Click(object sender, RoutedEventArgs e)
        {
            GifWindow gifWindow = null;

            // Открываем GifWindow в отдельном потоке
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    gifWindow = new GifWindow();
                    gifWindow.Show();
                });
            });

            List<Button> buttons1 = new List<Button>
    {
        Buon1, Buon2, Buon3, Buon4, Buon5, Buon6, Buon7, Buon8, Buon9, Buon10,
        Buon11, Buon12, Buon13, Buon14, Buon15
    };

            List<Button> buttons2 = new List<Button>
    {
        Butto1, Butto2, Butto3, Butto4, Butto5, Butto6, Butto7, Butto8, Butto9, Butto10,
        Butto11, Butto12, Butto13, Butto14, Butto15, Butto16, Butto17, Butto18
    };

            // Выполняем клики по первой группе кнопок в отдельном потоке
            await Task.Run(async () =>
            {
                foreach (Button button in buttons1)
                {
                    Application.Current.Dispatcher.Invoke(() => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent)));
                    await Task.Delay(100);
                }
            });

            // Выполняем клики по второй группе кнопок в отдельном потоке
            await Task.Run(async () =>
            {
                foreach (Button button in buttons2)
                {
                    Application.Current.Dispatcher.Invoke(() => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent)));
                    await Task.Delay(100);
                }
            });

            // Закрываем GifWindow после выполнения операций
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    gifWindow.Close();
                });
            });

            // Изменяем фон после выполнения операций
            this.Bord19.Background = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 108, 203, 95));
        }

        private async void ButtonActiv(object sender, RoutedEventArgs e)
        {
            this.progressBar.Visibility = Visibility.Visible;
            this.progressBar.IsIndeterminate = true;
            await Task.Run((Action)(() =>
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = "irm https://massgrave.dev/get | iex",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                using (Process process = new Process()
                {
                    StartInfo = processStartInfo
                })
                {
                    process.Start();
                    process.WaitForExit();
                }
            }));
            this.progressBar.Visibility = Visibility.Collapsed;
        }

        private void ButtonActiv2(object sender, RoutedEventArgs e)
        {
            string fileName = "https://www.cybermania.ws/apps/genp/";
            try
            {
                Process.Start(new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                int num = (int)System.Windows.MessageBox.Show("Не удалось открыть ссылку: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void ButtonActiv3(object sender, RoutedEventArgs e)
        {
            string fileName = "https://gist.github.com/PurpleVibe32/1e9b30754ff18d69ad48155ed29d83de";
            try
            {
                Process.Start(new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                int num = (int)System.Windows.MessageBox.Show("Не удалось открыть ссылку: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }
    }
}
