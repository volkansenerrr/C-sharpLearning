using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Metotların Aşırı Yüklenmesi
            //Bir sınıf içerisindeki metotların isimleri aynı ancak metot imzaları farklı olması durumunda metot overloading oluşur.

            #endregion

            #region Kullanım

            //Matematik m = new Matematik();
            //m.Topla(12, 22);
            //m.Topla(14.3, 47.1);

            //m.Topla("3", "5");
            ////Console.WriteLine(m.DoubleTopla(14.8, 25.9));

            //Convert.ToInt32("45");



            #endregion

            #region Sınav Sistemi

            Sinav deneme = new Sinav();
            deneme.isim = "Deneme Sınavı";
            deneme.gecmePuani = 70;
            deneme.tur = "Fizik";

            deneme.SoruEkle("Suyun kaynama sıcaklığı nedir?", "90", "80", "-20", "100", "D");
            deneme.SoruEkle("Yer çekimini kim bulmuştur?", "Fişne Suyu", "Meyve Suyu", "Issac Newton", "100", "C");
            deneme.SoruEkle("Naber?", "Sana ne", "Bana ne", "Kime ne", "Hayırdır", "D");
            deneme.SoruEkle("Fizik Nedir?", "Doğa Bilimi", "Dilara Bilimi", "Nasuh Bilimi", "Üseyin Bilmii", "B");
            deneme.SoruEkle("Momentum Nedir?", "Tavuk Döner", "Dünya Döner", "O Dönmez", "Dönerse Senindir", "A");

            int toplam = 0;

            for (int i = 0; i < deneme.sorular.Length; i++)
            {
                Console.Clear();
                deneme.SoruYazdir(i);
                Console.WriteLine("Cevap Seçiniz");
                string cevap = Console.ReadLine();

                if (cevap == deneme.DogruCevap(i))
                {
                    toplam += 20;
                }
            }
            Console.WriteLine("Sınav Tamamlandı");
            Console.WriteLine("Puanınız = " + toplam);


            #endregion

        }
    }
}
