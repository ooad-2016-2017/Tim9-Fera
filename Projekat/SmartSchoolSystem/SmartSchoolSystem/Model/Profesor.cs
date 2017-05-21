using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolSystem.Model
{
    public class Profesor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfesorId { get; set; }
        public String imeProf { get; set; }
        public String prezimeProf { get; set; }
        public DateTime datumRodenjaProf { get; set; }
        public String mjestoRodenjaProf { get; set; }
        public String jmbgProf { get; set; }
        public String drzavljanstvoProf { get; set; }
        public Predmet predmetProf { get; set; }
        public DateTime datumZapProf { get; set; }
        public Boolean jeLiRazrednik { get; set; }
        public byte[] slikaProf { get; set; }
    }
}
