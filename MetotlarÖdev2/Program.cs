using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarÖdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metnin boşluksuz halini yazdırma

            Metinİslemleri mi = new Metinİslemleri();
            //Console.WriteLine(mi.BoslukKırp("."+"Hüseyin SEVİM"));

            //string gelenmetin = mi.SondakiBoslukKırp("Hüseyin    ");
            //Console.WriteLine(gelenmetin+".");

            //string gelenmetin2 = mi.Kirp("   Hüseyin   ");
            //Console.WriteLine("."+gelenmetin2+".");
            #endregion

            #region Metnin içerisine metin arama
            //Console.WriteLine("Lütfen bir metin giriniz: ");
            //string girilenmetin = Console.ReadLine();
            //Console.WriteLine("\n Lütfen aramak istediğiniz karakteri giriniz: ");
            //string arananmetin = Console.ReadLine();

            //Console.WriteLine(mi.varmi(girilenmetin,arananmetin));

            #endregion

            #region Metin içerisinde karakter var mı?
            //Console.WriteLine("Lütfen mail adresinizi giriniz");
            //string mail = Console.ReadLine();

            //if (mi.karakterAra(mail,'@') && mi.karakterAra(mail,'.'))
            //{
            //    Console.WriteLine("Bu bir mail adresidir");
            //}
            //else
            //{
            //    Console.WriteLine("Bu bir mail adresi değildir");
            //}

            #endregion

            #region Metin Büyütme
            //Console.WriteLine(mi.KarakterBuyut("hüseyin"));
            //string buyuk = (mi.KarakterBuyut("hüseyin"));
            //Console.WriteLine(buyuk);
            #endregion

            #region Metin Küçültme
            //Console.WriteLine(mi.KarakterKucult("HUSEYIN"));
            //string kucuk = (mi.KarakterKucult("HUSEYIN"));
            //Console.WriteLine(kucuk);

            #endregion

            #region Karakter Değiştirme
            string metin = "İlk ölümsüz şarkılar dağı şenlendirmiş";

            string yeniMetinEN = mi.KarakterDegistir(metin.ToLower());
            Console.WriteLine(yeniMetinEN);

            #endregion

            #region C# METOTLAR
            //string isim2 = "   Alp";
            //Console.WriteLine(isim2.TrimStart());

            //string isim3 = "Alp    ";
            //Console.WriteLine(isim3.TrimEnd());

            //string isim4 = "   Alp   ";
            //Console.WriteLine(isim4.TrimStart());

            //string mail = "alpsarkisla@gmail.com";
            //Console.WriteLine(mail.Contains("Q") && mail.Contains("."));

            //string isim5 = "alpsarıkısla";
            //Console.WriteLine(isim5.Substring(0,5));

            //string isim6 = "alpsarikisla";
            //Console.WriteLine(isim6.Substring(isim6.Length -5,isim6.Length-1));

            //string isim7 = "alpsarikisla";
            //Console.WriteLine(isim7.Replace(" "," - "));
            #endregion

        }
    }
}
