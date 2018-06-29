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

namespace BaseTestingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Person> people = new List<Person>();

        public MainPage()
        {
            this.InitializeComponent();

            for(int i = 0; i < 25; i++)
            {
                people.Add(new Person() { ID = i });
            }

            AdaptiveGridViewControl.SelectionMode = ListViewSelectionMode.Single;
            AdaptiveGridViewControl.ItemsSource = people;
            AdaptiveGridViewControl.ItemClick += ItemClick;
        }

        private void ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Clicked {e.ClickedItem}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

        public override string ToString()
        {
            return $"Person #{ID}";
        }
    }
}
