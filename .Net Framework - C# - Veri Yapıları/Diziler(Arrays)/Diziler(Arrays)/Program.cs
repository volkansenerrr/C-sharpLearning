using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello There, My Name is Volkan Şener";

            var result = msg.Split(); // Split metodunun yaptığı string ifadeyi boşluk karakterlerinden bölerek her bir karakter kümesini ya da kelimeyi bir dizi içerisine atıyor.Result sonuç olarak çevrilebilir.
            // ve dizi içerisinden her bir elemana ulaşmak için bir tane indeks numarası veriliyor.

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
            Console.WriteLine(result[3]);
            Console.WriteLine(result[4]);
            Console.WriteLine(result[5]);
            Console.WriteLine(result[6]);

            // Hatırlarsak string bir ifade de bir karakter dizisidir.

            Console.WriteLine(msg[0]);
            Console.WriteLine(msg[1]);
            Console.WriteLine(msg[2]);
            Console.WriteLine(msg[3]);
            Console.WriteLine(msg[4]);

            // C#'da diziler (arrays), aynı türden birden fazla değeri varsayılan indeks numaralarıyla saklamak için kullanılan veri yapılarıdır.

            // string ad = "Volkan";
            // string ad2 = "Murtaza";

            string[] isimler = new string[5];
            isimler[0] = "Volkan";
            isimler[1] = "Ahmet";
            isimler[2] = "Sezgin";
            isimler[3] = "Özer";
            isimler[4] = "Cankuş";

            int[] numaralar = new int[5];
            numaralar[0] = 1;
            numaralar[1] = 2;
            numaralar[2] = 3;
            numaralar[3] = 4;
            numaralar[4] = 5;

            Console.WriteLine($"Öğrenci adı : {isimler[0]} ve numarası : {numaralar[0]}");

            string[] isimler2 = { "Volkan", "Ahmet", "Sezgin", "Özer", "Cankuş" }; // Bu şekilde eleman sayısı belirtmeden direk elemanlarımızı dizi içerisine atayabiliriz. 

            int[] numaralar2 = { 0, 1, 2, 3, 4, 5 }; // Yine aynı şekilde eleman sayısı belirtmeden direk elemanlarımızı atayabiliriz. Süslü veya kıvırcık parantezler içerisine girilen değerler otomatik olarak varsayılan indekslere atanır.

        }
    }
}
