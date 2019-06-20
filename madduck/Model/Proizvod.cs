using System;
using System.Collections.Generic;
using System.Text;

namespace madduck.Model
{
    public class Proizvod
    {
        public string nazivProizvoda { get; set; }
        public double cena { get; set; }
        public int zalihe { get; set; }

        
        public Proizvod()
        {

        }

        public Proizvod(string nazivProizvoda, double cena, int zalihe)
        {
            this.nazivProizvoda = nazivProizvoda;
            this.cena = cena;
            this.zalihe = zalihe;
        }

        public override string ToString()
        {
            return "Tip Proizvoda: " + base.ToString() + " - naziv prozvoda: " + nazivProizvoda;
        }
    }

    class Hrana : Proizvod {
        public Hrana(string naziv, double cena, int zalihe) : base(naziv,cena,zalihe)
        {

        }
    }

    class Pice : Proizvod
    {
        public Pice(string naziv, double cena, int zalihe) : base(naziv, cena, zalihe)
        {

        }
    }

    class Lek : Proizvod
    {
        string serijskiBroj;

        public Lek(string naziv, double cena, int zalihe) : base(naziv, cena, zalihe)
        {
            this.serijskiBroj = "Serijski_broj_leka:" + zalihe;
        }
    }

    class Cigare : Proizvod
    {
        public Cigare(string naziv, double cena, int zalihe) : base(naziv, cena, zalihe)
        {

        }
    }

    class Igracka : Proizvod
    {
        public Igracka(string naziv, double cena, int zalihe) : base(naziv, cena, zalihe)
        {

        }
    }

    class Parking_Karta : Proizvod
    {
        string serijskiBroj;

        public Parking_Karta(string naziv, double cena, int zalihe) : base(naziv, cena, zalihe)
        {
            this.serijskiBroj = "Serijski_broj_parkingKarte:" + zalihe;
        }
    }
}
