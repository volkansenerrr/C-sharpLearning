using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipiDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit casting otomatik dönüşüm (automatically): smaller type to larger
            // explicit casting açık veya bilinçli dönüşüm (manually): larger type to smaller

            /*
             Veri tipi dönüşümü (type casting), bir veri türünün başka bir veri türüne dönüştürülmesidir. C# programlama dilinde veri tipi dönüşümü, genellikle iki ana şekilde gerçekleştirilir: oto dönüşüm (implicit conversion) ve açık dönüşüm (explicit conversion).

             1. Oto Dönüşüm (Implicit Casting)
             Oto dönüşüm, veri kaybı olmadan, daha küçük bir veri türünden daha büyük bir veri türüne dönüşüm yapıldığında otomatik olarak gerçekleştirilir. Bu dönüşüm türü, genellikle dil tarafından otomatik olarak yapılır ve programcı tarafından herhangi bir özel işlem gerektirmez.
             
             Örnek:
             csharp
             Kodu kopyala  
             int myInt = 123;
             double myDouble = myInt; // Oto dönüşüm: int -> double
             Console.WriteLine(myDouble); // Çıktı: 123.0
             Bu örnekte, int türündeki bir değişken, double türüne otomatik olarak dönüştürülür. Bu işlem, veri kaybı yaşanmadan gerçekleşir.
             
             2. Açık Dönüşüm (Explicit Casting)
             Açık dönüşüm, bir veri türünden başka bir veri türüne dönüşüm yaparken, veri kaybı veya hassasiyet kaybı riski olduğunda kullanılır. Bu tür dönüşümler, genellikle programcı tarafından açıkça belirtilmelidir ve cast (dönüşüm) işlemi gerektirir.
             
             Örnek:
             csharp
             Kodu kopyala
             double myDouble = 123.45;
             int myInt = (int)myDouble; // Açık dönüşüm: double -> int
             Console.WriteLine(myInt); // Çıktı: 123 (45 kesildi)
             Bu örnekte, double türündeki bir değişken, int türüne dönüştürülürken kesilme (truncation) gerçekleşir, çünkü int türü ondalıklı kısmı tutmaz.
             
             Veri Tipleri ve Dönüşümler
             Sayısal Veri Türleri
             Küçükten büyüğe: byte -> short -> int -> long -> float -> double
             Büyükten küçüğe: double -> float -> long -> int -> short -> byte
             csharp
             Kodu kopyala
             int i = 100;
             double d = i; // Oto dönüşüm
             
             double bigDouble = 1.23456789;
             int truncatedInt = (int)bigDouble; // Açık dönüşüm (ondalık kısmı kaybolur)
             Karakter ve String Dönüşümleri
             char -> int: Bir karakterin ASCII kodunu almak için kullanılır.
             int -> char: Bir ASCII kodunu karaktere dönüştürmek için kullanılır.
             csharp
             Kodu kopyala
             char c = 'A';
             int asciiCode = (int)c; // Oto dönüşüm: char -> int
             Console.WriteLine(asciiCode); // Çıktı: 65
             
             int code = 66;
             char letter = (char)code; // Açık dönüşüm: int -> char
             Console.WriteLine(letter); // Çıktı: B
             string Dönüşümleri
             string -> sayısal türler: int.Parse, double.Parse gibi yöntemler kullanılabilir.
             Sayısal türler -> string: ToString() metodu kullanılabilir.
             csharp
             Kodu kopyala
             string numberString = "123";
             int number = int.Parse(numberString); // string -> int
             
             int anotherNumber = 456;
             string anotherString = anotherNumber.ToString(); // int -> string
             Özelleştirilmiş Dönüşümler
             Kendi özel sınıflarınız varsa, dönüşüm işlemlerini özelleştirmek için dönüşüm operatörleri (implicit ve explicit) tanımlayabilirsiniz.
             
             csharp
             Kodu kopyala
             public class MyClass
             {
                 public int Value { get; set; }
                 
                 // Oto dönüşüm
                 public static implicit operator MyClass(int value)
                 {
                     return new MyClass { Value = value };
                 }
             
                 // Açık dönüşüm
                 public static explicit operator int(MyClass myClass)
                 {
                     return myClass.Value;
                 }
             }
             
             MyClass myObj = 10; // int -> MyClass (implicit)
             int myInt = (int)myObj; // MyClass -> int (explicit)
             Özet
             Oto dönüşüm (implicit conversion): Veri kaybı olmadan yapılan dönüşümler, genellikle otomatik olarak gerçekleşir.
             Açık dönüşüm (explicit conversion): Veri kaybı veya hassasiyet kaybı riski olan dönüşümler, programcı tarafından açıkça belirtilmelidir.
             Veri tipi dönüşümleri, farklı veri türleri arasında geçiş yaparken doğru ve güvenli sonuçlar almak için önemlidir.
             */

            // Özetle

            // implicit conversion otomatik üstü kapalı bir dönüşüm veri kaybı olmadan otomatik gerçekleşebilen veri dönüşümünü ifade eder.
            // Küçükten büyüğe: byte -> short -> int -> long -> float -> double --> bu şekilde yapılacak bir veri tipi dönüşümü otomatik gerçekleşir.

            // byte bytSayi = 100;

            // short shrtSayi = bytSayi;

            // Console.WriteLine($"{shrtSayi} sayısının veri tipi = {shrtSayi.GetType()}"); // görüldüğü üzere system.int8 değil 100 değeri system.int16 yani short veri tipinde.


            // explicit conversion açık veya bilinçli dönüşümleri veri kaybı riski taşıyabilir bu yüzden programcının onayıyla dönüşüm yapılır.
            // Büyükten küçüğe: double -> float -> long -> int -> short -> byte bu şekilde veri kaybı göz önünde bulundurularak bilinçli explicit dönüşüm yapabiliriz.

            // Birde açık dönüşümlerde yani explicit conversion içerinde Formatlı Dönüşümler vardır 
            // Bunlar bir veri tipini başka bir veri tipine (genellikle string veri tipine) dönüştürürken belirli bir format(biçim) belirtildiği durumlardır. Bu tür dönüşümler, her zaman kodda açıkça belirtilmelidir.

            // Örneğin ToString() metodu Herhangi bir veri tipini string veri tipine dönüştürmek için kullanılır
            // Türü: Bu bir açık dönüşüm (explicit conversion) yöntemidir ve her türden değişkenin string formatına çevrilmesini sağlar.

            // int sayi = 30;

            // string strSayi = sayi.ToString(); 

            // Console.WriteLine(strSayi);
            // Console.WriteLine(sayi.ToString());

            // Convert.ToInt32() Metodu Convert Sınıfının diğer veri tipleri içinde metodları mevcuttur
            // Ne Yapar?: Bir dizeyi veya başka bir türden veriyi int veri tipine dönüştürür.
            // Türü: Bu da bir açık dönüşümdür, çünkü dönüşüm sırasında veri kaybı veya hata olasılığı vardır, bu nedenle açıkça belirtilmelidir.

            // string sayiString = "64587567854645535164"; // İşlenmeyen Özel Durum: System.OverflowException yani taşma istisnası hatası değer bir int32 --> int için çok büyük hatası alınır.
            // int sayi = Convert.ToInt32(sayiString);

            // Console.WriteLine(sayi);

            // string strSayi = "30";
            // int intSayi = int.Parse(strSayi);
            // Console.WriteLine(intSayi);

            // int.Parse() Metodu
            // Ne Yapar ?: Sadece string bir değeri int veri tipine dönüştürür.

            // string age = "30";
            // int intAge = int.Parse(age);

            // Console.WriteLine(intAge);

            // int sayi = 45;
            // string strSayi = Convert.ToString(sayi);
            // Console.WriteLine(strSayi);

            //double dblSayi = 355.12;

            //long longSayi = (long)dblSayi;


            //Console.WriteLine($"{longSayi} sayısının veri tipi {longSayi.GetType()}"); // burada görüldüğü gibi ondalıklı sayının virgülden sonrasını aldı tamsayı kısmını aldı.Ondalıklı sayıyı tamsayıya çevirdi.Veri kaybı yaşandı.


            //Console.Write("Bir sayı gir : "); 
            //int Sayi = int.Parse(Console.ReadLine());

            //Console.Write("Bir sayı daha gir : ");
            //int Sayi2 = int.Parse(Console.ReadLine());

            //int toplam = Sayi + Sayi2;

            // Console.WriteLine("Birleştirme : " + birlestirme); Bu şekilde yazdırma işlemi yapabiliriz.

            //Console.WriteLine($"Kullanıcıdan alınan sayıları topladım ve sonuç = {toplam}"); // Ya da başına dolar işareti koyup String Interpolation (Dizi yerleştirme) şeklinde çıktısını almak istediğimiz şeyleri metodumuza yerleştirebiliriz.

            // string isim = "Volkan";
            // Console.WriteLine($"Benim adım {isim} ismimin uzunluğu {isim.Length}"); // string metin veri tipi olsa da aynı zamanda bir karakter dizisiydi.Burada ismimin uzunluğu ismimin kaç karakterden oluştuğunu bize söylüyor bir başka ifadeyle ismimin karakter eleman sayısı.

            //int intSayi = 3254658;
            //byte bytSayi = (byte)intSayi;

            //Console.WriteLine(bytSayi);

            // string nullString = null;
            // int nullInt = Convert.ToInt32(nullString); // int.Parse metoduyla çevirmeye çalıştığımızda hata fırlattı
            // Console.WriteLine(nullInt);


            Console.Write("Kısa kenarı gir : ");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uzun kenarı gir : ");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());

            var alan = kisaKenar * uzunKenar;

            var cevre = (kisaKenar + uzunKenar) * 2;

            Console.Clear();

            Console.WriteLine($"Dikdörtgenin alanı = {alan}m2 çevresi = {cevre}");

            Console.Beep(37, 37000);

            // Interpolation (Türkçesiyle Ara Değerleme ya da İç İçe Yerleştirme),
            // C#'ta bir string içerisinde değişkenlerin ya da ifadelerin kolayca kullanılmasını sağlayan bir tekniktir.
            // Interpolation, $ sembolü ile başlatılan bir string ifadesi içinde {} parantezleri kullanılarak gerçekleştirilir.
            // Neden Kullanılır?
            // String birleştirme işlemlerini daha okunabilir ve kullanışlı hale getirmek için kullanılır.
            // Daha az hata riski taşır ve kodun daha temiz görünmesini sağlar.

            // C# dilinde var Keyword'ü yani anahtar kelimesi, bir değişkenin türünü açıkça belirtmek yerine, derleyicinin değişkenin türünü atanan değere göre otomatik olarak belirlemesine olanak tanır.
            // var kullanarak değişken tanımlarken, değişkenin türü atanan değerin türüne göre belirlenir ve bu tür, derleme zamanı sırasında belirlenir.

            // var sayi = 31;
               
            // var metin = "Salam Dünya";
               
            // var ondalik = 30.21;
               
            // var karar = true;
               
            // var fltOndalik = 25.1f;
               
            // var dcmOndalik = 22554.41m;

            // var karakter = 'V';

            
            // Breakpoint ekleyerek programı adım adım takip edebiliriz. Bir hatamız vardır hatamızın nerede olduğunu bilemiyoruzdur Breakpoint ile hatamızı bulmamız kolaylaşır.  
            
        }
    }
}
