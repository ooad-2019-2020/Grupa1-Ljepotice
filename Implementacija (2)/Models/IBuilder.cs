using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    interface IBuilder
    {
        public void dodajObicneUsluge();
        public void dodajVIPUsluge();
        public Cjenovnik dajCjenovnik();

    }
}
