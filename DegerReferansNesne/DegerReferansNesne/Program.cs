using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerReferansNesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaKarti GarantiKart = new BankaKarti();
            GarantiKart.KartNo = "4796";
            GarantiKart.Bakiye = 1000;

            BankaKarti Akbank = new BankaKarti();
            Akbank.KartNo = "1233";
            Akbank.Bakiye = 2000;

            Console.WriteLine("Garanti Kart");
            Console.WriteLine("Kart No = " + GarantiKart.KartNo);
            Console.WriteLine("Bakiye = " + GarantiKart.Bakiye);

            Console.WriteLine("Akbank Kart");
            Console.WriteLine("Kart No = " + Akbank.KartNo);
            Console.WriteLine("Bakiye = " + Akbank.Bakiye);

            GarantiKart.Bakiye = Akbank.Bakiye;

            Console.WriteLine("-----Değer Ataması Yapıldı-----");
            Console.WriteLine("Garanti Kart");
            Console.WriteLine("Kart No = " + GarantiKart.KartNo);
            Console.WriteLine("Bakiye = " + GarantiKart.Bakiye);

            Console.WriteLine("Akbank Kart");
            Console.WriteLine("Kart No = " + Akbank.KartNo);
            Console.WriteLine("Bakiye = " + Akbank.Bakiye);

            GarantiKart = Akbank;
            GarantiKart.KartNo = "98465456";
            Console.WriteLine("-----Değer Ataması Yapıldı-----");
            Console.WriteLine("Garanti Kart");
            Console.WriteLine("Kart No = " + GarantiKart.KartNo);
            Console.WriteLine("Bakiye = " + GarantiKart.Bakiye);

            Console.WriteLine("Akbank Kart");
            Console.WriteLine("Kart No = " + Akbank.KartNo);
            Console.WriteLine("Bakiye = " + Akbank.Bakiye);
        }
    }

    public class BankaKarti 
    {
        public string KartNo;
        public double Bakiye;
    }
}
