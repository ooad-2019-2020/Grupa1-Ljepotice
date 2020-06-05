using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class KorisnikDB
    {
        public int ID { get; set; }
        [Display(Name = "Ime")]
        public string ime { get; set; }
        [Display(Name = "Prezime")]
        public string prezime { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Broj telefona")]
        public string password { get; set; }
        public List<Tretman> listaOdradjenihTretmana { get; set; }
    }
}
