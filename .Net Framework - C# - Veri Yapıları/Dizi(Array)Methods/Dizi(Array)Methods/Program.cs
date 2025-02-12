using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" };

            int[] sayilar = { 8, 5, 6, 4, 2, 1 };

            // Console.WriteLine(isimler[0]);
            // Console.WriteLine(isimler[1]);
            // Console.WriteLine(isimler[2]);
            // Console.WriteLine(isimler[3]);
            // Console.WriteLine(isimler[4]);

            // isimler[0] = "Volkan";
            // isimler.SetValue("Volkan", 0); // değer güncelleme için alternatif bir metodumuz var buradaki dışında 7 tane overloadingi var farklı versiyonlarla farklı parametreler alabiliyor. Biz bir object bir indeks numarası alan parametresine önce Volkan sonra indeks numarası girdik. Bu şekilde isimler dizinin istediğim indeksine Volkan değerini atadım o indeksteki değerin üstüne güncelledim.
            // Set ayarlamak anlamında Value ise değer. Bu Array Sınıfına ait SetValue metodu 

            // Console.WriteLine(isimler.GetValue(0)); // isimler dizisinin 0 indeksli elemanını al ve konsol satırına yaz. Bu array sınıfına ait GetValue metodu

            // Console.WriteLine(Array.IndexOf(isimler, "Volkan")); // Array sınıfının IndexOf metodu ile dizimizin elemanının kaçıncı indekste olduğunu öğreniriz. İlk parametreye dizi ismini veriyoruz sonra değeri veriyoruz.

            // Console.WriteLine(isimler.Length); // Length özelliği ile dizinin uzunluğunu görürüz bize dizinin kaç elemanlı olduğunu gösterebilen bir özellik.

            // Array.Sort(isimler); // İsimler dizisindeki string elemanlar, alfabetik sıraya sıralanır. Bu metodu kullandığımızda isimler dizisini alfabetik sıraya sokar ve indekslerdeki elamanları bu sıraya göre değiştirir.
            // Console.WriteLine(isimler.GetValue(0)); // 0. indeksteki eleman Volkan değil Ada oldu artık alfabetik olarak sıralanmış oldu.

            // Array.Sort(sayılar); // Sort düzenleme veya sıralama olarak çevrilebilir.
            // Console.WriteLine(sayılar.GetValue(0)); // Artık 0. indeksinde 1 var küçükten büyüğe sıralayıp düzenlemesini istediğim için diziyi.

            // Array.Reverse(isimler); // Dizi elemanlarının en son sıralanışını tamamen tersine çevirir.son eleman ilk ilk indeksteki eleman son indeksteki eleman olur. reverse ters demektir bu metod elemanların sırasının tam tersine çevirir ve yeni sıralama yapmış olur.
            // Console.WriteLine(isimler.GetValue(0));

            // Array.Reverse(sayılar);
            // Console.WriteLine(sayılar.GetValue(0));

            // Array.Clear(isimler, 1, 3); // Dizinin istenen bölgesini temizleyip sıfırlar. Sıfırlanan indeksler null(boş) değere sahip olur.
            // Silinen eleman yerine null değer atanır çünkü string nullable yani boş bırakılabilir veri yapısıdır.

            // for (int i = 0; i < isimler.Length; i++)
            // {
            //     Console.WriteLine(isimler[i]);
            // }

            // Array.Clear(sayilar, 0, 6); // Tanımlanan int nullable olmadığı için silinen elemanlar yerine 0 atanır. 0 olarak default bir şekilde set edilmiş oluyor.

            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     Console.WriteLine(sayilar[i]);
            // }

            // var result = isimler[1..3]; // Aralık işleci c# 7.3'te kullanılmıyormuş
            
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("----------");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(isimler[i]);
            }
        }
    }
}
