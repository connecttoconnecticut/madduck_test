using System;
using System.Collections.Generic;
using System.Text;

namespace madduck.Model
{
    class Proizvod
    {
        string nazivProizvoda;
        double cena;
        int zalihe;

        public Proizvod()
        {

        }
    }

    class Hrana : Proizvod {
        
    }

    class Pice : Proizvod
    {

    }

    class Lek : Proizvod
    {
        string serijskiBroj;
    }

    class Cigare : Proizvod
    {

    }

    class Igracka : Proizvod
    {

    }

    class Parking_Karta : Proizvod
    {
        string serijskiBroj;
    }
}
