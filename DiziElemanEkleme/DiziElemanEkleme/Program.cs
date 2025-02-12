using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanEkleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Diziye eleman sayısını arttırmak mümkün DEĞİLDİR.
            //UPDATE
            //Dizinin eleman sayısını içindeki verileri koruyarak arttırmak mümkün değildir.

            #endregion

            #region NEDEN YAW?

            //string[] isimler = new string[5];// 5 string eleman alabilen dizi
            //isimler[0] = "Murtaza";
            //isimler[1] = "Şuayip";
            //isimler[2] = "Şerife";
            //isimler[3] = "Remziye";
            //isimler[4] = "Mülayim";

            //isimler = new string[10];

            //Console.WriteLine(isimler[3]);

            #endregion

            #region Peki çözüm nedir hocam ?

            //string[] isimler = new string[5];// 5 string eleman alabilen dizi
            //isimler[0] = "Murtaza";
            //isimler[1] = "Şuayip";
            //isimler[2] = "Şerife";
            //isimler[3] = "Remziye";
            //isimler[4] = "Mülayim";

            //string[] gecici = new string[isimler.Length + 1];

            ////Dizi Kopyalama
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    gecici[i] = isimler[i];
            //}

            ////gecici = "Murtaza", "Şuayip", "Şerife", "Remziye", "Mülayim", --------

            //gecici[gecici.Length - 1] = "Nasuh";

            //isimler = gecici;//Dizi diziye aktarıldığı için isimler dizi içindeki verilerin hepsi gecici dizinin elemanları oldu

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            #endregion

            #region Koleksiyon Mantığına Giriş

            //Konferans k = new Konferans();
            //k.katilimciEkle("Murtaza");
            //k.katilimciEkle("Şuayip");
            //k.katilimciEkle("Ali");
            //k.katilimciEkle("Volki");
            //k.katilimciEkle("Müdavim");
            //k.katilimciEkle("Şükriye");
            //k.katilimciEkle("Şerife");
            //k.katilimciEkle("Nasuh");
            //k.Yazdir();

            #endregion

            #region Katılımcıları konsoldan ekleyiniz
            //1-Katılımcı ekle
            //2-Katılımcı listele
            //3-Çıkış

            //Konferans k = new Konferans();
            //string secenek = "";

            //while (secenek != "3")
            //{
            //    Console.Clear();
            //    Console.WriteLine("1 - Katılımcı Ekle");
            //    Console.WriteLine("2 - Katılımcı listele");
            //    Console.WriteLine("3 - Çıkış");
            //    Console.Write("Lütfen Seçiniz = ");
            //    secenek = Console.ReadLine();

            //    switch (secenek)
            //    {
            //        case "1":
            //            Console.WriteLine("Lütfen isim giriniz");
            //            k.katilimciEkle(Console.ReadLine());
            //            break;
            //        case "2":
            //            Console.Clear();
            //            k.Yazdir();
            //            Console.WriteLine("Devam etmek için ENTER'a basınız");
            //            Console.ReadKey();
            //            break;
            //        default:
            //            break;

            //    }
            //}

            #endregion

            


        }
    }
}
