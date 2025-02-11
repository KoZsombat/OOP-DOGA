using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DOGA
{
    internal class Tanar
    {
        public string Nev { get; set; }
        public List<Tantargy> Tantargyak; 
        public int TanarID { get; set; }

        public Tanar(string nev, int tanarid)
        {
            Nev = nev;
            Tantargyak = new List<Tantargy>();
            TanarID = tanarid;  
        }

        public void HozzaadTantargy(Tantargy tantargy)
        {
            Tantargyak.Add(tantargy);
        }

        public string OktatottTantargyak()
        {
            string nickher = "";
            foreach (var item in Tantargyak)
            {
                nickher += item.Nev;
            }
            return nickher;
        }

    }
}
