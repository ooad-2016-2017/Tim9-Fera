﻿using System;
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
    }
}
