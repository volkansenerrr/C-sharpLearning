using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneYonelimliProgramlama_2
{
    public class Araba //Araba adında bir tane class oluşturdum.public ne olduğunu sonraki ders öğreneceğim.Araba class'ımın içerisine geldim şuanda boş bir araba gibi düşüneceğiz.
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;
        //özelliklerimizi tanımlayabiliriz.
        //Sonra metotlar tanımlayabiliriz

        public void motorCalistir() //public diyorum void(geriye herhangi bir değer döndürmeyen) bir metot tanımlamak istiyorum.
        {
            Console.WriteLine("Motor çalışıyor..."); //Ekrana bunu yazdıran basit bir metot tanımladım.
        }

        public void kapilariKilitle() 
        {
            Console.WriteLine("Kapılar kilitleniyor...");
        }

        //Bir önceki derste yaptığımız işlemin aynısını projemizin üzerinde yaptık.kapiSayisi, arabaModel, arabaRengi adında 3 adet property(özellik) ifade eden değişken tanımladım.
        //Sonra Araba class'ımın içerisine 2 adet metot tanımladım.Çok basit iki iş yapan metot tanımımız var.
        //Sınıfımı tanımladım bunu kullanmak istiyorum nasıl kullanacağım ? Main metoduma gelip class'ımdan bir tane nesne oluşturup bunu kullanmam gerekiyor.Bir sonraki derste oluşturulan classları 
        //nasıl kullanabiliriz onu göreceğiz.
    }
}
