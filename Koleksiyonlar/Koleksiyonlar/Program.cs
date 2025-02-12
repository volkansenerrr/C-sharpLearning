using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            //using System.Collections içerisinde bulunur.

            ArrayList liste = new ArrayList();

            liste.Add("Doğa");
            liste.Add("Dilara");
            liste.Add("Mustafa");
            liste.Add("Volkan");
            liste.Add("Nasuh");

            Console.WriteLine("Eleman Sayısı = " + liste.Count);
            Console.WriteLine("Kapasite = " + liste.Capacity);

            liste.TrimToSize();//Dizide açılmış olan kullanılmayan yerleri sil
            Console.WriteLine("Eleman Sayısı = " + liste.Count);
            Console.WriteLine("Kapasite = " + liste.Capacity);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");

            liste.Insert(2, "Berk");
            //liste[3] = "Murtaza";

            Insan ins = new Insan();
            ins.Isim = "Murtaza";
            ins.Soyisim = "Şuayipoğlu";

            liste.Add("Berk");

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].GetType() == typeof(Insan))
                {
                    Insan veri = (Insan)liste[i];
                    Console.WriteLine(veri.Isim + " " + veri.Soyisim);
                }
                else
                {
                    Console.WriteLine(liste[i]);
                }
            }
            Console.WriteLine("-*-*-*-*-*-*-3. İndexteki eleman-*-*-*-*-*-*");

            Console.WriteLine(liste[3]);

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Veri kaçıncı indexte " + liste.IndexOf("Berk"));
            Console.WriteLine("En son kaçıncı indexte " + liste.LastIndexOf("Berk"));

            liste.Remove("Berk");// İlk denk gelen veriyi siler
            liste.RemoveAt(5);

            //liste.Reverse();
            //liste.RemoveRange(2, 3);

            liste.Sort();

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");


            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }






            #endregion
        }
    }
    class Insan 
    { 
        public string Isim { get; set; }
        public string Soyisim { get; set; }
    }
}
