using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Implementacija.Models
{
    public class FormaZaTretman:IForma
    {
        public int ID { get; set; }
        public Tretman tretman { get; set; }
        public string opisRezultata { get; set; }
       // private Image slikaRezultata { get; set; }
        public RegistrovaniKorisnik klijent { get; set; }

        public string dajRezultatForme()
        {
            throw new NotImplementedException();
        }
    }
}
