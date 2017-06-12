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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartSchoolSystem.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdministratorForm : Page
    {
        DataAccess.SmartSchoolDataSource s = new DataAccess.SmartSchoolDataSource();
        public AdministratorForm()
        {
            this.InitializeComponent();
        }

        private void b_Prof_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.KorisnickiRacunProfForm));
        }

        private void b_Rod_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.KorisnickiRacunRodForm));
        }

        private void b_Ucenik_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.RegistracijaUcenikaForm));
        }

        private void b_odjava_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Login));
        }

        private async void b_noviPredmet_Click(object sender, RoutedEventArgs e)
        {
            String nazivPredmeta = tb_nazivPredmeta.Text;
            List<Model.Predmet> subjects = s.getAllSubjects();
            using (var connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), s.getDatabaPath()))
            {
                if(!s.DoesItExists(tb_nazivPredmeta.Text))
                {
                    connection.Execute("INSERT INTO Predmeti(Naziv)"
                         + "VALUES('" + nazivPredmeta + "')");
                }
                else
                {
                   await new MessageDialog("Subject already exists").ShowAsync();
                }
               
            }
        }
    }
}
