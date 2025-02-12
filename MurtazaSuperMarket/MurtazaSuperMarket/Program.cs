using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurtazaSupermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun[] urunler = new Urun[5];

            #region Ürün Tanımlamaları

            Urun urn = new Urun();
            urn.Isim = "Forforlu Kalam";
            urn.Marka = "Faber Castel";
            urn.Kategori = "Kırtasiye";
            urn.Fiyat = 50;
            urunler[0] = urn;

            Urun urn1 = new Urun(){ Isim = "Fosforlu Kalem", Marka = "Pelikan", Kategori = "Kırtasiye", Fiyat = 80 };
            urunler[1] = urn1;
            urunler[2] = new Urun() { Isim = "T-Shirt", Marka = "Mavi", Kategori = "Giyim", Fiyat = 250 };
            urunler[3] = new Urun() { Isim = "T-Shirt", Marka = "Tudors", Kategori = "Giyim", Fiyat = 300 };
            urunler[4] = new Urun() { Isim = "Defter", Marka = "Faber Castel", Kategori = "Kırtasiye", Fiyat = 300 };

            #endregion

            #region Menü Yazdırma

            string secim = "0";

            while (secim != "4")
            {
                Console.WriteLine();
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("*-*-*-*-*-*-* MENÜ *-*-*-*-*-*-");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine();
                Console.WriteLine("1) Kategoriye Göre Ürünler");
                Console.WriteLine("2) Markaya Göre Ürünler");
                Console.WriteLine("3) Tüm Ürünler");
                Console.WriteLine("4) Çıkış");
                Console.WriteLine("Lütfen Seçiniz");
                secim = Console.ReadLine();

                if (secim == "3")
                {
                    Console.Clear();
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i+1}) {urunler[i].Isim} {urunler[i].Kategori} {urunler[i].Marka} {urunler[i].Fiyat} TL");
                    }
                }
                if (secim == "1")
                {
                    Console.Clear();
                    Console.WriteLine("1) Kırtasiye");
                    Console.WriteLine("2) Giyim");
                    Console.WriteLine("Lütfen Seçiniz");
                    string kategorisecim = Console.ReadLine();
                    string kategori = "";
                    if (kategorisecim == "1")
                    {
                        kategori = "Kırtasiye";
                    }
                    else if(kategorisecim == "2")
                    {
                        kategori = "Giyim";
                    }
                    Console.Clear();
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].Kategori == kategori)
                        {
                            Console.WriteLine($"{i + 1}) {urunler[i].Isim} {urunler[i].Marka} {urunler[i].Fiyat} TL");
                        }
                    }
                }
                if (secim == "2")
                {
                    Console.Clear();
                    Console.WriteLine("1) Faber Castel");
                    Console.WriteLine("2) Pelikan");
                    Console.WriteLine("3) Tudors");
                    Console.WriteLine("4) Mavi");
                    Console.WriteLine("Lütfen Seçiniz");
                    string markasecim = Console.ReadLine();
                    string marka = "";
                    switch (markasecim)
                    {
                        case "1":
                            marka = "Faber Castel";
                                break;
                        case "2":
                            marka = "Pelikan";
                            break;
                        case "3":
                            marka = "Tudors";
                            break;
                        case "4":
                            marka = "Mavi";
                            break;
                    }
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].Marka == marka)
                        {
                            Console.WriteLine($"{i + 1}) {urunler[i].Isim} {urunler[i].Kategori} {urunler[i].Fiyat} TL");
                        }
                    }
                }
            }

            #endregion
        }
    }
}
