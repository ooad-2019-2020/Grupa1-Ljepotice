using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementacija.Models
{
    public class Izvjestaj
    {
      private int ID { get; set; }
      private string nazivSalona { get; set; }
      private Recepcioner recepcioner { get; set; }
      private List<Uplatnica> listaUplatnica { get; set; }
      private DateTime datumIVrijeme { get; set; }

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
