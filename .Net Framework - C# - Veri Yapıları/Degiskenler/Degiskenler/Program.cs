using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region ve #endregion önceden tanımlanmış kod bloklarını gruplamak için kullanılan özel bir C# özelliğidir.
            // Bu özellik, kodunuzu daha düzenli ve anlaşılır hale getirmenize yardımcı olabilir.
            // Derleyici bizim yazdığımız kodları çalıştıran daha detaya inersek kodların hata denetimini yapan ve çalıştırılabilir hale getiren bir yazılım aracıdır.

            #region Değişken Tanımı 

            // Değişkenler RAM üzerinde veri tutmaya yarayan araçlardır.
            // RAM (Random Access Memory - Rastgele Erişimli Bellek) bilgisayarlardaki veriler için hızlı erişim ve geçici veri depolama sağlar.

            #endregion

            #region C# programlama dili ile değişken nasıl tanımlanır ?

            // Değişken veri tipi(byte, short, int, long, float, double, decimal, string, char, bool, object) - değişken adı(isim, sayi, kontrol...)  - Atama Operatörü(=) - İlk Veri - Satır Kapama(;)

            #endregion

            #region Tam Sayı Değişkenleri

            #region byte

            // byte 0 ile 255 sayıları dahil ve arasında ki değerleri tutabilen bir veri tipidir.
            // RAM bellekte 8 bitlik(1 byte) yer kaplar.

            // byte bytSayi = 30;

            // byte bytSayi2 = 31;

            // byte toplam = (byte)(bytSayi + bytSayi2);

            // Console.WriteLine(toplam);

            // MaxValue veri türlerinin property'si (özellik) veri tipinin alabileceği maksimum değeri gösterir.
            // MinValue minimum değeri gösterir.

            // Console.WriteLine(byte.MaxValue);
            // Console.WriteLine(byte.MinValue);

            #endregion

            #region short

            // short veri tipinde bir değişken RAM bellekte 16 bitlik(2 Byte) yer kaplar.
            // int ve long veri tiplerine göre RAM bellekte daha az yer kaplarlar ve aldıkları değer aralıkları küçüktür.
            // short veri tipinde bir değişken -32768 ile 32767 arasında değerleri alabilir.

            // short shrtSayi = 30;

            // short shtrSayi2 = 31;

            // short toplam = (short)(shrtSayi + shtrSayi2); // Hatırlamak gerekirse byte ve short veri tipinde değerleri topladığımızda sonuç int bu sebeple toplayıp short veri tipinde bir değer dönüştürüp short veri tipinde bir değişkene atayabiliyoruz.

            // Console.WriteLine(toplam);
            // Console.WriteLine(toplam.GetType());

            #endregion

            #region int

            // int veri tipinde bir değişken RAM bellekte 4 byte(32 bit) yer kaplar.
            // int veri tipindeki bir değişken -2147483648 ile 2147483647 arasında değerleri alabilir.

            // int sayi1 = 30;

            // int sayi2 = 31;

            // int toplam = sayi1 + sayi2;

            // Console.WriteLine(toplam);

            #endregion

            #region long

            // long veri tipide tamsayıları tanımlamak için kullanılan bir veri tipidir.
            // RAM bellekte 64 bit(8 byte) yer kaplar.

            // long sayi1 = 30;

            // long sayi2 = 31;

            // long toplam = sayi1 + sayi2;

            // Console.WriteLine(toplam);

            // Console.WriteLine(toplam.GetType());

            // default tam sayı değeri int olduğu için yukarda görüldüğü gibi otomatik dönüşüm yapıyor derleyici.

            // long veri tipi int veri tipinin kapsadığı değer aralığını kapsadığı için yine dönüşüm otomatik yapıldı.

            #endregion

            #endregion

            #region Ondalık Sayı Değişkenleri

            #region float

            // float veri tipinde değişkenler RAM bellekte 32 bitlik(4 byte) yer kaplar.
            // float bir değer sonuna c# dilinde sonuna f koyularak float olduğu belirtilmesi gerekiyor.
            // Her tam sayı bir ondalık sayı olduğu için bir başka tabirle ondalık sayılar tam sayıları kapsadığı için toplama işleminin sonucu otomatik olarak dönüştürüldü.

            // float fltSayi = 30.1f;

            // float fltSayi2 = 30.5f;

            // float toplam = fltSayi + fltSayi2;

            // Console.WriteLine(toplam);

            #endregion

            #region double

            // double veri tipinde değişkenler RAM bellekte 64bitlik(8 byte) yer kaplar.
            // ondalık sayılar default olarak double olduğu için harf koymaya gerek yok bilgisayar otomatik tanıyor.
            // Yüksek duyarlılıklı ve hassas matematiksel işlemlerde kullanılır.
            // float veri tipinde bir değişkenden 2 kat daha fazla RAM bellekte yer kaplar.

            // double dblSayi = 30.31;

            // double dblSayi2 = 30;

            // Console.WriteLine(dblSayi2);

            #endregion

            #region decimal

            // RAM bellekte 128 bitlik(16 byte) yer kaplar.

            // decimal dcmSayi1 = 30.88m;

            // decimal dcmSayi2 = 30m;

            // Console.WriteLine(dcmSayi2);

            // sayının decimal veri türünde belirtmek istiyorsak sonuna m koyuyoruz.

            #endregion

            #endregion

            #region Metin Değişkenleri

            #region char

            // Sadece tek karakter değerlerini tutmak istersek kullandığımız veri türüdür.
            // Char veri türü 16 bit uzunluğunda Unicode standartlarında karakterlerin karşılıklarını tutan veri tipidir.
            // Her bir karakterin Unicode standartları çerçevesinde bir karşılığı bulunmaktadır ve char tipinde değişken değer atandıktan sonra bir karakteri temsil etmektedir.
            // Tek tırnak içerisinde tek değer alacak şekilde kullanılır.
            // *, ?, !, u, ı, Ş klavye üzerinde görülen tek bir karakteri tutmak için kullanmış olduğumuz veri tipidir.

            // char krktr = 'V';

            // char krktr1 = 'Ş';

            // Console.WriteLine(krktr + krktr1); // Konsol ekranında ki çıktı 436. Neden ? Bu şekilde kodu yazarsak şunu yapar harflerin unicode değerlerini alır V'nin 86 Ş'nin 350.Toplama operatörü kullan ve bu değerleri topla demiş olduk.

            // Console.WriteLine(krktr.ToString() + krktr1.ToString()); // Değişken içinde ki değeri string veri tipine çevirip VŞ yazdırabiliriz.

            // char krktr2 = (char)55;

            // Console.WriteLine(krktr2);

            #endregion

            #region string

            // Metinsel değerleri tutabilmek için string veri türünü kullanırız.
            // Değeri çift tırnak içerisinde yazmamız gerekir.
            // string değişken olarak tanımlansa da aslında bir karakter dizisidir. *

            // string slogan = "Seni Seviyorum Volkan Yani Kendimi (:";

            // Console.WriteLine(slogan);

            #endregion

            #endregion

            #region  Karar Değişkeni --> bool namıdeğer boolean

            // Boolean veri tipi iki tane ihtimalin olduğu yerde kullanılan bir veri tipidir.
            // Volkan bugün ders çalıştı mı? Bu sorunun iki cevabı vardır: evet çalıştı, hayır çalışmadı.
            // Kullanıcı adını soyadını girdi mi? True = Doğru, False = Yanlış
            // Tekrarlarsak Boolean veri tipi bool diye yazılır. Bool veri tipinde bir değişken sadece true ve false değerlerini tutar.
            // Boolean veri tipi, bir "true" ya da "false" (doğru - yanlış) sorusunun yanıtı olan mantıksal bir niceliği simgeler.

            // bool calisilanDerslerAnlasiliyorMu = true;

            // Console.WriteLine(calisilanDerslerAnlasiliyorMu);

            #endregion

            #region Değişken tanımlarken dikkat edilmesi gerekenler !

            // En çok yapılan hatalardan seçtim.
            // Rakamla başlayamazlar: int 1sayi = 5; hata alırız, geçersizdir.
            // Boşluk olmaz: int sayi degeri = 5;
            // Türkçe karakter kullanılmamalıdır: int çocukSayisi = 10; Bazı programlama dillerinde sıkıntı olmayabilir ama çoğu yerde baş ağrıtabiliyor.

            #endregion

            #region object

            // Veri tiplerinin atasıdır denilebilir. Tüm veri tiplerini tanıyan, hiçbir veri tipini ayırt etmeyen ve tüm veri tiplerinde değerleri tutabilen bir veri tipidir.

            // object sayi, isim, ondalik, karar, karakter;

            // sayi = 30;
            // isim = "Volkan Şener";
            // ondalik = 1.70;
            // karar = true;
            // karakter = 'V';

            // Console.WriteLine(sayi);
            // Console.WriteLine(isim);
            // Console.WriteLine(ondalik);
            // Console.WriteLine(karar);
            // Console.WriteLine(karakter);

            #endregion

            #region bazı uygulamalar ve bazı detaylar

            // Null boş, geçersiz

            // Nullable boş bırakılabilir, geçersiz kılınabilir

            // Kilo bilgisi tutacak bir değişken (byte, short, int, long)
            // byte? kilo = null; // veri tipinin yanına soru işareti koyarak kilo bilgisini tutacak değişkeni boş bırakılabilir hale getirebiliyoruz
            // byte kilo = null; hata alırız. Bu şekilde boş bırakılamaz. Nullable yapabilmemiz için veri tipinin sağına bir soru işareti konur.
            // Son olarak kilo bilgisini tutmak için kullanacağımız en mantıklı değişken tipi byte ya da short alabileceği değerler itibariyle.
            // 255 kilo üstünde birisinin verisini byte ile tutamayız veri alma kapasitesini aşmış oluruz.

            // Plaka bilgisini tutacak değişken 
            // byte plaka = 26; olabilir.
            // string plaka = "26"; aritmetik bir işleme tabi tutmayacağımız bir durum olduğu için plaka değerini tutmanın en mantıklı yolu metin olarak tutmaktır.

            // Araç km bilgisini tutan bir değişken 
            // int km = 25000; en mantıklısı

            // Müşteri id'sini tutacak değişken 
            // string musteriID = "12446866096"; en mantıklısı

            // Bir değişken türünün sağına bir soru işareti(?) konulup değişkenin null değeri alabilmesi sağlanabilir.Bu, değer türleri(value types) için geçerlidir.

            // int? nullableInt = null; // nullable int
            // double? nullableDouble = null; // nullable double

            // string referans türüdür ve varsayılan olarak null olabilir.
            // Ancak, "sayısal bir değişkene 0 değeri atanırsa değişken null olabilir" ifadesi yanlıştır. Bir sayısal değişkene(değer türü) varsayılan olarak 0 atanır ve bu null anlamına gelmez. Değer türlerinin null olabilmesi için açıkça nullable(?) olarak tanımlanması gerekir.

            // string str; // Referans türü, varsayılan olarak null
            // int number; // Değer türü, varsayılan olarak 0
            // int? nullableNumber = null; // Nullable değer türü, null olabilir

            // Sonuç
            // Nullable yapmak için değişken türünün sağına bir soru işareti(?) konulup değişkene null değeri atanabilir: Bu ifade doğrudur ve değer türleri için geçerlidir.
            // String bir değişkene değer atanmazsa null olabilir: Bu ifade doğrudur, çünkü string referans türüdür.
            // Sayısal bir değişkene 0 değeri atanırsa değişken null olabilir: Bu ifade yanlıştır.Sayısal bir değişkene değer atanmazsa, varsayılan değeri 0 olur, null olması için nullable(?) olarak tanımlanması gerekir.

            // Özet
            // Referans türleri(string gibi) varsayılan olarak null olabilir.
            // Değer türleri(int, double, vb.) varsayılan olarak null olamaz, ancak nullable(int?, double?) olarak tanımlanarak null olabilir.
            // Değer türlerine varsayılan olarak atanan değer 0'dır, null değildir.

            // Referans türü" (reference type) kavramı, bellekteki veri yönetimi ile ilgilidir. string gibi referans türleri, doğrudan veriyi değil, verinin bulunduğu bellekteki adresi (referansı) saklarlar. Bu, referans türlerinin değer türlerinden (value type) farklı olarak çalışmasına neden olur.

            // Referans Türleri ve Değer Türleri

            // Referans Türleri
            // Bellek Yönetimi: Bellekte verinin bulunduğu yeri işaret eder(referans).
            // Kopyalama: Bir referans türü kopyalandığında, aslında sadece bellek adresi kopyalanır, veri kopyalanmaz.
            // Varsayılan Değer: Referans türleri varsayılan olarak null olabilir.
            // Örnekler: string, class, interface, array ve delegate.

            // Değer Türleri
            // Bellek Yönetimi: Değeri doğrudan bellekte saklar.
            // Kopyalama: Bir değer türü kopyalandığında, veri doğrudan kopyalanır.
            // Varsayılan Değer: Değer türleri varsayılan olarak ilgili türün sıfır değerini alır (örneğin int için 0).
            // Örnekler: int, float, double, char, struct ve enum.
            // string ve Referans Türleri
            // Bir string değişkeni aslında karakterlerin bulunduğu bellekteki bir adresi tutar.İşte bu yüzden string bir referans türüdür.Bu, birkaç önemli sonuç doğurur:

            // Kopyalama:

            // Bir string değişkeni başka bir değişkene atandığında, sadece bellek adresi kopyalanır, karakter verisi kopyalanmaz.
            // Örnek:


            // string str1 = "Merhaba";
            // string str2 = str1; // str2, str1'in referansını tutar, yani aynı karakter dizisini işaret eder.
            // Değer Atama ve null Değeri:

            // Bir string değişkenine null atanabilir, yani bellekte hiçbir yeri işaret etmeyebilir.
            // Örnek:

            // string str = null; // str hiçbir yeri işaret etmiyor.

            // Bellek Yönetimi:

            // string değişkenleri, Garbage Collector tarafından yönetilen yığın(heap) bellek bölgesinde depolanır.
            // Bellekte aynı değeri tutan string değişkenleri için optimizasyon yapılabilir(interning).
            // Karakter Dizileri
            // string referans türü olmasına rağmen, karakter dizisinin kendisi bir char array(dizi) olarak düşünülebilir.Yani, bir string değişkeni bellekte bir char dizisine işaret eder.

            // Örnek:
            // string str = "Merhaba";
            //         Bu durumda str, bellekte "Merhaba" karakter dizisini işaret eden bir referanstır.Bu karakter dizisi, karakterlerin ardışık bir dizisini tutar.

            // Özet
            // string referans türüdür çünkü bellek adresini saklar, verinin kendisini değil.
            // Referans türleri bellekte verinin bulunduğu yeri işaret ederken, değer türleri veriyi doğrudan saklar.
            // string değişkenlerine null atanabilir ve bu değişkenler başka değişkenlere atandığında sadece referans kopyalanır.
            // string karakter dizilerinin bir referansıdır ve bu karakterler ardışık bir şekilde bellekte saklanır.

            #endregion

            
        }
    }
}
