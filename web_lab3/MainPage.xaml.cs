using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using web_lab3.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace web_lab3
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

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ((sender as ListView).SelectedItem as DTO);
            //this.Frame.Navigate(typeof(VisitRoom), item.thisRoom.Id);
        }

        // Create a Room button click, Navigates to CreateRoom.xaml
        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateRoom), null);
        }

        // Select a Room button click, Makes listView visable.
        private void selectRoomButton_Click(object sender, RoutedEventArgs e)
        {
            listView.Visibility = Visibility.Visible;
        }
    }
}
