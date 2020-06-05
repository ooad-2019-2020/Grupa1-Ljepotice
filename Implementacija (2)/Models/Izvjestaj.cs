using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class Izvjestaj
    {
      public int ID { get; set; }
      public string nazivSalona { get; set; }
      private Recepcioner recepcioner { get; set; }
      private List<Uplatnica> listaUplatnica { get; set; }
      public DateTime datumIVrijeme { get; set; }

      public void  setUplatnicu (Uplatnica uplatnica)
        {
            throw new NotImplementedException();
        }

      public Uplatnica getUplatnica (string nazivKlijenta,string nazivTretmana)
        {
            throw new NotImplementedException();
        }
    }
}
