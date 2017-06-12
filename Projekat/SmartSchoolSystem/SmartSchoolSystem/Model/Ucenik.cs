using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;

namespace SmartSchoolSystem.Model
{
    public class Ucenik
    {
        [PrimaryKey,AutoIncrement]
        public String Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }
        public String MjestoRodenja { get; set; }
        public String Jmbg { get; set; }
        public String Spol { get; set; }
        public String ImeRod { get; set; }
        public String PrezimeRod { get; set; }
        public String ZanimanjeRod { get; set; }
        public String Razred { get; set; }
        public List<Predmet> predmeti { get; set; } = new List<Predmet>();

        public override string ToString()
        {
            return Razred.ToString();
        }

    }
}
