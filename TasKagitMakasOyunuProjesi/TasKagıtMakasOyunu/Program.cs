using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagıtMakasOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("ibm857");

            Random rnd = new Random();
            string[] secenek = { "taş", "kağıt", "makas" };

            int kullaniciSkor = 0;
            int bilgisayarSkor = 0;

            Console.WriteLine("------- TAŞ KAĞIT MAKAS OYUNU ------- ");
            Console.WriteLine("Kurallar;");
            Console.WriteLine("Taş, Makası Yener");
            Console.WriteLine("Kağıt, Taşı Yener");
            Console.WriteLine("Makas, Kağıdı Yener");

            Console.WriteLine("Lütfen Adınızı Girin");
            string isim = Console.ReadLine();

            string oyun = "e";
            while (oyun == "e")
            {
                Console.WriteLine("---------------------------");
                int index = rnd.Next(3);
                Console.WriteLine("Bilgisayar {0} - {1} {2}", bilgisayarSkor, kullaniciSkor, isim);
                Console.WriteLine("Seçiminizi Yapın [taş, kağıt, makas]");
                string kullaniciTercihi = Console.ReadLine();
                string bilgisayarTercihi = secenek[index];

                Console.WriteLine("Senin Tercihin       = " + kullaniciTercihi);
                Console.WriteLine("Bilgisayarın Tercihi = " + bilgisayarTercihi);

                #region Kazanma olayları
                if (kullaniciTercihi == "taş" && bilgisayarTercihi == "makas")
                {
                    Console.WriteLine("{0} Kazandı !", isim);
                    kullaniciSkor++;
                }
                else if (kullaniciTercihi == "makas" && bilgisayarTercihi == "taş")
                {
                    Console.WriteLine("Bilgisayar Kazandı ! ");
                    bilgisayarSkor++;
                }
                else if (kullaniciTercihi == "kağıt" && bilgisayarTercihi == "taş")
                {
                    Console.WriteLine("{0} Kazandı !", isim);
                    kullaniciSkor++;
                }
                else if (kullaniciTercihi == "taş" && bilgisayarTercihi == "kağıt")
                {
                    Console.WriteLine("Bilgisayar Kazandı ! ");
                    bilgisayarSkor++;
                }
                else if (kullaniciTercihi == "makas" && bilgisayarTercihi == "kağıt")
                {
                    Console.WriteLine("{0} Kazandı !", isim);
                    kullaniciSkor++;
                }
                else if (kullaniciTercihi == "kağıt" && bilgisayarTercihi == "makas")
                {
                    Console.WriteLine("Bilgisayar Kazandı ! ");
                    bilgisayarSkor++;
                }
                else if (kullaniciTercihi == bilgisayarTercihi)
                {
                    Console.WriteLine("Berabere !");
                }
                else
                {
                    Console.WriteLine("Hatalı işlem");
                }
                #endregion

                if (bilgisayarSkor == 5)
                {
                    Console.WriteLine("Bilgisayar {0} - {1} {2}", bilgisayarSkor, kullaniciSkor, isim);
                    Console.WriteLine("Oyun Bitti..");

                    Console.WriteLine("Üzgünüm bilgisayar kazandı :(");
                    Console.WriteLine("Tekrar oynamak ister misin ? [e,h]");
                    oyun = Console.ReadLine();
                    bilgisayarSkor = 0;
                    kullaniciSkor = 0;
                }
                else if (kullaniciSkor == 5)
                {
                    Console.WriteLine("Bilgisayar {0} - {1} {2}", bilgisayarSkor, kullaniciSkor, isim);
                    Console.WriteLine("Oyun Bitti..");
                    Console.WriteLine("Tebrikler {0} sen kazandın", isim);
                    Console.WriteLine("Tekrar oynamak ister misin ? [e,h]");
                    oyun = Console.ReadLine();
                    bilgisayarSkor = 0;
                    kullaniciSkor = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
