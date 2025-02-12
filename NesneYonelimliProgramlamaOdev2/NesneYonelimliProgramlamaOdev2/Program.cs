using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlamaOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ödev2: web yazılım uzmanlığı, ileri yazılım uzmanlığı, grafik tasarım eğitimi alan 5 er öğrenci olacak. 
             * Bunlardan web yazılım uzmanlığı alanlar deyip 5 ini, ileri yazılım uzmanlığı alanlar deyip 5 ini, grafik tasarım eğitimi alanlar deyip 
             * 5 ini tek bir döngüde listeleme yapacağız.
            */
            #region Ödev
            Ogrenci[] ogrenciler = new Ogrenci[5];

            Ogrenci ogr = new Ogrenci() { isim = "Berk", soyisim = "Şimşek", bolum = "Web Yazılım Uzmanlığı" };
            ogrenciler[0] = ogr;
            ogrenciler[1] = new Ogrenci() { isim = "Doğa", soyisim = "Hava", bolum = "Flutter Mobil Yazılım" };
            ogrenciler[2] = new Ogrenci() { isim = "Deniz Alp", soyisim = "Tuğrul", bolum = "Web Yazılım Uzmanlığı" };
            ogrenciler[3] = new Ogrenci() { isim = "Dilara Nur", soyisim = "Şavran", bolum = "İleri Yazılım Uzmanlığı" };
            ogrenciler[4] = new Ogrenci() { isim = "Semih", soyisim = "Erdoğan", bolum = "Flutter Mobil Yazılım" };

            Console.WriteLine("\n*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*--*-*-*");
            Console.WriteLine("Web Yazılım Uzmanlığı");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ogrenciler[i].bolum == "Web Yazılım Uzmanlığı")
                {
                    Console.WriteLine($"{ogrenciler[i].isim} {ogrenciler[i].soyisim}");
                }
            }
            Console.WriteLine("\n------------------");
            Console.WriteLine("Flutter Mobil Yazılım");
            Console.WriteLine("------------------");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ogrenciler[i].bolum == "Flutter Mobil Yazılım")
                {
                    Console.WriteLine($"{ogrenciler[i].isim} {ogrenciler[i].soyisim}");
                }
            }

            Console.WriteLine("\n------------------");
            Console.WriteLine("İleri Yazılım Uzmanlığı");
            Console.WriteLine("------------------");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ogrenciler[i].bolum == "İleri Yazılım Uzmanlığı")
                {
                    Console.WriteLine($"{ogrenciler[i].isim} {ogrenciler[i].soyisim}");
                }
            }
            #endregion

            #region Listeleme

            Console.WriteLine("Öğrenci Listelemek istediğimiz bölümü seçiniz");
            Console.WriteLine("1) Web Yazılım Uzmanlığı");
            Console.WriteLine("2) İleri Yazılım Uzmanlığı");
            Console.WriteLine("3) Flutter Mobil Yazılım");
            Console.WriteLine("4) Tümü");

            string secenek = 

            #endregion
        }
    }
}
