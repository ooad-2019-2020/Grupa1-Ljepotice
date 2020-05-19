using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Implementacija.Models
{
    public class FormaZaTretman:IForma
    {
        private int ID { get; set; }
        private Tretman tretman { get; set; }
        private string opisRezultata { get; set; }
       // private Image slikaRezultata { get; set; }
        private RegistrovaniKorisnik klijent { get; set; }

        public string dajRezultatForme()
        {
            throw new NotImplementedException();
        }
    }
}
