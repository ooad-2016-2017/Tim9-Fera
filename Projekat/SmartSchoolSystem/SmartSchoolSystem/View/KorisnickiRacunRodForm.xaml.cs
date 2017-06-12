using SQLite.Net;
using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SmartSchoolSystem.View
{
    public sealed partial class KorisnickiRacunRodForm : Page
    {
        DataAccess.SmartSchoolDataSource s = new DataAccess.SmartSchoolDataSource();
        //public List<Model.Ucenik> ucenici = new List<Model.Ucenik>();
        public KorisnickiRacunRodForm()
        {
            this.InitializeComponent();
        }


        private async void b_potvrdi_Click(object sender, RoutedEventArgs e)
        {
            String ime = tb_imeRod.Text;
            String prezime = tb_prezimeRod.Text;
            String mjestoRodenja = tb_mjestoRodenjaRod.Text;
            String jmbg = tb_jmbgRod.Text;
            String drzavljanstvo = tb_drzavljanstvoRod.Text;
            String email = tb_emailRod.Text;
            String kontaktTel = tb_telRod.Text;
            String username = tb_imeRod.Text.Substring(0, 1) + tb_prezimeRod.Text;
            String pass = s.GenerateRandomData();
            String vrstaKorisnika = "Roditelj";
            

            using (var connection= new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), s.getDatabaPath()))
            {
                connection.Execute("INSERT INTO Korisnici(Ime,Prezime,MjestoRodenja,Jmbg,Drzavljanstvo,Email,KontaktTel,Username,PassHash,VrstaKorisnika)"
                         + "VALUES('" + ime + "','" + prezime + "','" + mjestoRodenja + "','" + jmbg + "','" + drzavljanstvo + "','" + email + "','" + kontaktTel + "','" + username + "','" + pass + "','" + vrstaKorisnika + "')");
            }
            delete();
           
            await new MessageDialog("You have added successfully a new user").ShowAsync();
        }


        

        private void b_odustani_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.AdministratorForm));
        }

        public void delete()
        {
            tb_imeRod.Text = "";
            tb_prezimeRod.Text = "";
            dtp_datumRodenjaRod.Date = DateTime.Now;
            tb_mjestoRodenjaRod.Text= "";
            tb_jmbgRod.Text= "";
            tb_drzavljanstvoRod.Text= "";
            tb_emailRod.Text= "";
            tb_telRod.Text= "";
        }

        private void lb_djecaRod_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in s.getAllStudents())
            {
                Grid sp = new Grid();
                sp.Width = 100;

                TextBlock ime = new TextBlock();
                ime.Text = item.Ime;
                ime.HorizontalAlignment = HorizontalAlignment.Left;

                TextBlock prezime = new TextBlock();
                prezime.Text = item.Prezime;
                prezime.HorizontalAlignment = HorizontalAlignment.Right;

                sp.Children.Add(ime);
                sp.Children.Add(prezime);

                lb_djecaRod.Items.Add(sp);

            }
        }

        private void tb_imeRod_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*if (DataValidation.FormDataValidator.validacijaKorisnika(tb_imeRod.Text, tb_prezimeRod.Text))
            {
                b_potvrdi.IsEnabled = true;
            }
            else
            {
                b_potvrdi.IsEnabled = false;
            }
            */
        }
    }
}
