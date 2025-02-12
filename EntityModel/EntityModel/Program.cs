using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VeriErisimKatmani;
using System.Runtime.InteropServices;

namespace EntityModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VeriModeli db = new VeriModeli();
            //Kategori k = new Kategori();
            //k.Isim = "Muro";
            //k.Aciklama = "Muro Muro Muro";

            #region Kategori ekledik
            //if (db.KategoriEkle(k))
            //{
            //    Console.WriteLine("Kategori Başarı ile Eklendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Hata Oluştu");
            //}
            #endregion

            #region Kategori Listeledik

            //List<Kategori> kategoriler = db.KategorileriGetir();

            //for (int i = 0; i < kategoriler.Count; i++)
            //{
            //    Console.WriteLine($"{kategoriler[i].KategoriID}){kategoriler[i].Isim}");
            //}

            #endregion

            string secenek = "";

            while (secenek != "q")
            {
                Console.Clear();
                Console.WriteLine("*-*-*-*-NORTH WIND-*-*-*-*");
                Console.WriteLine("Kategori İşlemleri");
                Console.WriteLine("\t1-Listele");
                Console.WriteLine("\t2-Ekle");
                Console.WriteLine("\t3-Güncelle");
                Console.WriteLine("\t4-Sil");
                Console.WriteLine("Lütfen işlem numarasını giriniz.");
                string islem = Console.ReadLine();
                Console.Clear();
                switch (islem)
                {
                    case "1":
                        Listele();
                        break;
                    case "2":
                        Kategori k1 = new Kategori();
                        Console.Write("Kategori Adı = ");
                        k1.Isim = Console.ReadLine();
                        Console.Write("Kategori Açıklama = ");
                        k1.Aciklama = Console.ReadLine();
                        if (db.KategoriEkle(k1))
                        {
                            Console.WriteLine("Kategori Eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Kategori Eklenirken bir hata oluştu.");
                        }
                        break;
                    case "3":
                        Listele();
                        Kategori k2 = new Kategori();
                        Console.WriteLine("Güncellemek istediğiniz kategorinin numarasını giriniz");
                        k2.KategoriID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kategori Adı = ");
                        k2.Isim = Console.ReadLine();
                        Console.Write("Kategori Açıklama = ");
                        k2.Aciklama = Console.ReadLine();
                        if (db.KategoriGuncelle(k2))
                        {
                            Console.WriteLine("Güncelleme Başarılı");
                        }
                        else
                        {
                            Console.WriteLine("Güncelleme Başarısız");
                        }
                        break;
                    case "4":
                        Listele();
                        Console.WriteLine("Silmek istediğiniz kategorinin numarasını giriniz");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (db.KategoriSil(id))
                        {
                            Console.WriteLine("Kategori Başarı Silindi");
                        }
                        else
                        {
                            Console.WriteLine("Bir şeyler Ters Gitti");
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem seçildi");
                        break;
                }
                Console.Beep(700, 600);

                Console.WriteLine("Çıkış için q ya devam etmek için enter'a basınız");
                secenek = Console.ReadLine();
            }
        }

        public static void Listele()
        {
            VeriModeli db = new VeriModeli();
            List<Kategori> kategoriler = db.KategorileriGetir();
            foreach (var item in kategoriler)
            {
                Console.WriteLine(item.KategoriID + " ) " + item.Isim + " " + item.Aciklama);
            }

        }
    }
}
