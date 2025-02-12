using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalMorpheus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = { "Domates", "Biber", "Badılcan", "Fasulya", "Soğan", "İliman" };
            //double[] fiyatlar = { 35, 79.95, 58.95, 57.90, 10, 20 };

            //for (int i = 0; i < isimler.Length; i++) 
            //{
            //    Console.WriteLine((i+1) + ") " + isimler[i] + "\t" + fiyatlar[i] + " TL");
            //    //Console.Writeline("{0}) {1}\t{2} TL",(i+1), isimler[i], fiyatlar[i]);
            //}

            #region Adet sorarak ürün aldırma

            //Öncelikle kaç adet ürün alacaksın diye soracağız
            // numaralı üründen istiyorum 

            //Console.WriteLine("Kaç adet ürün alacaksınız?");
            //int adet = Convert.ToInt32(Console.ReadLine());
            //double toplam = 0;
            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine("almak istediğiniz ürünün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1];
            //}
            //Console.WriteLine("Bakkal Morpheus'u tercih ettiğiniz için teşekkür ederiz");
            //Console.WriteLine("Toplam = " + toplam + " TL");
            //Console.WriteLine($"Toplam = {toplam} TL");
            //Console.WriteLine("Toplam = {0} TL", toplam);

            #endregion

            #region Adet Sormadan Ürün Satın Aldırma

            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Lütfen almak istediğiniz ürünün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1];

            //    Console.WriteLine("Alışverişe devam edilsin mi ? e/h");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Toplam = " + toplam + " TL");


            #endregion

            //ÖDEV 1 LÜTFEN ALMAK İSTEDİĞİNİZ ÜRÜNÜN NUMARASINI GİRİNİZ DEDİKTEN SONRA BU ÜRÜNDEN KAÇ TANE ALMAK İSTİYORSUN DİYE SORACAĞIZ ?
            //ÖDEV 2 İsimler listesi olmadan bir numara girilecek ve enter a basılacak,
            //eğer ki numara dizi içinde kayıtlı ise giriş başarılı kayıtlı değilse giriş başarısız diyecek
            //ÖDEV 3 Yine numaralar olacak birde bu numaralara karşılık gelen bakiyeler dizisi olucak,
            //her kart okutulduğunda eğer bakiye 17 liradan büyük ise kapı açıldı diyecek. Değilse bekle geçersin sen diyecek

        }
    }
}
