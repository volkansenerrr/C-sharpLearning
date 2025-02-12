using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime suan = DateTime.Now;

            Console.Write("Şu an = ");
            Console.WriteLine(suan);

            Console.Write("Bu gün = ");
            Console.WriteLine(suan.ToShortDateString());

            Console.Write("Bu gün = ");
            Console.WriteLine(suan.ToLongDateString());

            Console.Write("Şu an (saat) = ");
            Console.WriteLine(suan.ToShortDateString());

            Console.Write("Şu an (saat) = ");
            Console.WriteLine(suan.ToLongDateString());

            Console.Write("Bu yıl = ");
            Console.WriteLine(suan.Year);

            Console.Write("Bu ay = ");
            Console.WriteLine(suan.Month);

            Console.Write("Bu gün = ");
            Console.Write(suan.Day);

            Console.Write("Bu gün haftanın hangi günü = ");
            Console.Write(suan.DayOfWeek);

            Console.Write("Yılın kaçıncı günü = ");
            Console.WriteLine(suan.DayOfYear);

            Console.WriteLine("2 gün önce = ");
            Console.WriteLine(suan.AddDays(-2));

            Console.WriteLine("2 gün sonra");
            Console.WriteLine(suan.AddDays(2));

            DateTime tarih = Convert.ToDateTime("27.04.2024 10:00");
            Console.WriteLine(tarih);

            TimeSpan fark = DateTime.Now - tarih;
            Console.WriteLine(fark.Hours);
        }
    }
}
