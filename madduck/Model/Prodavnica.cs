using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace madduck.Model
{
    public class Prodavnica
    {
        int id_prodavnice;
        string naziv;
        List<Proizvod> proizvodiNaStanju;
        List<Racun> racuni;

        
        public enum TipProdavnice { trafika = 1, supermarket, apoteka };
        

        public TipProdavnice tip { get; set; }

        public Prodavnica()
        {

        }

        public Prodavnica(string naziv,int enumerationIndex)
        {
            this.naziv = naziv;
            tip = (TipProdavnice)enumerationIndex;
            proizvodiNaStanju = new List<Proizvod>();
            racuni = new List<Racun>();
        }

        public Prodavnica(string naziv, int enumerationIndex, List<Proizvod> proizvodiUprodanvici)
        {
            this.naziv = naziv;
            tip = (TipProdavnice)enumerationIndex;
            proizvodiNaStanju = new List<Proizvod>(proizvodiUprodanvici);
            racuni = new List<Racun>();
        }

        public void KreirajRacun(List<Proizvod> korpa)
        {
            if(proizvodiNaStanju.Count > 0)
            {
                racuni.Add(new Racun(racuni.Count + 1, korpa, id_prodavnice));
                foreach (Proizvod p in korpa)
                {
                    proizvodiNaStanju.FirstOrDefault(pSaStanja => pSaStanja.nazivProizvoda == p.nazivProizvoda).zalihe--;
                }
            }
        }

        

    }
}
