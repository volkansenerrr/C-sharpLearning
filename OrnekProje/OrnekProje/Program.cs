using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KONSOLDAN 5 ADET ÜRÜN FİYATI GİRİLMESİNİ İSTEYECEĞİZ
            //BİTTİKTEN SONRA ARA TOPLAM,KDV,GENELTOPLAM ŞEKLİNDE YAZDIRACAĞIZ
            //GENEL TOPLAM 250000 ÜSTÜNDE İSE TEBRİKLER 32 EKRAN SMART TV KAZANDINIZ YAZACAK

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Hoşgeldiniz..");
            Console.WriteLine("Lütfen almak istediğiniz ürünlerin fiyatını giriniz.");

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Lütfen birinci ürünün fiyatını giriniz.");
            double birinciUrunFiyati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Lütfen ikinci ürünün fiyatını giriniz.");
            double ikinciUrunFiyati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Lütfen üçüncü ürünün fiyatını giriniz.");
            double ucuncuUrunFiyati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Lütfen dördüncü ürünün fiyatını giriniz.");
            double dorduncuUrunFiyati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Lütfen beşinci ürünün fiyatını giriniz.");
            double besinciUrunFiyati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Ara toplam = " + (birinciUrunFiyati + ikinciUrunFiyati + ucuncuUrunFiyati + dorduncuUrunFiyati + besinciUrunFiyati));

            Console.WriteLine("KDV oranı = " + 0.20);

            double genelToplamMaliyet = (birinciUrunFiyati * (1 + 0.20)) + (ikinciUrunFiyati * (1 + 0.20)) + (ucuncuUrunFiyati * (1 + 0.20)) + (dorduncuUrunFiyati * (1 + 0.20)) + (besinciUrunFiyati * (1 + 0.20));

            Console.WriteLine("Genel Toplam = " + genelToplamMaliyet);

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            if (genelToplamMaliyet > 250000)
            {
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("Tebrikler 32 Ekran Smart TV kazandınız (:");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
            else 
            {
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("Bizden alışveriş yaptığınız için teşekkür ederiz hoşçakalın (:");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }

        }
    }
}
