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
        Kupac kupac;

        int idprodavnice;

        public Racun(int brojRacuna,List<Proizvod> kupljeno, int idprodavnice, Kupac k)
        {
            this.brojRacuna = brojRacuna;
            this.idprodavnice = idprodavnice;
            this.kupljeno = new List<Proizvod>(kupljeno);
            datum = DateTime.Now;
            kupac = k;
        }

        public override string ToString()
        {
            string retVal = "____________Racun broj: " + brojRacuna + "____________\n";
            retVal += "____________________________________\n";

            double platiti = 0;
            foreach (Proizvod p in kupljeno)
            {
                retVal += p.UspesnaKupovinaIspis(p.zalihe) + "\n";
                platiti += p.cena * p.zalihe;
            }

            retVal += "____________________________________\n";
            retVal += kupac + "\n";
            retVal += "Date: " + datum.ToString() + "\n";
            retVal += "____________________________________\n";
            retVal += "Cena: " + platiti + "\n";
            retVal += "____________________________________\n";



            return retVal;
        }
    }
}
