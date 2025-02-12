using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Jenerik_Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Murtaza");
            isimler.Add("Berk");
            //isimler.Add(45);

            List<ogrenci> ogrenciler = new List<ogrenci>();

            ogrenci ogr = new ogrenci();
            ogr.isim = "Alp";
            ogr.soyisim = "Sarıkışla";
            ogrenciler.Add(ogr);

            ogrenciler.Add(new ogrenci() { isim = "Murtaza", soyisim = "Şuayipoğlu" });

            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Console.WriteLine(ogrenciler[i].isim + " " + ogrenciler[i].soyisim);
            }
        }
    }
    class ogrenci 
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
    }
}
