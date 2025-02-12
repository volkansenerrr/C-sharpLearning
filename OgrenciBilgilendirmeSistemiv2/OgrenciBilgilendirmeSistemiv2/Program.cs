using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace OgrenciBilgilendirmeSistemiv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataModel dm = new DataModel();
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Furkan";
            ogretmen.Soyad = "Kocaoğlu";

            //if (dm.OgretmenEkle(ogretmen))
            //{
            //    Console.WriteLine("Öğretmen Adı    : "+ogretmen.Ad);
            //    Console.WriteLine("Öğretmen Soyadı : "+ ogretmen.Soyad);
            //}
            //else
            //{
            //    Console.WriteLine("Başaramadık ağbi");
            //}

            List<Ogretmen> ogretmenler = dm.OgretmenListele();

            for (int i = 0; i < ogretmenler.Count; i++)
            {
                Console.WriteLine($"Ogretmen No : {ogretmenler[i].OgretmenNo}\nAd : {ogretmenler[i].Ad}\nSoyad : {ogretmenler[i].Soyad}\n");
            }



        }
    }
}
