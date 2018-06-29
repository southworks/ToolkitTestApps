using Microsoft.Toolkit.Services.MicrosoftGraph;
using Microsoft.Toolkit.Uwp.UI.Controls.Graph;
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


        public MainPage()
        {
            this.InitializeComponent();

        }

        private void ClientId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ClientId.Text.Length > 0)
            {
                MicrosoftGraphService.Instance.AuthenticationModel = MicrosoftGraphEnums.AuthenticationModel.V2;
                string[] permissions = new string[] { "User.Read", "User.ReadBasic.All", "People.Read", "Files.ReadWrite.All"};
                if (!MicrosoftGraphService.Instance.Initialize(ClientId.Text, MicrosoftGraphEnums.ServicesToInitialize.UserProfile,permissions))
                {
                    System.Diagnostics.Debug.WriteLine($"Initialization failed, client id: {ClientId.Text}");
                }
            }
        }

        private void AADLogin_SignInCompleted(object sender, Microsoft.Toolkit.Uwp.UI.Controls.Graph.SignInEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Completed");
            SharePointFileList1.DriveUrl = "https://spiketestinc.sharepoint.com/sites/Demo/cdn";
           
            //ProfileCard1.UserId = ClientId.Text;
            template.Visibility = Windows.UI.Xaml.Visibility.Visible;
            //this.getUserInfo();

        }

        private void AADLogin_SignInFailed(object sender, Microsoft.Toolkit.Uwp.UI.Controls.Graph.SignInFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Failed: {e.Exception}");
        }

        private async System.Threading.Tasks.Task getUserInfo()
        {

            // You can also select any fields you want in the response
            MicrosoftGraphUserFields[] selectedFields =
            {
                
                MicrosoftGraphUserFields.DisplayName
              
            };

            var user = await MicrosoftGraphService.Instance.User.GetProfileAsync(selectedFields);
            //ProfileCard1.LargeProfileTitleDefaultText = "WELCOME " + user.DisplayName;
           
        }

    }


}


