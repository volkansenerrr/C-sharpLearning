using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakpointveTooltipOnemiproje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu kod, breakpoint ve tooltip kavramlarını açıklamak için yazılmıştır.

            // Breakpoint, kodun belirli bir noktasında çalışmayı durdurmak için yerleştirilen bir işaretleyicidir.
            // Kodunuzun herhangi bir yerine bir breakpoint yerleştirdiğinizde, kod çalışırken belirtilen noktaya ulaştığında çalışma durur ve bu noktada kodunuzun durumunu incelemenize ve takip etmenize olanak tanır.
            // Breakpoint eklemek, kodunuzun doğru çalışıp çalışmadığını veya belirli bir noktada beklenmedik bir davranış olup olmadığını anlamanıza yardımcı olabilir.
            // Özellikle karmaşık veya hata ayıklama gerektiren kodlar yazarken breakpointler çok faydalı olabilir.

            // Kodunuzun herhangi bir yerinde, çalışmayı durdurmak istediğiniz bir noktaya gelin.
            // Bulunduğunuz satırın solundaki boşlukta bir kez tıklayarak breakpoint'i ekleyin. Bu, o satırdaki kodun çalışması durdurulduğunda işaretleyici oluşturur.
            // Kodunuzu çalıştırdığınızda, breakpoint'in bulunduğu noktaya ulaşıldığında program durur ve duraklama noktasında kodun durumunu inceleyebilirsiniz.
            // Breakpointler, hata ayıklama sürecinde kodunuzun akışını anlamanıza ve belirli bir anda değişken değerlerini kontrol etmenize olanak tanır.

            // Tooltip ise bir kod veya nesne üzerine fareyi getirdiğinizde açılan küçük bir bilgi penceresidir.
            // Bu pencere, genellikle o kod veya nesnenin kısa bir açıklamasını veya kullanımını içerir.
            // Örneğin, bir metodun adını veya bir değişkenin türünü gösterebilir. Bu, kodunuzu daha okunabilir ve anlaşılır hale getirmenize yardımcı olabilir.

            int ilkSayi = 3;
            int ikinciSayi = 5;
            int ucuncuSayi = 10;

            int toplamSonuc = ilkSayi + ikinciSayi + ucuncuSayi;

            Console.WriteLine("Toplam Sonuç: " + toplamSonuc);




        }
    }
}
