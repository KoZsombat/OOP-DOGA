using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DOGA
{
    internal class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        public int Azonosito { get; set; }

        public Diak(string nev, string osztaly, int azonosito)
        {
            Nev = nev;
            Osztaly = osztaly;
            Azonosito = azonosito;
        }

        public string TeljesNevKiirasa()
        {
            return $"{Nev}, {Osztaly}";
        }

    }
}
