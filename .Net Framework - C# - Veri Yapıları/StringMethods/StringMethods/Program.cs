using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String sınıfı içerisinde ki metotlarla nasıl çalışacağımızı öğrenelim.
            // Şuanda Class kavramını bilmiyoruz lakin program class içerisinde main metodu içerisine kodlarımızı yazdık bu aşamada.

            // msg içerisine string bir veri ekledik.
            // Biz bu veri üzerinde bazı işlemler yapmak istiyoruz
            // Örneğin bu verinin tüm karakterlerini küçük harfe çevirmek istiyorum ya da hepsini büyük harfe çevirmek istiyorum ya da burada
            // kaç karakter var bunu tahmin etmek istiyorum ya da boşluk karakterlerini çizgi karakterleri ile değiştirmek istiyorum ya da name ifadesinin konumunu
            // baştan itibaren kaçıncı karakter olduğunu ya da bu string ifade içerisinde name bilgisi var mı yok mu şeklinde bir bilgi sormak istiyorsam 
            // ** string sınıfı içerisinde önceden tanımlanmış .Net Framework ile bize gelen bazı metotlar ve özellikler var.

            // ** Tabi ki bu metotları ve özellikleri nasıl oluşturacağımızı class kavramını öğrendikten sonra öğreneceğiz.

            //Şuan da bize hazır olarak gelen string sınıfı içerisinde ne gibi metotlar var ne gibi özellikler var bunları kullanmasını öğrenelim

            string msg = "Hello There, My Name is Volkan Şener.";

            Console.WriteLine(msg.Length); // Lenght property(özelliği), string'in uzunluğunu, yani içerisindeki karakter sayısını döner.
            Console.WriteLine(msg.ToLower()); // ToLower metodu, string'i yani dizeyi küçük harfe dönüştürür. toLower küçük harf ile 
            Console.WriteLine(msg.ToUpper()); // ToUpper metodu, string'i büyük harfe dönüştürür. toUpper büyük harf ile 
            Console.WriteLine(msg);
            Console.WriteLine(msg.Trim()); // String ifademin başına sonuna boşluk koydum veya öyle düşünelim. Ve biz boşluklardan kurtulmak istiyoruz.
            // Örneğin bir web sitesi yaptık kullanıcıdan isim istiyoruz kullanıcı isim girmeden önce yanlışlıkla boşluk tuşuna basmış olabilir.
            // Biz bu boşluğu veri tabanına kaydetmememiz gerekiyor. Bu bilgiyi işlemeden önce trim metodunu kullanıyoruz.
            // Özetle Trim() metodu String'in başındaki ve sonundaki boşlukları kaldırır. trim türkçesi düzeltme

            Console.WriteLine(msg.TrimStart()); // TrimStart() metodu String'in başındaki boşlukları kaldırır. başlangıç düzelt
            Console.WriteLine(msg.TrimEnd()); // TrimEnd() metodu String'in sonundaki boşlukları kaldırır. bitiş düzelt
            Console.WriteLine(msg.Split()[2]);// Bu metot, bir string'i belirli bir karakter veya karakter kümesi kullanarak parçalara ayırır ve bu parçaları bir dizi (array) olarak döner.
            // split bölmek anlamında yukardaki metnin boşluk karakterlerinden itibaren kelime kümelerine bölüp bu kelime kümeleri dizi(array) olarak döndürüyor. 0. index hello 1. index there, ..... .......

            Console.WriteLine(msg[0]); // String sadece veri tipi değil karakter dizisi demiştik. string ifadenin 0. index'inde H var 

            Console.WriteLine(msg.StartsWith("Hello")); // StartsWith() metodu String'i belirtilen karakter veya alt dizi ile başlayıp başlamadığını kontrol eder. H karakteriyle başladığı için True döner, aynı şekilde alt dizide başlangıç karakter kümesi Hello olduğu için True döner, başlangıçtan itibaren yazılan karakter kümesini eksiksiz yazıpta bu metod ile kontrol yapabiliriz.
            Console.WriteLine(msg.EndsWith("Şener.")); // String'in belirtilen karakter veya alt dizi ile bitip bitmediğini kontrol eder.
            // Starts With "" ile başlar demek Ends With "" ile biter

            // İstediğimiz bir karakter ifade içerisinde var mı yok mu ?
            Console.WriteLine(msg.Contains("Selim")); // Bu metot, string içinde belirli bir alt dizenin bulunup bulunmadığını kontrol eder. Boolean (true veya false) döner.
            // Contains türkçesi içerir. string ... içerir diyerek kontrol yaparız.

            // Kullanıcıdan mail adresi istediğimizde girilen mail adresi içerisinde "@" işaretinin olup olmadığını kontrol edebiliriz.
            // @ işareti yoksa demekki kullanıcı mail formatına uyan bir bilgi girmedi.

            //Console.WriteLine("Mail adresinizi giriniz : ");
            //string kullaniciMail = Console.ReadLine();

            //Console.WriteLine("Şifrenizi giriniz : ");
            //string strSifre = Console.ReadLine();

            //if (kullaniciMail.Contains("@") && !kullaniciMail.Contains(" ") && strSifre.Length <= 10)
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş.");
            //}

            Console.WriteLine(msg.IndexOf("e")); // Bu metot, belirli bir karakterin veya alt dizinin string içinde ilk bulunduğu indeksi döner. Eğer bulunamazsa, -1 döner.
            Console.WriteLine(msg.IndexOf("Name")); // 16 yani Name bilgisi string ifade içerisinde 16 index numarasından itibaren yer alıyor.
            Console.WriteLine(msg.Substring(5)); // Bu metot, string'in belirli bir kısmını (alt dizisini) almak için kullanılır. İki parametre alır: ilk parametre, alt dizinin başlayacağı indeks, ikinci parametre ise alınacak karakter sayısıdır.
            // Substring metodu bizden beklediği parametreler startIndex yani verdiğimiz bir index numarasından itibaren bize bu bilgiyi gönderir. Farklı parametreler gönderip farklı kullanımlar yapabiliriz.
            Console.WriteLine(msg.Substring(5,10)); // Bana 5. karakterden itibaren 10 karakter getir. Burada konum starindex 5 getirilecek karakter uzunluğu length 10.

            int index = msg.IndexOf("Name"); // Bu metot, belirli bir karakterin veya alt dizinin string içinde ilk bulunduğu indeksi döner. Eğer bulunamazsa, -1 döner.
            Console.WriteLine(index); // indexof indeksin, indeksin konumu şeklinde türkçeye çevrilebilir

            Console.WriteLine(msg.Replace("Hello There, My Name is Volkan Şener.", "Hallo, mein Name ist Volkan Şener.")); // Bu metot, string içinde belirli bir karakteri veya alt diziyi, başka bir karakter veya alt diziyle değiştirir. türkçesi değiştirmek
            Console.WriteLine(msg.Replace(" ", "-").Replace("-", ""));

            Console.WriteLine(msg.Insert(0, "...")); // insert ekle metodu bir int bir string parametresi tanımlanmış.Parametre metot veya fonksiyonun tanımı sırasında belirtilen değişkenler.
            // Parametreler, metot veya fonksiyonun çağırıldığı yerde verilen değerlerlerle doldurulur ve bu değerlerle işlemlerimizi yaparız
            // Insert ekle metodu bizden başlangıç indeksi istiyor ve oraya eklenecek değeri istiyor. ben 0. indexten itibaren 3 nokta ekledim.

            Console.WriteLine(msg.Insert(msg.Length, "...")); // string'imin uzunluğu benim orjinal stringimin son karakterinin index numarasıdır bunu başlangıç indeks olarak tanımlayıp oradan itibaren 3 nokta ekledim

            Console.WriteLine(msg.Remove(0)); // Remove() metodu, bir string içindeki belirli bir kısmı kaldırmak için kullanılır. Bu metot, bir string’in belirli bir bölgesini silip, kalan kısmı birleştirerek yeni bir string döner. Orijinal string üzerinde değişiklik yapmaz; bunun yerine, belirttiğiniz konumdan itibaren belirli bir uzunluktaki karakterleri kaldırarak yeni bir string oluşturur.
            // 2 aşırı yüklemesi var aynı isimle farklı parametrelerle 2 versiyonu tanımlanmış.
            // eğer sadece başlangıç indekse 0 eklersek bu metod orjinal stringin 0. indeksinden itibaren tüm kısmı siler.

            Console.WriteLine(msg.Remove(0, 13)); // 0. indeksten itibaren 13 karakteri saydırıp kaldırır. count say demektir. 


        }
    }
}
