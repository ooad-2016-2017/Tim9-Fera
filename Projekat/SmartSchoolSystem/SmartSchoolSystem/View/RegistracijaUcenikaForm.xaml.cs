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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartSchoolSystem.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaUcenikaForm : Page
    {
        private int _numValue = 1;
        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }

        public RegistracijaUcenikaForm()
        {
            this.InitializeComponent();
            txtNum.Text = _numValue.ToString();
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

     

        private void txtNum_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            if(txtNum==null)
            {
                return;
            }
            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }

        private void cmdup_Click(object sender, RoutedEventArgs e)
        {
            if (NumValue == 9)
                NumValue = 1;
            else
                NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
                if (NumValue == 1)
                    NumValue = 9;
                else
                    NumValue--;
        }
    }
}
