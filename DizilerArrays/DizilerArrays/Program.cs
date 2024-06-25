using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi, aynı türden birden fazla veriyi RAM üzerinde tutmamızı sağlayan ve bu verileri belirli index numaraları ile erişmemizi mümkün kılan özel değişkenlerdir.

            // Tür Çeşitliği:

            // Diziler genellikle tek bir veri türündeki öğeleri saklarlar. Örneğin, int, string, double gibi.
            // Statik dilde, dizinin veri türü tanımlandıktan sonra değiştirilemez.
               
            // Bellek Yönetimi:
               
            // Diziler, RAM üzerinde ardışık bellek blokları kullanarak verileri saklar.
            // Bu ardışıklık, her öğeye O(1) zaman karmaşıklığı ile hızlı erişim sağlar.
               
            // Sabit Boyut:
               
            // Çoğu programlama dilinde, bir dizi oluşturulduktan sonra boyutu sabittir ve değiştirilemez.
            // Bununla birlikte, bazı dillerde dinamik diziler(örneğin, List veya ArrayList gibi) boyutlarını dinamik olarak değiştirebilir.
               
            // Indexleme:
               
            // Dizilerdeki öğeler sıfır tabanlı indeksleme kullanılarak erişilir(ilk öğe 0 indeksi ile başlar).
               
            // Kullanım Alanları:
               
            // Diziler, hızlı ve rastgele erişim gerektiğinde kullanışlıdır.
            // Matris işlemleri, istatistiksel analizler ve veri toplama gibi çeşitli uygulamalarda yaygın olarak kullanılırlar.

            #region Dizi oluşturma 1

            //int[] sayilar = new int[4]; //dizimin içindeki değişkenlere ulaşmak için index numaraları kullanıyoruz demiştik.0 dan başlar demiştik.

            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[3] = 40;

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    Console.WriteLine(sayilar[i]);
            //}     

            #endregion

            #region Dizi oluşturma 2

            //int[] sayilar = { 1, -3, 7, 9, 15, 22, 85, 90, 14 };

            //Console.WriteLine("Sayilar dizimin 4. index'indeki değer = " + sayilar[4]);

            //Console.WriteLine("Sayilar dizi kaç değişkenli bir dizi = " + sayilar.Length); 

            #endregion

            #region Dizi oluşturma 3

            //string[] morpheusDevelopers = new string[11];

            //morpheusDevelopers[0] = "Berk";
            //morpheusDevelopers[1] = "Doğa";
            //morpheusDevelopers[2] = "Deniz";
            //morpheusDevelopers[3] = "Dilara";
            //morpheusDevelopers[4] = "Semih";
            //morpheusDevelopers[5] = "Okan";
            //morpheusDevelopers[6] = "Nasuh";
            //morpheusDevelopers[7] = "Volkan";
            //morpheusDevelopers[8] = "Furkan";
            //morpheusDevelopers[9] = "Hüseyin";
            //morpheusDevelopers[10] = "Ömer";

            //Console.WriteLine("Geliştiriciler dizisinin 7. index'inde ki veri : " + morpheusDevelopers[7]);

            //for (int i = 0; i < morpheusDevelopers.Length; i++) 
            //{
            //    Console.WriteLine(morpheusDevelopers[i]);
            //}

            #endregion

            #region Örnekler

            // Kullanıcıdan 10 tane int değer alan ve şunları yapan programı yapınız.
            // 1 - Kaç adet tek, çift eleman olduğunu
            // 2 - Çift değerlerin toplamını ve tek değerlerin toplamını
            // 3 - Son olarak kontrol yapsın çift değerlerin toplamı tek değerlerin toplamından büyükse çift değerlerin toplamı büyüktür yazdırsın.
            // 4 - Tek değerlerin toplamı büyükse tek değerlerin toplamı çift değerlerin toplamından büyüktür yazdırsın.
            // 5-  Tek değerlerin toplamı çift değerlerin toplamına eşitse eşittir yazdırsın.

            //int[] sayilar = new int[10];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write("Sayı gir : ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}

            //int ciftSayiAdet = 0;
            //int ciftToplam = 0;
            //int tekSayiAdet = 0;
            //int tekToplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ciftSayiAdet++;
            //        ciftToplam += sayilar[i];
            //    }
            //    else
            //    {
            //        tekSayiAdet++;
            //        tekToplam += sayilar[i];
            //    }
            //}

            //Console.WriteLine($"Girdiğin sayılardan {ciftSayiAdet} tanesi çift sayıdır ve bunların toplamı {ciftToplam}, {tekSayiAdet} tanesi tek sayıdır bu sayıların toplamıda {tekToplam}.");


            //if (ciftToplam > tekToplam)
            //{
            //    Console.WriteLine("Çift değerlerin toplamı tek değerlerin toplamından büyüktür.");
            //}
            //else if (ciftToplam < tekToplam)
            //{
            //    Console.WriteLine("Tek değerlerin toplamı çift değerlerin toplamından büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Tek değerlerin toplamıyla çift değerlerin toplamı birbirine eşittir.");
            //}

            //int[] sayilar = { 2, -3, 7, 9, 15, -22, 85, 90, 14 };

            //sayilar dizisi içerisindeki negatif sayıları yazdırın.

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    if (sayilar[i] < 0) 
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            //sayilar dizisi içerisindeki çift sayıları yazdırın

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    if ((sayilar[i] % 2) == 0) 
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            //Dizi içerisinde ki eleman tek ise tek çift ise çift yazan program 

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if ((sayilar[i] % 2) == 1) 
            //    {
            //        Console.WriteLine(i + ". indexteki " + sayilar[i] + " sayısı tektir.");
            //    }
            //    else if ((sayilar[i] % 2) == 0) 
            //    {
            //        Console.WriteLine(i + ". indexteki " + sayilar[i] + " sayısı çifttir.");
            //    }
            //}

            //sayilar dizisi içerisindeki sayıların ortalamasını bulunuz.

            //double toplam;

            //toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++) 
            //{ 
            //   toplam += sayilar[i];
            //}
            //Console.WriteLine("Ortalama = " + toplam / sayilar.Length);

            //C# dilinde, int türündeki bir değeri double türündeki bir değişkene eklerken otomatik tür dönüşümü (implicit type conversion) gerçekleşir.
            //Bu, C# dilinin sağladığı bir özelliktir ve bu sayede int türündeki bir değeri double türünde bir değişkene eklerken herhangi bir özel dönüşüm işlemi yapmanız gerekmez.

            //sayilar dizisi içerisindeki çift sayıların ortalamasını bulunuz.

            //double ciftSayilarinToplami;
            //int adet;
            //adet = 0;
            //ciftSayilarinToplami = 0; 

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    if ((sayilar[i] % 2) == 0) 
            //    {
            //        Console.WriteLine("Sayılar dizisinin içindeki çift sayılar : " + sayilar[i]);
            //        ciftSayilarinToplami += sayilar[i];
            //        adet++;
            //    }
            //}
            // Console.WriteLine("Sayılar dizisinin içinde ki çift sayıların adedi = " + adet);
            // Console.WriteLine("Ortalama = " + (ciftSayilarinToplami / adet)); 
            // ayrıntı C# dilinde, bir double değerin bir int değere bölünmesi durumunda, sonuç otomatik olarak double türünde olur.
            // Bunun nedeni, double türünün daha geniş bir veri aralığına ve hassasiyete sahip olmasıdır.
            // Bu işlem sırasında int türündeki adet değeri otomatik olarak double türüne dönüştürülür ve bölme işlemi double olarak gerçekleştirilir.
            // dolayısıyla sonuç doubledır.

            //Dizideki en büyük sayıyı yazdırınız.

            //Şöyle düşünelim bize 5 adet sayı söylensin bize bu sayılardan hangisi en büyük sayı dediğimizde en büyük değeri söyleyerek cevaplarız refleks haline gelmiş.
            //Farketmeden hızlıca algoritma kurup cevabı veririz.Beynimiz aldığı bilgileri kıyaslar karşılaştırır ve cevabı veririz.Her seferinde söylenen
            //sayıyı öncekilerle kıyaslayıp büyük olan değeri buluruz.Programını yazarken aynı mantığı kuracağız

            //int enBuyukSayi; // her adımda karşılaştırma yapılıp güncellenecek değişkeni tanımladım

            //enBuyukSayi = sayilar[0]; // ilk sıradaki değeri başlangıç için atadım daha sonra yeni değer üzerine yazılarak güncellenecek.

            //for (int i = 0; i < sayilar.Length; i++) //Döngümün 3 kuralını for döngüsünde tanımladım
            //{
            //    if (sayilar[i] > enBuyukSayi) //sayılar dizimin i. indeksindeki değer başlangıç olarak tanımladığım en büyük sayıdan büyükse 
            //    {
            //        enBuyukSayi = sayilar[i]; //bu değeri değişkenime ata döngü devam ettikçe bu değeri koşul karşılaştıracak büyükse değişkenimin içindeki değerin üstüne yazacak güncelleyecek.
            //    }
            //}
            //Console.WriteLine(enBuyukSayi); // döngü tamamlandığında enBuyukSayi değişkenimin içerisinde mantıksal olarak dizi içerisinde ki en büyük sayı olacak.

            //Dizi içerisindeki en küçük sayıyı bulunuz

            //int enKucukSayi;

            //enKucukSayi = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    if (sayilar[i] < enKucukSayi) 
            //    {
            //        enKucukSayi = sayilar[i];
            //    }
            //}
            //Console.WriteLine(enKucukSayi);



            //sayılar dizisi içerisindeki en büyük sayı ile en küçük sayının yerini değiştiriniz

            //int[] sayilar = { 2, -3, 7, 9, 15, -22, 85, 90, 14 };

            //int enBuyukSayi, enKucukSayi, enBuyukSayiIndexNo, enKucukSayiIndexNo;

            //enBuyukSayi = sayilar[0];
            //enKucukSayi = sayilar[0];
            //enBuyukSayiIndexNo = 0;
            //enKucukSayiIndexNo = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > enBuyukSayi)
            //    {
            //        enBuyukSayi = sayilar[i];
            //        enBuyukSayiIndexNo = i;
            //    }
            //    if (sayilar[i] < enKucukSayi) 
            //    {
            //        enKucukSayi = sayilar[i];
            //        enKucukSayiIndexNo = i;
            //    }
            //}

            //sayilar[enBuyukSayiIndexNo] = enKucukSayi;
            //sayilar[enKucukSayiIndexNo] = enBuyukSayi;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write(sayilar[i] + " "); //en büyük sayı ile en küçük sayının yeri değiştirildi
            //}

            //Dizinin elemanlarını kullanıcıdan alma ve ekrana yazdırma 

            //Console.WriteLine("Dizi kaç elemanlı olsun ?");
            //int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            //int[] sayilar = new int[elemanSayisi];

            //for (int i = 0; i < elemanSayisi; i++)
            //{
            //    Console.WriteLine("Değer giriniz.");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //Console.WriteLine("Dizinin kaçıncı index'inde ki değeri görüntüleme mi istersin ?");
            //int indexNo = Convert.ToInt32(Console.ReadLine());

            //if (indexNo >= 0 && indexNo < gunler.Length)
            //{
            //    Console.WriteLine("gunler dizisinin " + indexNo + ". index'inde ki gün = " + gunler[indexNo]); 
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz indeks, lütfen dizinin geçerli bir indeksiniz girin.");
            //}

            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    if (gunler[i] == gunler[indexNo])
            //    {
            //        Console.WriteLine("gunler dizisinin " + i + ". index'inde ki gün = " + gunler[i]);
            //    }
            //}



            //string[] gunler = { "Pazartesi", "Salı", " ", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //gunler[2] = "Pazartesi";

            //Console.WriteLine(gunler[2]);

            //Dizi içerisinde bulunan 5 öğrencinin notlarına 10 puan eklenmesini sağlayan programı yazınız.

            //int[] ogrenciNot = { 20, 30, 40, 47, 90, 10 };

            //for (int i = 0; i < ogrenciNot.Length; i++)
            //{
            //    Console.WriteLine(i + ". index'teki öğrencinin güncel notu = " + (ogrenciNot[i] + 10));
            //}



            //char[] karakter = { 'V', 'O', 'L', 'K', 'A', 'N' };

            //for (int i = 0; i < karakter.Length; i++)
            //{
            //    Console.Write(karakter[i]);
            //}
            //Console.ReadLine();


            //Dizinin elemanlarını kullanıcıdan alıp yazdırma işlemini yapınız.

            //Console.WriteLine("Kaç elemanlı bir dizi tanımlamak istiyorsun moruk ?");
            //int değişkenSayisi = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //string[] isimler = new string[değişkenSayisi];

            //for (int i = 0; i < değişkenSayisi; i++)
            //{
            //    Console.WriteLine("Veri gir.");
            //    string isim = Console.ReadLine();

            //    isimler[i] = isim;
            //}
            //Console.Clear();

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //Console.WriteLine("İşlem tamamlandı güle güle moruk (:");




            //Dizinin elemanlarını kullanıcıdan alıp yazdırma işlemini yapınız.

            //int[] sayilar = new int[4];

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    Console.WriteLine("Sayilar dizimin " + i + ". index'indeki değerini giriniz :");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Clear();

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            //Kullanıcının girdiği sayı dizinin içinde var mı ? Kontrol eden varsa kaç tane olduğunu söyleyen yoksa yoktur diye uyaran programı kodlayınız.

            //int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            //int adet = 0;

            //Console.Write("Sayı giriniz :");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayi == sayilar[i])
            //    {
            //        Console.WriteLine("Girdiğiniz sayı sayilar dizisinde mevcut.Girdiğin sayı sayilar dizisinin " + i + " . index'indeki " + sayilar[i] + " değeridir.");
            //        adet++;
            //    }
            //}

            //if (adet == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı dizi içerisinde bulunamadı...");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğin sayının dizi içinde ki adedi = " + adet);
            //}
            #endregion
        }
    }
}
