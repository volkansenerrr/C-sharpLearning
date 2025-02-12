using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BeyazEsya esya = new BeyazEsya();
            //esya.Isim = "Deneme";
            //esya.Marka = "Deneme";
            //esya.Fiyat = 50;

            CamasirMakinesi cm = new CamasirMakinesi();
            cm.Marka = "BOSCH";
            cm.ProgramSayisi = 3;
            cm.Kurutma = true;
            cm.Isim = "B0159";
            cm.Fiyat = 55;

            BulasikMakinesi bm = new BulasikMakinesi();
            bm.Marka = "SIEMENS";
            bm.Isim = "SM58";
            bm.Fiyat = 12000;
            bm.KisiSayisi = 6;
            bm.EnerjiSinifi = "G+";

            //Türetilen her sınıf içinde base class'ı barındırır
            List<BeyazEsya> esyalar = new List<BeyazEsya>();
            esyalar.Add(cm);
            esyalar.Add(bm);
            for (int i = 0; i < esyalar.Count; i++)
            {
                Console.WriteLine($"{esyalar[i].Marka} {esyalar[i].Isim} {esyalar[i].Fiyat}");
            }
        }
    }
}
