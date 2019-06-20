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


        public static void Testiranje()
        {
            TrgovinskiLanac noviLanac = new TrgovinskiLanac();

            Prodavnica trafika = new Prodavnica("Trafika 1", 1, trafikaStanje);
            Prodavnica apoteka = new Prodavnica("Apoteka 2", 3, apotekaStanje);
            Prodavnica supermarket = new Prodavnica("SuperMarket", 2, proizvodi);

            noviLanac.DodajProdavnicu(trafika);
            noviLanac.DodajProdavnicu(apoteka);
            noviLanac.DodajProdavnicu(supermarket);

            Kupac t_k1 = new Kupac("John", "Doe", "225-883");
            Kupac t_k2 = new Kupac("Joe", "Bloggs", "883-225");

            Console.WriteLine("Stanje PRE kupovine!!!");
            Console.WriteLine(trafika.IspisiStanje());
            //Console.WriteLine(apoteka.IspisiStanje());
            //Console.WriteLine(supermarket.IspisiStanje());

            Console.WriteLine("___________________________________________________");
            Console.WriteLine("_________________KUPOVINA_________________");
            trafika.KreirajRacun(new List<Proizvod>() {
                    new Proizvod("Sandwich",3),
                    new Proizvod("Chipsy",2),
                    new Proizvod("Caffetin",3),
                    new Proizvod("Coca-Cola",3),
                    new Proizvod("Crvena_zona",10),
            }, t_k1);
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Stanje POSLE kupovine!!!");
            Console.WriteLine(trafika.IspisiStanje());


        }
    }
}
