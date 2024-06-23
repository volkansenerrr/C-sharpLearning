using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakVeContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break anahtar kelimesi, bir döngüyü(örneğin, for, while, do -while) hemen sonlandırır. Aşağıdaki örnekte, i değişkeni 7'ye eşit olduğunda döngü tamamen sona erer.

            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    break; // i 7 olduğunda döngü sona erer
                }
                Console.WriteLine("i ' nin değeri : " + i);
            }

            // Çıktı:
            // i ' nin değeri : 1
            // i ' nin değeri : 2
            // i ' nin değeri : 3
            // i ' nin değeri : 4
            // i ' nin değeri : 5
            // i ' nin değeri : 6


            // continue anahtar kelimesi, döngünün mevcut yinelemesini atlar ve döngünün bir sonraki yinelemesine geçer.
            // Aşağıdaki örnekte, i değişkeni 7'ye eşit olduğunda, o adım atlanır ve döngü bir sonraki yinelemeye geçer.


            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    continue; // i 7 olduğunda bu yineleme atlanır
                }
                Console.WriteLine("i ' nin değeri : " + i);
            }

            // Çıktı:
            // i ' nin değeri : 1
            // i ' nin değeri : 2
            // i ' nin değeri : 3
            // i ' nin değeri : 4
            // i ' nin değeri : 5
            // i ' nin değeri : 6
            // i ' nin değeri : 8
            // i ' nin değeri : 9
            // i ' nin değeri : 10
        }
    }
}
