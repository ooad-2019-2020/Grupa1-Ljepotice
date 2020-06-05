using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class RezervacijaDB
    {
       
            public int ID { get; set; }
            public KorisnikDB korisnik { get; set; }
        [Display(Name = "Datum i vrijeme termina ")]
        public DateTime vrijemeRezervacije { get; set; }
        [Display(Name = "Ime i prezime ")]
        public string imeIPrezime { get; set; }

        [Display(Name = "Odabrani tretman ")]
        public string odabraniTretman { get; set; }

        //private Image fotografijaZaTretman { get; set; }

        [Display(Name = "Tip plaćanja")]
        public TipPlacanja tipPlacanja { get; set; }
        
    }
}

