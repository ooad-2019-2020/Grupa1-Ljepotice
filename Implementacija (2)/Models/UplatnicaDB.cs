using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class UplatnicaDB
    {
        public int ID { get; set; }
        [Display(Name = "Ime klijenta")]
        public string klijent { get; set; }
        [Display(Name = "Naziv tretmana")]
        public string nazivTretmana { get; set; }
        [Display(Name = "Broj racuna")]
        public int brojRacuna { get; set; }
        [Display(Name = "Cijena tretmana")]
        public double cijenaTretmana { get; set; }
        [Display(Name = "Nacin plaćanja")]
        public TipPlacanja nacinPlacanja { get; set; }
    }
}
