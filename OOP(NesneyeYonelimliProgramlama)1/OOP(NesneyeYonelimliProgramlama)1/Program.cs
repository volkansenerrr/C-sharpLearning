using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelimliProgramlama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Oriented Programming yani Nesne Yönelimli Programlama
            //Oriented burada yönelim, odaklı demek nesneye yönelim nesneye odaklı anlamlarında

            //Object Oriented Programming girişidir Class(sınıf)
            //Class'lardan giriş yapacağız.En temelden giriş yapacağız.

            //Object Oriented Programlama zor bir bölümdür.Zorlar lakin öğrenilecek

            //Class Nedir : Bizim field(alan) ve Metotlarımızı içinde tutan container'dır.Çevreleyici bir yapıdır.
            //field türkçede alan demektir property diye geçer değişkenlerimizdir.

            //Odamızın içindeki eşyalarımız field ve metot iken odamız Classlar gibi düşünebiliriz.
            //Önce araba düşünelim sadece iskeleti var bomboş bu classtır.Arabamızın tüm bileşenleri değişkenlerimiz kapılar, rengi, motoru, koltukları vs...
            //Bu arabayı kullanırken yaptığımız eylemler arabayı kullanırken uyguladığımız metotlardır diye yorumluyorum.

            //Peki nasıl tanımlarız ?

           //Main metodumun en son kıvırcık parantezinin dışına public class Araba adında bir class tanımlayalım.
           //içerisine iki tane parça ekledik.Araba sınıfımızın içerisine iki tane metot tanımladık.
        }
        public class Araba
        {
            public int kapiSayisi;
            public string arabaRengi;

            public void kapilariKilitle()
            {
                //Çalışacak kodlar
            }

            public void motoruCalistir()
            {
                //Çalışacak kodlar
            }
        }

        //Sınıf(Class) Boş Araba Taslağı

        //-------------------------------------------------------------------------
        //Değişken kapı sayısı(kapiSayisi), arabanın rengi(arabaRengi)
        //Nesne(object) -Taslak üzerinde geliştirilen arabalar.
        //Metot kapıları kilitle(kapilariKilitle, motoru çalıştır(motoruCalistir)
        //-------------------------------------------------------------------------

        //public ve private adında erişim belirleyicileri göreceğiz.Yeri ve zamanı geldiğinde öğreneceğiz bunlarıda.

        //araba class'ı benim iki değişkenim ve 2 metodumu barındırıyor.Konteynır(conteiner) görevi görüyor.4 tane değeri ekranda tutuyor.
        //Daha sonra araba sınıfından objeler oluşturarak bunları kullanacağız.
        //classların temel yapısı budur.Bir sonraki derste biraz daha derine inelim.Sınıflarımızı program üzerinde oluşturalım bunlardan objeler türetelim.
        //Obje, Türkçe dilinde “nesne” anlamına gelir. Bu iki kelime benzer anlamlara sahiptir. Nesne, genellikle cansız varlıkları veya fiziksel varlıkları ifade ederken kullanılır.
    }
}
