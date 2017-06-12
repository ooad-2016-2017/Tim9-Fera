using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Administrator:Korisnik
    {
        public Administrator(String ime, String Prezime, String mjestoRodenja, String jmbg, String drzavljanstvo, String email, String kontaktTel, String username, String pass,String vrstaKorisnika)
            :base(ime, Prezime,mjestoRodenja,jmbg,drzavljanstvo,email,kontaktTel,username,pass,vrstaKorisnika)
        {

        }
    }
}
