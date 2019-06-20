using System;
using System.Collections.Generic;
using System.Text;

namespace madduck.Model
{
    public class Kupac
    {
        string ime;
        string prezime;
        string broj_telefona;

        List<Proizvod> korpa;

        public Kupac(string ime,string prezime, string broj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.broj_telefona = broj;
            korpa = new List<Proizvod>();
        }

        public void DodajUKorpu(Proizvod p)
        {
            korpa.Add(p);
        }

        public override string ToString()
        {
            return ime + " " + prezime + " " + " ;kontakt: " + broj_telefona;
        }
    }
}
