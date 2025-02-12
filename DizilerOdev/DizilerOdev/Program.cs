using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Domates", "Biber", "Badılcan", "Fasulya", "Soğan", "İliman", "Ekmek", "Kola", "Yumurta" };
            double[] fiyatlar = { 35, 79.35, 58.95, 57.90, 10, 20, 10, 50.40, 50 };
            string[] birimler = { "Kg", "Kg", "Kg", "Kg", "Kg", "Kg", "Adet", "Lt", "Koli" };
            double[] kdvoranlari = { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.8, 0.8, 0.1 };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + isimler[i] + " \t" + fiyatlar[i] + " TL");
            }

            string secenek = "evet";
            double aratoplam = 0;
            double geneltoplam = 0;
            double toplamKdv = 0;

            while (secenek == "evet")
            {
                Console.WriteLine("Lütfen almak istediğiniz ürün numarasını giriniz");
                int urunno = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Kaç " + birimler[urunNo - 1] + " " + isimler[urunNo - 1] + " alacaksınız?");
                Console.WriteLine($"Kaç {birimler[urunno - 1]} {isimler[urunno - 1]} alacaksınız?");
                int adet = Convert.ToInt32(Console.ReadLine());

                double urunFiyat = fiyatlar[urunno - 1] * adet; // Seçilen ürünün toplam fiyatı (adet * birim fiyat)
                double urunKdv = urunFiyat * kdvoranlari[urunno - 1]; // Seçilen ürün için KDV hesaplanır
                toplamKdv += urunKdv; // Toplam KDV'ye eklenir
                aratoplam += urunFiyat; // Ara toplam güncellenir (KDV eklenmeden)
                geneltoplam = aratoplam + toplamKdv; // Genel toplam KDV dahil hesaplanır

                Console.WriteLine("Alışverişe devam edilsin mi? evet/hayır");
                secenek = Console.ReadLine();

                if (secenek == "hayır")
                {
                    Console.WriteLine("Morpheus Market iyi günler diler");
                    Console.WriteLine("ARA TOPLAM = " + aratoplam);
                    Console.WriteLine("KDV = " + toplamKdv);
                    Console.WriteLine("GENEL TOPLAM = " + geneltoplam + " TL");
                }
            }






        }
    }
}
