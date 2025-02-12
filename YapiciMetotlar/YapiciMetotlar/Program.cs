using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Yapıcı metot kullanımı zorunlu değildir.
            //Amacı belirli işlemleri nesne oluşturma anında zorunlu getirmektir.
            //Otomatik olarak çalışır.
            //Geriye veri döndürmez.
            //metodun ismi sınıfın ismiyle aynı olmak zorundadır.

            #endregion

            #region Insan sınıfı ile yapıcı metot olmadan kullanım

            Insan ins = new Insan();
            ins.isim = "ibrahim";

            Console.WriteLine(ins.isim);
            Console.WriteLine(ins.soyisim);

            #endregion

            #region Personel sınıfı ile yapıcı metot kullanımı

            //Personel p = new Personel();

            Personel prs = new Personel("Murtaza", "Şuayipoğlu");
            Console.WriteLine(prs.isim + " " + prs.soyisim);

            #endregion
        }
    }
}
