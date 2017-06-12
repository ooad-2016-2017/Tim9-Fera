using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;

namespace SmartSchoolSystem.Model
{
    public class Predmet
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public String Naziv { get; set; }
        public List<Ocjena> ocjene { get; set; } = new List<Ocjena>();

    }
}
