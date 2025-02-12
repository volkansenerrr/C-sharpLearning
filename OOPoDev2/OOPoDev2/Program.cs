using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPoDev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.GetEncoding("ibm857");

            #region Ürün Nesneleri
            // Ayakkabı - Start
            Urun u1 = new Urun()
            {
                isim = "Runfalcon 3.0",
                marka = "Adidas",
                kategori = "Ayakkabı",
                fiyat = 2099
            };
            Urun u2 = new Urun()
            {
                isim = "Advantage k",
                marka = "Adidas",
                kategori = "Ayakkabı",
                fiyat = 1579,
            };
            Urun u3 = new Urun()
            {
                isim = "Hoops 3.0",
                marka = "Adidas",
                kategori = "Ayakkabı",
                fiyat = 2449,

            };
            Urun u4 = new Urun()
            {
                isim = "Club C 85",
                marka = "Reebok",
                kategori = "Ayakkabı",
                fiyat = 2889.99,
            };
            Urun u5 = new Urun()
            {
                isim = "Smash Edge 5",
                marka = "Reebok",
                kategori = "Ayakkabı",
                fiyat = 1999.99,
            };
            Urun u6 = new Urun()
            {
                isim = "SuperStar",
                marka = "Adidas",
                kategori = "Ayakkabı",
                fiyat = 3000,
            };
            Urun u7 = new Urun()
            {
                isim = "Revolotion 6",
                marka = "Nike",
                kategori = "Ayakkabı",
                fiyat = 2299.99,
            };
            Urun u8 = new Urun()
            {
                isim = "Revolotion 7",
                marka = "Nike",
                kategori = "Ayakkabı",
                fiyat = 3000,
            };
            // Ayakkabı - End

            // Pantolon - Start
            Urun u9 = new Urun()
            {
                isim = "Tapered",
                marka = "Mavi",
                kategori = "Pantolon",
                fiyat = 1099.99,
            };
            Urun u10 = new Urun()
            {
                isim = "Classic Denim",
                marka = "Mavi",
                kategori = "Pantolon",
                fiyat = 1000,
            };
            Urun u11 = new Urun()
            {
                isim = "Jeans",
                marka = "ElitWear",
                kategori = "Pantolon",
                fiyat = 419.90,
            };
            Urun u12 = new Urun()
            {
                isim = "Forclaz",
                marka = "Decathlon",
                kategori = "Pantolon",
                fiyat = 1155,
            };
            Urun u13 = new Urun()
            {
                isim = "Classic Denim",
                marka = "Buratti",
                kategori = "Pantolon",
                fiyat = 509.99,
            };

            // Pantolon - End

            // Tshirt - Start
            Urun u14 = new Urun()
            {
                isim = "Brooklyn",
                marka = "Modarich",
                kategori = "Tshirt",
                fiyat = 349.99,
            };
            Urun u15 = new Urun()
            {
                isim = "Cool Tarz",
                marka = "Füme",
                kategori = "Tshirt",
                fiyat = 295.99,
            };
            Urun u16 = new Urun()
            {
                isim = "Boston",
                marka = "Adrift",
                kategori = "Tshirt",
                fiyat = 179.99,
            };
            Urun u17 = new Urun()
            {
                isim = "Regular",
                marka = "Kaft",
                kategori = "Tshirt",
                fiyat = 600,
            };
            Urun u18 = new Urun()
            {
                isim = "Balance",
                marka = "Palpito",
                kategori = "Tshirt",
                fiyat = 123.99,
            };
            // Tshirt - End
            #endregion

            Urun[] urunler = { u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, u11, u12, u13, u14, u15, u16, u17, u18 };

            bool kontrol = true;

            while (kontrol)
            {
                Console.WriteLine("Listelemek istediğiniz ürün kategorisini seçiniz.");
                Console.WriteLine("[1] Ayakkabı");
                Console.WriteLine("[2] Pantolon");
                Console.WriteLine("[3] Tshirt");
                Console.WriteLine("[4] Tüm Ürünler");
                Console.WriteLine("[V] Çıkış");
                string kategoriSecim = Console.ReadLine();

                if (kategoriSecim == "1")
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].kategori == "Ayakkabı")
                        {
                            Console.WriteLine("Lütfen bir marka seçiniz");
                            Console.WriteLine("[1] Adidas");
                            Console.WriteLine("[2] Reebok");
                            Console.WriteLine("[3] Nike");
                            Console.WriteLine("[4] Tümü");
                            Console.WriteLine("[q] Ana Menü");
                            string markaSecim = Console.ReadLine();
                            if (markaSecim == "1")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Adidas")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "2")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Reebok")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "3")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Nike")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "4")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].kategori == "Ayakkabı")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "q")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız.");
                            }
                        }
                    }

                }
                else if (kategoriSecim == "2")
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].kategori == "Pantolon")
                        {
                            Console.WriteLine("Lütfen bir marka seçiniz");
                            Console.WriteLine("[1] Mavi");
                            Console.WriteLine("[2] ElitWear");
                            Console.WriteLine("[3] Decathlon");
                            Console.WriteLine("[4] Buratti");
                            Console.WriteLine("[5] Tümü");
                            Console.WriteLine("[q] Ana Menü");
                            string markaSecim = Console.ReadLine();
                            if (markaSecim == "1")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Mavi")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "2")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "ElitWear")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "3")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Decathlon")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "4")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Buratti")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "5")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].kategori == "Pantolon")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "q")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız.");
                            }
                        }
                    }

                }
                else if (kategoriSecim == "V")
                {
                    Console.WriteLine("Güle güle (:");
                    kontrol = false;
                }
                else if (kategoriSecim == "3")
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i].kategori == "Tshirt")
                        {
                            Console.WriteLine("Lütfen bir marka seçiniz");
                            Console.WriteLine("[1] Modarich");
                            Console.WriteLine("[2] Füme");
                            Console.WriteLine("[3] Adrift");
                            Console.WriteLine("[4] Kaft");
                            Console.WriteLine("[5] Palpito");
                            Console.WriteLine("[6] Tümü");
                            Console.WriteLine("[q] Ana Menü");
                            string markaSecim = Console.ReadLine();
                            if (markaSecim == "1")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Modarich")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "2")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Füme")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "3")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Adrift")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "4")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Kaft")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "5")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].marka == "Palpito")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "6")
                            {
                                for (int j = 0; j < urunler.Length; j++)
                                {
                                    if (urunler[j].kategori == "Tshirt")
                                    {
                                        Console.WriteLine("{0} - {1} - {2} TL", urunler[j].isim, urunler[j].marka, urunler[j].fiyat);
                                    }
                                }
                            }
                            else if (markaSecim == "q")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız.");
                            }
                        }
                    }
                }
                else if (kategoriSecim == "V")
                {
                    Console.WriteLine("Güle güle (:");
                    kontrol = false;
                }


            }
        }
    }
}     
