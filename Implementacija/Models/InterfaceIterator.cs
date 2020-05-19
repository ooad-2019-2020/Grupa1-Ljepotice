using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    interface InterfaceIterator
    {
        public Korisnik hasNext();


        public Korisnik getNext();


        public bool isComplited();


    }
}
