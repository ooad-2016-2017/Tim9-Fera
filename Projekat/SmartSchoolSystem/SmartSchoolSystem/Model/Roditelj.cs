using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Roditelj:Korisnik
    {
        public List<Ucenik> djecaRod=new List<Ucenik>();

        public Roditelj(String ime, String Prezime, String mjestoRodenja, String jmbg, String drzavljanstvo, String email, String kontaktTel, String username, String pass,String vrstaKorisnika)
            :base(ime, Prezime,mjestoRodenja,jmbg,drzavljanstvo,email,kontaktTel,username,pass,vrstaKorisnika)
        {

        }
    }

}
