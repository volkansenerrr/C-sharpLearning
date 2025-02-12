using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazaar
{
    internal class Fis
    {
        public Urun[] urunler;
        public Urun[] sepet;
        public string[] kategoriler;
        public int[] indexler;

        public Fis()
        {
            urunler = new Urun[0];
            sepet = new Urun[0];
            kategoriler = new string[0];
            indexler = new int[0];
        }

        public void UrunEkle(string urunAdi, string birim, string kategori, double fiyat, int stok)
        {
            Urun[] gecici = new Urun[urunler.Length + 1];
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[urunler.Length] = new Urun(urunAdi, birim, kategori, fiyat, stok);
            urunler = gecici;
        }

        public string[] KategoriListesiOlustur()
        {

            for (int i = 0; i < urunler.Length; i++)
            {
                #region Kategori eklenmiş mi ?
                int index = -1;
                for (int j = 0; j < kategoriler.Length; j++)
                {
                    if (urunler[i].kategori == kategoriler[j])
                    {
                        index = j;
                    }
                }
                #endregion

                #region Eklenmemişse ekle
                if (index == -1)
                {
                    string[] gecici = new string[kategoriler.Length + 1];
                    Array.Copy(kategoriler, gecici, kategoriler.Length);
                    gecici[kategoriler.Length] = urunler[i].kategori;
                    kategoriler = gecici;
                }
                #endregion

            }
            return kategoriler;
        }

        public void KategoriYazdir()
        {
            for (int i = 0; i < kategoriler.Length; i++)
            {
                Console.WriteLine("[{0}] {1} ", (i+1), kategoriler[i]);
            }
        }

        public void KategoriyeGoreFiltrele(string islem)
        {

            int intIslem = Convert.ToInt32(islem);
            string seciliKategori = "";
            intIslem -= 1;
            
            #region İşlemin kategorisini belirle
            switch (islem)
            {
                case "1":
                    seciliKategori = "İçecek";
                    break;
                case "2":
                    seciliKategori = "Gıda";
                    break;
                case "3":
                    seciliKategori = "Elektronik";
                    break;
                case "4":
                    seciliKategori = "Temizlik";
                    break;
                case "5":
                    seciliKategori = "Eşya";
                    break;
            }
            #endregion

            #region Filtrelenmiş şekilde yazdır
            int sayac = 1;  // Ürün numaraları için sayaç
            
            for (int i = 0; i < urunler.Length; i++)
            {
                if (urunler[i].kategori == seciliKategori && urunler[i].stok > 0)
                {
                    Console.WriteLine("[{0}] {1} || {2} || {3} TL || Stok : {4}", (sayac), urunler[i].urunAdi, urunler[i].kategori, urunler[i].fiyat, urunler[i].stok);

                    //Listelenen ürünlerin index numaralarını tutan "indexler" dizisi oluşturma
                    IndexlerDizisiOlustur(i);

                    sayac++;
                }
            }
            #endregion
        }

        private void IndexlerDizisiOlustur(int index)
        {
            int[] gecici = new int[indexler.Length + 1];
            Array.Copy(indexler, gecici, indexler.Length);
            gecici[indexler.Length] = index;
            indexler = gecici;
        }

        public int SecilenUrunIndexiDondur(string urunIslem)
        {
            int urunIndexNo = -1;
            if (urunIslem != "q")
            {
                int intUrunIslem = Convert.ToInt32(urunIslem);
                urunIndexNo = indexler[intUrunIslem - 1];
            }
            return urunIndexNo;

        }

        public void SatinAl(string urunIslem, int adet)
        {
            int urunIndexNo = -1;
            if (urunIslem != "q")
            {
                int intUrunIslem = Convert.ToInt32(urunIslem);

                // Filtrelenmiş listede seçilen ürünün, urunler dizisindeki index numarasını bulmak için
                urunIndexNo = indexler[intUrunIslem - 1];

                #region Sepet'e Urun nesnesi ekle

                // Stok kontrolü
                if (urunler[urunIndexNo].stok >= adet)
                {
                    Console.Clear();
                    Console.WriteLine("Ürün sepete eklenmiştir.");

                    Urun[] gecici = new Urun[sepet.Length + 1];
                    Array.Copy(sepet, gecici, sepet.Length);
                    gecici[sepet.Length] = urunler[urunIndexNo];
                    gecici[sepet.Length].stok = adet; // Eklenen üründen kaç tane alındığı bilgisini stokta tutuyoruz.
                    gecici[sepet.Length].fiyat *= adet; // Ürünün toplam fiyatını hesapladık
                    sepet = gecici;

                    indexler = new int[0]; // Sepete ürün ekledikten sonra indexler dizisini 0'lıyoruz.
                }
                else if (urunler[urunIndexNo].stok < adet)
                {
                    Console.WriteLine("Abim o kadar yok be ama söz haftaya gelecek");
                }

                #endregion
            }
        }

        public void SepetGoster()
        {
            Console.WriteLine("SEPETİM");
            for (int i = 0; i < sepet.Length; i++)
            {
                Console.WriteLine("{0}) {1} || x{2} || {3} TL ", (i+1), sepet[i].urunAdi, sepet[i].stok, sepet[i].fiyat);
            }

        }

        public double GenelToplamHesapla()
        {
            double genelToplam = 0;
            for (int i = 0; i < sepet.Length; i++)
            {
                genelToplam += sepet[i].fiyat;
            }

            return genelToplam;
        }

        public void TumUrunleriListele()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("[{0}] {1} || {2} || {3} TL || Stok : {4}", (i+1), urunler[i].urunAdi, urunler[i].kategori, urunler[i].fiyat, urunler[i].stok);

                IndexlerDizisiOlustur(i);
            }
        }

    }
}



