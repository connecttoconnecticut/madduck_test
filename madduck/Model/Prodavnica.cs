using System;
using System.Collections.Generic;
using System.Text;

namespace madduck.Model
{
    public class Prodavnica
    {
        string naziv;
        public enum TipProdavnice { trafika, supermarket, apoteka };

        public TipProdavnice tip { get; set; }
    }

}
