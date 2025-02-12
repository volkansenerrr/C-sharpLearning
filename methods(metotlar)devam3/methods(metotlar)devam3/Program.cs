using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_metotlar_devam3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan aldığımız sayının karesini alalım eğer karesi 25'ten büyükse ;
            //Karesi 25'ten büyüktür 
            //değilse 25'ten küçüktür yazdırsın.

            //Console.Write("Lütfen bir sayı giriniz :");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sayininKaresi = sayi * sayi;

            //if (sayininKaresi > 25) 
            //{
            //    Console.WriteLine("Sayının karesi 25'ten büyüktür.");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayının karesi 25'ten küçüktür. ");
            //}

            //int kareDeger = kareAl(sayi);

            //if (kareDeger > 25)
            //{
            //    Console.WriteLine("Sayının karesi 25'ten büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayının karesi 25'ten küçüktür.");
            //}



            //Kullanıcıdan alınan sayı tek mi çift mi olduğunu bulan metot yazalım...

            //Console.Write("Lütfen bir sayı giriniz : ");
            //int kullanicidanAlinanSayi = Convert.ToInt32(Console.ReadLine());

            //tekmiCiftmiBul(kullanicidanAlinanSayi);



            //Kullanıcıdan 2 tane sayı alalım hangisi büyükse ; büyük olan sayıyı ekrana yazdıralım...

            Console.Write("Lütfen sayı giriniz : ");
            int girilenSayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen sayı daha giriniz : ");
            int girilenSayi2 = Convert.ToInt32(Console.ReadLine());

             KontrolEt(girilenSayi1, girilenSayi2);
 
        }

        static void KontrolEt(int s1, int s2) 
        {
            if (s1 > s2)
            {
                Console.WriteLine("Büyük olan sayı " + s1 + " yani 1. sayı 2. sayıdan büyüktür.");
            }
            else if (s1 < s2) 
            {
                Console.WriteLine("Büyük olan sayı " + s2 + " yani 2. sayı 1.sayıdan büyüktür.");
            }
            else
            {
                Console.WriteLine("1. sayı 2. sayıya eşittir.");
            }
        }

        static void tekmiCiftmiBul(int sayi) 
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else 
            {
                Console.WriteLine("Sayı tektir.");
            }
        }


        static int kareAl(int s) 
        {
            return s * s;
        }
        
    }
}
