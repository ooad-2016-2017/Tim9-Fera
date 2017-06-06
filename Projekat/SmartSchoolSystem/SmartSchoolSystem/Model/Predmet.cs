using System;
using System.Collections.Generic;

namespace SmartSchoolSystem.Model
{
    public class Predmet
    {
        public int UcenikId { get; set; }
        public String nazivPredmeta { get; set; }
        public List<Ocjena> ocjene { get; set; } = new List<Ocjena>();

    }
}
