using SQLite.Net;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace SmartSchoolSystem.View
{
    public sealed partial class Login : Page
    {
        DataAccess.SmartSchoolDataSource s = new DataAccess.SmartSchoolDataSource();
        public Login()
        {
            this.InitializeComponent();
            s.konektuj();

        }


        private  void logInButton_Click(object sender, RoutedEventArgs e)
        {

            Model.Korisnik user = s.findUser(username.Text, login.Password);
            if (user != null && user.VrstaKorisnika == "Administrator")
            {
                this.Frame.Navigate(typeof(View.AdministratorForm));
            }
            else if (user != null && user.VrstaKorisnika == "Roditelj")
            {
                this.Frame.Navigate(typeof(View.RoditeljForm));
            }
            else if (user != null && user.VrstaKorisnika == "Profesor")
            {
                this.Frame.Navigate(typeof(View.ProfesorForm));
            }

            MessageDialog msg= new MessageDialog("Ne postoji korisnik pod tim username/paswordom!");
            msg.ShowAsync();
               
            
            /*MobileServiceCollection<Model.Roditelji,Model.Roditelji> items;
            items = await uceniciObjTabel.Where(x => x.pass == login.Password && x.username == username.Text).ToCollectionAsync();
            Model.Roditelji m = new Model.Roditelji();
            m = await uceniciObjTabel
                .Where(x =>  x.pass == login.Password && x.username==username.Text)
                .Select(x => x.imeRod, x.prezimeRod, x.mjestoRodenjaRod, x.jmbgRod, x.drzavljanstvoRod, x.emailRod, x.telRod)
                .ToCollectionAsync();*/



            //select in entitity framework
            /*IEnumerable<List<String>> roditelji = await uceniciObjTabel
                .Where(x => x.pass == login.Password)
                .Select(x => new List<String>{ x.jmbgRod, x.pass }).ToEnumerableAsync();

            String pass = "sda";//paswords.FirstOrDefault();*/

            /*IEnumerable<String> paswords = await uceniciObjTabel
                .Where(x => x.pass == login.Password)
                .Select(x => x.pass).ToEnumerableAsync();

            String pass =paswords.FirstOrDefault();*/

            /*IEnumerable<Model.Roditelji> r = await uceniciObjTabel
                .Where(x => x.pass == login.Password && x.username == username.Text)
                .Select(x => new Model.Roditelji
                {
                    imeRod = x.imeRod,
                    prezimeRod = x.prezimeRod,
                    mjestoRodenjaRod = x.mjestoRodenjaRod,
                    jmbgRod = x.jmbgRod,
                    drzavljanstvoRod = x.drzavljanstvoRod,
                    emailRod = x.emailRod,
                    telRod = x.telRod
                }).ToEnumerableAsync();*/

            /*IEnumerable<Model.Roditelji> r = await uceniciObjTabel
                .Where(x => x.pass == login.Password && x.username == username.Text)
                .Select(x => new Model.Roditelji
                {
                    imeRod = x.imeRod,
                    prezimeRod = x.prezimeRod,
                    mjestoRodenjaRod = x.mjestoRodenjaRod,
                    jmbgRod = x.jmbgRod,
                    drzavljanstvoRod = x.drzavljanstvoRod,
                    emailRod = x.emailRod,
                    telRod = x.telRod
                }).ToEnumerableAsync();*/




            /*if ()
            {

                this.Frame.Navigate(typeof(View.RoditeljForm));
            }

            else
            {
                var dialog = new MessageDialog("Neuspjesna prijava");
                await dialog.ShowAsync();
            }*/



        }




    }

        
}
            



