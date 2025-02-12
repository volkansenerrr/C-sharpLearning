using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOgrencileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Furkan", "Volkan", "Doğa", "Dilara Nur", "Nasuh", "Hüseyin", "Deniz", "Berk" };
            string[] numaralar = { "0579341572", "0044612612", "3127350532", "1792481028", "1219969301", "0708424452", "0490753442", "3124835332" };

            string no = " ";

            while (no != "")
            {
                Console.WriteLine("Lütfen Kartınızı Okutunuz");
                string kartno = Console.ReadLine();
                no = kartno;
                int index = -1;

                for (int i = 0; i < numaralar.Length; i++)
                {
                    if (numaralar[i] == kartno)
                    {
                        index = i;

                    }
                }

                if (index != -1)
                {
                    Console.WriteLine("Merhaba = " + isimler[index]);
                }
                else
                {
                    Console.WriteLine("Giriş Reddedildi");
                }
            }
            //RFID CİHAZI na götürüp okuttuğumuzda kart numarsını çıkarttı
            //Kendisine gönderilen numaraları yazıp enter basıyor
            //ÖDEV İSİMLERİ YAPMADAN BİR NUMARA GİRİLECEK EĞER Kİ NUMARA DİZİ İÇİNDE KAYITLIYSA GİRİŞ BAŞARILI DEĞİLSE GİRİŞ BAŞARISIZ
            // ÖDEV 3 NUMARALARIMIZ OLACAK BİR DE BU NUMARALARA KARŞILIK BAKİYELER DİZİSİ OLACAK BAKİYE BİLGİSİ 17 LİRANIN ÜZERİNDEYSE KAPI AÇILACAK DEĞİLSE BAKİYE YETERSİZ


        }
    }
}
