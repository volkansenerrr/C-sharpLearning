using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_metotlar_devam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametre Alan - Geriye Değer Döndüren Metot Tanımlama
            //return anahtar kelimesi return türkçede geriye döndür demek.
            //metot sonu

            //int donenDeger = toplamaYap(6,7);

            // if (donenDeger > 10)
            // {
            //     Console.WriteLine("Değer 10'dan büyüktür.");
            // }
            // else
            // {
            //     Console.WriteLine("Değer 10'dan küçüktür.");

            // }


            string gelenIsimSoyisimDegeri = isimSoyisim("Volkan", "Şener"); //Return anahtar kelimesiyle buraya bırakılan değeri bir değişkene atayarak değeri yakaladım istediğim zaman kullanabilirim.

            Console.WriteLine(gelenIsimSoyisimDegeri);
        }

        static int toplamaYap(int sayi1, int sayi2) //static deyip void demiyoruz geriye veri döndüren veri tipini giriyoruz.int veri tipinde değer döndürsün dedim.Önceki derslerde void girmiştik void geriye değer döndürmeyen demekti.  
        { 
           int sonuc = sayi1 + sayi2;
           return sonuc;
        }

        //Şöyle çalışacak toplamaYap metoduma git birinci parametreye 6 değerini koy ikinci parametreye 7 değerini koy dedik.Sonra toplamaYap metoduma gidecek sayi1 6 sayi2 7 değeri olacak.
        //sayi1 ile sayi2 toplarsak 13 olur.13'ü al sonuç değişkenime ata dedim.Sonucum içinde 13 var.Sonra return dedim return türkçede geriye döndür demek 13 değerimi al ve geriye döndür.
        //bunu dersek şöyle yapar 13 değerimi return alacak metodun çağırıldığı yere 13 değerini bırakacak.
        //Return anahtar kelimesini şöyle düşünebiliriz.pizzacı veya kargocu gibi müşteri iki tane pizza siparişi yapıyor kargocu 2 pizzayı hazırlıyor motoruna koyuyor pizzanın sipariş 
        //verildiği yere pizzaları götürüyor.Pizzaları çağırıldığı yere götürüyor.
        //toplamaYap(6,7); gördüğümüz yer 13 değerine sahip oldu 13 değerini al metodun çağırıldığı yere bırak dedik orada 13 değeri oldu bu 13 değerimi yakaladım.

        //metodun üzerine geldiğimizde tooltipte ben geri int veri tipinde bir dönüş yapıyorum diyor void demiyor.

        //int donenDeger adında bir değişken tanımlayıp değeri yakalayabilirim.

        static string isimSoyisim(string isim, string soyisim) //static yazıp string dediğimizde ben string bir değer döneceğim demiş oluyorum.Buradaki veri tipi döndüreceğim değerin veri tipinin tanımlanması
        {
            return isim + " " + soyisim; //Burada döndüreceğim değerin veri tipiyle başta döndürmek istediğim verinin tipi aynı olmalıdır.
        }

        //Son olarak Return anahtar kelimemiz bir metodun bitişidir return anahtar kelimesinden sonra yazılabilecek kodlar çalışmaz.

        //return anahtar kelimesinin iki işlevi vardır birincisi değerleri döndürmesi 
        //ikincisi metodu bitiren anahtar kelimedir.

    }
}
