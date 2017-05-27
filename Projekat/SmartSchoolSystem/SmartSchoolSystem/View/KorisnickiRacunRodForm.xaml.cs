using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;
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
    public sealed partial class KorisnickiRacunRodForm : Page
    {
        public KorisnickiRacunRodForm()
        {
            this.InitializeComponent();
        }

       
      

        private void b_potvrdi_Click(object sender, RoutedEventArgs e)
        {
            IMobileServiceTable<Model.Roditelji> roditeljiObjTabel = App.context.GetTable<Model.Roditelji>();
            try
            {
                Model.Roditelji obj = new Model.Roditelji();
                obj.imeRod = tb_imeRod.Text;
                obj.prezimeRod = tb_prezimeRod.Text;
                obj.mjestoRodenjaRod = tb_mjestoRodenjaRod.Text;
                obj.jmbgRod = tb_jmbgRod.Text;
                obj.drzavljanstvoRod = tb_drzavljanstvoRod.Text;
                obj.emailRod = tb_emailRod.Text;
                obj.telRod = tb_telRod.Text;
                obj.username = tb_imeRod.Text + tb_prezimeRod.Text;
                String pass = String.Empty;
                pass = GenerateRandomData();
                obj.pass = pass;
                roditeljiObjTabel.InsertAsync(obj);
                MessageDialog ms = new MessageDialog("Uspjesno je kreiran nalog pod username:"+obj.username+" i pass:"+obj.pass);
                ms.ShowAsync();
            }
            catch(Exception ex)
            {
                MessageDialog ms = new MessageDialog("Error :" + ex.Message);
            }
        }

        public string GenerateRandomData()
        {
            // Define the length, in bytes, of the buffer.
            uint length = 32;

            // Generate random data and copy it to a buffer.
            IBuffer buffer = CryptographicBuffer.GenerateRandom(length);

            // Encode the buffer to a hexadecimal string (for display).
            string randomHex = CryptographicBuffer.EncodeToHexString(buffer);

            return randomHex;
        }
    }
}
