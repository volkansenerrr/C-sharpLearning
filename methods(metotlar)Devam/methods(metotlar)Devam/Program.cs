using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_metotlar_Devam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametreli metot tanımlama 
            //Parametre Alan - Geriye Değer Döndürmeyen Metot Yazma
            //Metot tanımlayacağız bu metot bizden bir parametre alacak.Geriye değer döndürmeyecek 
            //Parametrelerimi parantez() içerisine tanımlıyoruz

            toplamaYap(5,7); //hata aldık parametre değerlerini vermedin diyor.Metot tanımlayıp bizden bir parametre alıyorsa parametre değerlerini göndermek zorundayız.

            carpmaYap(5, 7, 10); //tooltip okuduğumuzda metot bizden int veri tipinde bir tane değer istiyorum diyor 5 değerimi koyduktan sonra int veri tipinde sayi2 değişkenime bir değer istiyorum diyor

            isimSoyisimYazdir("Volkan", "Şener");
        }

        static void toplamaYap(int sayi1, int sayi2) // iki adet parametre tanımladım iki şey istiyor parametre için parametrenin veri tipi ne olsun parametrenin değişkeninin adı ne olsun.Virgülle ayırıyoruz
        {                                            //sınır yok istediğimiz kadar parametre tanımlayabiliriz.
            Console.WriteLine("Gönderilen sayıların toplamı : " + (sayi1 + sayi2));
        }


        static void carpmaYap(int sayi1, int sayi2, int sayi3) //Yukardaki metottaki ilk parametredeki sayi1 ile buradaki sayi1 karışmıyor.İlerleyen derslerde anlatılacak.Ufak bir bilgi
        {                                                      //olsun yukardaki sayi1 değişkeni metodun kıvırcık parantezleri içinden yani sadece metottan erişilebilen bir değişkendir.Class seviyesinde olsaydı her yerden erişilebilirdi.
                                                               //İki metodun parametrelerinde ki değişkenler birbirlerini görmüyorlar.O yüzden aynı ismi kullanabiliyoruz.
            Console.WriteLine("Üç sayının çarpımı : " + (sayi1*sayi2*sayi3));  
        }

        static void isimSoyisimYazdir(string isim, string soyisim) 
        {
            Console.WriteLine("İsim ve Soyisim : " + isim + " " + soyisim);
        }
    }
}
