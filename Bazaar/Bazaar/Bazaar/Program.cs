using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BAZAAAAARRR");

            #region Ürün Ekle

            Fis fis = new Fis();
            Random rnd = new Random();

            fis.UrunEkle("Coca Cola", "Lt", "İçecek", 25.50, rnd.Next(0, 21));
            fis.UrunEkle("Sütaş Yoğurt", "Kg", "Gıda", 39.95, rnd.Next(0, 21));
            fis.UrunEkle("Maden Suyu", "Lt","İçecek", 32.95, rnd.Next(0, 21));
            fis.UrunEkle("Fuse Tea", "Lt", "İçecek", 20.95, rnd.Next(0, 21));
            fis.UrunEkle("Pirinç", "Kg", "Gıda", 134, rnd.Next(0, 21));
            fis.UrunEkle("Un", "Kg", "Gıda", 68.95, rnd.Next(0, 21));
            fis.UrunEkle("Powerbank", "Adet", "Elektronik", 169.95, rnd.Next(0, 21));
            fis.UrunEkle("Elektrikli Süpürge", "Adet", "Elektronik", 629.97, rnd.Next(0, 21));
            fis.UrunEkle("Playstation 6", "Adet", "Elektronik", 34000, 0);
            fis.UrunEkle("Tost Makinesi", "Adet", "Elektronik", 594.97, rnd.Next(0, 21));
            fis.UrunEkle("Asperox", "Adet", "Temizlik", 79.95, rnd.Next(0, 21));
            fis.UrunEkle("Yüzey Temizleyici", "Adet", "Temizlik", 59.95, rnd.Next(0, 21));
            fis.UrunEkle("Camsil", "Adet", "Temizlik", 95.95, rnd.Next(0, 21));
            fis.UrunEkle("Küllük", "Adet", "Eşya", 19.95, rnd.Next(0, 21));
            fis.UrunEkle("Kamp Sandalyesi", "Adet", "Eşya", 309.95, rnd.Next(0, 21));
            fis.UrunEkle("Koltuk", "Adet", "Eşya", 899.95, rnd.Next(0, 21));
            fis.UrunEkle("Raf", "Adet", "Eşya", 95.95, rnd.Next(0, 21));

            fis.KategoriListesiOlustur();
            #endregion

            string islem = "";
            while (islem != "q")
            {
                #region Menü

                Console.WriteLine("[1] Kategorileri Listele");
                Console.WriteLine("[2] Tüm Ürünleri Listele");
                Console.WriteLine("[3] Sepete Git");
                islem = Console.ReadLine();

                #endregion

                switch (islem)
                {

                    #region Kategoriye Göre Listele

                    case "1":
                        Console.Clear();

                        Console.WriteLine("KATEGORİLER");
                        fis.KategoriYazdir();
                        Console.WriteLine("Lütfen kategori numarasını giriniz");
                        string kategoriIslem = Console.ReadLine();
                        Console.Clear();

                        fis.KategoriyeGoreFiltrele(kategoriIslem);

                        Console.WriteLine("Almak istediğiniz ürün numarasını girin : ");
                        Console.WriteLine("Çıkış için [q]");
                        string urunIslem = Console.ReadLine();

                        int seciliUrunIndexi = fis.SecilenUrunIndexiDondur(urunIslem); // Ürünün asıl index'ini alma
                        Urun seciliUrun = fis.urunler[seciliUrunIndexi];// Urun nesnesi oluşturarak yazım kısaltma

                        Console.WriteLine("Kaç {0} {1} almak istersiniz ? Stok : {2}", seciliUrun.birim, seciliUrun.urunAdi, seciliUrun.stok);
                        int adet = Convert.ToInt32(Console.ReadLine());

                        fis.SatinAl(urunIslem, adet);
                        break;

                    #endregion

                    #region Tüm Ürünleri Listele

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Tüm Ürünler");

                        fis.TumUrunleriListele();

                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Almak istediğiniz ürün numarasını girin : ");
                        Console.WriteLine("Çıkış için [q]");
                        urunIslem = Console.ReadLine();
                        seciliUrun = fis.urunler[Convert.ToInt32(urunIslem) - 1];

                        Console.WriteLine("Kaç {0} {1} almak istersiniz ? Stok : {2}", seciliUrun.birim, seciliUrun.urunAdi, seciliUrun.stok);
                        adet = Convert.ToInt32(Console.ReadLine());

                        fis.SatinAl(urunIslem, adet);
                        break;

                    #endregion

                    #region Sepet

                    case "3":
                        fis.SepetGoster();

                        double toplam = fis.GenelToplamHesapla();

                        Console.WriteLine("Genel Toplam : " + toplam);
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz...");
                        islem = "q";
                        break;

                    #endregion

                }
            }
        }
    }
}
