using SQLite.Net.Attributes;
using System;


namespace SmartSchoolSystem.Model
{
    public class Korisnik
    {
       [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String DatumRodenja { get; set; }
        public String MjestoRodenja { get; set; }
        public String Jmbg { get; set; }
        public String Drzavljanstvo {get;set;}
        public String Spol { get; set; }
        public String Email { get; set; }
        public String KontaktTel { get; set; }
        public String Username { get; set; }
        public String PassHash { get; set; }
        public String VrstaKorisnika { get; set; }

        public Korisnik() { }
        public Korisnik(String ime,String prezime,String mjestoRodenja,String jmbg,String drzavljanstvo,String email,String kontaktTel,String username,String pass,String vrstaKorisnika)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.MjestoRodenja = mjestoRodenja;
            this.Jmbg = jmbg;
            this.Drzavljanstvo = drzavljanstvo;
            this.Email = email;
            this.KontaktTel = kontaktTel;
            this.Username = username;
            this.PassHash = pass;
            this.VrstaKorisnika = vrstaKorisnika;
        }

    }
}
