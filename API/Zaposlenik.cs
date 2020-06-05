using System;
using System.Collections.Generic;

namespace API
{
    public partial class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TipKozmeticara { get; set; }
    }
}
