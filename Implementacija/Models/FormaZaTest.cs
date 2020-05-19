using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    enum TipKoze
    {
        Suha,
        Mjesovita,
        Masna
    }
    public class FormaZaTest:IForma
    {
        private int ID { get; set; }
        private TipKoze tipKoze { get; set; }
        private Tretman preporuceniTretman { get; set; }
        private RegistrovaniKorisnik klijent { get; set; }

        public string dajRezultatForme()
        {
            throw new NotImplementedException();
        }
    }
}
