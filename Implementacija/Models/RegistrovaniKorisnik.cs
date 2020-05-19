using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class RegistrovaniKorisnik:Korisnik
    {
        private string ime { get; set; }
        private string prezime { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private bool daLiJeRezervisanTermin { get; set; }
        private List<Tretman> listaOdradjenihTretmana { get; set; }

    }
}
