using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DOGA
{
    internal class Osztaly
    {
        public string Nev { get; set; }
        public List<Diak> Diakok = new List<Diak>();
        public Tanar Osztalyfonok { get; set; }

        public Osztaly(string nev, Diak diak, Tanar tanar)
        {
            Nev = nev;
            Diak diakk = diak;
            Diakok.Add(diakk);
            Osztalyfonok = tanar;
        }

        public void HozzaadDiak(Diak diak) 
        { 
            if (Diakok.Count < 25)
            {
                Diakok.Add(diak);
            }
        }

        //public string OsszesDiakListazasa()
        //{
        //   return $"{string.Join(", ", Diakok)}";
        //}

        public void OsszesDiakListazasa()
        {
            foreach (var asd in Diakok)
            {
                Console.WriteLine(asd.Nev);
            }
        }

        public string OsztalyfonokKiirasa()
        {
            return $"{Osztalyfonok.Nev}, {Osztalyfonok.OktatottTantargyak()}";
        }
    }
}
