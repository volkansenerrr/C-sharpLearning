using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDiziler_StringArrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //int[] sayilar = { 15, 45, 20, 88 };
            //string[] isimler = { "Alp", "Sarıkışlar" };

            //string isim = "İbrahim Alp Sarıkışla";
            //Console.WriteLine(isim[5]);

            ////isim[7] = "a"; //string'in indexlerine veri atılamaz

            //isim += " Murtaza";
            //Console.WriteLine(isim);
            #endregion

            #region Yazı içerisinde @ var mı ?

            //char[] mail = { 'v', .... };
            //string mailstr = "volkanvssener@hotmail.com";

            //string mail;

            //Console.WriteLine("Lütfen mail adresinizi giriniz.");
            //mail = Console.ReadLine();

            //bool varmi = false;

            //for (int i = 0; i < mail.Length; i++) 
            //{
            //    if (mail[i] == '@') 
            //    { 
            //       varmi = true;
            //    }
            //}

            //if(varmi == true)
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //else
            //{
            //    Console.WriteLine("Mail adresi geçersiz");
            //}
            #endregion

            #region Yazı içerisinde @ var mı ?

            //Console.WriteLine("Lütfen mail adresinizi giriniz.");
            //string mail = Console.ReadLine();

            //int index = -1;

            //for (int i = 0; i < mail.Length; i++)
            //{
            //    if (mail[i] == '@') 
            //    { 
            //         index = i;
            //    }
            //}
            //if (index == -1)
            //{
            //    Console.WriteLine("Mail adresi hatalı");
            //}
            //else 
            //{
            //    Console.WriteLine("Merhaba");
            //}

            #endregion

            #region Yazının başındaki boşlukları yok etme

            //Console.WriteLine("Lütfen metin giriniz");
            //string metin = Console.ReadLine();

            //int index = -1;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] != ' ')
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //string bosluksuz = "";
            //for (int i = index; i < metin.Length; i++)
            //{
            //    bosluksuz += metin[i];
            //}
            //Console.WriteLine(bosluksuz);
            #endregion

            #region Metinin içinde karakter bulma

            //Console.WriteLine("Metin giriniz.");
            //string metin = Console.ReadLine();

            //Console.WriteLine("Aranacak karakter giriniz.");
            //char girilenKarakter = Convert.ToChar(Console.ReadLine());

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == girilenKarakter)
            //    {
            //        Console.WriteLine("Aranan karakter " + i + ". indextedir");
            //    }
            //}

            #endregion

            #region Oyun 1 Metin Tahmin Etme (Adam Asmaca) ÖDEV

            Console.WriteLine("Adam Asmaca oyunuma hoşgeldin (:");
            Console.WriteLine("Zorluk seç bakalım");
            Console.WriteLine("[1] Kolay - 20 Hak");
            Console.WriteLine("[2] Orta - 10 Hak");
            Console.WriteLine("[3] Zor - 5 Hak");
            Console.WriteLine("[4] İmkansız - 2 Hak");
            string zorluk = Console.ReadLine();

            int hak = 0;

            switch (zorluk) 
            {
                case "1":
                    hak = 20;
                    break;
                case "2":
                    hak = 10;
                    break;
                case "3": 
                    hak = 5; 
                    break;
                case "4":
                    hak = 2;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim");
                    break;
            }
            Console.Clear();

            Console.WriteLine("Film adı giriniz");
            string filmAdi = Console.ReadLine();
            Console.Clear();

            char[] filmHarfleri = new char[filmAdi.Length];
            Console.Write("Referans = ");

            for (int i = 0; i < filmAdi.Length; i++)
            {
                if (filmAdi[i] == ' ') 
                {
                    filmHarfleri[i] = '/';
                    Console.Write("/");
                }
                else
                {
                    filmHarfleri[i] = '-';
                    Console.Write("-");
                }
            }

            while (hak >= 0) 
            {
                int kontrol = -1;

                for (int i = 0; i < filmHarfleri.Length; i++)
                {
                    if (filmHarfleri[i] == '-')
                    {
                        kontrol = i;
                    }
                }

                if (kontrol == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Tebrikler filmi doğru tahmin ettiniz.");
                    Console.WriteLine("Film adı = " + filmAdi);
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Kalan hak = " + hak);
                Console.Write("Harf tahmini : ");
                char tahminHarf = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                bool varmi = false;
                

                for (int i = 0; i < filmAdi.Length; i++)
                {
                    if (filmAdi[i] == tahminHarf) 
                    {
                        filmHarfleri[i] = tahminHarf;
                        Console.Write(tahminHarf);
                        varmi = true;
                    }
                    else
                    {
                        Console.Write(filmHarfleri[i]);
                    }
                }
                if (varmi == false)
                {
                    hak--;
                }
            }
            if (hak < 0) 
            {
                Console.Clear();
                Console.WriteLine("Haklarınız bitmiştir kaybettiniz.");
                Console.WriteLine("Filmin adı : " + filmAdi + " olacak.");
            }

            

            

           #endregion
        }
    }
}
