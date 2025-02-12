using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Cirak
    {
        public string isim;
        public string soyisim;

        public void SelamSoyle() 
        {
            Console.WriteLine("Ustamın selamı var");
        }

        public void IsmeSelamSoyle(string isim)
        {
            Console.WriteLine(isim + " abi ustam selam söyledi");
        }

        public void CaySoyle(int adet, string cayci) 
        {
            Console.WriteLine(cayci + " abi ustam " + adet + " çay söyledi");
        }

        public void IsmeCokSelamSoyle (string isim, int adet) 
        {
           for (int i = 0; i < adet; i++)
           {
                Console.WriteLine(isim + " abi ustam selam söyledi");
           }
        }

        public double KolaAl(int adet, double para) 
        {
            double fiyat = 50;
            double toplam = fiyat * adet;

            if (para > toplam)
            {
                para -= toplam;
            }

            return para;
        }
    }
}
