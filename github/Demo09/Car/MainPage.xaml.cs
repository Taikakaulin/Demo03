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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Car
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int cars = 0;
        int trucks = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            textBoxCars.Text = cars.ToString();

        }

        private void Trucks_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            textBoxTrucks.Text = trucks.ToString();
        }
    }
}
