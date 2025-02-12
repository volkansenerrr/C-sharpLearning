using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoldanVeriAlmaOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("ibm857");

            #region Çok Basit Hesap Makinesi

            //Console.WriteLine("Lütfen birinci sayıyı giriniz (:");//Birinci sayıyı iste
            //double sayi1 = Convert.ToDouble(Console.ReadLine());//Birinci sayıyı al sayısal veri tipinde değere dönüştür aynı veri tipinde değişkenin içine aktar
            //Console.WriteLine("---------------------------------");//Writeline metodu en basit haliyle ekrana yazı yazdırmaya yarar.

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz (:");//İkinci sayıyı iste
            //double sayi2 = Convert.ToDouble(Console.ReadLine());//İkinci sayıyı konsoldan al sayısal veri tipinde değere dönüştür aynı veri tipinde değişkenin içine ata
            //Console.WriteLine("---------------------------------");

            //double toplam = sayi1 + sayi2;
            //Console.WriteLine("Toplam = " + toplam);
            //Console.WriteLine("---------------------------------");

            //double fark = sayi1 - sayi2;
            //Console.WriteLine("Fark = " + fark);
            //Console.WriteLine("---------------------------------");
            //                                                          //İki girdiyi tüm matematiksel işlemlerde kullanıp sonuçları ekrana yazdırıp çıktısını verdim
            //double carpım = sayi1 * sayi2;
            //Console.WriteLine("Çarpım = " + carpım);
            //Console.WriteLine("---------------------------------");

            //double bolum = sayi1 / sayi2;
            //Console.WriteLine("Bölüm = " + bolum);
            //Console.WriteLine("---------------------------------");

            //double kalan = sayi1 % sayi2;
            //Console.WriteLine("Kalan = " + kalan);
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Çıkmak için bir tuşa basınız (:");
            //Console.ReadKey(); //kullanıcı bir tuşa basana ve uygulama sonlandırana veya ek bir bilgi penceresi görüntüleyene kadar program yürütmeyi durdurmaktır
            #endregion

            #region Konsoldan alınan sayı pozitif mi ?

            //Pozitif ise true değilse false sonucunu yazdırsın 

            //Console.WriteLine("Lütfen bir sayı giriniz (:");
            //double sayi = Convert.ToDouble(Console.ReadLine());

            //bool sonuc = sayi > 0;
            //Console.WriteLine(sonuc);

            #endregion

            #region Konsoldan alınan sayı 100'den küçük mü ?

            //100'den küçük ise true değilse false yazdıralım konsol ekranına

            //Console.WriteLine("Lütfen bir sayı giriniz (:");
            //double sayi = Convert.ToDouble(Console.ReadLine());

            //bool sonuc = sayi < 100;
            //Console.WriteLine(sonuc);

            #endregion

            #region Konsoldan sayı çift mi ?

            //Alınan sayı çift ise true değilse false yazdıralım

            //Console.WriteLine("Lütfen bir sayı giriniz (:");
            //double sayi = Convert.ToDouble(Console.ReadLine());

            //double kalan = sayi % 2;
            //bool sonuc = kalan == 0; //bir "true" ya da "false" (doğru - yanlış) sorusunun yanıtı olan mantıksal bir niceliği simgeler.

            //Console.WriteLine("Sayı çift mi = " + sonuc);
            #endregion

            #region Konsoldan alınan iki notun ortalamasını yazdırınız

            //Console.WriteLine("Lütfen vize notunuzu giriniz");
            //int vizeNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen final notunuzu giriniz");
            //int finalNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Not ortalamanız = " + (vizeNot + finalNot)/2);

            #endregion

            #region Konsoldan alınan üç notun ortalamasını yazdırınız

            //Console.WriteLine("Lütfen birinci notunuzu giriniz");
            //int birinciNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci notunuzu giriniz");
            //int ikinciNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen üçüncü notunuzu giriniz");
            //int ucuncuNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Not ortalamanız = " + (birinciNot+ikinciNot+ucuncuNot)/3);

            #endregion

            #region Konsoldan kısa ve uzun kenar alınan dikdörtgenin alanını hesaplayınız

            //Console.WriteLine("Dikdörtgenin uzun kenarını giriniz");
            //int uzunKenar = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Dikdötrgenin kısa kenarını giriniz");
            //int kısaKenar = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Dikdötrgenin alanı = " + (uzunKenar * kısaKenar));

            #endregion

            #region Konsoldan iki sayı al alınan sayıların toplam,fark,çarpım,bölüm ve mod sonuçlarını yazdır

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = sayi1 + sayi2;
            //Console.WriteLine("Toplam = " + toplam);

            //double fark = sayi1 - sayi2;
            //Console.WriteLine("Fark = " + fark);

            //double carpım = sayi1 * sayi2;
            //Console.WriteLine("Çarpım = " + carpım);

            //double bolum = sayi1 / sayi2;
            //Console.WriteLine("Bölüm = " + bolum);

            //double mod = sayi2 % sayi2;
            //Console.WriteLine("Kalan = " + mod);

            #endregion

            #region İki sayı al 1. sayı 2. sayıdan büyük mü küçük mü durumlarını yazdır

            //Console.WriteLine("Lütfen 1. Sayıyı giriniz");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sayıyı giriniz");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //bool buyukmuKucukmu = sayi1 > sayi2;
            //Console.WriteLine("Sonuç = " + buyukmuKucukmu);

            #endregion

            #region Üçgenin alanı yazdır

            //Console.WriteLine("Lütfen Üçgenin taban uzunluğunu giriniz");
            //double tabanUzunlugu = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Şimdi Üçgenin yükseklik uzunluğunu giriniz");
            //double yukseklikUzunluğu = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Üçgenin alanı = " + (tabanUzunlugu * yukseklikUzunluğu)/2);

            #endregion

            #region Dairenin alanı yazdır

            //Console.WriteLine("Lütfen dairenizin yarıçapını giriniz");
            //double yariCap = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Dairenin alanı = " + (Math.PI * (yariCap * yariCap)));
            //Programlama dillerinde Pi sayısı gibi sabitler framework içerisinde sabit olarak zaten bulunmaktadır ve değiştirilemeden kullanılabilirler.
            //Math.PI 3,14 olarak başlan pi değerinin ilk 15 basamağının çıktısını bizlere verir.
            // C# programlama dilinde de pi sabiti double veri tipinde bir sabittir ve Math.PI ile çağırılarak gerekli
            // yerlerde (dairenin alanının ya da çevresinin hesaplanması gibi) kullanılabilir.
            #endregion

            #region Final notunun ortalaması vize %40 final %60

            //Console.WriteLine("Lütfen vize notunuzu giriniz");
            //double vizeNot = Convert.ToDouble(Console.ReadLine());

            //double vizeNotyuzdeKirk = (vizeNot * 40) / 100;

            //Console.WriteLine("Lütfen final notunuzu giriniz");
            //double finalNot = Convert.ToDouble(Console.ReadLine());

            //double finalNotyuzdeAltmis = (finalNot * 60) / 100;

            //Console.WriteLine("Not Ortalaması = " + (vizeNotyuzdeKirk + finalNotyuzdeAltmis) / 2);


            #endregion

            #region Final notunun ortalaması vize %40 final %60 ortalama 0 ile 100 arasında mı ?

            //Console.WriteLine("Lütfen Vize notunuzu giriniz");
            //double vizeNot = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen Final notunuzu giriniz");
            //double finalNot = Convert.ToDouble(Console.ReadLine());

            //double vizeNotyuzdeKırk = (vizeNot * 40) / 100;
            //double finalNotyuzdeAltmis = (finalNot * 60) / 100;

            //double ortalama = (vizeNotyuzdeKırk + finalNotyuzdeAltmis) / 2;

            //bool sifirİleyuzArasindami = 0 < ortalama && ortalama < 100;

            //Console.WriteLine("Ortalama 0 ile 100 arasında mı : " + sifirİleyuzArasindami);

            #endregion

        }
    }
}
