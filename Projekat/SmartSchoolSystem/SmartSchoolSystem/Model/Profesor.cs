using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Profesor:Korisnik
    {
        public Predmet PredmetProf { get; set; } = new Predmet();
        public DateTime DatumZapProf { get; set; }
        public Boolean JeLiRazrednik { get; set; }
        
        public Profesor(String ime,String Prezime,String mjestoRodenja,String jmbg,String drzavljanstvo,String email,String kontaktTel,String username,String pass,String vrstaKorisnika)
            :base(ime, Prezime,mjestoRodenja,jmbg,drzavljanstvo,email,kontaktTel,username,pass,vrstaKorisnika)
        {

        }
    }
}
