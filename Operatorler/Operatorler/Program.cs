using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetik Operatörler

            // Aritmetik matematiğin sayılar arasındaki ilişkiler ile sayıların problem çözmede kullanımı ile ilgilenen dalı. 
            // Programlama dillerinde tek başlarına herhangi bir anlamı olmayan ancak programın işleyişine katkıda bulunan karakter ya da karakter topluluklarına operatör denir.

            // = Atama Operatörü
            // + Toplama Operatörü (Sayısal ifadeler)
            // + Birleştirme Operatörü (Metinsel ifadeler)
            // - Çıkartma Operatörü
            // * Çarpma Operatörü
            // / Bölme Operatörü
            // % Mod alma Operatörü // Kalan bulmaya yarar. Bir sayının tam olarak bölünüp bölünmediğini kontrol ederiz. Bir sayının tek mi çift mi olduğunu kontrol ederiz.
            // -- Azaltma Operatörü // Değeri bir azaltır
            // ++ Arttırma Operatörü // Değeri bir arttırır

            double mustakbelYas = 30;
            double simdikiYas = 29;

            Console.WriteLine("Yaşlı kurdun müstakbel yaşıyla şimdiki yaşının toplamı = " + (mustakbelYas + simdikiYas));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Yaşlı kurdun müstakbel yaşıyla şimdiki yaşının arasındaki fark = " + (mustakbelYas - simdikiYas));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Yaşlı kurdun müstakbel yaşıyla şimdiki yaşının çarpımı = " + (mustakbelYas * simdikiYas));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Yaşlı kurdun müstakbel yaşıyla şimdiki yaşının bölümü = " + (mustakbelYas / simdikiYas));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Yaşlı kurdun müstakbel yaşının şimdiki yaşına bölümünden kalan = " + (mustakbelYas % simdikiYas));
            Console.WriteLine("------------------------------------");

            mustakbelYas--;
            Console.WriteLine(mustakbelYas);
            Console.WriteLine("------------------------------------");

            simdikiYas++;
            Console.WriteLine(simdikiYas);
            Console.WriteLine("------------------------------------");

            // İŞLEM ÖNCELİK SIRASI KURALLARI
            // Önce parantezler sırayla, varsa üslü ifadeler, çarpma ve bölme, en son toplama ve çıkarma işlemleri yapılır.

            #endregion

            #region Karşılaştırma Operatörleri

            // Program içindeki ifadelerin karşılaştırılması için kullanılır.
            // Karşılaştırma ifadelerin sonucu ya TRUE (doğru) ya da FALSE (yanlış) olur.
            // Üçüncü bir ihtimal yoktur.

            // > Büyük mü
            // < Küçük mü
            // == Eşit mi
            // != Eşit değil mi ya da farklı mı 
            // >= Büyük veya eşit mi
            // <= Küçük veya eşit mi

            #endregion

            #region Mantıksal Operatörler

            // Birden fazla karşılaştırma ifadesini birleştirmek için kullanılır.

            // && ve (and) Operatörü
            // Birden fazla karşılaştırma ifadesinin hepsinin doğru olması durumunda True sonucunu verir. Şartların bir tanesinin yanlış olması
            // durumunda False sonucunu verir.

            // || veya (or) Operatörü
            // Birden fazla koşuldan bir tanesinin doğru olması durumunda True sonucunu verir. Şartların tümünün yanlış olması durumunda
            // False sonucunu verir.

            // ! değil Operatörü
            // True ifadesini False, False ifadesini True yapar. İşlemi tersine çevirir.

            bool b = true;
            Console.WriteLine(!b); // false olarak çıktı alırız.

            #endregion

            #region Ek Operatörler

            // += artı eşittir operatörü // sağdaki değeri alıp soldaki değere ekle değişkene ata
            // -= eksi eşittir operatörü // soldaki değerden soldaki değeri çıkart değişkene ata
            // /= bölü eşittir operatörü // soldaki değeri sağdaki değere böl sonucu tekrar değişkene ata
            // *= çarpı eşittir operatörü // soldaki değerle sağdaki değeri çarp değişkene ata

            int sayi1 = 30;
            sayi1 += 100; // sayi1 = sayi1 + 100
            Console.WriteLine("Sonuç = " + sayi1);
            Console.WriteLine("---------------------");

            int sayi2 = 29;
            sayi2 -= 1;
            Console.WriteLine("Sonuç = " + sayi2);
            Console.WriteLine("---------------------");

            int sayi3 = 30;
            sayi3 /= 2;
            Console.WriteLine("Sonuç = " + sayi3);
            Console.WriteLine("---------------------");

            int sayi4 = 30;
            sayi4 *= 2;
            Console.WriteLine("Sonuç = " + sayi4);

            #endregion

            Console.ReadLine(); // Programın kapatılmaması için bekletme
        }
    }
}
