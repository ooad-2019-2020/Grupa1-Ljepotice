using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public enum TipPlacanja
    {
        Gotovina,
        Kartica
    }
    public class Uplatnica
    {
        public int ID { get; set; } 
        public string nazivTretmana { get; set; }
        private RegistrovaniKorisnik klijent { get; set; }
        public int brojRacuna { get; set; }
        public double cijenaTretmana { get; set; }
        public TipPlacanja nacinPlacanja { get; set; }
    }
}
