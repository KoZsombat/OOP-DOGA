using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DOGA
{
    internal class Ertekeles
    {
        public Diak diak { get; set; }
        public Tantargy tantargy { get; set; }
        public int Erdemjegy { get; set; }

        public Ertekeles(Diak d, Tantargy t, int j)
        {
            diak = d;
            tantargy = t;
            Erdemjegy = j;
        }

        public string JegyKiirasa()
        {
            return $"{diak.Nev}: {tantargy.Nev}: {Erdemjegy}";
        }

    }
}
