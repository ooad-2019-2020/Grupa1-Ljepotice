using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class FormaZaTretmanDB
    {
        public int ID { get; set; }
        [Display(Name = "Ime klijenta")]
        public string klijent { get; set; }
        [Display(Name = "Naziv tretmana")]
        public string tretman { get; set; }
        [Display(Name = "Odabrana zona")]
        public string odabranaZona { get; set; }
        // private Image slikaRezultata { get; set; }
        [Display(Name = "Rezultat tretmana")]
        public string rezultatTretmana { get; set; }
        [Display(Name = "Tehnika rada")]
        public string tehnikaRada { get; set; }
        [Display(Name = "Dodatne napomene")]
        public string dodatneNapomene { get; set; }
        

    }
}
