using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class UplatnicaDB
    {
        public int ID { get; set; }
        public string nazivTretmana { get; set; }
        public KorisnikDB klijent { get; set; }
        public int brojRacuna { get; set; }
        public double cijenaTretmana { get; set; }
        public TipPlacanja nacinPlacanja { get; set; }
    }
}
