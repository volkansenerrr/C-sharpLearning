using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngüler (loops), programlama dillerinde belirli bir kod bloğunu veya komutları belirli bir koşul veya kriter sağlanana kadar tekrar tekrar çalıştırmak için kullanılan yapısal öğelerdir.
            // Döngüler, program içinde aynı veya benzer işlemleri tekrarlamak ve tekrar eden işlemleri otomatikleştirmek için kullanılır.
            // 4 tane döngü çeşidimiz vardır. for, while, do while, foreach.

            // En basitinden siz 1'den 10'a kadar sayıları yazdıracaksınız farz edelim.Teker teker yazdırıp çıktı verebilirsiniz.Peki 1000'e kadar yazdıracak olsanız ?
            // İşte bu noktada döngü yapılarını kullanırız.

            #region for

            // En temel haliyle while döngüsündeki yapıyı toparlamak için kullanılır
            // Parantezler içerisinde 3 adımdan oluşuyor 
            // birincisi başlangıç değişkeni tanımlamak ve başlangıç değerini atamak
            // İkincisi koşulumuzu belirtmek 
            // üçüncüsü bu döngümüz artsın mı azalsınmı onu belirlemek 
            // ikinci adımdaki koşul sağlandığı sürece for döngümüz blokları çalışır

            // 1'den 10'a kadar olan sayıları alt alta ekrana yazdıran programı kodlayınız..

            // for (int i = 2; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //  1'den 10'a kadar olan sayılardan çift olanları ekrana yazdırmak istiyorum 

            // for (int i = 2; i < 10; i+=2)
            // {
            //     Console.WriteLine(i);
            // }

            //  1 ile 10 arasında ki sayılardan tek olanları ekrana yazdıralım

            // for (int i = 3; i < 10; i+=2)
            // {
            //     Console.WriteLine(i);
            // }

            // i(local variable)(yerel değişken) :
            // yerel : belirli bir yere özgü, bir yere bağlı, dar sınırlı, yayılmamış, bir yerle ilgili olan.

            // 0 - 100 sayıları yazdırınız

            // for (int i = 1; i < 100; i++)
            // {
            //     Console.WriteLine(i);
            // }


            // 0 ile 100 arasındaki çift sayıları yazdırın

            // for (int i = 2; i < 100; i+=2)
            // {
            //     Console.WriteLine(i);
            // }

            // 0 - 100 arasında 5'e bölünebilen kaç sayı var?

            // 5 sayısına bölünebilme kuralı: Bir sayının son rakamı 5 ve 0 ise 5'e tam bölünür 

            // int adet;

            // adet = 0;

            // for (int i = 5; i < 100; i += 5)
            // {
            //     adet++;
            // }

            // Console.WriteLine("0 ile 100 arasında 5'e bölünebilen " + adet + " sayı vardır.");


            // 0 - 100 arasında 2'ye bölünebilen kaç sayı var?

            // Bir sayının 2'ye bölümünden kalan 0 ise bu sayı 2'ye tam bölünür.

            // int adet;

            // adet = 0;

            // for (int i = 2; i < 100; i+=2)
            // {
            //     adet++;
            // }

            // Console.WriteLine("0 ile 100 arasında 2'ye tam bölünebilen " + adet + " sayı vardır.");


            // 0 - 100 arasında 2'e bölünebilen kaç sayı var? //Başka şekilde

            // int kalan, adet;

            // adet = 0;

            // for (int i = 2; i < 100; i++)
            // {
            //     kalan = i % 2;
            //     if (kalan == 0) 
            //     {
            //         adet++;
            //     }
            // }
            // Console.WriteLine("0 ile 100 arasında 2'ye tam bölünebilen " + adet + " sayı vardır.");


            // 0 - 100 arasında 5'e bölünebilen kaç sayı var?

            // int kalan, adet;

            // adet = 0;

            // for (int i = 5; i < 100; i++)
            // {
            //     kalan = i % 5;
            //     if (kalan == 0)
            //     {
            //         adet++;
            //     }
            // }

            // Console.WriteLine("0 ile 100 arasında 5'e tam bölünebilen " + adet + " sayı vardır");



            // Konsola 20 kere adınızı yazdırınız

            // for (int i = 0; i < 20; i++)
            // {
            //     Console.WriteLine("VOLKAN (:");
            // }


            // Çarpım tablosunun 7'ler basamağını yazdırınız

            // int sabitSayi;

            // sabitSayi = 7;

            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine((sabitSayi + " X " + i) + " = " + (sabitSayi * i));
            // }



            // Çarpım Tablosunun konsoldan alınan basamağını yazdırınız

            // int basamak;

            // Console.WriteLine("Lütfen çarpım tablosundan görmek istediğiniz basamağı yazınız");
            // basamak = Convert.ToInt32(Console.ReadLine());

            // if (1 <= basamak && basamak <= 10)
            // {
            //    for (int i = 1; i <= 10; i++)
            //    {
            //         Console.WriteLine(basamak + " x " + i + " = " + (basamak * i));
            //    }
            // }
            // else
            // {
            //     Console.WriteLine("Geçerli bir basamak değeri giriniz");
            // }

            //  Girilen bir ifadeyi 10 defa yazmasını sağlayan programı yazınız.

            // string dümenden;

            // Console.WriteLine("İstediğin bir şeyi yazabilirsin moruk 10 defa çıktısını vereceğim sana.");
            // dümenden = Console.ReadLine();

            // Console.WriteLine("-----------------------------------------------------------------------------");

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(dümenden);
            // }
            // Console.WriteLine("-----------------------------------------------------------------------------");

            // while ile yapalım 

            // string dümenden;
            // int baslangiDegeri;

            // Console.WriteLine("İstediğin bir şeyi yazabilirsin moruk 10 defa çıktısını vereceğim sana.");
            // dümenden = Console.ReadLine();

            // baslangiDegeri = 1;

            // Console.WriteLine("----------------------------------------");

            // while (baslangiDegeri <= 10) 
            // {
            //     Console.WriteLine(dümenden);
            //     baslangiDegeri++;
            // }
            // Console.WriteLine("-----------------------------------------");


            // Klavyeden girilen 10 tane sayıyı toplayan programı yazınız.

            // double sayi, toplam;

            // toplam = 0;

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Sayı giriniz.");
            //     sayi = Convert.ToDouble(Console.ReadLine());
            //     toplam += sayi;
            // }

            // Console.WriteLine("Toplam = " + toplam);



            // örnek iç içe for döngüsü kullanmak

            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= i; j++) 
            //     {
            //         Console.Write(j);
            //     }
            //     Console.WriteLine(" ");
            // }

            // Ekrana yan yana 10 defa Yıldız (*) yazdırılmak istenirse

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write("*");
            // }


            // Ekrana alt alta 10 defa Yıldız (*) yazdırılmak istenirse

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("*");
            // }

            // Yukarıdaki örneklerde birinde yan yana diğerinde alt alta yazdırılmıştır.
            // ilk satırda bir , sonraki satırda iki şeklinde her satırda bir artırarak yapılmak istenirse iç içe döngü kullanılmalıdır.

            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= i; j++) //içerdeki for döngüsünün başlangıç değeri değişmiyor en dıştaki ana döngünün başlangıç değeri değişiyor.Anlaşılan içteki Döngünün koşulu false sonucunu verdiğinde dış döngüye takılıp tekrar bu döngüye takıldığında çalışmaya baştan başlıyor  
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine(" ");
            // }

            // Girilen sayının mükemmel sayı olup olmadığını bulan programı yazınız.
            // Mükemmel sayı kendisi hariç pozitif tam bölenlerinin toplamı, sayının kendisine eşit olan sayıya denir.
            // Örneğin 28 sayısının pozitif tam bölenlerinin toplamı: 1+2+4+7+14=28
            // 6 da mükemmel sayıdır 1,2,3

            // int kullaniciGirdigiSayi, pozitifTamBolenleriToplami, kalan;

            // Console.WriteLine("Girdiğin sayının mükemmel sayı olup olmadığını sana gösterecek programı yazacağım.");
            // Console.WriteLine("-----------------------------------------");

            // Console.WriteLine("Sayı gir bakalım (:");
            // kullaniciGirdigiSayi = Convert.ToInt32(Console.ReadLine());

            // pozitifTamBolenleriToplami = 0;

            // for (int i = 1; i < kullaniciGirdigiSayi; i++)
            // {
            //     kalan = kullaniciGirdigiSayi % i;
            //     if (kalan == 0) 
            //     {
            //         pozitifTamBolenleriToplami += i;
            //     }
            // }
            // if (pozitifTamBolenleriToplami == kullaniciGirdigiSayi) 
            // {
            //     Console.WriteLine("Sayınız mükemmel sayıdır.");
            // }
            // else
            // {
            //     Console.WriteLine("Sayınız mükemmel sayı değildir.");
            // }

            // 5'e kadar olan çarpım tablosunu ekrana yazdırınız

            // 1 x 1 = 1
            // ..
            // ..

            // for (int i = 1; i < 5; i++)
            // {
            //     for (int j = 1; j <= 10; j++)
            //     {
            //         Console.WriteLine(i + " x " + j + " = " + (i * j));
            //     }
            // }




            // tekrar yapalım üstteki örneklerimden 

            // 1
            // 12
            // 123
            // .
            // .
            // .
            // 1234567910

            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= i; j++) 
            //     {
            //         Console.Write(j);
            //     }
            //     Console.WriteLine(" ");
            // }



            // Girilen sayının faktöriyelini hesaplayan programı yaz.
            // 1'den başlayarak belirli bir sayma sayısına kadar olan sayıların çarpımına o sayının faktöriyeli denir.
            // 1x2*3*4*5=5!

            // int sayi, carpim;

            // Console.WriteLine("Sayı girde faktöriyelini hesaplayayım sana göstereyim moruk.");
            // Console.WriteLine("Gir bakalım.");
            // sayi = Convert.ToInt32(Console.ReadLine());

            // carpim = 1;

            // for (int i = 1; i <= sayi; i++)
            // {
            //     carpim *= i;
            // }

            // Console.WriteLine(sayi + "!" + " = " + carpim);





            // Girilen 10 adet sayının kaç tanesinin pozitif kaç tanesinin negatif olduğunu bulan program

            // int kullaniciAlinanSayi, pozitifSayiAdet, negatifSayiAdet;

            // pozitifSayiAdet = 0;

            // negatifSayiAdet = 0;

            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine("Lütfen sayı giriniz.");
            //     kullaniciAlinanSayi = Convert.ToInt32(Console.ReadLine());

            //     if (kullaniciAlinanSayi > 0)
            //     {
            //         pozitifSayiAdet++;
            //     }
            //     else if (kullaniciAlinanSayi < 0) 
            //     {
            //         negatifSayiAdet++;
            //     }
            // }

            // Console.WriteLine("Girdiğin negatif sayı adedi = " + negatifSayiAdet);

            // Console.WriteLine("Girdiğin pozitif sayı adedi = " + pozitifSayiAdet);

            // Bu projemizde çarpım tablosu yapacağız for döngüsüyle
            // int girilenBasamakDegeri, basamakSayisi;

            // Console.WriteLine("Çarpım tablosunda görüntülemek istediğiniz basamağı giriniz.");
            // girilenBasamakDegeri = Convert.ToInt32(Console.ReadLine());

            // if (1 <= girilenBasamakDegeri && girilenBasamakDegeri <= 10)
            // {
            //     for (int carpan = 1; carpan <= 10; carpan++) 
            //     {
            //         Console.WriteLine(girilenBasamakDegeri + " X " + carpan + " = " + (girilenBasamakDegeri * carpan));
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Geçerli bir değer girmediniz.");
            // }


            // Konsoldan veri almadan tamamını yazdıralım yazdıralım

            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(" ");
            //     for (int j = 1; j <= 10; j++) 
            //     {
            //         Console.WriteLine(i + " X " + j + " = " + (i*j));
            //     }
            // }

            #region WhatIsMatrix?

            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.BackgroundColor = ConsoleColor.Black;

            // for (int i = 0; i < int.MaxValue; i++)
            // {
            //     Console.Write(i);
            // }

            #endregion

            // Kullanıcının girdiği metni kullanıcının istediği sayı kadar ekrana yazdıran program

            // string kullanicininGirdigiMetin;
            // int istenenAdet;

            // Console.WriteLine("Yazdırmak istediğiniz metni giriniz");
            // kullanicininGirdigiMetin = Console.ReadLine();

            // Console.WriteLine("Bu metni kaç defa ekrana yazdırayım ?");
            // istenenAdet = Convert.ToInt32(Console.ReadLine());

            // if (istenenAdet > 0)
            // {
            //     for (int i = 0; i < istenenAdet; i++)
            //     {
            //         Console.WriteLine(kullanicininGirdigiMetin);
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("-12322 gibi saçma sapan değer girdin galiba dostum geçerli bir değer gir canımı sıkma!!!!");
            // }



            // Konsoldan alınan 2 sayı arasındaki tüm sayıları yazdırın
            // double birinciSayi, ikinciSayi;

            // Console.WriteLine("İlk gireceğiniz sayı ikinci sayıdan küçük olacak!");

            // Console.WriteLine("Lütfen bir sayı girer misin ?");
            // birinciSayi = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Aferin, şimdi bir sayı daha gir");
            // ikinciSayi = Convert.ToDouble(Console.ReadLine());

            // if (birinciSayi < ikinciSayi) 
            // {

            //     birinciSayi++;
            //     Console.WriteLine("-------------------------------------------------------------");

            //     for (double i = birinciSayi; i < ikinciSayi; i++) 
            //     {
            //         Console.WriteLine(i);
            //     }
            //     Console.WriteLine("--------------------------------------------------------------");
            // }
            // else
            // {
            //     Console.WriteLine("Birader ilk girdiğin sayı ikinci girdiğin sayıdan küçük olacak tekrar dene !");
            // }


            // Konsoldan alınan 5 sayının tek ve çift toplamlarını yazdırınız

            // double sayi, kalan, tekSayilarinToplami, ciftSayilarinToplami;

            // tekSayilarinToplami = 0;

            // ciftSayilarinToplami = 0;

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Lütfen bir sayı giriniz");
            //     sayi = Convert.ToDouble(Console.ReadLine());

            //     kalan = sayi % 2;

            //     if (kalan == 0)
            //     {
            //         ciftSayilarinToplami += sayi;
            //     }
            //     else
            //     {
            //         tekSayilarinToplami += sayi;
            //     }
            // }

            // Console.WriteLine("Girilen sayılardan çift olanlarının toplamı = " + ciftSayilarinToplami);
            // Console.WriteLine("-----------------------------------------------------------");
            // Console.WriteLine("Girilen sayılardan tek olanlarının toplamı = " + tekSayilarinToplami);



            // TEKRAR YAPALIM 

            // Kullanıcının girdiği metni kullanıcının istediği sayı kadar ekrana yazdıran program

            // string kullanicininGirdigimetin;
            // int adet;

            // Console.WriteLine("Yazdırmak istediğiniz metni yazınız ?");
            // kullanicininGirdigimetin = Console.ReadLine();

            // Console.WriteLine("Bu metni ekrana kaç kez yazdırmak istersiniz ?");
            // adet = Convert.ToInt32(Console.ReadLine());

            // if (adet > 0)
            // {
            //     for (int i = 0; i < adet; i++)
            //     {
            //         Console.WriteLine(kullanicininGirdigimetin);
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            // }

            // while sırasında anlamında
            // if eğer anlamında

            // Konsoldan alınan 2 sayı arasındaki tüm sayıları yazdırın

            // int sayi1, sayi2;

            // Console.WriteLine("Senin seçeceğin iki sayı arasında ki sayıları yazdıracağım..");
            // Console.WriteLine("Birinci gireceğin sayı ikinci gireceğinden büyük olacak ayık ol.");

            // Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            // sayi1 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            // sayi2 = Convert.ToInt32(Console.ReadLine());

            // if (sayi1 > sayi2)
            // {
            //     sayi2++;
            //     for (int i = sayi2; i < sayi1; i++)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Geçerli bir değer gir.");
            // }


            // Konsoldan alınan 5 sayının tek ve çift toplamlarını yazdırınız. for Döngü yapısını kullanarak !

            // int sayi, kalan, girilenCiftSayilarinToplami, girilenTekSayilarinToplami;

            // girilenCiftSayilarinToplami = 0;
            // girilenTekSayilarinToplami = 0;

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Lütfen bir sayı giriniz.");
            //     sayi = Convert.ToInt32(Console.ReadLine());

            //     kalan = sayi % 2;

            //     if (kalan == 0)
            //     {
            //         girilenCiftSayilarinToplami += sayi;
            //     }
            //     else if (kalan != 0) 
            //     {
            //         girilenTekSayilarinToplami += sayi;
            //     }
            // }

            // Console.WriteLine("Girmiş olduğun 5 sayıdan çift olanlarının toplamı = " + girilenCiftSayilarinToplami);
            // Console.WriteLine("--------------------------------------------------");
            // Console.WriteLine("Girmiş olduğun 5 sayıdan tek olanlarının toplamı = " + girilenTekSayilarinToplami);



            // a - z arasındaki karakterleri yazınız

            // American Standard Code for Information Interchange(ASCII) Türkçesi Bilgi Değişimi İçin Amerikan Standart Kodlama Sistemi

            // char karakter;

            // for (int i = 97; i <= 122; i++)
            // {
            //     karakter = (char)i; // i değişkeni içinde ki değeri char karşılığına çevir karakter değişkenine ata
            //     Console.Write(karakter + " ");
            // }



            // Konsoldan alınan karakter büyük mü? küçükmü?

            // char girilenKarakter;
            // int karakterSayiKarsiligi;

            // Console.WriteLine("Girdiğin karakterin büyük harfli bir karakter mi yoksa büyük harfli mi olduğunu kontrol edeceğim.");

            // Console.WriteLine("Lütfen istediğiniz harfi yazınız.");
            // girilenKarakter = Convert.ToChar(Console.ReadLine());

            // karakterSayiKarsiligi = (int)girilenKarakter;

            // if (65 <= karakterSayiKarsiligi && karakterSayiKarsiligi <= 90)
            // {
            //     Console.WriteLine("Kullanıcının girdiği harf büyük harftir.");
            // }
            // else if (97 <= karakterSayiKarsiligi && karakterSayiKarsiligi <= 122) 
            // {
            //     Console.WriteLine("Kullanıcının girdiği harf küçük harftir.");
            // }
            // else
            // {
            //     Console.WriteLine("Yanlış değer girdiniz, lütfen istenen değeri giriniz.");
            // }


            // Konsoldan alınan karakter eğer büyük ise küçük halini yazdırınız

            // Console.WriteLine("Bir karakter gir.");
            // char karakter = Convert.ToChar(Console.ReadLine());

            // int karakterinSayisalKarsiligi = (int)karakter;

            // if (karakterinSayisalKarsiligi >= 97 && karakterinSayisalKarsiligi <= 122)
            // {
            //     char buyukHarfHali = (char)(karakterinSayisalKarsiligi - 32);
            //     Console.WriteLine("Girdiğin karakterin büyük hali = " + buyukHarfHali);
            // }
            // else if (karakterinSayisalKarsiligi >= 65 && karakterinSayisalKarsiligi <= 90)
            // {
            //     char kucukHarfHali = (char)(karakterinSayisalKarsiligi + 32);
            //     Console.WriteLine("Girdiğin karakterin küçük hali = " + kucukHarfHali);
            // }
            // else
            // {
            //     Console.WriteLine("Harf dışında karakter girdin.");
            // }



            // İsminizin karakterklerini tek-tek alarak isiminizi yazdırın.

            // Volkan
            // int karakterSayisi;
            // char karakter;
            // string birlesmisKarakter, strkarakter;

            // birlesmisKarakter = "";

            // Console.WriteLine("İsminiz kaç karakterli ?");
            // karakterSayisi = Convert.ToInt32(Console.ReadLine());

            // for (int i = 0; i < karakterSayisi; i++)
            // {
            //     Console.WriteLine("İsminizin harfini giriniz.");
            //     karakter = Convert.ToChar(Console.ReadLine());
            //     strkarakter = Convert.ToString(karakter);
            //     birlesmisKarakter += strkarakter;
            // }
            // Console.WriteLine("----------------------");
            // Console.WriteLine(birlesmisKarakter);
            // Console.WriteLine("----------------------");




            // 21 ye kadar olan fibonaççi dizisini yazınız BURAYA TEKRAR DÖNÜLECEK 
            // Bir sayının kendisinden önceki sayıyla toplanması sonucu kendisinden sonra ki sayıyı vermesine denir 
            // 0 1 1 2 3 5 8 13 21
            // int ilkSayi = 0;

            // int ikinciSayi = 1;

            // Console.WriteLine("Fibonacci serisi : ");
            // Console.Write(ilkSayi + " " + ikinciSayi + " ");

            // for (int i = 2; i < 9; i++)
            // {
            //     int sonrakiSayi = ilkSayi + ikinciSayi;
            //     Console.Write(sonrakiSayi + " ");
            //     ilkSayi = ikinciSayi;
            //     ikinciSayi = sonrakiSayi;
            // }

            // İki karenin alanının toplamı

            // double kenarUzunlugu, alan, alanToplam;

            // alanToplam = 0;

            // for (int i = 0; i < 2; i++)
            // {
            //     Console.WriteLine("Karenin kenar uzunluğunu giriniz.");
            //     kenarUzunlugu = Convert.ToDouble(Console.ReadLine());
            //     alan = kenarUzunlugu * kenarUzunlugu;
            //     alanToplam += alan;
            // }

            // Console.WriteLine("İki karenin alanının toplamı = " + alanToplam);


            // KONSOLDAN ALINAN İKİ SAYI ARASINDAKİ TEK SAYILARIN ORTALAMASINI BULDURUN

            // int birinciSayi, ikinciSayi, kalan, tekSayiToplam, tekSayilarinAdedi;

            // Console.WriteLine("Birinci sayıyı giriniz.");
            // birinciSayi = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("İkinci sayıyı giriniz.");
            // ikinciSayi = Convert.ToInt32(Console.ReadLine());

            // tekSayiToplam = 0;
            // tekSayilarinAdedi = 0;

            // if (birinciSayi < ikinciSayi)
            // {
            //     birinciSayi++;
            //     for (int i = birinciSayi; birinciSayi < ikinciSayi; birinciSayi++)
            //     {
            //         kalan = birinciSayi % 2;
            //         if (kalan != 0)
            //         {
            //             tekSayiToplam += birinciSayi;
            //             tekSayilarinAdedi++;
            //         }
            //     }
            //     Console.WriteLine("Girdiğin iki sayı arasındaki tek sayıların ortalaması = " + (tekSayiToplam / tekSayilarinAdedi));
            // }
            // else
            // {
            //     Console.WriteLine("Geçersiz bir sayı girdiniz.");
            // }



            // KONSOLDAN KAÇ ADET SAYI GİRİLECEĞİNİ SORUN GİRİLEN SAYILARIN ORTALAMASINI ALDIRINIZ

            // int sayiAdet, sayi, toplam;

            // Console.WriteLine("Kaç adet sayının ortalamasını ortalamasınız almamı istiyorsun ?");
            // sayiAdet = Convert.ToInt32(Console.ReadLine());

            // toplam = 0;

            // if (sayiAdet > 0)
            // {
            //     for (int i = 0; i < sayiAdet; i++)
            //     {
            //         Console.WriteLine("Sayı giriniz");
            //         sayi = Convert.ToInt32(Console.ReadLine());
            //         toplam += sayi;
            //     }
            // }
            // Console.WriteLine("Ortalama = " + toplam / sayiAdet);

            // Fibonaççi dizisini kullanıcıdan alarak yapalım
            // Bir sayının kendisinden önceki sayıyla toplanması sonucu kendisinden sonra ki sayıyı vermesine denir 
            //  0 1 ...


            // Console.WriteLine("Kaç adet Fibonacci sayısı hesaplamak istiyorsunuz ?"); //Kullanıcıdan, kaç adet Fibonacci sayısı hesaplamak istediğini isteyeceğiz. Bu sayıyı alıp bir değişkene atayacağız.
            // int sayiAdet = Convert.ToInt32(Console.ReadLine());

            // int ilkSayi = 0;

            // int ikinciSayi = 1;

            // //Fibonacci serisini yazdırma

            // Console.WriteLine("Fibonacci serisi : ");
            // Console.Write(ilkSayi + " " + ikinciSayi + " ");

            // for (int i = 2; i < sayiAdet; i++) // başlangıç değerini 2 seçmemizin nedeni ilk iki değeri başlangıçta tanımladık 3. elemanı hesaplayarak seriye devam edebiliriz.
            // {
            //     int siradakiSayi = ilkSayi + ikinciSayi;
            //     Console.Write(siradakiSayi + " ");
            //     ilkSayi = ikinciSayi;
            //     ikinciSayi = siradakiSayi;
            // }

            //  KULLANICIDAN BİR SAYI ALACAĞIZ 0' DAN BAŞLAYIP ALDIĞIMIZ SAYIYA KADAR TOPLAYACAĞIZ VE GİRDİĞİ SAYIYI BÖLECEĞİZ EĞER ORTALAMA
            //  50' DEN BÜYÜKSE ORTALAMA 50' DEN BÜYÜKTÜR
            // DEĞİLSE ORTALAMA 50'DEN KÜÇÜKTÜR YAZDIRSIN 

            // Console.WriteLine("Lütfen bir sayı giriniz");
            // double sayi = Convert.ToDouble(Console.ReadLine());

            // double toplam = 0;

            // for (double i = 0; i < sayi; i++)
            // {
            //     toplam += i;
            // }

            // double ortalama = toplam / sayi;

            // if (ortalama > 50)
            // {
            //     Console.WriteLine("Ortalama 50'den büyüktür");
            // }
            // else
            // {
            //     Console.WriteLine("Ortalama 50'den küçüktür");
            // }

            #endregion

            #region while

            // while (true)//Koşul parantezi içerisindeki değer true olduğu sürece çalış
            // {
            //     Console.WriteLine("while Çalıştı");
            // }
            // Console.WriteLine("Koşul dışı bölge");


            // 0 - 10 arasındaki sayıları yazdıralım

            // int baslangicDegiskeni; // Başlangıç değişkenim

            // baslangiçDegiskeni = 1; // Başlangıç değerim 1 bu değeri başlangıç değişkenime atadım  

            // while (baslangiçDegiskeni < 10) // Döngüyü kıracak koşulu tanımladım
            // {
            //     Console.WriteLine(baslangiçDegiskeni);  
            //     baslangiçDegiskeni++; // İterasyon sağlamak için artış miktarı.Sonsuz bir döngü olmaması için ardışık işlem sağlayan artış miktarı. 
            // }



            // 100 - 0 arasındaki sayıları yazdıralım

            // int baslangicDegiskeni;

            // baslangiçDegiskeni = 1;

            // while (baslangiçDegiskeni < 100) 
            // {
            //     Console.WriteLine(baslangiçDegiskeni);
            //     baslangiçDegiskeni++;
            // }


            // Konsola 10 kere adımızı yazdıralım

            // int baslangicDegiskeni;

            // baslangicDegiskeni = 0; // 0 başlangıç değeri

            // while (baslangicDegiskeni < 10) //10 döngünün bitiş değeri denebilir yay parantez içindeki koşul döngüyü kırmak için gerekli ifade.
            // {
            //     Console.WriteLine("Volkan");
            //     baslangicDegiskeni++;
            // }

            // Koşul ifadesi boolean değer üretir demiştik koşul true oldukça while bloklarımın içindeki kodlar çalışır

            // 0 - 100 arası çift sayılar

            // int baslangicDegiskeni;

            // baslangicDegiskeni = 0; 

            // while (baslangicDegiskeni < 100)
            // {
            //     Console.WriteLine(baslangicDegiskeni);
            //     baslangicDegiskeni+=2;
            // }
            // Döngü tamamlandıktan sonra derleyici koşul dışı bölgeden devam eder.


            // KONSOLDAN ALINAN SAYIDAN BAŞLAYARAK 100'E KADAR OLAN ÇİFT SAYILARI YAZDIRMAK

            // Console.WriteLine("Lütfen bir sayı giriniz.");
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // Console.Clear();

            // if (sayi < 100) //Kullanıcının girdiği sayı 100 den küçükse
            // {
            //     int kalan = sayi % 2;
            //     if (kalan == 0)
            //     {
            //         sayi += 2;
            //         while (sayi < 100)
            //         {
            //             Console.WriteLine(sayi);
            //             sayi += 2;
            //         }
            //     }
            //     else
            //     {
            //         sayi += 1;
            //         while (sayi < 100)
            //         {
            //             Console.WriteLine(sayi);
            //             sayi += 2;
            //         }
            //     }
            // }

            // if (sayi > 100) //Kullanıcının girdiği sayı 100'den büyükse
            // {
            //     int kalan = sayi % 2;
            //     if (kalan == 0)
            //     {
            //         sayi -= 2;
            //         while (sayi > 100)
            //         {
            //             Console.WriteLine(sayi);
            //             sayi -= 2;
            //         }
            //     }
            //     else
            //     {
            //         sayi -= 1;
            //         while (sayi > 100)
            //         {
            //             Console.WriteLine(sayi);
            //             sayi -= 2;
            //         }
            //     }
            // }

            // KULLANICIDAN BİR KÜÇÜK SAYI BİR DE BÜYÜK SAYI ALIP ARALARINDAKİ SAYILARI YAZDIR

            // Console.WriteLine("Bir tane büyük sayı gir.");
            // double sayi1 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Bir tana küçük sayı gir.");
            // double sayi2 = Convert.ToDouble(Console.ReadLine());
            // Console.Clear();

            // if (sayi1 > sayi2)
            // {
            //     sayi1--;
            //     while (sayi1 > sayi2)
            //     {
            //         Console.WriteLine(sayi1);
            //         sayi1--;
            //     }

            // }
            // else
            // {
            //     Console.WriteLine("İstenen değer ölçüsünde değer gir.");
            // }

            // Console.WriteLine(" ");

            // Console.WriteLine("Tekrar bir tane büyük sayı gir.");
            // sayi1 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Tekrar bir tana küçük sayı gir.");
            // sayi2 = Convert.ToDouble(Console.ReadLine());
            // Console.Clear();

            // if (sayi1 > sayi2)
            // {
            //     sayi2++;
            //     while (sayi2 < sayi1)
            //     {
            //         Console.WriteLine(sayi2);
            //         sayi2++;
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("İstenen değer ölçüsünde değer gir.");
            // }

            // Konsoldan alınan 10 sayının ortalamasını yazınız

            // double sayi, toplam, baslangicDegiskeni;

            // baslangicDegiskeni = 0;

            // toplam = 0; //döngü dönerken konsoldan alınan sayılar toplam değişkeninin içindeki değerle toplanıp toplam değişkenine atanacak

            // while (baslangicDegiskeni < 10) 
            // {
            //     Console.WriteLine("Lütfen bir sayı giriniz.");
            //     sayi = Convert.ToDouble(Console.ReadLine());
            //     toplam += sayi;
            //     baslangicDegiskeni++;
            // }

            // Console.WriteLine("Ortalama = " + (toplam/10));




            // Konsoldan alınan sayıların ortalaması

            // double sayi, baslangicDegiskeni, adet, toplam;

            // baslangicDegiskeni = 0;

            // Console.WriteLine("Kaç adet sayının ortalamasını almak istiyorsunuz ?");
            // adet = Convert.ToDouble(Console.ReadLine());

            // toplam = 0;

            // while (baslangicDegiskeni < adet) 
            // {
            //     Console.WriteLine("Lütfen bir sayı giriniz.");
            //     sayi = Convert.ToDouble(Console.ReadLine());
            //     toplam += sayi;
            //     baslangicDegiskeni++;
            // }
            // Console.WriteLine("Ortalama = " + (toplam/adet));

            // 100'den 0'a kadar olan sayıların çift olanlarını büyükten küçüğe yazdırın

            // int baslangicDegiskeni;

            // baslangicDegiskeni = 98;

            // while (baslangicDegiskeni > 0)
            // {
            //     Console.WriteLine(baslangicDegiskeni);
            //     baslangicDegiskeni-=2;
            // }


            // Kullanıcı giriş sayfası uygulaması yapacağız
            // Kullanıcı adı ve şifresini doğru girerse tebrikler başarılı bir şekilde giriş yaptınız 
            // yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcı yanlış girdiği sürece döngü devam etsin 

            // string kullaniciAdi, girilenKullaniciAdi;
            // int kullaniciSifre, girilenSifre, girisHakki;

            // #region Kayıtlı Kullanıcı Bilgileri
            // kullaniciAdi = "Volkan";
            // kullaniciSifre = 2468;
            // #endregion

            // girisHakki = 3;

            // while (true)
            // {
            //     Console.WriteLine("Hoşgeldiniz..");
            //     Console.WriteLine("Kullanıcı adı :");
            //     girilenKullaniciAdi = Console.ReadLine();

            //     Console.WriteLine("Şifre :");
            //     girilenSifre = Convert.ToInt32(Console.ReadLine());

            //     if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == kullaniciSifre)
            //     {
            //         Console.WriteLine("Tebrikler, başarılı bir şekilde giriş yaptınız.");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Kullanıcı adı veya şifrenizi yanlış girdiniz, lütfen tekrar deneyiniz.");
            //         if (girisHakki > 0) 
            //         {
            //             girisHakki -= 1;
            //         }
            //         else if (girisHakki == 0)
            //         {
            //             Console.WriteLine("Giriş hakkınız dolmuştur, tekrar giriş yapamazsınız.");
            //             Console.WriteLine("Konuyla ilgili müşteri hizmetlerimizle iletişime geçebilirsiniz.");
            //             break;
            //         }

            // Kullanıcı giriş sayfası uygulaması yapacağız
            // Kullanıcı adı ve şifresini doğru girerse tebrikler başarılı bir şekilde giriş yaptınız 
            // yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcı yanlış girdiği sürece döngü devam etsin 

            // string kullaniciAdi, kullaniciSifre, girilenKullaniciAdi, girilenKullaniciSifre;
            // int girisHakki;

            // girisHakki = 2;

            // #region Kayıtlı Kullanıcı Bilgileri

            // kullaniciAdi = "volkansenersen";
            // kullaniciSifre = "volkitolki123/*-";

            // #endregion

            // Console.WriteLine("Hoşgeldiniz..");


            // while (true)
            // {

            //     Console.WriteLine("Kullanıcı adı : ");
            //     girilenKullaniciAdi = Console.ReadLine();

            //     Console.WriteLine("Şifre :");
            //     girilenKullaniciSifre = Console.ReadLine();

            //     if (girilenKullaniciAdi == kullaniciAdi && girilenKullaniciSifre == kullaniciSifre)
            //     {
            //         Console.WriteLine("Tebrikler, başarılı bir şekilde giriş yaptınız.");
            //         break;
            //     }
            //     else
            //     {

            //         Console.WriteLine("Kullanıcı adı veya şifrenizi yanlış girdiniz.");
            //         if (girisHakki > 0)
            //         {
            //             girisHakki--;
            //         }
            //         else if (girisHakki == 0)
            //         {
            //             Console.WriteLine("Giriş hakkınız dolmuştur, tekrar giriş yapamazsınız.");
            //             Console.WriteLine("Konuyla ilgili müşteri hizmetlerimizle iletişime geçebilirsiniz.");
            //             Console.WriteLine("İyi günler.");
            //             break;
            //         }
            //     }
            // }


            // Kullanıcı giriş sayfası uygulaması yapacağız
            // Kullanıcı adı ve şifresini doğru girerse tebrikler başarılı bir şekilde giriş yaptınız 
            // yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcı yanlış girdiği sürece döngü devam etsin 

            #region Kullanıcı Bilgileri

            // string kullaniciAdi = "Volkan_Crazy";
            // string kullaniciSifre = "volkitolki123/*-";

            #endregion

            // Console.WriteLine("Burası Volkanbook hoşgeldin (:");
            // Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            // Console.Write("Kullanıcı adı : ");
            // string girilenKullaniciAdi = Console.ReadLine();
            // Console.Write("Sifre : ");
            // string girilenSifre = Console.ReadLine();
            // Console.Clear();

            // int sayac = 0;
            // int girisHakki = 2;
            // while (sayac < girisHakki)
            // {
            //     if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == kullaniciSifre)
            //     {
            //         Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız (:");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Kullanıcı adı veya şifrenizi yanlış girdiniz tekrar deneyiniz.");
            //         Console.WriteLine("--------------------------------------------------------------");
            //         Console.Write("Kullanıcı adı : ");
            //         string tekrarGirilenKullaniciAdi = Console.ReadLine();
            //         Console.Write("Sifre : ");
            //         string tekrarGirilenSifre = Console.ReadLine();
            //         girisHakki--;
            //     }
            // }

            // Console.WriteLine("------------------------------------------------------------------------");

            // if (girisHakki == 0)
            // {
            //     Console.WriteLine("Hesabınız bloke olmuştur.");
            // }




            // Girilen sayının asal çarpanlarını bulan kodları yazınız.

            // Console.WriteLine("Sayı giriniz:");
            // int sayi = Convert.ToInt32(Console.ReadLine());

            // string asalCarpanlar = "";

            // if (sayi <= 1)
            // {
            //     Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            // }
            // else
            // {
            //     int bolen = 2; // Başlangıçta en küçük asal sayı olan 2'ye başlayalım

            //     while (sayi > 1)
            //     {
            //         if (sayi % bolen == 0)
            //         {
            //             // Eğer sayı, bolen'e tam olarak bölünüyorsa, bu bolen sayısı asal çarpanıdır.
            //             asalCarpanlar += bolen + " ";
            //             sayi /= bolen; // sayıyı bolen'e böl ve kalan sayıyı kontrol et
            //         }
            //         else
            //         {
            //             bolen++; // bolen'i bir arttırarak bir sonraki olası asal sayıyı dene
            //         }
            //     }

            //     Console.WriteLine("Girilen sayının asal çarpanları: " + asalCarpanlar);
            // }

            // Girilen sayının asal çarpanlarını bulan kodları yazınız.(tekrar) problemli

            // Console.WriteLine("Girdiğin sayının asal çarpanlarını bulalım..");
            // Console.WriteLine("Sayı gir bakalım.");
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // Console.Clear();

            // string asalCarpanlar = "";

            // if (sayi < 0)
            // {
            //     Console.WriteLine("Lütfen pozitif bir sayı gir.");
            // }
            // else if (sayi > 1)
            // {
            //     int bolen = 2;

            //     while (bolen < sayi)
            //     {
            //         if (sayi % bolen == 0) 
            //         {
            //             string strbolen = Convert.ToString(bolen);
            //             asalCarpanlar += strbolen + " ";
            //         }
            //         bolen++;
            //     }
            // }

            // Console.Write("Girilen sayının asal çarpanları = " + asalCarpanlar);
            // Console.ReadLine(); 

            // Girilen sayının asal çarpanlarını bulan kodları yazınız.(tekrar)

            // Console.WriteLine("Lütfen bir sayı giriniz.");
            // int sayi = Convert.ToInt32(Console.ReadLine());

            // int bolen = 2;

            // string asalCarpanlar = "";

            // while (sayi > 1)
            // {
            //     if (sayi % bolen == 0)
            //     {
            //         sayi = sayi / bolen;
            //         asalCarpanlar += bolen + " ";
            //     }
            //     else
            //     {
            //         bolen++;
            //     }

            // }
            // Console.Write("Girilen sayının asal çarpanları :" + asalCarpanlar);
            // Console.ReadLine();

            // Girilen sayının asal olup olmadığını tespit etme

            // Console.WriteLine("Lütfen bir sayı giriniz.");
            // int sayi = Convert.ToInt32(Console.ReadLine());

            // bool asalMi = true; //varsayılan olarak asal sayıyı true kabul ediyoruz.

            // if (sayi <= 1)
            // {
            //     asalMi = false;
            // }
            // else if (sayi == 2)
            // {
            //     asalMi = true;
            // }
            // else
            // {
            //     int i = 2; //başlangıç değeri

            //     while (i < sayi)
            //     {
            //         if (sayi % i == 0)
            //         {
            //             asalMi = false;
            //             break;
            //         }
            //         i++;
            //     }
            // }

            // if (asalMi)
            // {
            //     Console.WriteLine(sayi + " bir asal sayıdır.");
            // }
            // else
            // {
            //     Console.WriteLine(sayi + " bir asal sayı değildir.");
            // }

            // 10 tabanındaki bir sayıyı 2 tabanının çeviren algoritma ve akış diyagramını hazırlayınız.


            // Console.WriteLine("Girdiğin 10luk tabandaki sayıyı 2lik tabana çevireceğim..");
            // Console.WriteLine("Sayı gir.");
            // int onlukSayi = Convert.ToInt32(Console.ReadLine());

            // if (onlukSayi == 0)
            // {
            //     Console.WriteLine("İkili tabanda karşılığı: = 0");
            //     return; //Main metodunun dışına çıkıyor kodları çalıştıran derleyici.Mantık şu kullanıcının girdiği sayı 0 olursa if kıvırcık parantez içindeki kodlar çalışacak return anahtar kelimesi
            // }           //olmasa derleyici if yaşam alanının dışından devam edecekti diğer kodlara gidecekti yerinde bir kullanım oldu.
            //             //Return anahtar kelimesi türkçesi geri götürme, döndürme gibi düşünülebilir.return anahtar kelimesi bir fonksiyonun sonlandırılmasına ve fonksiyonun çağrıldığı yere götürmesini
            //             //sağlar.Kullanacağız metotlarda
            // string ikilikSayi = "";

            // while (onlukSayi > 0)
            // {
            //     int kalan = onlukSayi % 2;
            //     ikilikSayi = kalan + ikilikSayi; //her adımda önüne ekliyor
            //     onlukSayi /= 2;
            // }

            // Console.WriteLine("İkili taban karşılığı = " + ikilikSayi);

            // Klavyeden 0 sayısı girilene kadar, girilen tüm sayıları toplayan programı yazınız.

            // double sayi, toplam;

            // toplam = 0;

            // while (true)
            // {
            //     Console.WriteLine("Sayı gir bakalım.");
            //     sayi = Convert.ToDouble(Console.ReadLine());
            //     if (sayi != 0)
            //     {
            //         toplam += sayi;
            //     }
            //     else if (sayi == 0) 
            //     {
            //         break;
            //     }
            // }

            // Console.WriteLine("Toplam = " + toplam);




            // 0-100 arasında 3 'e ve 5'e tam bölünen sayıları listeleyen programı while döngüsü kullanarak programlayınız.

            // int sayi;
            // string strsayi;    
            // string uceBolunenSayilar, beseBolunenSayilar;

            // sayi = 1;

            // uceBolunenSayilar = " ";

            // beseBolunenSayilar = " ";

            // while (sayi < 100) 
            // {
            //     if (sayi % 3 == 0)
            //     {
            //         strsayi = Convert.ToString(sayi);
            //         uceBolunenSayilar += strsayi + " ";
            //     }
            //     else if (sayi % 5 == 0) 
            //     {
            //         strsayi = Convert.ToString(sayi);
            //         beseBolunenSayilar += strsayi + " ";
            //     }
            //     sayi++;
            // }

            // Console.WriteLine("0 - 100 arasında 3'e tam bölünen sayıların listesi : " + uceBolunenSayilar);

            // Console.WriteLine("0 - 100 arasında 5'e tam bölünen sayıların listesi : " + beseBolunenSayilar);


            // 1'den 10'a kadar olan sayıları while döngüsü kullanarak ekrana yazdıralım

            // int sayi;

            // sayi = 2;

            // while (sayi < 10) 
            // {
            //     Console.WriteLine(sayi);
            //     sayi++;
            // }


            // 100 'den 0'a kadar olan sayıların çift olanlarını büyükten küçüğe yazdırın.

            // int sayi, kalan;

            // sayi = 99;

            // while (sayi > 0)
            // {
            //     if (sayi % 2 == 0)
            //     {
            //         Console.WriteLine(sayi + " ");
            //     }
            //     sayi--;
            // }

            #endregion

            #region do while

            // do while döngüsünün çalışma yapısını while döngüsünden ayıran 1 fark var.
            // Derleyici yukardan geliyor do bloklarına içerisine giriyor ver orada varsa kodlarımı çalıştırıyor.Çalıştırılacak kod kalmadıktan sonra while döngüsünün
            // koşuluna geliyor koşuluma bakıyor eğer koşul true sonucunu verirse derleyici do bloklarımın içine giriyor aynı işlemi yapıyor while koşuluna tekrar geliyor
            // şartım sağlıyor mu TRUE sonucunu alırsam tekrar başa dönüyor.While döngüsünü kıracak koşulum sağlamıyorsa FALSE sonucunu verecek aynı dönüşü yapmayacak
            // do blokları içerisine tekrar girmiyor.

            // Farka gelecek olursak do while döngüsünde koşulumuz altta derleyici yukardan geliyor koşulum sağlamasa bile en az bir kez çalışıyor.
            // while döngüsünde koşul sağlamadığı müddetçe while bloklarına girip kodlarımız çalışmazdı.

            // do // yapmak anlamında
            // {

            // }while(şart) while sırasında anlamında 



            // 1'den 10'a kadar olan sayıları ekrana do while döngüsünü kullanarak yazdırınız.

            // int sayi;

            // sayi = 2;

            // do // iki kere tab basınca code builder otomatik olarak ifadeyi yazıyor.
            // {
            //     Console.WriteLine(sayi);
            //     sayi++;
            // } while (sayi < 10);



            // 1'den 100'e  kadar olan sayıların toplamını ekrana yazdırınız do while ile

            // int sayi, toplam;

            // sayi = 2;

            // toplam = 0;

            // do
            // {
            //     toplam += sayi;
            //     sayi++;
            // } while (sayi < 100);

            // Console.WriteLine(toplam);

            #endregion

            #region foreach

            // Diziler konusuna devam ediyoruz.
            // for,while ve do while döngüsünü görmüştük 
            // 4. döngümüz foreach döngüsü
            // Diziler için kullanılan bir döngü çeşididir.Diziler için kolaylık sağlar.

            // string[] isimler = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" }; // null boş demek

            // //for (int i = 0; i < isimler.Length; i++)
            // //{
            // //    Console.WriteLine(isimler[i]);
            // //}

            // foreach (string isim in isimler) //isimler dizisi collection yani koleksiyon bizim dizimiz orada collection yazsaydı dizinin ismini girecektik.in türkçede içinde demek
            // {                             //in isimler isimler dizimin içinde teker teker dön her almış olduğun değeri  isim(item) adlı değişkene ata diyorum.var kalıbı değişkenin veri tipi.string olarak tanımladım
            //     Console.WriteLine(isim);//isim değişkenimi ekrana yazdır.isim değişkeni içerisine dizideki değerler sırayla atandıkça güncellenecek her aşamada değeri yazdıracak. 
            // }
            // isimler dizisinin içine girdi baştan sırayla değeri aldı tanımladığım değişkene atadı bunu ekrana yazdır dedim ve çıktı istediğim çıktıları aldım.Döngü son değere 
            // kadar devam edip kırıldı.isim değişkeninin tutacağı değer string olduğu için değişkenin veri tipini string yaptım.

            double[] ondalikliSayilar = { 0.154, 0.45, 1.78, 89.5452, 45.475 };

            foreach (double ondalikliSayi in ondalikliSayilar) //varsayılan kalıplaşmış gelen var veri tipi en son tanımlanan dizinin veri tipinde otomatik tanımlanıyor yani local variable(yerel değişken).item ise öğe demek yani eleman
            {
                Console.WriteLine(ondalikliSayi);
            }

            #endregion
        }
    }
}
