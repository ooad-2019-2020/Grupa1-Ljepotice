using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class FormaZaTestDB
    {
        public int ID { get; set; }
        [Display(Name = "Tip kože")]
        public TipKoze tipKoze { get; set; }
        [Display(Name = "Vrsta testa")]
        public string odabranaZona { get; set; }
        [Display(Name = "Rezultat testa")]
        public string rezultat { get; set; }
        [Display(Name = "Ime klijenta")]
        public string klijent { get; set; }

    }
}
