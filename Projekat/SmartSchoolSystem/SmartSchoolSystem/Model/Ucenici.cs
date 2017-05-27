using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Ucenici
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public DateTime datumRod { get; set; }
        public String mjestoRodenja { get; set; }
        public String jmbg { get; set; }
        public String spol { get; set; }
        public String imeRod { get; set; }
        public String prezimeRod { get; set; }
        public String zanimanjeRod { get; set; }
        public List<Predmet> predmeti { get; set; }
       
    }
}
