using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic(Jenerik) Kavramı
            //Personel p = new Personel(); //Jenerik olmayan nesne
            //p.Isim = "Alp";
            //p.Soyisim = "Sarıkışla";

            Personel <string> prs = new Personel<string>();
            prs.Isim = "Alp";
            prs.Soyisim = "Sarıkışla";
            prs.Yas = "30";
            prs.CocukSayisi = "0";

            Personel <int> prs2 = new Personel<int>();
            prs2.Isim = "Murtaza";
            prs2.Soyisim = "Şuayipoğlu";
            prs2.Yas = 30;
            prs2.CocukSayisi = 7;

            Console.WriteLine("İsim = " + prs2.Isim + "\nSoyisim = " + prs2.Soyisim + "\nYaş = " + (prs2.Yas + 2) +"\nÇocuk Sayısı = "+ prs2.CocukSayisi);

            Arac <string, int> araclar = new Arac<string, int>();
            araclar.Anahtar = "ID";
            araclar.Deger = 1;
        }
    }
    class Personel <T>
    {
        public string Isim  { get; set; }
        public string Soyisim { get; set; }
        public T Yas  { get; set; }

        public  T CocukSayisi { get; set; }
    }
    class Arac<T,Y> 
    {
        public T Anahtar { get; set; }
        public Y Deger { get; set; }
    }
}
