using System;
using System.Collections.Generic;

namespace API
{
    public partial class Uplatnica
    {
        public int Id { get; set; }
        public string NazivTretmana { get; set; }
        public int? KlijentId { get; set; }
        public int BrojRacuna { get; set; }
        public double CijenaTretmana { get; set; }
        public int NacinPlacanja { get; set; }

        public virtual Korisnik Klijent { get; set; }
    }
}
