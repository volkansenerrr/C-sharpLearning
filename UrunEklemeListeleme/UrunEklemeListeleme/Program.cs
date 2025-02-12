using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunEklemeListeleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ürünlerin Adı, Kategorisi, fiyatı, stok miktarı
            //1 - ürün ekle
            //Ürünün tüm özellikleri konsoldan alınabilecek

            //2 - ürün listele
            //Ürünün kategori veya adına göre filtreleme yapılabilecek
            //filtrelemede ürünün tam adını yazmak zorunda değiliz

            //3 - çıkış
            
            Program p = new Program();
            List<Urun> urunler = new List<Urun>();

            bool devam = true;

            while(devam)
            {
                int secim = p.MenuYazdir();
                if (secim == 1) 
                {
                    Console.Clear();
                    Urun u = new Urun();
                    Console.WriteLine("Ürünün;");
                    Console.Write("Adı=");
                    u.Isim = Console.ReadLine();
                    Console.Write("Kategorisi=");
                    u.Kategori = Console.ReadLine();
                    Console.Write("Fiyat=");
                    u.Fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Stok Miktarı=");
                    u.StokMiktari = Convert.ToInt16(Console.ReadLine());
                    urunler.Add(u);
                }
                if (secim == 2)
                {
                    Console.Clear();
                    foreach (Urun eleman in urunler) 
                    {
                        Console.WriteLine(eleman.Isim + " " + eleman.Kategori + " " + eleman.Fiyat + " " + eleman.StokMiktari);
                    }

                    //for (int i = 0; i < urunler.Count; i++)
                    //{
                    //    Urun u = urunler[i];
                    //    Console.WriteLine(u.Isim + " " + u.Kategori);
                    //}

                }
                if(secim == 3)
                {
                    break;
                }
            }
            
            
        }

        public int MenuYazdir() 
        {
            Console.WriteLine("1 - Ürün Ekle");
            Console.WriteLine("2 - Ürün Listeleme");
            Console.WriteLine("3 - Çıkış");
            Console.Write("İşlem Seçiniz = ");
            int secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
    }
}
