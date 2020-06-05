using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class Cjenovnik
    {
        public int ID { get; set; }
        public List<Tretman> listaTretmana { get; set; }
        public bool VIPUsluge { get; set; }
        public bool standardneUsluge { get; set; }
        public bool testiranje { get; set; }
        public double novcaniDodatakZaDodatneUsluge { get; set; }
        private List<double> listaCijena { get; set; }

    }
}
