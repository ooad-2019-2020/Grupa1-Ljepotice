using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Implementacija.Models
{
    public class Rezervacija
    {
        private int ID { get; set; }
        private RegistrovaniKorisnik korisnik { get; set; }
        private DateTime vrijemeRezervacije { get; set; }
        private Tretman odabraniTretman { get; set; }

        //private Image fotografijaZaTretman { get; set; }
        private TipPlacanja tipPlacanja { get; set; }
}
}
