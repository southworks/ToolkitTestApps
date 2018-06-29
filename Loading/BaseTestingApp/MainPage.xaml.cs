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
using Microsoft.Toolkit.Services.Bing;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BaseTestingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ;
        }
        private Loading loadingControl; 

        public async void startLoading(object sender, RoutedEventArgs e)
        {
            loadingControl = Grid.FindName("LoadingControl") as Loading;

            loadingControl.IsLoading = true;
            await Task.Delay(3000);
            loadingControl.IsLoading = false;
        }
    }
}
