using madduck.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace madduck
{
    class Test
    {
        static List<Proizvod> proizvodi = new List<Proizvod>()
            {
                new Hrana("Sandwich",159.99,3),
                new Hrana("Pancake",130,2),
                new Pice("Coca-Cola",59.90,10),
                new Pice("Fanta",59.90,20),
                new Igracka("Spinner", 100, 5),
                new Igracka("Lopta", 500, 3),
                new Parking_Karta("Crvena_zona", 100, 50),
                new Parking_Karta("Plava_zona", 150, 35)
            };

        static List<Proizvod> trafikaStanje = new List<Proizvod>(proizvodi)
            {
                new Cigare("Marlboro",300,20),
                new Cigare("Parlament", 350, 15)
            };

        static List<Proizvod> apotekaStanje = new List<Proizvod>(proizvodi)
            {
                new Lek("Brufen", 400, 15),
                new Lek("Caffetin",350, 25)
            };


        public static void TestiranjeVerzija1()
        {
            TrgovinskiLanac noviLanac = new TrgovinskiLanac();

            Prodavnica trafika = new Prodavnica("Trafika 1", 1, trafikaStanje);
            Prodavnica apoteka = new Prodavnica("Apoteka 2", 3, apotekaStanje);
            Prodavnica supermarket = new Prodavnica("SuperMarket", 2, proizvodi);

            noviLanac.DodajProdavnicu(trafika);
            noviLanac.DodajProdavnicu(apoteka);
            noviLanac.DodajProdavnicu(supermarket);

            


        }
    }
}
