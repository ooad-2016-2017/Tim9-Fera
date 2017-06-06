using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;




namespace SmartSchoolSystem.View
{
    public sealed partial class RegistracijaUcenikaForm : Page
    {
        public String id = "1";
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
            if (txtNum == null)
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

        private void b_potvrdi_Tapped(object sender, TappedRoutedEventArgs e)
        {

            

        }
        
    }
    
}
