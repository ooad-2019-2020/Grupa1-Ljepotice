using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public abstract class Zaposlenik
    { 
        private int ID { get; set; }
        private string ime { get; set; }
        private string prezime { get; set; }
        private string username { get; set; }
        private string password { get; set; }

    }
}
