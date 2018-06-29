using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer power = new DispatcherTimer();
        int value = 10;

        public MainPage()
        {
            InitializeComponent();
            power.Interval = TimeSpan.FromSeconds(1);
            power.Tick += interval_Tick;
            power.Start();
        }

        void interval_Tick(object sender, object e)
        {
            RadialGaugeControl.Value += value;

            if (RadialGaugeControl.Value == RadialGaugeControl.Maximum)
            {
                power.Stop();
            }
        }
    }
}
