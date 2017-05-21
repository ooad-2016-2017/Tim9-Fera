using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Ucenik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UcenikId { get; set; }
        public String imeUcenika { get; set; }
        public String prezimeUcenika { get; set; }
        public DateTime datumRodUcenika { get; set; }
        public String mjestoRodenjaUcenika { get; set; }
        public String jmbgUcenika { get; set; }
        public enum Spol { Musko,Zensko};
        public String imeRod { get; set; }
        public String prezimeRod { get; set; }
        public String zanimanjeRod { get; set; }
        public List<Predmet> predmeti { get; set; }
    }
}
