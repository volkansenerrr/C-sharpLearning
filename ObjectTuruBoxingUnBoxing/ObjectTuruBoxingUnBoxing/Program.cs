using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTuruBoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Her tür Object türünden doğar.
            //Object her türden veriyi kabul eder.
            //Object içindeki verinin türünüde saklar.

            #endregion

            #region Object Türü

            //string isim = "Alp";

            //object obj = "Alp";

            //obj = 45;
            //obj = 45.7;
            //obj = Console.ReadLine();
            //obj = obj + 2;

            //Console.WriteLine(obj);

            #endregion

            #region Boxing - Cast - UnBoxing İşlemi

            //Herhangi bir türdeki verinin ya da nesnenin object türündeki alana atılması olayına boxing denir.

            //Insan ins = new Insan();
            //ins.Isim = "Alp";
            //ins.Soyisim = "Sarıkışla";

            //object obj = ins;
            //Insan veri = (Insan)obj;//Unboxing
            //Console.WriteLine(veri.Isim);

            //string isim = "Murtaza";
            //object obj2 = isim;
            ////int s = (int)obj2;//Invalid Cast Exception
            //string sayi = (string)obj2;//UnBoxing
            //Console.WriteLine(sayi);

            #endregion

            #region TypeOf Ve GetType

            string isim = "Murtaza";

            object obj = isim;

            Console.WriteLine(isim.GetType());
            Console.WriteLine(obj.GetType());

            int sayi = 45;

            obj = sayi;

            if (obj.GetType() == typeof(int))
            {
                int s = (int)obj;
                Console.WriteLine(s * 2);
            }
            else
            {
                Console.WriteLine(obj);
            }

            #endregion
        }
    }

    class Insan 
    { 
        public string Isim { get; set; }

        public string Soyisim { get; set; }
    }
}
