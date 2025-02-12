using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOdevveIslemlerienson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = { "Furkan", "Volkan", "Doğa", "Dilara Nur", "Nasuh", "Hüseyin", "Deniz", "Berk" };
            //string[] numaralar = { "0579341572", "0044612612", "3127350532", "1792481028", "1219969301", "0708424452", "0490753442", "3124835332" };
            //double[] bakiyeler = { 100, 40, 3, 16, 19, 0.5, 16.99, 30.5 };

            //string[] isimler = { "Domates", "Biber", "Kola  ", "Fasulya", "Soğan", "İliman" , "Ekmek", "Yumurta"};
            //double[] fiyatlar = { 35, 79.95, 58.95, 57.90, 10, 20, 10, 40};
            //string[] birimler = { "Kg", "Kg", "Lt", "Kg", "Kg", "Adet", "Adet", "Koli"};

            #region Menü Yazdırma

            //for (int i = 0; i < isimler.Length; i++) 
            //{
            //    Console.WriteLine((i+1) + ") " + isimler[i] + "\t" + fiyatlar[i] + " TL");
            //}



            #endregion

            #region Ödev 1
            //Lütfen almak istediğiniz ürünün numarasını dedikten sonra bu ürünün kaç adet alacaksınız diye soracağız.

            //double toplam = 0;
            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Almak istediğiniz ürün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bu üründen kaç adet alacaksınız");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Morpheus Market iyi günler diler");
            //Console.WriteLine("TOPLAM = " + toplam + " TL");


            #endregion

            #region Uygulama 2

            //Bu üründen kaç adet alacaksınız yerine 
            //Kaç adet domates alacaksın

            //double toplam = 0;
            //string secenek = "e";

            //while (secenek == "e") 
            //{
            //    Console.WriteLine("Almak istediğiniz ürünün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Kaç adet " + isimler[urunno - 1] + " alacaksın" );
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();

            //    Console.WriteLine("Morpheus Market iyi günler diler");
            //    Console.WriteLine("TOPLAM = " + toplam + " TL");


            //}


            #endregion

            #region Uygulama 3
            //Birim belirterek ürün aldırma

            //string secenek = "e";
            //double toplam = 0;
            //while (secenek == "e")
            //{
            //    Console.WriteLine("Lütfen almak istediğiniz ürün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"Kaç {birimler[urunno - 1]} {isimler[urunno - 1]} alacaksınız?");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi? e/h");
            //    secenek = Console.ReadLine();

            //}

            //Console.WriteLine("Morpheus Market iyi günler diler");
            //Console.WriteLine("TOPLAM = " + toplam + " TL");


            #endregion

            #region Giriş Başarılı Giriş Başarısız ödev 2

            //Console.WriteLine("Lütfen kartınızı okutunuz");
            //string kartno = Console.ReadLine();

            //int index = -1;

            //for (int i = 0; i < numaralar.Length; i++) 
            //{
            //    if (numaralar[i] == kartno) 
            //    { 
            //        index = i; 
            //    }
            //}
            //Console.Clear();
            //if (index != -1)
            //{
            //    Console.WriteLine("Giriş Başarılı. Hoş Geldin " + isimler[index]);
            //}
            //else
            //{
            //    Console.WriteLine("Giriş Başarısız");
            //}
            #endregion

            #region Eskart 3.ödev

            //Console.WriteLine("Kartınızı okutunuz");
            //string kartno = Console.ReadLine();

            //double biletfiyat = 17;
            //int index = -1;

            //for (int i = 0; i < numaralar.Length; i++)
            //{
            //    if (numaralar[i] == kartno) 
            //    {
            //        index = i;
            //    }
            //}
            //if (index == -1)
            //{
            //    Console.WriteLine("Tanımsız kart");
            //}
            //else
            //{
            //    if (bakiyeler[index] >= biletfiyat) 
            //    {
            //        Console.WriteLine("Kapı Açıldı");
            //        Console.Beep(1500, 20);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bakiye yetersiz");
            //        Console.Beep(500, 500);
            //    }
            //}

            #endregion

            #region Mario 



            #endregion


        }
    }
}
