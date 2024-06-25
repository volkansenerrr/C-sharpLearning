using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertveParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arasındaki farklar

            // Örneğin int.Parse

            // int.Parse, yalnızca geçerli bir string ifadesini bir integer'a dönüştürür.
            // Eğer string ifade null veya boş bir string ("") ise bir hata (exception) fırlatır.

            int number1 = int.Parse("123");  // Çalışır
            int number2 = int.Parse(null);  // Hata fırlatır: ArgumentNullException
            int number3 = int.Parse("");    // Hata fırlatır: FormatException


            // Örneğin Convert.ToInt32

            // Convert.ToInt32, string ifadesinin yanı sıra, null değeri de alabilir.
            // Eğer string ifade null ise, 0 döner. Ayrıca, diğer türleri de dönüştürebilir (örneğin, boolean, float, vb.).

            int number4 = Convert.ToInt32("123");  // Çalışır
            int number5 = Convert.ToInt32(null);  // 0 döner
            int number6 = Convert.ToInt32("");    // Hata fırlatır: FormatException

            #region Karşılaştırma

            // Geçerlilik Durumu:

            // int.Parse, sadece geçerli bir string ifadesini dönüştürür. null veya boş string durumlarında hata fırlatır.
            // Convert.ToInt32, null değerleri 0'a dönüştürür ve diğer türleri de dönüştürebilir.
            // Kullanım Senaryoları:

            // int.Parse: Eğer dönüştürülecek değer kesinlikle geçerli bir string olacaksa ve null değeriyle karşılaşılmayacaksa kullanılır.
            // Convert.ToInt32: Eğer dönüştürülecek değer null olabilecekse ve null değerini 0 olarak kabul etmek uygunsa kullanılır.
            // Ayrıca, farklı türleri dönüştürmek için kullanılabilir.

            #endregion
        }
    }
}
