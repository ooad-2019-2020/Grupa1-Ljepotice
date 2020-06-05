using System;
using System.Collections.Generic;

namespace API
{
    public partial class Tretman
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int KategorijaTretmana { get; set; }
        public string OpisTretmana { get; set; }
        public int? KorisnikDbid { get; set; }

        public virtual Korisnik KorisnikDb { get; set; }
    }
}
