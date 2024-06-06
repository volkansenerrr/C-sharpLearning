using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çift slash yorum satırı oluşturmamızı sağlar.
            // Yorum satırları, kodunuzu daha anlaşılır hale getirir.
            // Ancak, aşırı kullanılmamaları ve gereksiz bilgiler içermemeleri önemlidir, çünkü gereksiz yorumlar kodu karmaşık hale getirebilir.
            // Yorumlar, kodunuzun anlamını artırmak ve başkalarının kodunuzu daha iyi anlamasını sağlamak için kullanılmalıdır.

            #region Hello World
            // Console.WriteLine ve Console.Write metodları, konsol ekranına çıktı yazdırmak için kullanılır.
            // WriteLine, verilen metni ekrana yazdırır ve ardından bir satır atlar.
            // Write ise verilen metni ekrana yazdırır ancak bir satır atlamaz, yani bir sonraki yazılan metin aynı satırda devam eder.

            // "Hello World" metnini Console ekranına yazdırıyoruz.
            Console.WriteLine("Hello World");

            // Ayırıcı bir çizgi oluşturmak için "----------" metnini yazdırıyoruz.
            Console.WriteLine("----------");

            // "Volkan" ve "Şener" kelimelerini yan yana yazdırıyoruz.
            // Boşluk karakteri ile iki kelime arasına bir boşluk ekliyoruz.
            Console.Write("Volkan");
            Console.Write(" Şener");
            #endregion
        }
    }
}
