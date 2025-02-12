using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPoDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ürün Tanımlama
            Urun u1 = new Urun()
            {
               isim = "Joystick",
               kategori = "Elektronik",
               marka = "Logitech",
               fiyat = 9999
            };

            Urun u2 = new Urun()
            {
                isim = "Akıllı Saat",
                kategori = "Elektronik",
                marka = "Philips",
                fiyat = 24000,
            };

            Urun u3 = new Urun()
            {
                isim = "Televizyon",
                kategori = "Elektronik",
                marka = "Philips",
                fiyat = 24000
            };

            Urun u4 = new Urun()
            {
                isim = "Kalem",
                kategori = "Kırtasiye",
                marka = "Faber Casttle",
                fiyat = 35
            };

            Urun u5 = new Urun()
            {
                isim = "Defter",
                kategori = "Kırtasiye",
                marka = "Faber Casttle",
                fiyat = 35
            };

            Urun u6 = new Urun()
            {
                isim = "Cetvel",
                kategori = "Kırtasiye",
                marka = "Atas",
                fiyat = 20
            };

            Urun u7 = new Urun()
            {
                isim = "Tshirt",
                kategori = "Giyim",
                marka = "Seher Yıldızı",
                fiyat = 250
            };

            Urun u8 = new Urun()
            {
                isim = "Gömlek",
                kategori = "Giyim",
                marka = "DS Damat",
                fiyat = 700
            };

            Urun u9 = new Urun()
            {
                isim = "Pantolon",
                kategori = "Giyim",
                marka = "Mavi",
                fiyat = 1100
            };
            #endregion

            Urun[] urunler = new Urun[] {u1, u2, u3, u4, u5, u6, u7, u8, u9};

            #region Ödev 1 Markaya ve kategoriye göre listelencek.

            Console.WriteLine("Ürün adı - Kategori - Fiyat");
            Console.WriteLine("---------------------------------");

            for (int i = 0; i < urunler.Length; i++) 
            {
                //Console.WriteLine("{0} - {1} - {2} TL", urunler[i].isim, urunler[i].kategori, urunler[i].fiyat);
                Console.WriteLine(urunler[i].isim + " - " + urunler[i].kategori + " - " + urunler[i].fiyat + " TL");
                //Console.WriteLine($"{ urunler[i].isim} - { urunler[i].kategori} - {urunler[i].fiyat} TL");
            }
            Console.WriteLine("----------------------------------");

            
            Console.WriteLine("[1] Giyim");
            Console.WriteLine("[2] Elektronik");
            Console.WriteLine("[3] Kırtasiye");
            Console.WriteLine("[q] Çıkış");

            Console.WriteLine("----------------------------------");

            bool kontrol = true; // kontrol true olduğu sürece çalıştır

            while (kontrol)
            {
                Console.WriteLine("Listelemek istediğiniz ürün kategorisini girin");
                string secim = Console.ReadLine();

                if (secim == "1") 
                {
                    for (int i = 0; i < urunler.Length; i++) 
                    {
                        if (urunler[i].kategori == "Giyim")
                        {
                            Console.WriteLine(urunler[i].isim + " - " + urunler[i].kategori);
                        }
                    }
                }
                else if (secim == "2")
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].kategori == "Elektronik")
                        {
                            Console.WriteLine(urunler[i].isim + " - " + urunler[i].kategori);
                        }
                    }
                 }
                else if (secim == "3")
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].kategori == "Kırtasiye")
                        {
                            Console.WriteLine(urunler[i].isim + " - " + urunler[i].kategori);
                        }
                    }
                }
                else if(secim == "q")
                {
                    kontrol = false;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar deneyiniz.");
                }
                
            }
            #endregion

            #region 
            #endregion
        }
    }
}
