using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
        DataAccess.SmartSchoolDataSource s = new DataAccess.SmartSchoolDataSource();
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

        private async void b_potvrdi_Click(object sender, RoutedEventArgs e)
        {
            String ime = tb_imeProf.Text;
            String prezime = tb_prezimeProf.Text;
            String mjestoRodenja = tb_mjestoRodenjaProf.Text;
            String jmbg = tb_jmbgProf.Text;
            String drzavljanstvo = tb_drzavljanstvoProf.Text;
            String spol = String.Empty;
            if (cb_spolMusko.IsChecked == true)
                spol = "Musko";
            else
                spol = "Zensko";
            String JeLiRarednik=String.Empty;
            if (cb_statusRazDA.IsChecked == true)
                JeLiRarednik = "DA";
            else
                JeLiRarednik = "NE";
            String email = tb_emailProf.Text;
            String username = tb_imeProf.Text.Substring(0, 1) + tb_prezimeProf.Text;
            String pass = s.GenerateRandomData();
            String vrstaKorisnika = "Profesor";
            using (var connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), s.getDatabaPath()))
            {
                connection.Execute("INSERT INTO Korisnici(Ime,Prezime,MjestoRodenja,Jmbg,Drzavljanstvo,Razrednik,Spol,Email,Username,PassHash,VrstaKorisnika)"
                         + "VALUES('" + ime + "','" + prezime + "','" + mjestoRodenja + "','" + jmbg + "','" + drzavljanstvo + "','" + JeLiRarednik + "','" + spol + "','" + email + "','" + username + "','" + pass + "','" + vrstaKorisnika + "')");
            }
            ClearFields();
            await new MessageDialog("You have added successfully a new user").ShowAsync();
        }

        public void ClearFields()
        {
            tb_imeProf.Text = "";
            tb_prezimeProf.Text = "";
            tb_mjestoRodenjaProf.Text = "";
            tb_jmbgProf.Text = "";
            tb_drzavljanstvoProf.Text = "";
            cb_spolMusko.IsChecked = false;
            cb_spolZensko.IsChecked = false;
            tb_emailProf.Text = "";
            cb_statusRazDA.IsChecked = false;
            cb_statusRazNE.IsChecked = false;

        }

        private void b_odustani_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.AdministratorForm));
        }
    }
}
