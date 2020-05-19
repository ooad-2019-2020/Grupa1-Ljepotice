using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class Cjenovnik
    {
        private int ID { get; set; }
        private List<Tretman> listaTretmana { get; set; }
        private bool VIPUsluge { get; set; }
        private bool standardneUsluge { get; set; }
        private bool testiranje { get; set; }
        private double novcaniDodatakZaDodatneUsluge { get; set; }
        private List<double> listaCijena { get; set; }

    }
}
