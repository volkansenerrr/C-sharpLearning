using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlamaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İnsan Sınıfı
            //Insan ins = new Insan();
            //ins.isim = "Murtaza";
            //ins.soyisim = "Şuayipoğlu";

            //Insan ins2 = new Insan();
            //ins2.isim = "Davut";
            //ins2.soyisim = "Şakiroğlu";

            //Console.WriteLine(ins.isim + " " + ins.soyisim);
            //Console.WriteLine(ins2.isim + " " + ins2.soyisim);
            #endregion

            #region Öğrenci Sınıfı 

            //Ogrenci ogr = new Ogrenci();
            //ogr.soyisim = "Sarıkışla";
            //ogr.isim = "Alp";
            //ogr.yas = 26;

            //Console.WriteLine($"isim = {ogr.isim} Soyisim = {ogr.soyisim} Yaş = {ogr.yas}");
            //Console.WriteLine("İsim = " + ogr.isim + "Soyisim = " + ogr.soyisim + " Yaş = " + ogr.yas);

            #endregion

            #region Ürün Sınıfı

            Urun u1 = new Urun();
            u1.isim = "Domates";
            u1.kategori = "Gıda";
            u1.birim = "Kg";
            u1.fiyat = 38.50;
            u1.stok = 500;

            Urun u2 = new Urun();
            u2.birim = "Adet";
            u2.fiyat = 19900;
            u2.isim = "Logitech Direksiyon";
            u2.kategori = "Elektronik";
            u2.stok = 2;

            //Her sınıf aynı zamanda bir türdür
            Urun[] urunler = new Urun[3];//ürün türünde 2 eleman alabilen dizi 
            urunler[0] = u1;
            urunler[1] = u2;

            urunler[2] = new Urun();
            urunler[2].isim = "Biber";
            urunler[2].fiyat = 40;
            urunler[2].kategori = "Gıda";
            urunler[2].stok = 50;
            urunler[2].birim = "Kg";

            for (int i = 0; i < urunler.Length; i++) 
            {
                Console.WriteLine(urunler[i].isim + " " + urunler[i].fiyat + " TL");
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Sadece gıda ürünleri");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            for (int i = 0; i < urunler.Length; i++) 
            {
                if (urunler[i].kategori == "Gıda") 
                {
                    Console.WriteLine(urunler[i].isim + " " + urunler[i].kategori + " " + urunler[i].fiyat + " TL");
                }
            }
            #endregion

        }
    }
    class Insan 
    {
        public string isim;
        public string soyisim;
    }
}
