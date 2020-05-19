using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public enum KategorijaTretmana
    {
        Manikir,
        Sminkanje,
        Depilacija
    }
    public class Tretman
    {
        private int ID { get; set; }
        private string naziv { get; set; }
        private float cijena { get; set; }
        private KategorijaTretmana kategorijaTretmana { get; set; }
        private string opisTretmana { get; set; }

    }
}
