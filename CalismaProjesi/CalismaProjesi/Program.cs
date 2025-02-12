using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalismaProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bilgisayar

            //Bilgisayar, tekrar tekrar programlanabilen elektronik bir cihazdır. Bu tanım, bilgisayarın temel işlevini ve özelliklerini açıklar.İşte daha ayrıntılı bir açıklama:
            //Elektronik Cihaz: Bilgisayar, elektronik bileşenlerden oluşur.Bu bileşenler arasında mikroçipler, transistörler, devre kartları ve diğer elektronik parçalar bulunur.
            //Programlanabilirlik: Bilgisayarlar, kullanıcıların istedikleri görevleri gerçekleştirmek için programlanabilir. Programlama dilleri aracılığıyla yazılan kodlar, bilgisayarın işlem yapmasını sağlar.
            //İşlem Gücü: Bilgisayarlar, hızlı hesaplamalar yapabilme yeteneğine sahiptir.Bu, verileri işlemek, hesaplamalar yapmak, grafikleri oluşturmak ve daha fazlasını yapmak için kullanılır.
            //Veri Depolama: Bilgisayarlar, verileri depolamak için sabit diskler, SSD’ler, RAM ve diğer depolama birimleri kullanır. Bu, dosyaları saklamak, programları yüklemek ve veritabanlarına erişmek için önemlidir.
            //Giriş ve Çıkış: Bilgisayarlar, klavye, fare, monitör, hoparlörler ve diğer cihazlar aracılığıyla kullanıcılarla etkileşim kurar. Bu, veri girişi ve çıkışı için gereklidir.
            //Sonuç olarak, bilgisayarlar günümüzde hayatımızın ayrılmaz bir parçasıdır ve birçok farklı alanda kullanılırlar.

            #endregion

            #region Veri

            //Bilgisayar için işlenebilir duruma getirilmiş sayısal ya da sayısal olmayan nicelikleri ifade eder.Bu kavram bilgisayar bilimlerinde önemli bir rol oynar.

            //Sayısal Veriler : Bilgisayarlar tarafından işlenebilen sayılarla ifade edilen verilerdir.Örneğin, bir öğrencinin notu veya bir ülkenin nüfusu gibi nicel veriler örnek
            //verilebilir.

            //Sayısal Olmayan Veriler : Bilgisayarlar tarafından işlenebilen, ancak sayısal ifadeler içermeyen verilerdir.Bu tür veriler ses, metin, resim gibi birçok farklı 
            //türde olabilir.

            //Bilgisayarlar, bu verileri çeşitli işlemlerde kullanır ve saklar.Kullandığımız telefon,bilgisayar gibi neredeyse bütün akıllı cihazlar, yaptığınız işlemleri arka planda
            //saklar ve bu işlemlere veri denir.

            #endregion

            #region İnternet

            //İnternet, bilgisayar sistemlerini birbirine bağlayan elektronik bir iletişim ağıdır.TDK, internet sözcüğüne karşılık olarak genel ağ önermiştir.İnternet, dünya üzerindeki
            //bilgisayar ağlarının birbirleriyle bağlanması sonucu ortaya çıkmış olan, herhangi bir sınırlaması ve yöneticisi olmayan uluslarası bir bilgisayar ve bilgi iletişim
            //ağıdır.İnternet sayesinde bilgiye erişmek oldukça kolaydır ve tüm dünyadakki bilgilere tek tıkla ulaşılabilmektedir.Bulunduğunuz konum fark etmeksizin, internet üzerinden
            //herhangi bir bilgiye ulaşmak mümkündür.İnternet, sunucular(server) ve sunucularla çalışan bir sistemdir.

            #endregion

            #region Sunucu(Server)

            //Bilgisayar ağlarında,istemcilerin(kullanıcıların) erişebileceği, kullanımına ve paylaşımına açık kaynakları veya bazı servisleri (FTP,E-Posta,Web Sitesi) çalıştıran 
            //bilgisayar birimlerine verilen genel bir addır.Yani sunucular, verileri saklayan, düzenleyen ve kullanıcılara sunan güçlü bilgisayar olarak ifade edilebilir.
            #endregion

            #region C#

            //C# (C Sharp), Microsoft tarafından geliştirilen bir programlama dilidir.İşte C# hakkında bazı temel bilgiler :

            //Nesne Yönelimli : C#, nesneye yönelimli bir programlama dilidir.Bu, kodun nesneler (örneğin sınıflar ve nesneler) üzerinde çalıştığı anlamına gelir.Nesneye yönelimli
            //programlama, kodun daha modüler, anlaşılır ve bakımı kolay hale gelmesini sağlar.

            //Modern ve esnek : C#, basit, modern ve esnek bir dil olarak bilinir.Bu dil, güçlü bir altyapıya sahip olup birçok platformda kullanılabilir.

            //.NET Framework ile Entegrasyon : C#, .NET Framework ile uyumlu bir şekilde çalışır..NET Framework, C# kodlarını derleyerek uygulamayı çalıştırılabilir hale getirir.
            //Bu sayede C# ile geliştirilen yazılımlar, sistemler tarafında çalıştırılabilir.

            //Debugger Özelliği : C# yazılımcıları için gelişmiş hata ayıklama (debugger) özelliği sunar.Bu özellik, yazılımcıların hataları kolayca tespit etmelerine yardımcı olur.

            //C#, default(varsayılan) olarak case-sensitive(büyük-küçük harf duyarlı) bir programlama dilidir.Bu, C# dilinde değişken, fonksiyon adları ve diğer tanımlayıcılar için büyük ve küçük
            //harf ayrımının olduğu anlamına gelir.Yani, myVariable ve myvariable iki farklı değişken olarak kabul edilir.Eğer bir C# sözlüğünde (dictionary) anahtarları büyük-küçük harf
            //duyarlı olarak kullanmak isterseniz, bunu özel olarak belirtmeniz gerekir.Aksi takdirde, C# sözlükleri varsayılan olarak büyük-küçük harf duyarlıdır.


            #endregion

            #region IDE(Integrated Development Enviroment/Entegre Geliştirme Ortamı)

            //Biz C# bu araçlardan Visual Studio üzerinden çalıştırıyoruz.Visual Studio Code değil!!!Visual Studio Code Notepad++ 'in Microsoft tarafından yeniden geliştirilmiş halidir.
            //Örneğin Java için Eclipse,Python için PyCharm kullanılır.


            #endregion

            //Console App yeni çıkan .Net Core ile geliştirilen Console uygulamasıdır.Bir de geçmişten bugüne gelen .Net standarttan sonra oluşturulan ve .Net Framework 4.7 üzerinde
            //çalışan kullanılan Console uygulamasıdır.Biz şuan .Net Core öğrenmediğimiz için diğer Console uygulamasını kullanıyoruz.

            #region Console Uygulaması 

            //Hem form üzerinde hemde web üzerinde C# dilini etkili şekilde kullanabilmemiz için bu uygulamayı kullanıyoruz.Çünkü öğrendiğimiz komutlar hem form, hem web yazılımı üzerinde
            //çalışmaktadır.Console uygulaması C#'ı tam olarak temelleriyle birlikte öğrenebilmemizi sağlar.

            //Console App(.Net Framework) ekranında seçimi yaptıktan sonra proje adını ve projenin kaydedileceği lokasyonu gösteren ekran karşımıza gelir.Türkçe karakter, boşluk kullanılmaz.
            //Bu ekrandaki location kısmının baz değeri C:\Users\Kullanıcı Adı\Source\Repos tur.
            //Ben repos klasörünü manuel olarak masaüstüne aldım bu nedenle C:\Users\I-Life\source\repos şeklinde kayıtlıdır.

            #endregion

            //Kodlar namespace class main altındaki yaşam alanı parantezleri {} içerisine yazılırlar.
            //C# programlama dilinde kodları yazarken açılan yardımcı menüye IntelliSense denir. IntelliSense, kod yazarken otomatik tamamlama, fonksiyon ve değişken adlarını önerme, parametre bilgilerini gösterme gibi işlevleri içerir.
            //Bu özellik, yazılım geliştiricilere daha hızlı ve hatasız kod yazma imkanı sağlar.

            #region Kod ve Komut

            //Kod(Code):
            //“Kod”, genellikle programlama dillerinde yazılan talimatları ifade eder.
            //Bir programın içindeki işlevleri, mantığı ve algoritmayı tanımlayan metin tabanlı ifadelerdir.
            //Kod, bir programın çalışma mantığını belirler ve bilgisayar tarafından yorumlanarak işletilir.

            //Komut(Command):
            //“Komut”, genellikle işletim sistemleri veya komut satırı arayüzleri gibi ortamlarda kullanılır.
            //Bir işlemi gerçekleştirmek için yazılan talimatları ifade eder. Örneğin, bir komut satırında “ls” (Linux)veya “dir” (Windows)komutu, dizin içeriğini listeler.
            //Komutlar, genellikle işletim sistemi düzeyinde çalışır ve kullanıcının bilgisayar üzerinde belirli görevleri yerine getirmesini sağlar.
            //Kısacası, “kod” programlama dillerinde yazılan metin tabanlı ifadeleri ifade ederken, “komut” işletim sistemi veya komut satırı arayüzlerinde kullanılan talimatları ifade eder.

            #endregion

            #region Bazı tanımlar

            //C# dilinde byte veri tipi, System.byte adlı bir yapıya(struct) karşılık gelir.Struct burada yapı anlamına gelir.Yani, bir byte değişkeni 2^8 yani 256 farklı değeri temsil edebilir.
            //0'dan 255'e.Bu byte veri tipinin genellikle ikili(binary) verileri ve küçük tam sayıları saklamak için kullanıldığı anlamına gelir.
            //system.byte ifadesi, byte veri tipinin .NET Framework'teki tam adını belirtir.System ad alanı(namespace), .NET Framework'teki temel tipleri ve özellikleri içerir.
            //Bu nedenle, byte veri tipi System ad alanının bir parçasıdır ve tam adı System.Byte'dir.

            //Constant demek programın çalışması sırasında değişmez demektir.Değişmez değerler constant değerlerdir byte.MinValue, short.MinValue, short.MaxValue gibi gibi
            //Yani programın çalışması sırasında değişmeyen değişkendir.Değişmeyen değerleri temsil için kullanılır

            //struct(yapı) c# dilinde değer tipinde bir veri yapısıdır.Structlar,birçok yönden bir class(sınıf) 'a benzer.Sınıflar gibi, property(özellikler), constructor(yapıcılar)
            //method(metotlar), field(alan) gibi öğeler içerirler ve ilgili üyeleri tek bir pakette gruplandırmanıza olanak tanır.
            //struct hakkında bazı önemli noktalar:
            //değer tipi: structlar değer tipi olarak işlev görür ve değer tipi kopyalaması yaparlar.Yani, bir struct değişkeni, bellekte doğrudan değerini tutar, referansını değil.
            //kullanım alanları: structlar genellikle küçük veri yapılarını temsil etmek için kullanılır.Örneğin, bir nokta koordinatını veya bir tarih zaman bilgisini temsil
            //etmek için bir struct tanımlanabilir.
            //Sınırlamalar: structlar sınırlı özelliklere ve davranışlara sahip olduğu için, daha karmaşık veri yapıları için genellikle classlar tercih edilir.
            //Performans: structlar, belirli senaryolarda performans avantajı sağlayabilirken, classlar daha esnek bir yapı sunarak daha karmaşık uygulamaları desteklerler.

            //void anahtar kelimesi bir metot ya da fonksiyonun herhangi bir değer döndürmediğini belirtmek için kullanılır.
            //Bir metot ya da fonksiyon, bir işlemi gerçekleştirdikten sonra genellikle bir değer döndürür.Ancak bazı durumlarda, bir metot veya fonksiyon bir değer döndürmesine 
            //gerek yoktur.Bu tür metot ya da fonksiyonlar, genellikle bir işlemi gerçekleştirir ve sonra kontrolü çağıran koda geri verir.

            //Bir metot veya fonksiyonun “değer döndürmediğini” söylediğimizde, bu, metot veya fonksiyonun çalıştırıldıktan sonra herhangi bir değer üretmediği anlamına gelir.
            //Bir metot veya fonksiyon genellikle, belirli bir işlemi gerçekleştirdikten sonra bir sonuç üretir.
            //Bu sonuç, metot veya fonksiyonun “döndürdüğü” değerdir.
            //Bu değer, metot veya fonksiyonun çağrıldığı yere geri gönderilir ve genellikle bir değişkende saklanır veya başka bir işlemde kullanılır.


            #endregion

            #region Projelerin kayıt yeri

            //Kodları başlat(ctrl f5) komutu verdiğimizde otomatik olarak proje harddiske kaydedilir.
            //C# projeniz, harddiskte kayıtlıdır. RAM (Bellek), çalışma anında programın işlem yapması için kullanılan geçici bellektir.
            //Program çalıştığında, işletim sistemi projenizi RAM’e yükler ve çalıştırır. Ancak projeniz kalıcı olarak harddiskte saklanır. 
            //Yani, projeniz hem harddiskte hem de RAM’de bulunur, ancak kalıcı olarak harddiskte depolanır.


            #endregion


            char krktr = 'a';
            int sayi = 0;

            //metotlardayım

            //---------------------------------------------------------------------------


            //string[] isimler = { "Domates", "Biber", "Patlıcan", "Fasulye", "Soğan", "Limon", "Ekmek", "Kola", "Yumurta" };
            //double[] fiyatlar = { 35, 79.35, 58.95, 57.90, 10, 20, 10, 50.40, 50 };
            //string[] birimler = { "Kg", "Kg", "Kg", "Kg", "Kg", "Kg", "Adet", "Lt", "Koli" };
            //double[] kdvOranlari = { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.8, 0.8, 0.1 };
            //Öncelikle ürünlerin fiyatları, birimleri ve KDV oranlarını dizilerde tanımladık.
            //yukarıdaki ürünlere kdv ekleyeceğiz. Alışveriş sonunda ara toplam, kdv, genel toplam olmak üzere 3 seçenek göstereceğiz.

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Markete hoş geldiniz");
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ") " + isimler[i] + " \t" + fiyatlar[i] + " TL"); //Ürünleri fiyatlarıyla listeledik.
            //}

            //string secenek = "evet";
            //double araToplam = 0;
            //double toplamKdv = 0;
            //double genelToplam = 0;

            //while (secenek == "evet") 
            //{
            //    Console.WriteLine("Almak istediğiniz ürünün numarasını giriniz.");
            //    int urunNo = Convert.ToInt32(Console.ReadLine());

            //    //Console.WriteLine("Kaç " + birimler[urunNo - 1] + " " + isimler[urunNo - 1] + " alacaksınız?");
            //    Console.WriteLine($"Kaç {birimler[urunNo - 1]} {isimler[urunNo - 1]} alacaksınız?");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    double urunFiyat = fiyatlar[urunNo - 1] * adet;
            //    double urunKdv = urunFiyat * kdvOranlari[urunNo - 1];   
            //    toplamKdv += urunKdv;
            //    araToplam += urunFiyat;
            //    genelToplam += araToplam + toplamKdv;

            //    Console.WriteLine("Alışverişe devam edilsin mi ? evet/hayır");
            //    secenek = Console.ReadLine();

            //    if (secenek == "hayır")
            //    {
            //        Console.WriteLine("Morpheus Market iyi günler diler.");
            //        Console.WriteLine("ARA TOPLAM = " + araToplam);
            //        Console.WriteLine("KDV = " + toplamKdv);
            //        Console.WriteLine("GENEL TOPLAM = " + genelToplam + " TL");
            //    }
            //}




            //string[] isimler = { "Furkan", "Volkan", "Doğa", "Dilara Nur", "Nasuh", "Hüseyin", "Deniz", "Berk" };
            //string[] numaralar = { "0579341572", "0044612612", "3127350532", "1792481028", "1219969301", "0708424452", "0490753442", "3124835332" };
            //double[] bakiyeler = { 100, 40, 3, 16, 19, 0.5, 16.99, 30.5 };

            //string[] isimler = { "Domates", "Biber", "Kola  ", "Fasulya", "Soğan", "İliman", "Ekmek", "Yumurta" };
            //double[] fiyatlar = { 35, 79.95, 58.95, 57.90, 10, 20, 10, 40 };
            //string[] birimler = { "Kg", "Kg", "Lt", "Kg", "Kg", "Adet", "Adet", "Koli" };


            //Menü Yazdırma

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ")" + isimler[i] + " \t" + fiyatlar[i] + " TL");
            //}

            //Lütfen almak istediğiniz ürünün numarasını dedikten sonra bu ürünün kaç adet alacaksınız diye soracağız.

            //double toplamFiyat = 0;
            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Almak istediğiniz ürünün numarasını giriniz.");
            //    int urunNo = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bu üründen kaç adet alacaksınız ?");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplamFiyat = fiyatlar[urunNo - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi ? e/h");
            //    secenek = Console.ReadLine();

            //    if (secenek == "h")
            //    {
            //        Console.WriteLine("Marketim iyi günler diler.");
            //        Console.WriteLine("TOPLAM = " + toplamFiyat + " TL");
            //    }
            //}


            //Birim belirterek ürün aldırma

            //double toplamFiyat = 0;
            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Almak istediğiniz ürünün numarasını giriniz.");
            //    int urunNo = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"Kaç {birimler[urunNo - 1]} {isimler[urunNo -1]} alacaksınız ?");
            //    int adet = Convert.ToInt32((Console.ReadLine()));

            //    toplamFiyat += fiyatlar[urunNo - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi ? e/h");
            //    secenek = Console.ReadLine();

            //    if (secenek == "h")
            //    {
            //        Console.WriteLine("Marketim iyi günler diler.");
            //        Console.WriteLine("TOPLAM = " + toplamFiyat + " TL");
            //    }
            //}

            //Giriş Başarılı Giriş Başarısız

            //-----------------------------------


        }
    }
}

