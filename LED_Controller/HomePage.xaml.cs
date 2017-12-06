using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LED_Controller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public static bool changePreview = false;
        public HomePage()
        {
            this.InitializeComponent();
            colorIndicatorAppliedHome.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255,GlobalVar.colorRGBApplied[0],GlobalVar.colorRGBApplied[1],GlobalVar.colorRGBApplied[2]));
            colorIndicatorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBPreview[0], GlobalVar.colorRGBPreview[1], GlobalVar.colorRGBPreview[2]));
            redSlider.Value = GlobalVar.colorRGBPreview[0];
            greenSlider.Value = GlobalVar.colorRGBPreview[1];
            blueSlider.Value = GlobalVar.colorRGBPreview[2];
            changePreview = true;
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            colorIndicatorAppliedHome.Background = new SolidColorBrush(Functions.ApplyColor());
            string colorValueString = GlobalVar.colorRGBApplied[0] + "," + GlobalVar.colorRGBApplied[1] + "," + GlobalVar.colorRGBApplied[2];
            Functions.OpenSerialAsync(colorValueString);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
             redSlider.Value = GlobalVar.colorRGBApplied[0];
             greenSlider.Value = GlobalVar.colorRGBApplied[1];
             blueSlider.Value = GlobalVar.colorRGBApplied[2];
             colorIndicatorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBApplied[0], GlobalVar.colorRGBApplied[1], GlobalVar.colorRGBApplied[2]));
        }

        private void RedSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (changePreview == true)
                GlobalVar.colorRGBPreview[0] = Convert.ToByte(redSlider.Value);
            colorIndicatorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBPreview[0], GlobalVar.colorRGBPreview[1], GlobalVar.colorRGBPreview[2]));
        }

        private void GreenSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (changePreview == true)
                GlobalVar.colorRGBPreview[1] = Convert.ToByte(greenSlider.Value);
            colorIndicatorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBPreview[0], GlobalVar.colorRGBPreview[1], GlobalVar.colorRGBPreview[2]));
        }
        private void BlueSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (changePreview == true)
                GlobalVar.colorRGBPreview[2] = Convert.ToByte(blueSlider.Value);
            colorIndicatorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBPreview[0], GlobalVar.colorRGBPreview[1], GlobalVar.colorRGBPreview[2]));
        }
    }
}
