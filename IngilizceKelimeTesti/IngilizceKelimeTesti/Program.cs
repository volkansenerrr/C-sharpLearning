using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngilizceKelimeTesti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region A1 - Sınav 1 Hazırlık

            Soru[] a1sinav1 = new Soru[5];
            a1sinav1[0] = new Soru()
            {
                soruMetni = "Melon",
                cevap = new string[4] {"Çilek","Karpuz","Kavun","Ananas"},
                dogruCevap = "C",
                dogruKelime = "Kavun"

            };
            a1sinav1[1] = new Soru()
            {
                soruMetni = "News",
                cevap = new string[4] { "Yenilikler", "Haberler", "Haber", "Yeniler" },
                dogruCevap = "C",
                dogruKelime = "Haber"
            };
            a1sinav1[2] = new Soru()
            {
                soruMetni = "Winter",
                cevap = new string[4] { "Yaz", "Kış", "Sonbahar", "İlkbahar" },
                dogruCevap = "B",
                dogruKelime = "Kış"
            };
            a1sinav1[3] = new Soru()
            {
                soruMetni = "Cloud",
                cevap = new string[4] { "Yağmur", "Güneş", "Bulut", "Kar" },
                dogruCevap = "C",
                dogruKelime = "Bulut"
            };
            a1sinav1[4] = new Soru()
            {
                soruMetni = "Chair",
                cevap = new string[4] { "Masa", "Sandalye", "Halı", "Dolap" },
                dogruCevap = "B",
                dogruKelime = "Sandalye"
            };

            #endregion

            #region A2 - Sınav 1 Hazırlık

            Soru[] a2sinav1 = new Soru[5];
            a2sinav1[0] = new Soru()
            {
                soruMetni = "Dangerous",
                cevap = new string[4] { "Tehlikeli", "Hassas", "Sert", "Tehlike" },
                dogruCevap = "A",
                dogruKelime = "Tehlikeli"
            };
            a2sinav1[1] = new Soru()
            {
                soruMetni = "Elevator",
                cevap = new string[4] { "Salıncak", "Kaydırak", "Merdiven", "Asansör" },
                dogruCevap = "D",
                dogruKelime = "Asansör"
            };
            a2sinav1[2] = new Soru()
            {
                soruMetni = "Furniture",
                cevap = new string[4] { "Mobilya", "Gelecek", "Gerçek", "Çekmece" },
                dogruCevap = "A",
                dogruKelime = "Mobilya"
            };
            a2sinav1[3] = new Soru()
            {
                soruMetni = "Garlic",
                cevap = new string[4] { "Havuç", "Soğan", "Sarımsak", "Turp" },
                dogruCevap = "C",
                dogruKelime = "Sarımsak"
            };
            a2sinav1[4] = new Soru()
            {
                soruMetni = "Nervous",
                cevap = new string[4] { "Gergin", "Hasta", "Gururlu", "Mutlu" },
                dogruCevap = "A",
                dogruKelime = "Gergin"
            };

            #endregion

            #region B1 - Sınav 1 Hazırlık


            Soru[] b1sinav1 = new Soru[5];
            b1sinav1[0] = new Soru()
            {
                soruMetni = "Funeral",
                cevap = new string[4] { "Cenaze", "Eğlenceli", "Düğün", "Komik" },
                dogruCevap = "A",
                dogruKelime = "Cenaze"
            };
            b1sinav1[1] = new Soru()
            {
                soruMetni = "Guilty",
                cevap = new string[4] { "Sessiz", "Suçlu", "Kelepçe", "Sakin" },
                dogruCevap = "B",
                dogruKelime = "Suçlu"
            };
            b1sinav1[2] = new Soru()
            {
                soruMetni = "Invent",
                cevap = new string[4] { "Hasta olmak", "Davet etmek", "Ziyaret etmek", "İcat etmek" },
                dogruCevap = "D",
                dogruKelime = "İcat Etmek"
            };
            b1sinav1[3] = new Soru()
            {
                soruMetni = "Sneeze",
                cevap = new string[4] { "Bayılmak", "Öksürmek", "Kusmak", "Hapşırmak" },
                dogruCevap = "D",
                dogruKelime = "Hapşırmak"
            };
            b1sinav1[4] = new Soru()
            {
                soruMetni = "Disease",
                cevap = new string[4] { "İğne", "Hastalık", "Sağlık", "Serum" },
                dogruCevap = "B",
                dogruKelime = "Hastalık"
            };

            #endregion

            #region B2 - Sınav 1 Hazırlık

            Soru[] b2sinav1 = new Soru[5];
            b2sinav1[0] = new Soru()
            {
                soruMetni = "Beg",
                cevap = new string[4] { "Çanta", "Sormak", "Dilenmek", "Tokuşturmak" },
                dogruCevap = "C",
                dogruKelime = "Dilenmek"
            };
            b2sinav1[1] = new Soru()
            {
                soruMetni = "Coal",
                cevap = new string[4] { "Tunç", "Kömür", "Bakır", "Kükürt" },
                dogruCevap = "B",
                dogruKelime = "Kömür"
            };
            b2sinav1[2] = new Soru()
            {
                soruMetni = "Marvellous",
                cevap = new string[4] { "Vasat", "Harika", "Korkunç", "Sevimli" },
                dogruCevap = "B",
                dogruKelime = "Harika"
            };
            b2sinav1[3] = new Soru()
            {
                soruMetni = "Insurance",
                cevap = new string[4] { "Ödünç", "Kapora", "Sigorta", "Satmak" },
                dogruCevap = "C",
                dogruKelime = "Sigorta"
            };
            b2sinav1[4] = new Soru()
            {
                soruMetni = "Commerce",
                cevap = new string[4] { "Hakimiyet", "İndirim", "Teslim Olmak", "Ticaret" },
                dogruCevap = "D",
                dogruKelime = "Ticaret"
            };

            #endregion

            #region C1 - Sınav 1 Hazırlık

            Soru[] c1sinav1 = new Soru[5];
            c1sinav1[0] = new Soru()
            {
                soruMetni = "Antibody",
                cevap = new string[4] { "Alerjik", "Vücut için zararlı olan", "Antikor", "Antibiyotik" },
                dogruCevap = "C",
                dogruKelime = "Antikor"
            };
            c1sinav1[1] = new Soru()
            {
                soruMetni = "Embrace",
                cevap = new string[4] { "Ertelemek", "Kucaklaşmak", "Utandırmak", "Sinirlenmek" },
                dogruCevap = "B",
                dogruKelime = "Kucaklaşmak"
            };
            c1sinav1[2] = new Soru()
            {
                soruMetni = "Equivalent",
                cevap = new string[4] { "Ayrışmak", "Eşsiz", "Eşdeğer", "Benzer" },
                dogruCevap = "C",
                dogruKelime = "Eşdeğer"
            };
            c1sinav1[3] = new Soru()
            {
                soruMetni = "Faucet",
                cevap = new string[4] { "Tıpa", "Musluk", "Kapak", "Kolon" },
                dogruCevap = "B",
                dogruKelime = "Musluk"
            };
            c1sinav1[4] = new Soru()
            {
                soruMetni = "Narrative",
                cevap = new string[4] { "Hayal gücü", "Öykü", "Karamsarlık", "Ritim" },
                dogruCevap = "B",
                dogruKelime = "Öykü"
            };

            #endregion

            #region C2 - Sınav 1 Hazırlık

            Soru[] c2sinav1 = new Soru[5];
            c2sinav1[0] = new Soru()
            {
                soruMetni = "Deliberate",
                cevap = new string[4] { "Kasıtlı", "Zorunluluk", "Farkındalık", "Kaçınılmaz" },
                dogruCevap = "A",
                dogruKelime = "Kasıtlı"
            };
            c2sinav1[1] = new Soru()
            {
                soruMetni = "Fraction",
                cevap = new string[4] { "Artış", "Çarpık", "Boşluk", "Kesir" },
                dogruCevap = "D",
                dogruKelime = "Kesir"
            };
            c2sinav1[2] = new Soru()
            {
                soruMetni = "Imperative",
                cevap = new string[4] { "Bitkinlik", "Zorunluluk", "Koşuşturmak", "Çaresizlik" },
                dogruCevap = "B",
                dogruKelime = "Zorunluluk"
            };
            c2sinav1[3] = new Soru()
            {
                soruMetni = "Subsequent",
                cevap = new string[4] { "Baştaki", "Sonraki", "Arkadaki", "Önceki" },
                dogruCevap = "B",
                dogruKelime = "Sonraki"
            };
            c2sinav1[4] = new Soru()
            {
                soruMetni = "Strain",
                cevap = new string[4] { "Güzellik", "Karışık", "Gerginlik", "Akıcı" },
                dogruCevap = "C",
                dogruKelime = "Gerginlik"
            };

            #endregion

            #region Testler

            Test[] testler = new Test[6];
            testler[0] = new Test()
            {
                seviye = "A1",
                gecmePuani = 60,
                soruSayisi = 5,
                sorular = a1sinav1
            };
            testler[1] = new Test()
            {
                seviye = "A2",
                gecmePuani = 60,
                soruSayisi = 5,
                sorular = a2sinav1
            };
            testler[2] = new Test()
            {
                seviye = "B1",
                gecmePuani = 60,
                soruSayisi = 5,
                sorular = b1sinav1
            };
            testler[3] = new Test()
            {
                seviye = "B2",
                gecmePuani = 60,
                soruSayisi = 5,
                sorular = b2sinav1
            };
            testler[4] = new Test()
            {
                seviye = "C1",
                gecmePuani = 60,
                soruSayisi = 5,
                sorular = c1sinav1
            };
            testler[5] = new Test()
            {
                seviye = "C2",
                gecmePuani = 60,
                soruSayisi = 5,
                sorular = c2sinav1
            };

            #endregion

            int puan = 0;
            string secenek = "";
            while (secenek != "h")
            {
                #region Sistemde hazır olan testlerin gösterimi

                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Sistemde bulunan testler");
                for (int i = 0; i < testler.Length; i++)
                {
                    Console.WriteLine("{0}) Seviye : {1} | Soru Sayısı {2} | Geçme Puanı {3}", (i + 1), testler[i].seviye, testler[i].soruSayisi, testler[i].gecmePuani);
                }
                Console.WriteLine("7) Hard mod");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Lütfen girmek istediğiniz testin 'seviyesini' yazınız. (Hard mod için [7])");
                Console.WriteLine("Çıkış için [h]");
                secenek = Console.ReadLine();

                #endregion

                if (secenek != "h")
                {
                    #region Girilen seviyenin testler dizisindeki index numarasını bulma
                    int index = -1;
                    for (int i = 0; i < testler.Length; i++)
                    {
                        if (secenek == testler[i].seviye)
                        {
                            index = i;
                        }
                    }
                    Console.Clear();
                    #endregion

                    #region Normal mod
                    
                    if (secenek != "7")
                    {
                        Console.WriteLine("{0} Seviye Testi Başlıyor...", testler[index].seviye);
                        for (int i = 0; i < testler[index].soruSayisi; i++)
                        {
                            #region Sorunun Gösterimi
                            Console.WriteLine("Soru {0}: {1} kelimesinin Türkçe karşılığı nedir ?", (i + 1), testler[index].sorular[i].soruMetni);
                            Console.WriteLine("A) " + testler[index].sorular[i].cevap[0]);
                            Console.WriteLine("B) " + testler[index].sorular[i].cevap[1]);
                            Console.WriteLine("C) " + testler[index].sorular[i].cevap[2]);
                            Console.WriteLine("D) " + testler[index].sorular[i].cevap[3]);
                            Console.Write("Cevap : ");
                            string cevap = Console.ReadLine();
                            #endregion

                            #region Verilen cevap küçük harf ise büyük harfe döndürülmesi
                            char charCevap = Convert.ToChar(cevap);
                            int intCevap = (int)charCevap;
                            if (intCevap >= 97 && intCevap <= 100)
                            {
                                intCevap -= 32;
                                charCevap = (char)intCevap;
                                cevap = Convert.ToString(charCevap);
                            }
                            #endregion

                            #region Doğru cevap puanlaması

                            if (cevap == testler[index].sorular[i].dogruCevap)
                            {
                                puan += 100 / testler[index].soruSayisi;
                            }
                            Console.Clear();

                            #endregion
                        }

                        Console.WriteLine("Tebrikler testi tamamladınız.");
                        // Testteki kelimelerin doğru cevaplarını gösterme
                        Console.WriteLine("Testteki kelimelerin doğru cevapları aşağıdaki gibidir;");
                        for (int i = 0; i < testler[index].soruSayisi; i++)
                        {
                            Console.WriteLine(testler[index].sorular[i].soruMetni + " -> " + testler[index].sorular[i].dogruKelime);
                        }
                        Console.WriteLine(testler[index].seviye + " Seviyesi puanınız = " + puan);
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Devam etmek ister misiniz ? [e/h]");
                        secenek = Console.ReadLine();
                        if (secenek == "h")
                        {
                            Console.WriteLine("Çıkış yapılıyor..");
                        }
                    }

                    #endregion

                    #region Hard mod

                    else if (secenek == "7")
                    {

                        #region Hard mod bilgilendirme

                        Console.WriteLine("Hard mod, A1 seviyesinden başlayıp C2 seviyesine gelinen bir moddur.");
                        Console.WriteLine("Bulunduğunuz testten geçer not almadığınız sürece bir üst seviyeye geçemezsiniz.");
                        Console.WriteLine("2 Hakkınız vardır. Süreç boyunca 2 kere kalırsanız başa dönersiniz!");
                        Console.WriteLine("C2 seviyesini görebilecek misin ?");
                        Console.WriteLine("Testi başlatmak için [Enter] tuşuna basın.");
                        Console.ReadLine();
                        Console.Clear();

                        #endregion

                        int hak = 2;
                        int hardmodIndex = 0;
                        while (hardmodIndex < 6)
                        {
                            int hardmodPuan = 0;
                            // Hardmod for
                            for (int i = 0; i < testler[hardmodIndex].soruSayisi; i++)
                            {
                                #region Soru gösterimi

                                Console.WriteLine("Test {0}) Seviye : {1} | Soru Sayısı {2} | Geçme Puanı {3}",
                                (hardmodIndex + 1), testler[hardmodIndex].seviye,
                                testler[hardmodIndex].soruSayisi,
                                testler[hardmodIndex].gecmePuani);
                                Console.WriteLine("Hak = " + hak);
                                Console.WriteLine("------------------------------------------------------------------");
                                Console.WriteLine("Soru {0}: {1} kelimesinin Türkçe karşılığı nedir ?", (i + 1), testler[hardmodIndex].sorular[i].soruMetni);
                                Console.WriteLine("A) " + testler[hardmodIndex].sorular[i].cevap[0]);
                                Console.WriteLine("B) " + testler[hardmodIndex].sorular[i].cevap[1]);
                                Console.WriteLine("C) " + testler[hardmodIndex].sorular[i].cevap[2]);
                                Console.WriteLine("D) " + testler[hardmodIndex].sorular[i].cevap[3]);
                                Console.Write("Cevap : ");
                                string cevap = Console.ReadLine();

                                #endregion

                                #region Verilen cevap küçük harf ise büyük harfe döndürülmesi

                                char charCevap = Convert.ToChar(cevap);
                                int intCevap = (int)charCevap;
                                if (intCevap >= 97 && intCevap <= 100)
                                {
                                    intCevap -= 32;
                                    charCevap = (char)intCevap;
                                    cevap = Convert.ToString(charCevap);
                                }

                                #endregion

                                #region Sorunun cevabının kontrolü

                                if (cevap == testler[hardmodIndex].sorular[i].dogruCevap)
                                {
                                    hardmodPuan += 100 / testler[hardmodIndex].soruSayisi;
                                }
                                Console.Clear();

                                #endregion

                            }

                            Console.WriteLine("Tebrikler {0} seviyesi testini tamamladınız.", testler[hardmodIndex].seviye);
                            Console.WriteLine("Puanınız " + hardmodPuan);

                            #region Sonraki seviye için hak kazanma kontrolü ve bitiş 

                            if (hardmodIndex == 5 && hardmodPuan >= 60)
                            {
                                Console.WriteLine("Tebrikler tüm testlerden başarıyla geçtiniz.");
                                Console.WriteLine("!!! Hediye 6'lı falım sakız !!!");
                                hardmodIndex++;
                                Console.ReadLine();
                            }
                            else if (hardmodPuan >= testler[hardmodIndex].gecmePuani)
                            {
                                Console.WriteLine("Tebrikler bir sonraki seviyeye geçebilirsiniz.");
                                Console.WriteLine("Devam etmek için [Enter] tuşuna basınız.");
                                Console.ReadLine();
                                hardmodIndex++;
                                Console.Clear();
                            }
                            else
                            {
                                hak--;
                                if (hak == -1)
                                {
                                    hardmodIndex = 0;
                                    hak = 2;
                                    Console.WriteLine("Maalesef tüm haklarınızı doldurdunuz, başa dönmek zorundasınız.");
                                    Console.WriteLine("Testi tekrar başlatmak için [Enter] tuşuna basınız.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else 
                                {
                                    Console.WriteLine("Malesef {0} testinden geçemediniz. Bir sonraki seviye için geçer not almalısınız.", testler[hardmodIndex].seviye);
                                    Console.WriteLine("Testi tekrar başlatmak için [Enter] tuşuna basınız.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }

                            #endregion
                        }
                    }

                    #endregion
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor..");
                }
            }
        }
    }
}
