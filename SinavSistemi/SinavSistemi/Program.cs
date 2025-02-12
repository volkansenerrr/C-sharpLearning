using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinav s1 = new Sinav();
            s1.isim = "Genel Kültür";
            s1.soruSayisi = 5;
            s1.gecmePuani = 50;
            

            Soru[] sinav = new Soru[5];

            #region Sinav Hazırla

            sinav[0] = new Soru() { SoruMetin = "Türkiyenin başkenti neresidir?", SecenekA = "Adana", SecenekB = "Trabzon", SecenekC = "Tokat", SecenekD = "Ankara", DogruCevap = "D" };
            sinav[1] = new Soru() { SoruMetin = "Ülkemizde 2017 yılında asgari ücret ne kadardı?", SecenekA = "1000", SecenekB = "1200", SecenekC = "1700", SecenekD = "2100", DogruCevap = "C" };
            sinav[2] = new Soru() { SoruMetin = "Alp Hocanın 2024 yılında yaşı kaçtır?", SecenekA = "26", SecenekB = "27", SecenekC = "28", SecenekD = "29", DogruCevap = "A" };
            sinav[3] = new Soru() { SoruMetin = "Türlerin kökeni Kitabının yazarı kimdir?", SecenekA = "Celal Şengör", SecenekB = "Charles Darwin", SecenekC = "Lamark", SecenekD = "Leonardo DiCaprio", DogruCevap = "B" };
            sinav[4] = new Soru() { SoruMetin = "Asprine'in ilk kez çıkış tarihi nedir?", SecenekA = "1799", SecenekB = "1994", SecenekC = "1899", SecenekD = "1950", DogruCevap = "C" };

            #endregion

            s1.sorular = sinav;

            Console.WriteLine("Sınav Adı = " + s1.isim);
            Console.WriteLine("Soru Sayısı = " + s1.soruSayisi);
            Console.WriteLine("Geçme Puanı = " + s1.gecmePuani);

            Console.WriteLine("*-**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Başlamak için Enter'a basınız");
            Console.ReadLine();

            #region Sınav Başlat
            int puan = 0;
            for (int i = 0; i < s1.sorular.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"{i+1} ) {s1.sorular[i].SoruMetin}");
                Console.WriteLine($"A ) {s1.sorular[i].SecenekA}");
                Console.WriteLine($"B ) {s1.sorular[i].SecenekB}");
                Console.WriteLine($"C ) {s1.sorular[i].SecenekC}");
                Console.WriteLine($"D ) {s1.sorular[i].SecenekD}");
                Console.WriteLine("Cevabınızı Yazınız = ");
                string cevap = Console.ReadLine();
                char karakter = Convert.ToChar(cevap);
                int sayisal = (int)karakter;
                if (sayisal >= 97 && sayisal <= 122)
                {
                    sayisal -= 32;
                    char buyukkarakter = (char)sayisal;
                    cevap = Convert.ToString(buyukkarakter);
                }
                if (cevap == s1.sorular[i].DogruCevap)
                {
                    puan += 20;
                }
            }
            Console.WriteLine("Sınav Tamamlandı");
            Console.WriteLine("Puanınız = " + puan);
            if (puan > s1.gecmePuani)
            {
                Console.WriteLine("Tebrikler Geçtiniz");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }


            #endregion
        }
    }
}
