using System;
using System.Collections.Generic;

namespace API
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Rezervacija = new HashSet<Rezervacija>();
            Tretman = new HashSet<Tretman>();
            Uplatnica = new HashSet<Uplatnica>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
        public virtual ICollection<Tretman> Tretman { get; set; }
        public virtual ICollection<Uplatnica> Uplatnica { get; set; }
    }
}
