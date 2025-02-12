using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasiOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("ibm857");

            #region Ürün Nesneleri
            Kitap u1 = new Kitap()
            {
                Adi = "RESİMLERLE SOSYOLOJİ",
                SayfaSayisi = 117,
                Yazari = "MİCHAEL HARALAMBOS",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u2 = new Kitap()
            {
                Adi = "DEADPOOL",
                SayfaSayisi = 254,
                Yazari = "GERRY DUGGAN",
                Turu = "Çizgi Roman"
            };
            Kitap u3 = new Kitap()
            {
                Adi = "ATATÜRK'ÜN KURDUĞU KURUMLAR",
                SayfaSayisi = 240,
                Yazari = "CEVAT ŞENOL",
                Turu = "Tarih"
            };
            Kitap u4 = new Kitap()
            {
                Adi = "MUSTAFA KEMAL'İN AĞZINDAN VAHDETTİN",
                SayfaSayisi = 136,
                Yazari = "FALİH RIFKI ATAY",
                Turu = "Tarih"
            };
            Kitap u5 = new Kitap()
            {
                Adi = "ATATÜRK VE CHP SAKLI TARİHİ",
                SayfaSayisi = 288,
                Yazari = "ALİ KUZU",
                Turu = "Tarih"
            };
            Kitap u6 = new Kitap()
            {
                Adi = "ANILARLA ATATÜRK",
                SayfaSayisi = 216,
                Yazari = "CEVAT ŞENOL",
                Turu = "Tarih"
            };
            Kitap u7 = new Kitap()
            {
                Adi = "ASKERİ DEHA",
                SayfaSayisi = 176,
                Yazari = "KAHRAMAN YUSUFOĞLU",
                Turu = "Tarih"
            };
            Kitap u8 = new Kitap()
            {
                Adi = "KOMUNİST MANİFESTO",
                SayfaSayisi = 101,
                Yazari = "KARL MARX - FREDERİCH ENGELS",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u9 = new Kitap()
            {
                Adi = "SOSYOLOJİ NEDİR ?",
                SayfaSayisi = 309,
                Yazari = "NORMBERT ELIAS",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u10 = new Kitap()
            {
                Adi = "SOSYAL DEMOKRASİ İDEOLOJİSİ",
                SayfaSayisi = 333,
                Yazari = "ADNAN GÜRİZ",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u11 = new Kitap()
            {
                Adi = "HERKES İÇİN İKTİSAT(KAPİTALİST SÖMÜRÜYÜ ANLAMA KILAVUZU",
                SayfaSayisi = 336,
                Yazari = "JİM STAFFORD",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u12 = new Kitap()
            {
                Adi = "CUMHURİYET TARİHİ YALANLARI",
                SayfaSayisi = 528,
                Yazari = "SİNAN MEYDAN",
                Turu = "Tarih"
            };
            Kitap u13 = new Kitap()
            {
                Adi = "DEİZM",
                SayfaSayisi = 331,
                Yazari = "YAŞAR NURİ ÖZTÜRK",
                Turu = "Felsefe"
            };
            Kitap u14 = new Kitap()
            {
                Adi = "DEVRİMLERİN EFENDİSİ",
                SayfaSayisi = 152,
                Yazari = "OSMAN PAMUKOĞLU",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u15 = new Kitap()
            {
                Adi = "BEYAZ ZAMBAKLAR ÜLKESİNDE",
                SayfaSayisi = 255,
                Yazari = "GRIGORY PETROV",
                Turu = "Dünya Klasikleri"
            };
            Kitap u16 = new Kitap()
            {
                Adi = "SHERLOCK HOLMES GİBİ DÜŞÜNMEK",
                SayfaSayisi = 326,
                Yazari = "MARİA KONNİKOVA",
                Turu = "Kişisel Gelişim"
            };
            Kitap u17 = new Kitap()
            {
                Adi = "GOEBBELS BÜYÜK YALANLAR",
                SayfaSayisi = 469,
                Yazari = "PAUL JOSEPH GOEBBELS",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u18 = new Kitap()
            {
                Adi = "1984",
                SayfaSayisi = 350,
                Yazari = "GEORGE ORWELL",
                Turu = "Politik Kurgu"
            };
            Kitap u19 = new Kitap()
            {
                Adi = "HACHIKO",
                SayfaSayisi = 123,
                Yazari = "LESLIA NEWMAN",
                Turu = "Roman"
            };
            Kitap u20 = new Kitap()
            {
                Adi = "BİR İDAM MAHKUMUNUN SON GÜNÜ",
                SayfaSayisi = 144,
                Yazari = "VICTOR HUGO",
                Turu = "Roman"
            };
            Kitap u21 = new Kitap()
            {
                Adi = "İNSAN NE İLE YAŞAR ?",
                SayfaSayisi = 117,
                Yazari = "LEV TOLSTOY",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u22 = new Kitap()
            {
                Adi = "KAVGAM",
                SayfaSayisi = 597,
                Yazari = "ADOLF HİTLER",
                Turu = "Politik"
            };
            Kitap u23 = new Kitap()
            {
                Adi = "KÖY ENSİTÜTÜLERİ",
                SayfaSayisi = 320,
                Yazari = "AHMET SEYREK",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u24 = new Kitap()
            {
                Adi = "FAŞİZM",
                SayfaSayisi = 156,
                Yazari = "BENİTO MUSSOLONİ",
                Turu = "Politik"
            };
            Kitap u25 = new Kitap()
            {
                Adi = "CHE GUEVARA",
                SayfaSayisi = 490,
                Yazari = "YAŞAR ŞAHİN ANIL",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u26 = new Kitap()
            {
                Adi = "DAS KAPİTAL",
                SayfaSayisi = 400,
                Yazari = "KARL MARX",
                Turu = "Felsefe"
            };
            Kitap u27 = new Kitap()
            {
                Adi = "RÜYANIN PSİKOLOJİSİ",
                SayfaSayisi = 191,
                Yazari = "JACQUES MONTANGERO",
                Turu = "Psikoloji"
            };
            Kitap u28 = new Kitap()
            {
                Adi = "SHERLOCK HOLMES KIZIL DOSYA",
                SayfaSayisi = 192,
                Yazari = "SİR ARTHUR CONAN DOYLE",
                Turu = "Polisiye"
            };
            Kitap u29 = new Kitap()
            {
                Adi = "SHERLOCK HOLMES AKIL OYUNLARININ GÖLGESİNDE",
                SayfaSayisi = 382,
                Yazari = "SİR ARTHUR CONAN DOYLE",
                Turu = "Polisiye"
            };
            Kitap u30 = new Kitap()
            {
                Adi = "İNCİL",
                SayfaSayisi = 462,
                Yazari = "KİTABI MUKADDES ŞİRKETİ",
                Turu = "Dini"
            };
            Kitap u31 = new Kitap()
            {
                Adi = "ANARŞİZM",
                SayfaSayisi = 127,
                Yazari = "COLİN WARD",
                Turu = "Felsefe"
            };
            Kitap u32 = new Kitap()
            {
                Adi = "TÜRK ROCK 2000",
                SayfaSayisi = 200,
                Yazari = "GÜVEN ERKİN ARKAL",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u33 = new Kitap()
            {
                Adi = "NUTUK",
                SayfaSayisi = 500,
                Yazari = "MUSTAFA KEMAL ATATÜRK",
                Turu = "Tarih"
            };
            Kitap u34 = new Kitap()
            {
                Adi = "DEVLET VE ANARŞİ",
                SayfaSayisi = 291,
                Yazari = "MİHAİL BAKUNİN",
                Turu = "Araştırma-İnceleme"
            };
            Kitap u35 = new Kitap()
            {
                Adi = "FELSEFE NEDİR ?",
                SayfaSayisi = 175,
                Yazari = "LYDIA KORSHUNOVA",
                Turu = "Araştırma-İnceleme"
            };

            #endregion

            Kitap[] kitaplar = { u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, u11, u12, u13, u14, u15, u16, u17, u18, u19, u20, u21, u22, u23, u24, u25, u26, u27, u28, u29, u30, u31, u32, u33, u34, u35 };

            bool kontrol = true;

            while (kontrol)
            {
                Console.WriteLine("VOLKİ TOLKİ KÜTÜPHANE UYGULAMASINA HOŞGELDİNİZ (:");
                Console.WriteLine("[1] Yazara göre ara");
                Console.WriteLine("[2] Türe göre ara");
                Console.WriteLine("[3] Tüm kitapları listele");
                Console.WriteLine("[4] Çıkış");
                string menuSecim = Console.ReadLine();
                Console.Clear();

                if (menuSecim == "1") 
                {
                    Console.WriteLine("Aramak istediğiniz kitabın yazarını giriniz.");
                    string yazarAdi = Console.ReadLine();
                    Console.Clear();

                    for (int i = 0; i < kitaplar.Length; i++)
                    {
                        if (kitaplar[i].Yazari == yazarAdi) 
                        {
                            Console.WriteLine(kitaplar[i].Adi);
                        }
                        else
                        {
                            Console.WriteLine("Kütüphanemizde aradığınız yazara ait kitap bulunamadı.");
                            break;
                        }
                    }
                }
                if (menuSecim == "2")
                {
                    Console.WriteLine("Aramak istediğiniz kitabın türünü giriniz.");
                    string turAdi = Console.ReadLine();

                    for (int i = 0; i < kitaplar.Length; i++)
                    {
                        if (kitaplar[i].Turu == turAdi)
                        {
                            Console.WriteLine(kitaplar[i].Turu);
                        }
                        else
                        {
                            Console.WriteLine("Kütüphanemizde aradınız türe göre kitap bulunamadı");
                        }
                    }
                }
                if (menuSecim == "3")
                {

                    for (int i = 0; i < kitaplar.Length; i++)
                    {
                        Console.WriteLine(kitaplar[i]);
                    }
                }
                if (menuSecim == "4")
                {

                    Console.WriteLine("Güle güle (:");
                    break;
                }
            }
        }
    }
}
