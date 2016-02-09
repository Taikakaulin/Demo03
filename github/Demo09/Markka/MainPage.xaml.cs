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

namespace Markka
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

        
        private string Calc(string raha, bool onkoeuro)
        {
            double vastaus;
            double k;
            if(double.TryParse(raha, out k))
            {
                if (onkoeuro)
                {
                    vastaus = k * 5.94573;

                }
                else
                {
                    vastaus = k * 0.168187;

                }
                return vastaus.ToString("0.00");

            }
            return " ";
            
          

        }

       

        private void textBox1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            textBox.Text = Calc(textBox1.Text, false);
        }

        private void textBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            textBox1.Text = Calc(textBox.Text, true);
        }
    }
}
