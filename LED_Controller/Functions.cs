using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media;
using WindowsBluetooth;

namespace LED_Controller
{
    class Functions : MainPage
    {
        public static Windows.UI.Color ApplyColor()
        {
            GlobalVar.colorRGBApplied[0] = GlobalVar.colorRGBPreview[0];
            GlobalVar.colorRGBApplied[1] = GlobalVar.colorRGBPreview[1];
            GlobalVar.colorRGBApplied[2] = GlobalVar.colorRGBPreview[2];
            Windows.UI.Color color = new Windows.UI.Color();
            color = Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBApplied[0], GlobalVar.colorRGBApplied[1], GlobalVar.colorRGBApplied[2]);
            return color;
        }

        public static async void OpenSerialAsync(string colorValue)
        {
            var selector = SerialDevice.GetDeviceSelector("COM5");
            var devices = await DeviceInformation.FindAllAsync(selector);
            if (devices.Any())
            {
                var deviceInfo = devices.First().Id;
                SerialDevice serialDevice = await SerialDevice.FromIdAsync(deviceInfo);
                if (serialDevice != null)
                {
                    serialDevice.BaudRate = 9600;
                    serialDevice.DataBits = 8;
                    serialDevice.StopBits = SerialStopBitCount.One;
                    serialDevice.Parity = SerialParity.None;
                    serialDevice.Handshake = SerialHandshake.None;

                    DataWriter dataWriter = new DataWriter(serialDevice.OutputStream);
                    dataWriter.WriteString(colorValue + "\n");
                    await dataWriter.StoreAsync();
                    dataWriter.DetachStream();
                    serialDevice.Dispose();
                }
            }
            else
            {
                MessageDialog popup = new MessageDialog("Sorry, no device found.");
                await popup.ShowAsync();
            }
        }
    }
}
