using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartSchoolSystem.DataValidation
{
    class FormDataValidator
    {
        public static Boolean validacijaKorisnika(String ime,String prezime)
        {
            if (Regex.IsMatch(ime, "^[a-zA-Z]+$") && Regex.IsMatch(prezime, "^[a-zA-Z]+$"))
                return true;
            return false;
        }

        public static Boolean validacijaUcenika(String ime, String prezime)
        {
            if (Regex.IsMatch(ime, @"^[a-zA-Z]+$") && Regex.IsMatch(prezime, @"^[a-zA-Z]+$"))
                return true;
            return false;
        }
    }
}
