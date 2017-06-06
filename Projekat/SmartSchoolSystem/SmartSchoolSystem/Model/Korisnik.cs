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

    }
}
