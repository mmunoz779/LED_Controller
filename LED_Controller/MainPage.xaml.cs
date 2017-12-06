using System;
using System.Globalization;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using Windows.Devices.SerialCommunication;
using System.Linq;
using System.Windows;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Networking.Sockets;
using WindowsBluetooth;
using System.Threading.Tasks;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LED_Controller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    ///     

    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(HomePage));
        }

        //Hamburger menu navigation events
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            HamburgerMenu.IsPaneOpen = !HamburgerMenu.IsPaneOpen;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            if (!MainFrame.CurrentSourcePageType.Equals(typeof(HomePage))) 
                MainFrame.Navigate(typeof(HomePage));
            Debug.WriteLine("Home Button Clicked");
        }

        private void PresetButton_Click(object sender, RoutedEventArgs e)
        {
            if (!MainFrame.CurrentSourcePageType.Equals(typeof(PresetPage)))
                MainFrame.Navigate(typeof(PresetPage));
            Debug.WriteLine("Preset Button Clicked");
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!MainFrame.CurrentSourcePageType.Equals(typeof(SettingsPage)))
                MainFrame.Navigate(typeof(SettingsPage));
            Debug.WriteLine("Settings Button Clicked");
        }

        /*
        private void StartScan()
        {
            tbOutput.Text = "Scan Starting....";
            BluetoothClient client = new BluetoothClient();
            BluetoothDeviceInfo[] devices = client.DiscoverDevicesInRange();
            tbOutput.Text = "Scan Complete";
            foreach(BluetoothDeviceInfo d in devices)
            {
                bluetoothDevices.Add(d.DeviceName);
        }
        UpdateDeviceList();
        }

        private void UpdateDeviceList()
        {
        Func<int> del = delegate ()
        {
        listBox1.DataContext = bluetoothDevices;
        return 0;
        };
        del();
        }
        */
    }

}
