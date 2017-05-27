using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Roditelji
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String imeRod { get; set; }
        public String prezimeRod { get; set; }
        public DateTime datumRodenjaRod { get; set; }
        public String mjestoRodenjaRod { get; set; }
        public String jmbgRod { get; set; }
        public String drzavljanstvoRod { get; set; }
        public List<Ucenici> djecaRod;
        public String emailRod { get; set; }
        public String telRod { get; set; }
        public byte[] slikaRod { get; set; }
        public String username { get; set; }
        public String pass { get; set; }

    }

}
