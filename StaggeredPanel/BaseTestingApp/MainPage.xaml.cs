using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BaseTestingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; private set; }
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainPageViewModel();
            GridView.ItemsSource = ViewModel.Photos;
        }
        
    }

    public class MainPageViewModel
    {
        public IEnumerable<PhotoItem> Photos { get; }

        public MainPageViewModel()
        {
            var availableHeight = new List<int> { 480, 320, 210 };
            var random = new Random();
            Photos = Enumerable.Range(0, 23).Select(x =>
            {
                var randIndex = random.Next(3);
                var height = availableHeight.ElementAt(randIndex);
                return new PhotoItem { Source = $"https://placeimg.com/210/{height}/nature", Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua" };
            }).ToList();
        }

    }

    public class PhotoItem
    {
        public string Source { get; set; }
        public string Title { get; set; }
    }
}
