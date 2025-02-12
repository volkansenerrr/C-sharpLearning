using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan ins = new Insan();
            ins.isim = "Alp";
            ins.soyisim = "Sarıkışla";

            Console.WriteLine(ins.isim + " " + ins.soyisim);

            Personel prs = new Personel();
            prs.Set_isim("Alp");
            Console.WriteLine(prs.Get_isim());

            Ogrenci ogr = new Ogrenci();
            ogr.Isim = "Alp Property";
            Console.WriteLine(ogr.Isim);
            ogr.Soyisim = "Sarıkışla";
            Console.WriteLine(ogr.Soyisim);
        }

        public class Personel 
        {
            string isim;
            string soyisim;

            public void Set_isim(string isim) 
            {
                this.isim = isim;
            }

            public string Get_isim() 
            {
                return isim;
            }
        }

        public class Insan 
        {
            public string isim;
            public string soyisim;
        }
        public class Ogrenci 
        {
            private string isim;

            public string Isim//Property
            {
                get { return isim; }
                set { isim = value; }
            }

            public string Soyisim { get; set; } //Auto-Implamented Property

        }
    }
}
