using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class Proxy
    {
        private int nivoPristupa { get; set; }
        //private BeautyCentar beautyCentar { get; set; }
        private string password { get; set; }
        public void authenticate(string password)
        {
            throw new NotImplementedException();
        }
    }
}
