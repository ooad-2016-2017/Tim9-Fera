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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartSchoolSystem.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KorisnickiRacunProfForm : Page
    {
        public KorisnickiRacunProfForm()
        {
            this.InitializeComponent();
        }

        private void cb_spolMusko_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (cb_spolMusko.IsChecked == true)
                cb_spolZensko.IsChecked = false;
        }

        private void cb_spolZensko_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (cb_spolZensko.IsChecked == true)
                cb_spolMusko.IsChecked = false;
        }

        private void cb_statusRazDA_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (cb_statusRazDA.IsChecked == true)
                cb_statusRazNE.IsChecked = false;
        }

        private void cb_statusRazNE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (cb_statusRazNE.IsChecked == true)
                cb_statusRazDA.IsChecked = false;
        }

        private void b_potvrdi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
