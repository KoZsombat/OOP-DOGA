using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DOGA
{
    internal class Tantargy
    {
        public string Nev { get; set; }
        public int KontaktOrak { get; set; }

        public Tantargy(string nev,  int kontaktorak)
        {
            Nev = nev;
            KontaktOrak = kontaktorak;
        }

        public string TantargyAdatok()
        {
            return $"{Nev}, {KontaktOrak} óra/hét";
        }

    }
}
