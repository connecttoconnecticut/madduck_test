using System;
using System.Collections.Generic;
using System.Text;

namespace madduck.Model
{
    class TrgovinskiLanac
    {
        int id_lanca;
        List<Prodavnica> prodavnice;
        
        public TrgovinskiLanac()
        {
            prodavnice = new List<Prodavnica>();
        }

        public void DodajProdavnicu(Prodavnica novaProdavnica)
        {
            prodavnice.Add(novaProdavnica);
        }


    }
}
