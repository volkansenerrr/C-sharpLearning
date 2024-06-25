using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacisKarakterleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               ’ – Output a Single quote 
               ” – Output a double quote
               \ – Output a Backslash
               \n – Insert a newline
               \r – Insert a carriage-return
               \t – Insert a tab
               \0 – Insert a null character
               \b – Insert a backspace
            */

            // Bu tür kaçış karakterleri(escape sequences) C# ve diğer birçok programlama dilinde metin içeriğinde özel karakterleri temsil etmek ve belirli kontroller gerçekleştirmek için kullanılır.
            // Her bir kaçış karakterinin ne anlama geldiğini ve nasıl kullanılacağını göstermek için örnekler sunabilirim.

            
            // Tek Tırnak(\')
            // Tek tırnak karakterini(') çıktıda göstermek için kullanılır.
            Console.WriteLine('\'');  // Çıktı: '

            
            
            // Çift Tırnak(\")
            // Çift tırnak karakterini(") çıktıda göstermek için kullanılır.
            Console.WriteLine("\"");  // Çıktı: "



            // Ters Bölü(\\)
            // Ters bölü(\) karakterini çıktıda göstermek için kullanılır.
            Console.WriteLine("\\");  // Çıktı: \

            
            
            // Yeni Satır(\n)
            // Yeni bir satır başlatmak için kullanılır.
            Console.WriteLine("Merhaba\nDünya");  // Çıktı: Merhaba
                                                  //        Dünya


            // Satır Başı(\r)
            // Satır başına geri dönmek için kullanılır. Genellikle \n ile birlikte kullanılır.
            Console.WriteLine("Merhaba\rDünya");  // Çıktı: Dünya



            // Tab(\t)
            // Bir sekme karakteri eklemek için kullanılır.
            Console.WriteLine("Merhaba\tDünya");  // Çıktı: Merhaba    Dünya



            // Null Karakter(\0)
            // Null karakter eklemek için kullanılır.String'in sonunu belirtmek için kullanılır.
            Console.WriteLine("Merhaba\0Dünya");  // Çıktı: Merhaba (sonrası gözükmez, çünkü null karakter sonlandırır)



            // Geri Al(\b)
            // Bir karakter geri almak için kullanılır.
            Console.WriteLine("Merhaba\bDünya");  // Çıktı: MerhabDünya (a karakteri silindi)

            Console.WriteLine("Tek tırnak: \'");
            Console.WriteLine("Çift tırnak: \"");
            Console.WriteLine("Ters bölü: \\");
            Console.WriteLine("Yeni satır:\nBu yeni satırdır.");
            Console.WriteLine("Satır başı: Merhaba\rDünya");
            Console.WriteLine("Sekme:\tBu bir sekme karakteridir.");
            Console.WriteLine("Null karakter: Merhaba\0Dünya");  // Bu çıktıda sadece "Merhaba" görünür
            Console.WriteLine("Geri al: Merhaba\bDünya");  // Bu çıktıda "MerhabDünya" görünür


            // Bu örnekler C#'ta kaçış karakterlerinin doğru kullanımını gösterir.
            // Kaçış karakterleri metin içeriğinde özel karakterler eklemek veya belirli kontroller gerçekleştirmek için kullanılır.
            // \r ve \0 karakterlerinin doğru şekilde çalışmadığı durumlar olabilir, bu nedenle kullanımına dikkat edilmelidir.
        }
    }
}
