using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_metotlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Giriş
            //Metotlar nedir ?
            //Neden kullanırız ?

            //Örneğin kullanıcının 2 sayı girmesini istiyoruz.Aldık ve bu sayıların toplamını ekrana yazdırmak istiyoruz.Yazdırdık diyelim.
            //Daha sonra bir daha kullanıcıdan sayı almak istiyoruz ve bir daha toplamlarını ekrana yazdırmak istiyoruz.Bir daha toplamlarını ekrana yazdırmak istiyoruz.
            //Ne yapmamız gerekiyor ? Yazmış olduğumuz bir önceki kodları kopyalayıp yapıştır yapmamız gerekiyor.
            //Yani aynı şeyi birden fazla kez kullanmaya kalktığımda kodlarım kopyala yapıştır(copy paste) olmuş olacak.

            //Metotlar burada bunun önüne geçiyor.

            //Metotlar şudur yapmak istediğimiz işe hizmet eden program parçacıklarıdır kısacası
            //Bir tana metot yazarız bu metot iki sayının toplamını yapacak diyelim ki..
            //Bir metot yazarız 3 tane sayının çarpımını yapar 
            //Bir metot yazarız ismimizi ve soy ismimizi yan yana yazar.

            //Bu şekilde metotlara hizmet edecekleri veya yapacakları işi tanımlarız 
            //Daha sonrada bu metotları çağırırız ve kullanırız.Tekrar tekrar çağırıp kullanabiliriz.

            //Aynı kodları bir daha kopyalayıp yapıştır yapmamıza gerek kalmaz tek yapmamız gereken aynı amaçla tanımladığımız metodu çağırmaktır.
            #endregion

            #region Parametresiz(parametre almayan) - Geriye Değer Döndürmeyen Metot Tanımlama

            //static void Main aslında bir metotdur.Burada static anahtar kelimesi var, void var, dizi var.Static anahtar kelimesi ilerinin konuları, erişim belirleyicileri var ilerinin konuları
            //sınıflar var ilerinin konuları şimdilik bunları öğrenmeyeceğiz.Yazılımda uzak durulması gereken şey ezberdir.Mantığını anlarsak bilgi ömür boyu kalır.

            //Bu derste static anahtar kelimesini kullanacağız şimdilik yazıp geçeceğiz ilerleyen derslerde mantığını öğreneceğiz.

            //main bir metottur.Tüm yazılan kodlar bu metodun blokları(kıvırcık parantezleri) içerisine yazılır.

            //Kendimize ait metotlarımızı tanımlayalım.
            //main'in kıvırcık parantezlerinin dışına çıkıyoruz.

            #endregion

            //SelamVer();// SelamVer adında ki metodumu çağırmak istiyorum.Breakpoint koyup çalışma mantığına bakalım.Derleyicim sarı olan yerde Step Into(İçine Adım)(F11) basıyoruz.Derleyicim şöyle çalışacak
            ////SelamVer metodumun içine git diyorum şuanda.SelamVer metodumu çalıştır diyorum.Derleyici içine gittikten sonra Step Over(Üzerine Adım)(F10) ile geziniyorum.
            //AdiniYaz();

            //for (int i = 0; i < 100; i++)
            //{
            //    SelamVer();
            //}
        }
        static void SelamVer() //şimdilik ezbere static anahtar kelimesini yazacağız detaylı bir şekilde öğreneceğiz.void önemli bir anahtar kelime geriye değer döndürmeyen string olsun, int olsun değer döndürmeyen anahtar kelimedir.
        {                      //void anahtar kelimesi sadece çıktı işlemlerinde kullanılır.Geriye değer döndüreni gördüğümüzde void'i daha iyi anlayacağız.Sonra metodumun ismini veriyorum.oval parantezi açıp kapatıyorum.Parantez, içine parametre yazılan parantez.Yukarda static void Main(string[] args) parantez içerisinde parametre alınmış ben almadım.
            Console.WriteLine("Selamlar :)"); //kıvırcık parantezleri açtım bunları(Console.WriteLine("Selamlar :)");) yapsın dedim. 
        }
        //Biz tüm bunları yaparak metodumuzu tanımladık.Bu metodu çağırma zamanı.Metodu oluşturduk çağırmamız gerekiyor.Çağırmazsak hiç oluşturulmamış gibi duracaktır.Çalışmaz.
        //main içerisine metodumun ismini yazıyorum.Örneğin bir arkadaşımız çağırdığı zaman nasıl çağırıyor ismimizle çağırıyor değil mi.Volkan buraya gel vs

        //Çalışma yapısı bu şekilde bir metodu çağırdığımız zaman bu metodu çalıştır anlamına geliyor.Metodun yaşam alanındaki kodları çalıştırıyor.

        static void AdiniYaz() 
        {
            Console.WriteLine("Volkan Şener");
        }

        //Breakpoint koyup çalıştırıp metodun içerisine girebilmek için (Step Into)F11 metodun içerisinde gezinebilmek için (Step Over)F10.
        //Metotların içinde ki kodlar çalıştıktan sonra derleyici tekrar metodumu çalıştırdığım noktaya geldi.Önce metodumu çağırdığım yani çalıştırdığım noktadan başlayacak metodun içinde
        //yazdığım kodları çalıştırıp tekrar metodumu çağırdığım noktaya gelecek ve altından devam edecek derleyici.Döngü bu şekilde.

        //Bir metot yazarız bu metot bir işe hizmet eder istediğimiz yerde istediğimiz kadar kullanabiliriz metodun ismini yazmamız yeterli.
        //En basit metot tanımını bu şekilde yaptık.







    }
}
