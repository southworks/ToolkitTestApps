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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BaseTestingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {
        public List<string> Items;
        public MainPage()
        {
            this.InitializeComponent();
            Items = new List<string>
            {
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "10. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "11. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat.",
                "12. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris efficitur eros urna. Sed id magna nec est pretium auctor. Nunc ipsum leo, aliquam sit amet varius nec, posuere nec lorem. Integer ultrices, nisi sed tempor scelerisque, purus ligula mattis purus, nec rhoncus ante eros eu felis. Morbi nunc magna, dictum in congue sollicitudin, vehicula sed erat. Donec volutpat, dolor id ornare commodo, lorem leo volutpat nulla, ac viverra sem lacus sit amet tellus. Suspendisse auctor lobortis velit, non tempus mauris suscipit vitae. Fusce at vestibulum erat."
            };
        }

        
    }

}
