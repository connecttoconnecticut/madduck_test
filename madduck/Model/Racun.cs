using System;
using System.Collections.Generic;
using System.Text;

namespace madduck.Model
{
    class Racun
    {
        int brojRacuna;
        DateTime datum;
        List<Proizvod> kupljeno;

        int idprodavnice;

        public Racun()
        {

        }

        public Racun(int brojRacuna,List<Proizvod> kupljeno, int idprodavnice)
        {
            this.brojRacuna = brojRacuna;
            this.idprodavnice = idprodavnice;
            this.kupljeno = new List<Proizvod>(kupljeno);
        }
    }
}
