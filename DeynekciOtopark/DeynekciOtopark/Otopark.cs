using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeynekciOtopark
{
    internal class Otopark
    {
        public string[] araclarim;
        public DateTime[] girisSaatleri;

        Random rnd = new Random();

        int girisUcreti = 50;
        int saatlikUcret = 35;

        public Otopark()
        {
            araclarim = new string[0];
            girisSaatleri = new DateTime[0];
        }

        public void aracEkle(string plaka, DateTime aracGirisSaati)
        {
            string[] geciciAraclarim = new string[araclarim.Length + 1];
            DateTime[] geciciGirisSaatleri = new DateTime[girisSaatleri.Length + 1];

            for (int i = 0; i < araclarim.Length; i++)
            {
                geciciAraclarim[i] = araclarim[i];
                geciciGirisSaatleri[i] = girisSaatleri[i];
            }

            geciciGirisSaatleri[girisSaatleri.Length] = aracGirisSaati;
            geciciAraclarim[geciciAraclarim.Length - 1] = plaka;
            araclarim = geciciAraclarim;
            girisSaatleri = geciciGirisSaatleri;
        }

        public DateTime aracGirisSaatiOlustur() 
        {
            int randomSaat = rnd.Next(1, 11);

            DateTime aracGirisSaati = DateTime.Now.AddHours(-randomSaat);

            return aracGirisSaati;
        }

        public void Listele() 
        {
            Console.WriteLine("Plaka\t\tGiriş Saati\tÇıkış Saati\tToplam Tutar");
            for (int i = 0; i < araclarim.Length; i++)
            {
                int toplamSaat = DateTime.Now.Hour - girisSaatleri[i].Hour;
                int toplamTutar = girisUcreti + (saatlikUcret * toplamSaat);

                string plaka = araclarim[i];
                string girisSaati = girisSaatleri[i].Hour.ToString() + ":" + girisSaatleri[i].Minute.ToString();
                string cikisSaati = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                Console.WriteLine("{0}   \t{1}\t\t{2}\t\t{3} TL", plaka, girisSaati, cikisSaati, toplamTutar);
            }
        }

        public void menuYazdir() 
        {
            Console.WriteLine("[1] Araçları Listele");
            Console.WriteLine("[2] Araç Ekle");
            Console.WriteLine("[3] Programı Kapat");
        }


    }
}
