using System;
using System.Collections.Generic;

namespace API
{
    public partial class Rezervacija
    {
        public int Id { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime VrijemeRezervacije { get; set; }
        public int TipPlacanja { get; set; }
        public string ImeIprezime { get; set; }
        public string OdabraniTretman { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
