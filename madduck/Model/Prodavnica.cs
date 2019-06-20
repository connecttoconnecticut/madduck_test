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

        public void KreirajRacun(List<Proizvod> korpa, Kupac k)
        {
            if(proizvodiNaStanju.Count > 0)
            {
                var tempKorpa = new List<Proizvod>();
                foreach (Proizvod p in korpa)
                {
                    var temp = proizvodiNaStanju.FirstOrDefault(pSaStanja => pSaStanja.nazivProizvoda == p.nazivProizvoda);
                    if(temp != null)
                    {
                        if(temp.zalihe >= p.zalihe)
                        {
                            temp.zalihe = temp.zalihe - p.zalihe;
                            p.cena = temp.cena;
                            tempKorpa.Add(p);
                            Console.WriteLine("Proizvod " + temp.UspesnaKupovinaIspis(p.zalihe) + " uspesno dodat na racun.");
                        }
                        else
                        {
                            Console.WriteLine("Na stanju nema dovoljno proizvoda: " + p.ProizvodaNemaNaStanju());
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine(p.ProizvodNijePronadjenIspis());
                    }
                }

                if(tempKorpa.Count > 0)
                {
                    Racun r = new Racun(racuni.Count + 1, tempKorpa, id_prodavnice, k);
                    racuni.Add(r);
                    Console.WriteLine("___________________________________________________");
                    Console.WriteLine("Prodavnica: " + naziv + " ,uspesno kreirala racun:\n" + r);
                }
                else
                {
                    Console.WriteLine("Na stanju nemamo nista od trazenog.");
                }
            }
        }

        public string IspisiStanje()
        {
            string retVal = "-----------_" + naziv + "_-----------\n";
            retVal += "-------------------------------\n";


            foreach (Proizvod p in proizvodiNaStanju)
            {
                retVal += p.ToString() + "\n";
            }

            return retVal;
        }

    }
}
