using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public enum TipKoze
    {
        Suha,
        Mjesovita,
        Masna
    }
    public class FormaZaTest:IForma
    {
        public int ID { get; set; }
        public TipKoze tipKoze { get; set; }
        public Tretman preporuceniTretman { get; set; }
        public RegistrovaniKorisnik klijent { get; set; }

        public string dajRezultatForme()
        {
            throw new NotImplementedException();
        }
    }
}
