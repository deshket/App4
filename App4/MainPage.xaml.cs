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

namespace App4
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

        private void HplToDoList_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Todolist));
        }

        private void HplBtnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AuthLogin));
        }

        //using Amazon.IdentityManagement;
        //using Amazon.IdentityManagement.Model;

        public static string AWS_Name { get; set; }

        public static void GetAWS()
        {

            var Var2 = new Amazon.Auth.AccessControlPolicy.Policy();
            AWS_Name = Convert.ToString(Var2.Version);

        }


        private void BtnGetAPI_Click(object sender, RoutedEventArgs e)
        {
            GetAWS();
        }

        private void HplBtnezbooks_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ezbooks));
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GoogleAuth));
        }
    }
}
