using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Matematik
    {
        public void ToplaYazdir(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine(toplam);
        }

        public int Topla(int s1, int s2) 
        {
            int toplam = s1 + s2;
            return toplam;
        }

        public int StringTopla(string s1, string s2)
        {
            int sayi1 = Convert.ToInt32(s1);
            int sayi2 = Convert.ToInt32(s2);
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        //Kendisine gönderilen sayının karesini döndüren metot
        public int KareAl(int sayi) 
        {
            int sayininKaresi = sayi * sayi;
            return sayininKaresi;
        }

        //Kendisine gönderilen taban ve üs değerlerine sayının kuvvetini alan metot
        public int UsAL(int taban, int us) 
        {
            int sonuc = 1;

            for (int i = 0; i < us; i++) 
            {
                sonuc *= taban;
            }
            return sonuc;
        }
    }
}
