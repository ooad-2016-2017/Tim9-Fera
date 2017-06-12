using SQLite.Net;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;




namespace SmartSchoolSystem.View
{
    public sealed partial class RegistracijaUcenikaForm : Page
    {
        DataAccess.SmartSchoolDataSource s = new DataAccess.SmartSchoolDataSource();
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

        private void b_potvrdi_Click(object sender, RoutedEventArgs e)
        {
            String ime = tb_imeUcenika.Text;
            String prezime = tb_prezimeUcenika.Text;
            String mjestoRodenja = tb_mjestoRodenja.Text;
            String jmbg = tb_jmbg.Text;
            String spol = String.Empty;
            if (cb_spolMusko.IsChecked == true)
                spol = "Musko";
            else
                spol = "Zensko";
            String imeRod = tb_imeStaratelja.Text;
            String prezimeRod = tb_prezimeStaratelja.Text;
            String zanimanjeRod = tb_zanimanjeStaratelja.Text;
            int razred = Convert.ToInt32(txtNum.Text);
            using (var connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), s.getDatabaPath()))
            {
                connection.Execute("INSERT INTO Ucenici(Ime,Prezime,MjestoRodenja,Jmbg,Spol,ImeRod,PrezimeRod,ZanimanjeRod,Razred)"
                         + "VALUES('" + ime + "','" + prezime + "','" + mjestoRodenja + "','" + jmbg + "','" + spol + "','" + imeRod + "','" + prezimeRod + "','" + zanimanjeRod + "','" + razred + "')");
            }
            ClearFields();
        }

        private void b_odustani_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.AdministratorForm));
        }

        public void ClearFields()
        {
            tb_imeUcenika.Text = "";
            tb_prezimeUcenika.Text = "";
            tb_mjestoRodenja.Text = "";
            tb_jmbg.Text = "";
            tb_mjestoRodenja.Text = "";
            cb_spolMusko.IsChecked = false;
            cb_spolZensko.IsChecked = false;
            tb_imeStaratelja.Text = "";
            tb_prezimeStaratelja.Text = "";
            tb_zanimanjeStaratelja.Text = "";
            txtNum.Text = "1";
        }
    }
    
}
