using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneYonelimliProgramlama_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir önceki derste oluşturduğumuz Araba sınıfını nasıl kullanırız nasıl bir nesne oluştururuz bunu anlayacağız.
            //Oluşturulan classlardan nesne türetmek nedir ne işimize yarar ?

            //Biz oluşturmuş olduğumuz sınıflardan objeler türeterek class içinde tanımlamış olduğumuz değişken ve metotlarımıza erişiriz.
            //Bir önceki derste Araba adında bir class oluşturdum içine değişken ve metotlarımı koydum fakat kullanamadım.

            //Bir araba aldım kapının önünde duruyor ne işe yarar ki o araba ? 

            //İlk başta class'ımızın ismini yazıyoruz.
            //Sonra içinde varolan değişkenlerime ve metotlarıma erişeceğim REFERANS İSMİNİ veriyorum.
            // = eşittir yani bizim atama operatörümüzü koyuyorum 
            //new anahtar kelimesi var yeni anlamına gelen onu koyuyorum.
            //daha sonra class'ımızın ismini yazıp parantez açıp kapatıyoruz sonuna noktalı virgül koyup satır kapamamızı yapıyoruz.

            //Araba referansİsmi = new Araba(); //Ne demiş oldum araba sınıfında bir tana obje oluşturmak istiyorum.Bu objemin ismi şu isim olsun diyorum.
            //Referans ismi sayesinde class'ımın içindeki property(özellik) ve metotlara erişebileceğim.

            //Nesne (Obje): Gözlemlenen, algılanan, dış dünyada var olan herhangi bir şey nesne olarak adlandırılır.
            //Nesneler, beş duyu ile algılanabilir, elle tutulabilir ve üç boyutlu cisimlerdir.
            //Bu kavram sadece fiziksel varlıkları ifade etmez; aynı zamanda soyut kavramları da içerir.
            //Birincil Nitelikler: Doğrudan nesnenin kendisine ait olan özelliklerdir. Örneğin, bir masa fiziksel bir nesnedir ve yer kaplar.
            //İkincil Nitelikler: Renk, koku, tat gibi özelliklerdir.Bu nitelikler fiziksel nesnenin ikincil özellikleridir.
            //Özetle, nesnelerin en temel özelliği var olmalarıdır. Bir nesnenin tüm özellikleri alınabilir, ancak mevcudiyeti asla elinden alınamaz.

            //Araba sınıfının tooltip okuduğumuzda class.OOP_NesneYonelimliProgramlama_3.Araba -->  OOP_NesneYonelimliProgramlama_3 adında bir tane namespace'im var bu namespace içinde tanımlanmış Araba adında bir class var.
            //Tooltip, kullanıcılara bir kontrol veya öğe hakkında kısa ve açıklayıcı bir metin içeren küçük bir baloncuk veya açıklama kutusu olarak tanımlanabilir.
            //null türkçede boş demek.string veri tipinde bir değişkene herhangi bir değer atanmazsa default(varsayılan) olarak otomatik olarak null değeri atanır.Strign değişkenim null ise string değişkenimde herhangi bir değer yok anlamına gelir değer ataması yoksa değişkenim (null)boştur.
            //int veri tipinde değişken içinde 0 varsa aynı şekilde default(varsayılan) olarak 0 değeri otomatik atanır.int değişkenimin içinde herhangi bir değer yok boş anlamındadır.Herhangi bir atamadığımız takdirde otomatik olarak default(varsayılan) o değeri atanır.

            Araba araba1 = new Araba(); //okuduğumuzda Araba sınıfından araba1 adında bir tane nesne(obje) oluşturuyoruz.Referans ismi araba1 olan nesnem ile Araba.cs gidip içindeki property(özellik) ve metotları kullanabileceğim.
            araba1.kapiSayisi = 4; //Arabam 4 kapılı olsun //kapiSayisi tooltip --> değişken(field) int.Araba.kapiSayisi --> ben araba sınıfı içerisinde tanımlanmış kapisayisi adında int veri tipinde bir değişkenim dolayısıyla int değer alırım senden.
            araba1.arabaRengi = "Kırmızı"; // Arabamın rengi kırmızı olsun //arabaRengi tooltip --> Araba sınıfı içerisinde tanımlanmış arabaRengi adında string veri tipinde değer alan bir değişkenim
            araba1.arabaMarka = "Renault"; // Arabamın markası Renault olsun.

            //Tanımladığım değişkenlerime değerleri atadım.

            araba1.kapilariKilitle(); //araba1 referans adıyla nokta koyup bu metodumu çağırıp kullandım.tooltip okursak --> Araba sınıfı içerisinde tanımlanmış(oluşturulmuş) kapilariKilitle adında bir metodum herhangi bir parametre almam geriye herhangi bir değer dönmem(void).
            araba1.motorCalistir();

            Console.WriteLine("Arabanın kapı sayısı : " + araba1.kapiSayisi);
            Console.WriteLine("Araba rengi : " + araba1.arabaRengi);
            Console.WriteLine("Arabanın markası : " + araba1.arabaMarka);
           
        }   

    }
}
