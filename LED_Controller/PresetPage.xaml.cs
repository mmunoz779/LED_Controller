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
    public sealed partial class PresetPage : Page
    {
        public PresetPage()
        {
            this.InitializeComponent();
            HomePage.changePreview = false;
            colorIndicatorAppliedPreset.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.colorRGBApplied[0], GlobalVar.colorRGBApplied[1], GlobalVar.colorRGBApplied[2]));
            PresetOneColorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.presetOne[0], GlobalVar.presetOne[1], GlobalVar.presetOne[2]));
            PresetTwoColorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.presetTwo[0], GlobalVar.presetTwo[1], GlobalVar.presetTwo[2]));
        }

        private void PresetOne_Click(object sender, RoutedEventArgs e)
        {
            GlobalVar.colorRGBApplied[0] = GlobalVar.presetOne[0];
            GlobalVar.colorRGBApplied[1] = GlobalVar.presetOne[1];
            GlobalVar.colorRGBApplied[2] = GlobalVar.presetOne[2];
            colorIndicatorAppliedPreset.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.presetOne[0], GlobalVar.presetOne[1], GlobalVar.presetOne[2]));
            string colorValueString = GlobalVar.presetOne[0] + "," + GlobalVar.presetOne[1] + "," + GlobalVar.presetOne[2];
            Functions.OpenSerialAsync(colorValueString);
        }

        private void SavePresetOne_Click(object sender, RoutedEventArgs e)
        {
            GlobalVar.presetOne[0] = GlobalVar.colorRGBApplied[0];
            GlobalVar.presetOne[1] = GlobalVar.colorRGBApplied[1];
            GlobalVar.presetOne[2] = GlobalVar.colorRGBApplied[2];
            PresetOneColorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.presetOne[0], GlobalVar.presetOne[1], GlobalVar.presetOne[2]));
        }


        private void PresetTwo_Click(object sender, RoutedEventArgs e)
        {
            GlobalVar.colorRGBApplied[0] = GlobalVar.presetTwo[0];
            GlobalVar.colorRGBApplied[1] = GlobalVar.presetTwo[1];
            GlobalVar.colorRGBApplied[2] = GlobalVar.presetTwo[2];
            colorIndicatorAppliedPreset.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.presetTwo[0], GlobalVar.presetTwo[1], GlobalVar.presetTwo[2]));
            string colorValueString = GlobalVar.presetTwo[0] + "," + GlobalVar.presetTwo[1] + "," + GlobalVar.presetTwo[2];
            Functions.OpenSerialAsync(colorValueString);
        }

        private void SavePresetTwo_Click(object sender, RoutedEventArgs e)
        {
            GlobalVar.presetTwo[0] = GlobalVar.colorRGBApplied[0];
            GlobalVar.presetTwo[1] = GlobalVar.colorRGBApplied[1];
            GlobalVar.presetTwo[2] = GlobalVar.colorRGBApplied[2];
            PresetTwoColorPreview.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, GlobalVar.presetTwo[0], GlobalVar.presetTwo[1], GlobalVar.presetTwo[2]));
        }

    }
}
