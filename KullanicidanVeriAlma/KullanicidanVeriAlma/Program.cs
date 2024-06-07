using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanVeriAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öncelikle kullanıcıya çıktı verip veri istenir.
            // Sonra Console sınıfının ReadLine fonksiyonunu kullanarak kullanıcıdan değer alırız. Console.ReadLine();
            // Kullanıcıdan alınan değer her zaman string (metinsel) veri tipindedir.
            // Gerektiğinde tür dönüşümü yapılması gerekir.

            Console.WriteLine("Lütfen adınızı ve soyadınızı giriniz :"); // Kullanıcıdan veri iste.
            string adSoyad = Console.ReadLine(); // ReadLine metoduyla veriyi al ve veri hangi veri tipindeyse o veri tipinde
                                                 // tanımladığımız değişkenin içerisine ata.
            Console.WriteLine("---------------------------");
            //Console.WriteLine("Merhaba " + adSoyad + " (:");
            Console.WriteLine($"Merhaba {adSoyad} (:"); // Dolar karakteri kullanarak bu şekilde de yazılabilir.
            Console.WriteLine("---------------------------");
        }
    }
}
