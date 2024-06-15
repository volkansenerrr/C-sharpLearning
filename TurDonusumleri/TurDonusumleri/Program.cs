using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tür Dönüşümleri (Type Conversion) Örnekleri
            // C# programlama dilinde tür dönüşümleri (type conversion), bir veri tipindeki değeri başka bir veri tipine dönüştürme işlemidir.
            // Bu dönüşümler bazen otomatik olarak gerçekleşirken, bazı durumlarda programcının açıkça belirtmesi gerekebilir.

            // 1. Bilinçsiz (Implicit) Tür Dönüşümleri
            // Bilinçsiz tür dönüşümleri, C# programının veri kaybı riski olmaksızın otomatik olarak gerçekleştirdiği dönüşümlerdir.
            // Bu tür dönüşümler genellikle küçük veri tiplerinden büyük veri tiplerine yapılan atamalarda görülür.

            byte byt = 29;
            int intbyt = byt; // Küçükten büyüğe doğru tür dönüşümü, otomatik olarak gerçekleştirilir

            Console.WriteLine(intbyt); // Çıktı: 29
            Console.WriteLine(intbyt.GetType()); // Çıktı: System.Int32 (int veri tipi)

            int intSayi = 52244;
            long longSayi = intSayi; // Otomatik tür dönüşümü, int değeri long değere atanabilir

            Console.WriteLine(longSayi); // Çıktı: 52244
            Console.WriteLine(longSayi.GetType()); // Çıktı: System.Int64 (long veri tipi)

            // 2. Bilinçli (Explicit) Tür Dönüşümleri
            // Bilinçli tür dönüşümleri, programcının açıkça bir ifade kullanarak bir veri tipini başka bir veri tipine dönüştürdüğü dönüşüm türleridir.
            // Bu tür dönüşümler genellikle büyük veri tiplerinden küçük veri tiplerine veya türler arası uyumsuz veri tiplerine dönüşümlerde kullanılır.

            int sayi1 = 1000;
            // short sayi2 = sayi1; // Hata: Küçükten büyüğe doğru otomatik tür dönüşümü yapılamaz

            short sayi2 = (short)sayi1; // Bilinçli tür dönüşümü ile int değeri short değere dönüştürüldü

            Console.WriteLine(sayi2); // Çıktı: 1000

            // Bilinçli tür dönüşümleri genellikle veri kaybı riski taşırlar, çünkü büyük veri tiplerinin tamamını küçük veri tiplerine sığdıramayabilirler.
            // Bu durumda dönüşüm yapılmadan önce dikkatlice değerlendirilmelidir.

            // Örneğin, int veri tipinden short veri tipine dönüşümünde değer aralığına dikkat etmek önemlidir.

            int sayi3 = 50000;
            short sayi4 = (short)sayi3; // Bilinçli tür dönüşümü ile int değeri short değere dönüştürüldü

            Console.WriteLine(sayi4); // Çıktı: -15536 (Veri kaybı riski taşır, çünkü short değer aralığı aşıldı)
            Console.WriteLine(short.MaxValue); // Çıktı: 32767 (short veri tipinin maksimum değeri)
            Console.WriteLine(short.MinValue); // Çıktı: -32768 (short veri tipinin minimum değeri)

            // 3. Tür Dönüşümleri ve Veri Güvenliği
            // Tür dönüşümleri yapılırken, veri güvenliği ve doğruluğu önemli bir konudur.
            // Büyük veri tiplerinden küçük veri tiplerine yapılan dönüşümlerde veri kaybı riski olduğundan, dikkatle yapılmalı ve gerekirse veri aralığı kontrol edilmelidir.

            // Örneğin, short veri tipine dönüştürülen bir int değerinin, short veri tipinin değer aralığını aşıp aşmadığı kontrol edilmelidir.

            int sayi5 = 50000;
            short shrtSayi = (short)sayi5; // Bilinçli tür dönüşümü ile int değeri short değere dönüştürüldü

            Console.WriteLine(shrtSayi); // Çıktı: -15536 (Veri kaybı riski taşır, çünkü short değer aralığı aşıldı)

            // 4. Uyumsuz Tür Dönüşümleri
            // Uyumsuz tür dönüşümleri, bir veri tipinin başka bir uygun veri tipine dönüştürülmesi anlamına gelir.
            // Örneğin, metin (string) bir değeri tamsayı (int) veri tipine dönüştürmek için Convert.ToInt32 metodu kullanılabilir.

            string strSayi = "10000";
            int intSayi1 = Convert.ToInt32(strSayi); // string değer int değere dönüştürüldü

            string strSayi2 = "31";
            int intSayi2 = Convert.ToInt32(strSayi2); // string değer int değere dönüştürüldü

            Console.WriteLine(intSayi + intSayi2); // Çıktı: 10031

            // Bu örnekte, kullanıcı girdisi olan string değerler, uygun bir tamsayı değerine dönüştürülerek matematiksel işlemlerde kullanıldı.

            // Tür dönüşümleri genellikle veri uyumluluğunu sağlamak ve verileri doğru şekilde işlemek için kullanılır.
            // Ancak, dikkatsizce yapılan tür dönüşümleri veri kaybına veya beklenmeyen sonuçlara neden olabilir.
            // Bu nedenle, tür dönüşümleri yapılırken dikkatli olunmalı ve gerektiğinde veri aralıkları kontrol edilmelidir.

            // Sonuç olarak, C# programlama dilinde tür dönüşümleri, veri tipleri arasında güvenli ve doğru bir şekilde veri alışverişi yapmak için önemli bir araçtır.
            // Bilinçsiz ve bilinçli tür dönüşümleri arasındaki farkları anlamak ve doğru senaryoda doğru dönüşümü seçmek, sağlam ve güvenilir programlar yazmanın temel adımlarından biridir.




        }
    }
}
