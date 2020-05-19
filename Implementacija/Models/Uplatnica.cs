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
        private int ID { get; set; } 
        private string nazivTretmana { get; set; }
        private RegistrovaniKorisnik klijent { get; set; }
        private int brojRacuna { get; set; }
        private double cijenaTretmana { get; set; }
        private TipPlacanja nacinPlacanja { get; set; }
    }
}
