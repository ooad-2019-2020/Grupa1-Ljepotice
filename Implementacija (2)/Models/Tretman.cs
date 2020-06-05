using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public enum KategorijaTretmana
    {
        Manikir,
        Sminkanje,
        Depilacija
    }
    public class Tretman
    {
        public int ID { get; set; }
        [Display(Name = "Naziv tretmana")]
        public string naziv { get; set; }
        [Display(Name = "Cijena tretmana")]
        public float cijena { get; set; }
        [Display(Name = "Kategorija tretmana")]
        public KategorijaTretmana kategorijaTretmana { get; set; }
        [Display(Name = "Opis tretmana")]
        public string opisTretmana { get; set; }

    }
}
