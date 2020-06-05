using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class ZaposlenikDB
    {
        public int ID { get; set; }
        [Display(Name = "Ime")]
        public string ime { get; set; }
        [Display(Name = "Prezime")]
        public string prezime { get; set; }
        [Display(Name = "Email")]
        public string username { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Radno mjesto")]
        public string tipKozmeticara { get; set; }

    }
}
