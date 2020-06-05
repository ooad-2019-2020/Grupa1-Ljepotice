using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class KorisnikPrijava:IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
