using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region ve #endregion önceden tanımlanmış kod bloklarını gruplamak için kullanılan özel bir C# özelliğidir.
            // Bu özellik, kodunuzu daha düzenli ve anlaşılır hale getirmenize yardımcı olabilir.

            #region Değişken tanımı

            // Değişkenler RAM üzerinde veri tutmaya yarayan araçlardır
            // RAM (Random Access Memory - Rastgele Erişimli Bellek), bilgisayarlardaki veriler için hızlı erişim ve geçici veri depolama sağlar.

            #endregion

            #region C# ile değişken nasıl tanımlanır ?

            // Değişkenin veri tipi  -   değişken adı   -   atama operatörü(=)  -  ilk veri  -   satır kapama(;)
            // örnek : int Murtaza = 30;

            #endregion

            // Tam Sayı Değişkenleri ---> byte, short, int, long

            #region byte

            // byte 0 ile 255 sayıları dahil ve arasında ki verileri tutabilen bir veri tipidir.
            // RAM bellekte 8 bitlik(1 Byte) yer kaplar.
            // Bitten sonra ki ikinci en küçük bilgisayar bellek ölçü birimidir.

            byte byteSayi = 0;
            byte byteSayi2 = 255;
            Console.WriteLine("İlk sayı = " + byteSayi + " İkinci sayi = " + byteSayi2);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Byte veri tipinde bir değişken 0 ile 255 sayıları ve arasındaki değerleri alabilir.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("RAM bellekte 8 bitlik yer kaplar.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Byte veri tipinde bir değişkenin alabileceği maksimum değer = " + byte.MaxValue);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Byte veri tipinde bir değişkenin alabileceği minimum değer = " + byte.MinValue);

            // MaxValue veri türlerinin property'si (özellik) veri tipinin alabileceği maksimum değeri gösterir.
            // MinValue minimum değeri gösterir.

            #endregion

            #region short

            // short veri tipinde bir değişken RAM bellekte 16 bitlik(2 Byte) yer kaplar.
            // int ve long veri tiplerine göre RAM bellekte daha az yer kaplarlar ve aldıkları değer aralıkları küçüktür.
            // short veri tipinde bir değişken -32768 ile 32767 arasında değerleri alabilir.

            short maxDeger = short.MaxValue;
            short minDeger = short.MinValue;

            Console.WriteLine("short veri tipinde bir değişkenin alabileceği maksimum değer = " + maxDeger);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("short veri tipinde bir değişkenin alabileceği minimum değer = " + minDeger);
            Console.WriteLine("----------------------------------");

            short yas = 29;
            short ikiMayistaGirecegiYas = 30;

            Console.WriteLine("Şu anki yaşım = " + yas);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("2 Mayıs'ta gireceğim yaşım = " + ikiMayistaGirecegiYas);

            #endregion

            #region int

            // int veri tipinde bir değişken RAM bellekte 4 byte(32 bit) yer kaplar.
            // int veri tipindeki bir değişken -2147483648 ile 2147483647 arasında değerleri alabilir.

            int ugurluSayi = 7;
            int hesaptakiPara = 0;

            Console.WriteLine("Uğurlu sayım = " + ugurluSayi);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hesaptaki param = " + hesaptakiPara);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("int veri tipinde bir değişkenin alabileceği maksimum değer = " + int.MaxValue);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("int veri tipinde bir değişkenin alabileceği minimum değer = " + int.MinValue);

            #endregion

            #region long

            // long veri tipide tamsayıları tanımlamak için kullanılan bir veri tipidir.
            // RAM bellekte 64 bit(8 byte) yer kaplar.

            long tckimlikNo = 12446866096;
            Console.WriteLine("TC Kimlik Numaram = " + tckimlikNo);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("long veri tipinde bir değişkenin alabileceği maksimum değer = " + long.MaxValue);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("long veri tipinde bir değişkenin alabileceği minimum değer = " + long.MinValue);
            Console.WriteLine("------------------------------------");

            // Console.WriteLine("Lütfen TC Kimlik Numaranızı giriniz");
            // long tckimlikNo = Convert.ToInt64(Console.ReadLine());
            // Console.WriteLine("T.C Kimlik Numaranız = " + tckimlikNo);

            #endregion

            // Ondalık Değişkenler ---> float, double, decimal

            #region float 

            // float veri tipinde değişkenler RAM bellekte 32 bitlik(4 byte) yer kaplar.
            // float ondalikliSayi = 30.5; // hata alırız çünkü float değişkeni tanımladık 30.5 sayısının sonuna F veya f koyarak float türünün float olduğunu belirtmemiz gerekmektedir. Sebebi C# ortamında noktalı sayıların varsayılan(default) değeri double'dır. double değerini float dönüştürmek için f koyarız.

            // 30.5f;

            float fltondalikliSayi = 29.30f;
            Console.WriteLine(fltondalikliSayi);

            Console.WriteLine("float veri tipinde bir değişken " + float.MaxValue + " ve " + float.MinValue + " arasında değerleri alabilir.");

            #endregion

            #region double

            // Yüksek duyarlıklı ve hassas matematiksel işlemlerde kullanılır.
            // Ondalıklı sayıları tanımlamak için kullanılır.
            // RAM bellekte 64 bit(8 byte) yer kaplar.
            // float veri tipinde bir değişkenden 2 kat daha fazla RAM bellekte yer kaplar.

            double ondalikliSayi = 1.70;
            Console.WriteLine(ondalikliSayi);

            Console.WriteLine("double veri tipinde bir değişkenin alabileceği maksimum değer = " + double.MaxValue);
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("double veri tipinde bir değişkenin alabileceği minimum değer = " + double.MinValue);
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("double veri tipinde bir değişkenin alacağı değerler " + double.MaxValue + " ile " + double.MinValue + " arasındadır.");

            #endregion

            #region decimal

            // RAM bellekte 128 bitlik(16 byte) yer kaplar.
            // decimal veri tipinde bir değişken tanımladığımızda eğer içerisine tam sayı olmayan bir değer atamak istediğimizde sayısının sonuna M veya m koyarak türünün decimal olduğunu belirtmemiz gerekmektedir. Bunun sebebi C# ortamında noktalı sayıların varsayılan değeri double'dır. Biz virgüllü bir sayıyı decimal olarak tanımladığımızı sonuna gerekli eklemeyi yaparak belirtiriz.

            decimal dcmondalikliSayi = 30.29m;
            Console.WriteLine(dcmondalikliSayi);

            Console.WriteLine("decimal türündeki bir değişkenin alabileceği değerler " + decimal.MinValue + " ve " + decimal.MaxValue + " arasındadır.");

            #endregion

            // Metinsel Değişkenler --> char, string

            #region char

            // Sadece tek karakter değerlerini tutmak istersek kullandığımız veri türüdür.
            // Char veri türü 16 bit uzunluğunda Unicode standartlarında karakterlerin karşılıklarını tutan veri tipidir.
            // Her bir karakterin Unicode standartları çerçevesinde bir karşılığı bulunmaktadır ve char tipinde değişken değer atandıktan sonra bir karakteri temsil etmektedir.
            // Tek tırnak içerisinde tek değer alacak şekilde kullanılır.
            // *, ?, !, u, ı, Ş klavye üzerinde görülen tek bir karakteri tutmak için kullanmış olduğumuz veri tipidir.

            char harf1 = 'V'; // Doğrudan karakter atayabiliriz.
            Console.WriteLine("Reisin isminin baş harfi : " + harf1);

            char harf2 = (char)55; // ASCII sayısal karşılığından char türüne dönüşüm yapabiliriz. 55 sayısının char (karakter) karşılığını tut harf2 değişkenine ata.
            Console.WriteLine(harf2);

            #endregion

            #region string

            // Metinsel değerleri tutabilmek için string veri türünü kullanırız.
            // Değeri çift tırnak içerisinde yazmamız gerekir.
            // string değişken olarak tanımlansa da aslında bir karakter dizisidir.

            string slogan = "Don't worry be happy.";
            Console.WriteLine(slogan);

            #endregion

            // Karar Değişkeni ---> bool

            #region Karar Değişkeni

            // Boolean veri tipi iki tane ihtimalin olduğu yerde kullanılan bir veri tipidir.
            // Volkan bugün ders çalıştı mı? Bu sorunun iki cevabı vardır: evet çalıştı, hayır çalışmadı.
            // Kullanıcı adını soyadını girdi mi? True = Doğru, False = Yanlış
            // Tekrarlarsak Boolean veri tipi bool diye yazılır. Bool veri tipinde bir değişken sadece true ve false değerlerini tutar.
            // Boolean veri tipi, bir "true" ya da "false" (doğru - yanlış) sorusunun yanıtı olan mantıksal bir niceliği simgeler.

            bool dersAnlasiliyorMu = true;
            Console.WriteLine(dersAnlasiliyorMu);

            #endregion

            #region Değişken tanımlarken dikkat edilmesi gerekenler !

            // En çok yapılan hatalardan seçtim.
            // Rakamla başlayamazlar: int 1sayi = 5; hata alırız, geçersizdir.
            // Boşluk olmaz: int sayi degeri = 5;
            // Türkçe karakter kullanılmamalıdır: int çocukSayisi = 10; Bazı programlama dillerinde sıkıntı olmayabilir ama çoğu yerde baş ağrıtabiliyor.

            #endregion

            #region object

            // Veri tiplerinin atasıdır denilebilir. Tüm veri tiplerini tanıyan, hiçbir veri tipini ayırt etmeyen ve tüm veri tiplerinde değerleri tutabilen bir veri tipidir.

            object sayi, isim, ondalik, karar, karakter;

            sayi = 30;
            isim = "Volkan Şener";
            ondalik = 1.70;
            karar = true;
            karakter = 'V';

            Console.WriteLine(sayi);
            Console.WriteLine(isim);
            Console.WriteLine(ondalik);
            Console.WriteLine(karar);
            Console.WriteLine(karakter);

            #endregion
        }
    }
}
