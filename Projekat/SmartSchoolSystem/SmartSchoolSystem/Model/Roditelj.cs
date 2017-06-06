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
            

    }

}
