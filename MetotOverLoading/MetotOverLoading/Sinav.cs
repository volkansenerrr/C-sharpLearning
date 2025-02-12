using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Sinav
    {
        public string isim;
        public int gecmePuani;
        public string tur;
        public Soru[] sorular;

        public Sinav()
        {
            sorular = new Soru[0];
        }

        public void SoruEkle(Soru s)
        {
            Soru[] gecici = new Soru[sorular.Length + 1];
            Array.Copy(sorular, gecici, sorular.Length);
            gecici[gecici.Length - 1] = s;
            sorular = gecici;
        }
        public void SoruEkle(string m, string sA, string sB, string sC, string sD, string d)
        {
            Soru[] gecici = new Soru[sorular.Length + 1];
            Array.Copy(sorular, gecici, sorular.Length);
            gecici[gecici.Length - 1] = new Soru(m, sA, sB, sC, sD, d);
            sorular = gecici;
        }

        public void SoruYazdir(int index)
        {
            Soru s = sorular[index];
            Console.WriteLine(s.metin);
            Console.WriteLine("A) " + s.secenekA);
            Console.WriteLine("B) " + s.secenekB);
            Console.WriteLine("C) " + s.secenekC);
            Console.WriteLine("D) " + s.secenekD);
        }

        public string DogruCevap(int index)
        {
            Soru s = sorular[index];
            return s.dogru;
        }
    }
}
