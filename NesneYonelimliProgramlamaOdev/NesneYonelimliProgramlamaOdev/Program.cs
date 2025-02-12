using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlamaOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ödev1: Ürünler listelenecek, satın almak istenilen ürün numarası girilecek. Kaç kg domates alacaksın diye soracak mesela. 
             * Stok yeterli ise istediği kadar ürün toplama eklenecek, stok yetersiz ise stok miktarı kadar ürün eklenecek. 
             * Alışverişe devam etmek istiyor musun şeklinde sorulduğunda hayır denirse eğer toplam fiyat 1000 tl üzerinde ise bişeyler hediye edin.
            */

            Console.OutputEncoding = Encoding.GetEncoding("ibm857");

            Urun[] urunler = new Urun[6];

            #region Ürün Tanımlamaları
            Urun u1 = new Urun();
            u1.isim = "Domates";
            u1.kategori = "Gıda";
            u1.birim = "Kg";
            u1.fiyat = 38.50;
            u1.stok = 500;
            urunler[1] = u1;

            Urun u2 = new Urun();
            u2.isim = "Biber";
            u2.kategori = "Gıda";
            u2.birim = "Kg";
            u2.fiyat = 79.95;
            u2.stok = 500;
            urunler[2] = u2;

            Urun u3 = new Urun();
            u3.isim = "Patlıcan";
            u3.kategori = "Gıda";
            u3.birim = "Kg";
            u3.fiyat = 58.95;
            u3.stok = 500;
            urunler[3] = u3;

            Urun u4 = new Urun();
            u4.isim = "Fasülye";
            u4.kategori = "Gıda";
            u4.birim = "Kg";
            u4.fiyat = 57.90;
            u4.stok = 500;
            urunler[4] = u4;

            Urun u5 = new Urun();
            u5.isim = "Soğan";
            u5.kategori = "Gıda";
            u5.birim = "Kg";
            u5.fiyat = 10;
            u5.stok = 500;
            urunler[5] = u5;

            Urun u6 = new Urun();
            u6.isim = "Limon";
            u6.kategori = "Gıda";
            u6.birim = "Adet";
            u6.fiyat = 20;
            u6.stok = 500;
            urunler[6] = u6;
            #endregion

            

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Volki Türko Market'e Hoşgeldiniz (:");
            Console.WriteLine("-----------------------------------");

            //Menü yazdıralım

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i+1}) {urunler[i].isim} {urunler[i].fiyat} TL");
            }

            bool devam = true;
            
            double toplam = 0;

            while (devam)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Lütfen almak istediğiniz ürün numarasını giriniz");
                int urunno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------");
                int index = urunno - 1;

                Console.WriteLine($"Kaç {urunler[index].birim} {urunler[index].isim} alacaksınız?");
                int adet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                if (adet <= urunler[index].stok) 
                {
                    toplam += urunler[index].fiyat * adet;
                    urunler[index].stok -= adet;
                }
                else
                {
                    Console.WriteLine($"stoktaki {urunler[index].stok} {urunler[index].birim} {urunler[index].isim} tamamı verildi.");
                    toplam += urunler[index].stok * urunler[index].fiyat;
                    toplam += urunler[index].stok = 0;
                }

                Console.WriteLine("Alışverişe devam edilsin mi?");
                string secim = Console.ReadLine();
                if (secim != "e") 
                {
                    devam = false;
                }
            }
            Console.WriteLine("Alışveriş için mersi janıms!!!");
            if (toplam >= 1000) 
            {
                Console.WriteLine("1 Litre cam suyu kazandınız");
            }
            else
            {
                Console.WriteLine("Hiç bir şey kazanmadınız");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Volki Türko Market iyi günler diler (:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("TOPLAM = " + toplam + " TL");
            Console.ReadKey();
        }
        
    }   }  
