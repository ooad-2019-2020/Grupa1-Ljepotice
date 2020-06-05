using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class StandardniBuilder:IBuilder
    {
        private Cjenovnik cjenovnik;

        public Cjenovnik dajCjenovnik()
        {
            throw new NotImplementedException();
        }

        public void dodajObicneUsluge()
        {
            throw new NotImplementedException();
        }

        public void dodajVIPUsluge()
        {
            throw new NotImplementedException();
        }
    }
}
