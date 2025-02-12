using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Belirli bir işi yapmak için oluşturulmuş küçük program parçasıdır.

            #endregion

            #region Çırak sınıfı ile metotları öğreniyorum
            //Cirak c = new Cirak();
            //c.isim = "Murtaza";
            //c.soyisim = "Şuayipoğlu";

            //c.SelamSoyle();
            //c.IsmeSelamSoyle("Şuayip");
            //c.IsmeSelamSoyle("Alp");

            //c.CaySoyle(4, "Remzi");

            //c.IsmeCokSelamSoyle("Hamza", 5);

            ////string isim = Console.ReadLine();
            ////Console.WriteLine();;

            //double paraustu = c.KolaAl(2, 120);
            //Console.WriteLine("Para üstü = " + paraustu);

            #endregion

            #region Matematik Sınıfı Uygulamaları

            //Matematik mat = new Matematik();
            //mat.ToplaYazdir(12, 15);

            //int toplam = mat.Topla(45, 15);
            //Console.WriteLine(toplam + 2);

            //Console.WriteLine("Toplam = " + mat.StringTopla("20", "15"));

            //Console.WriteLine(mat.KareAl(10));

            //Console.WriteLine(mat.UsAL(2,5));

            #endregion

            #region MetinIslem Sınıfı İşlemleri 

            //MetinIslem yardimci = new MetinIslem();

            //Console.WriteLine("Lütfen mail adresinizi giriniz");
            //string mail = Console.ReadLine();

            //if(yardimci.iceriyormu(mail, '@'))
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen geçerli bir mail adresi giriniz");
            //}

            #endregion

            #region Boşluk temizle

            //MetinIslem met = new MetinIslem();
            //Console.WriteLine("Yaz bakalım");
            //string yazi = Console.ReadLine();

            //string bosluksuz = met.boslukTemizle(yazi);

            //Console.Write(bosluksuz);


            #endregion

            #region Karakter değiştir

            //MetinIslem met = new MetinIslem();
            //Console.WriteLine("Yaz bakalım");
            //string yazi = Console.ReadLine();

            //string yeniYazi = met.karakterDegistir(yazi);
            //Console.WriteLine("Yeni yazın " + yeniYazi);

            #endregion

            #region büyük harfi küçült

            MetinIslem met = new MetinIslem();

            Console.WriteLine("lütfen büyük karakter giriniz");
            char karakter = Convert.ToChar(Console.ReadLine());

            char isim = met.krktr(karakter);
            Console.WriteLine(isim);

            Console.WriteLine("lütfen küçük karakter giriniz");
            char karakter2 = Convert.ToChar(Console.ReadLine());

            char isim1 = met.kucuk(karakter2);
            Console.WriteLine(isim1);
            #endregion
        }
    }
}
