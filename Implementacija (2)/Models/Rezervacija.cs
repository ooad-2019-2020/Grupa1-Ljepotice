using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Implementacija.Models
{
    public class Rezervacija
    {
        public int ID { get; set; }
        public RegistrovaniKorisnik korisnik { get; set; }
        public DateTime vrijemeRezervacije { get; set; }
        public Tretman odabraniTretman { get; set; }

        //private Image fotografijaZaTretman { get; set; }
        public TipPlacanja tipPlacanja { get; set; }
}
}
