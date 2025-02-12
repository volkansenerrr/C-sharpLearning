using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeynekciOtopark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deynekçi Otopark");

            Otopark otoparkIslemleri = new Otopark();

            DateTime suan = DateTime.Now;

            string secenek = "";

            while (secenek != "3")
            {
                otoparkIslemleri.menuYazdir();

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
                secenek = Console.ReadLine();
                switch (secenek)
                {
                    case "1":
                        otoparkIslemleri.Listele();
                        Console.WriteLine("Devam etmek için [ENTER] tuşuna basınız.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Eklemek istediğiniz aracın plakasını girin : ");
                        string plaka = Console.ReadLine();
                        DateTime aracGirisSaati = otoparkIslemleri.aracGirisSaatiOlustur();
                        Console.Clear();

                        Console.WriteLine("Araç başarıyla eklenmişsitr.");
                        Console.WriteLine("Plaka        = " + plaka);
                        Console.WriteLine("Giriş saati  = {0}:{1}", suan.Hour, suan.Minute);

                        otoparkIslemleri.aracEkle(plaka, aracGirisSaati);
                        Console.WriteLine("Devam etmek için  [ENTER]");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
