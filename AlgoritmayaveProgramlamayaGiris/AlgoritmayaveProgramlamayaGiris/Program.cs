using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlgoritmayaveProgramlamayaGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bilgisayarın Çalışma Mantığı
            //Bilgisayar : Kullanıcıdan aldığı verilerle mantıksal ve aritmetiksel işlemleri yapan yaptığı işlemlerin sonucunu saklayabilen, sakladığı bilgilere
            //istenildiğinde ulaşılabilen elektronik bir makinedir.Bu işlemleri yaparken veriler girilir ve işlenir.Ayrıca, istenildiğinde yapılan işler depolanabilir
            //ve çıktısı alınabilir.

            //Bir başka tanımla Bilgisayar, kullanıcının girmiş olduğu bilgileri işleyerek bu işlediği bilgileri gerektiğinde saklayabilen, ve sakladığı bilgilerede
            //erişilerek kullanıcıya gösteren cihazlardır.Bu işlemleri yaparken, veriler girilir, işlenir ve ekranda gösterilir veya yazıcıdan çıktı olarak verilir.

            //Bu işlemler için 4 ana birimden bahsedelim.

            //GİRİŞ : Kişi tarafından veya bilgisayara tarafından sağlanan verilerdir.Bu veriler, sayılar, harfler, sözcükler, ses sinyalleri ve komutlardır.
            //Veriler giriş birimleri tarafından toplanır.Bir başka tanımla kullanıcıların bilgisayara verileri girebilmesi için kullanmış olduğu donanımlardır.
            //Nedir bunlar ? En basitinden klavye, mikrofon, kamera veya tarayıcılar.Tarayıcı belge taramayı sağlar.Fiziksel kağıt belgeleri veya kitap sayfalarını dijital ortama aktaran cihazlardır.

            //İŞLEM : Veriler insanların amaçları doğrultusunda, programın yetenekleri ölçüsünde işlem basamaklarından geçer.Bilgisayarın en önemli birimlerinden 
            //bir tanesidir.Çünkü verilerin işlenmesini sağlar.Verilerin çalıştırılmasını,programın çalıştırılmasını sağlayan birimdir.Bu da bizim bilgisayarımızın 
            //işlemcisidir.

            //BELLEK : Verilerin depolandığı yerdir.Giriş yapılan ve işlenen veriler bellekte depolanır.Ama geçici olarak RAM bellekte depolanabilir ama kalıcı olarak
            //HARD DİSK veya FLASH bellekte depolanabilir.

            //ÇIKIŞ : Bilgisayar tarafından işlem basamaklarından geçirilerek üretilen yazı, resim, tablo, müzik, grafik, görüntü, vb.nin ekrandan ya da yazıcı, hoparlör
            //gibi değişik çıkış birimlerinden alınmasıdır.Bir başka tanımla bilgisayar tarafından üretilen bilgilerin kullanıcıya sunulmasını sağlar.Yani gösterilmesini
            //sağlar.Bu da en çok kullanmış olduğumuz ekranlar olabilir, yazıcılar olabilir veya sesleri veren hoparlörler olabilir.
            #endregion

            #region Devam edelim
            //Kısaca şemayı düşünerek anlamaya çalışalım.
            //Öncelikle kullanıcı bilgisayara bir komut vermesi gerekiyor.
            //Bilgisayar ona bir adımı nasıl yapacağını göstermezseniz o size sonuç veremeyecektir.
            //Bu yüzden A'dan Z'ye her şeyi komut olarak vermemiz gerekiyor.

            //Öncelikle giriş cihazlarıyla bilgisayara komut verilir.Bizim algoritma ve programlamada göreceğimiz kısım.
            //Daha sonra bu girilen bilgiler işlemci tarafından otomatik olarak 1 ve 0'lara dönüştürülecektir.Neden ? Bilgisayarlar bizim anladığımız dilden anlamazlar.
            //Yazılanı,çizileni bizim gördüğümüz şekliyle görmez.Bunları 1 ve 0'lara dönüştürüp işler ve daha sonra bizim anlayacağımız hale getirerek sonucu gösterir.
            //İşlemci bizim girmiş olduğumuz bilgileri çalıştırır, işler, sonuç üretir ve bunları gerektiğinde geçici bellekte(RAM) olabilir kalıcı bellek(HARD DİSK)
            //buralara depolanmasını sağlar.
            //Depolanan bilgileri tekrar çağırarak işledikten sonra çıkış cihazları sayesinde kullanıcılara bu bilgileri sunabilir.

            #endregion

            #region İşlemcinin temel bölümleri

            //Detaya girersek işlemcinin temel bölümleri, bilgisayarın merkezi işlem birimi (CPU) oluşturan ve komutları yürüten bileşenlerdir.İşte bu bölümlerin
            //ana hatları :

            //1.KONTROL BİRİMİ (CONTROL UNIT):
            //Kontrol birimi, işlemcinin yönetimini sağlar 
            //Komutları alır, çözümler ve işlemci bileşenlerine iletilmesini sağlar.
            //Program akışını kontrol eder ve komutların sırasını belirler.

            //2.Aritmetik ve Mantık Birimi (Arithmetic Logic Unit - ALU):
            //ALU,matematiksel işlemleri gerçekleştirir.
            //İki sayıyı toplama, çıkarma, çarpma, bölme gibi temel aritmetik işlemleri yapar.
            //Mantıksal işlemleri (Örneğin, AND, OR, NOT) de gerçekleştirir.

            //3.Kayıt Seti (Register Set):
            //İşlemcinin hızlı erişimli belleğidir.
            //Geçici verileri ve işlem sonuçlarını depolar.
            //Genellikle genel amaçlı kayıtlar (Örneğin, EAX, EBX) ve özel amaçlı kayıtlar (Örneğin, program sayacı) içerir.

            //4.Önbellek (Cache):
            //İşlemcinin hızını arttırmak için kullanılır.
            //Verileri daha hızlı erişilebilir bir alanda saklar.
            //Genellikle L1,L2 ve L3 önbellek seviyeleri vardır.

            //5.Program Sayacı (Program Counter - PC):
            //İşlemcinin hangi komutun sıradaki olduğunu takip eder.
            //Komutların bellekteki adresini tutar.
            //Her komutun işlenmesinden sonra arttırılır.

            //6.Bellek Yönetim Birimi (Memory Management Unit - MMU)
            //Bellek erişimini yönetir.
            //Sanal bellek adreslerini fiziksel bellek adreslerine dönüştürür.
            //Bellek segmentasyonu ve sayfa tablosu gibi işlemleri gerçekleştirir.

            //Bu bileşenler, işlemcinin temel işlevlerini gerçekleştirmesine yardımcı olur.İşlemcin tasarımına ve mimarisine bağlı olarak daha fazla özel
            //bileşen de olabilir.

            #endregion

            #region Programlama

            //Programlama : Bilgisayarın donanıma nasıl davranacağını anlatan, bilgisayara yön veren komutlar, kelimeler ve aritmetik işlemlerden oluşan
            //bir süreçtir.Aynı zamanda bilgisayar programlarının yazılması, test edilmesi ve bakımının yapılması sürecine de verilen isimdir.
            //Programlama, bir programlama dilinde gerçekleştirilir. Bu diller, yüksek seviyede(örneğin Java veya c#) veya düşük seviyede (örneğin C, Assembly veya Makine dili)
            //olabilir.Programcılar, yazdıkları kaynak kodu derleyici veya yorumlayıcı yardımıyla çalıştırabilir hale getirirler.Derleyici, hataları bulup düzeltirken, yorumlayıcı
            //satır satır çalıştırma imkanı sağlar.Programlama, gerçek hayattaki problemleri çözmek gibi düşünülür ve komutlar sadece araç olarak kullanılır.
            //Programlama, modern dünyanın temel taşlarından biridir ve yazılım geliştirmenin temelini oluşturur.

            #endregion

            #region Derleyici(Compiler) ve Yorumlayıcı(Interpreter)

            //Derleyici(Compiler) ve Yorumlayıcı(Interpreter), bilgisayar programlarının çalıştırılabilir hale getirilmesi için kullanılan iki farklı yaklaşımdır.

            //1.Derleyici(Compiler): 
            //Derleyici, yüksek seviyeli bir programlama diliyle yazılmış KAYNAK KODU alır.
            //Bu kaynak kodu,makinenin mimarisine göre MAKİNE DİLİNDE ÇIKTIYA dönüştürür.
            //Derleyici, kodları derlemeden önce kontrol eder ve hataları raporlar.
            //Derlenen makine kodu, daha sonra farklı girdilerle tekrar tekrar çalıştırılabilir.
            //Örneğin, Java derleyicisi (javac), Java kaynak kodunu Java Sanal Makinesi için makine dilindeki java bytecode'a dönüştürülür.

            //2.Yorumlayıcı(Interpreter)
            //Yorumlayıcı, program için olan verilerle birlikte kaynak kodunu alır.
            //Kaynak programı satır satır yürütür ve doğrudan çalıştırır.
            //Örneğin, Java yorumlayıcısı(java),.class uzantılı dosyayı üzerinde çalıştığı makinede çalıştırılabilecek doğal makine kodlarına çevirir.
            //Java'da derleyici ve yorumlayıcı beraber çalışır: Önce kaynak koddan bir ara kod(bytecode) üretilir, sonra bu bytecode Java Sanal Makinesi(JVM)
            //üzerinde yorumlanarak yürütülür.

            //Bu iki yaklaşımın farkları:
            //Derleyici, kodu tamamen çevirir ve yürütülebilir bir dosya oluşturur.Yorumlayıcı ise her seferinde kaynak kodu çevirir ve doğrudan yürütür.
            //Derleyiciler genellikle daha hızlıdır, çünkü çeviri süreci gerçekleştirilir.

            #endregion

            #region Bazı tanımlar
            //İşlevsellik
            //Programlamada işlevsellik demek kodun, saf bir matematik fonksiyonu şeklinde ifade edilebileceği anlamına gelir.
            //Bir başka deyişle işlevsel olma çalışır,fonksiyonlarını yerine getirebilir anlamında tümce içinde kullanılabilir.

            //Makine
            //Makine, düzenli yapısal ve işlevsel özellikleri olan herhangi bir fiziksel sistemdir.Bilgisayar, Otomobil, Çamaşır Makinesi...

            //Bilgi
            //Genellikle geçerliliği veya doğruluğu varsayılacak şekilde mümkün olan en yüksek kesinlik derecesi ile karakterize edilen, kişiler veya gruplar için
            //mevcut olan bir dizi gerçek.

            //Mantık
            //Bilginin yapısını inceleyen, doğru ile yanlış arasındaki akıl yürütmenin ayrımını yapan disiplindir, doğru düşüncenin aletidir.

            //İşleme
            //Bir şeye emek vererek onu daha elverişli bir duruma getirmek anlamına gelir.

            //Elverişli
            //Bir işe uygun gelen, işe yarayan, kullanılabilen, uygun, işe yarar anlamında sıfattır.

            //Elektronik
            //Elektrik kullanarak bilgi işleyen, taşıyan veya depolayan elemanları ve sistemleri inceleyen bilim dalıdır.

            //Aritmetik
            //Sayıları, sayıların özelliklerini ve bunlarla yapılan işlemleri konu alan matematiğin bir koludur.

            //Araç
            //Bir işte gücünden yararlanılan nesne.
            #endregion

            #region Web Tarayıcıları

            //İnternet sayfalarına erişebilmek için kullanılan bir araçtır.
            //Web tarayıcıları, bilgisayar, telefon, tablet, akıllı televizyon ve oyun konsolları gibi birçok sistemde internet bağlantısı kullanılarak 
            //internet sitelerinin ziyaret edilmesini sağlayan bir web arayüzüdür.
            //İlk başlarda sadece bilgisayar üzerinden web tarayıcılarına erişebiliyorken, teknolojinin gelişmesiyle beraber mobil cihazlara da yayılmıştır.
            //Tarayıcı ne işe yarar ? İnternet tarayıcısı veya web tarayıcısı, kullanıcıların World Wide Web üzerinde yer alan internet sitelerini görüntülemesi için
            //kullanılır.
            //Piyasada birçok web tarayıcısı bulunsa da hepsi aynı amaca hizmet eder.Bu tarayıcıları kullanarak internet sayfalarına hızlı ve verimli bir şekilde
            //ulaşabiliyoruz.
            //Tarayıcıların özellikleri nelerdir ? 
            //Her web tarayıcısı içerisinde kendi özelliklerini bulundurur 
            //Ortak özellikleri şunlardır :
            //Adres Çubuğu : İstediğiniz web sayfasının adını yazarak internet sitesine ulaşabilirsiniz.Aynı alanda sayfa içerisinde ileri veya geri gitme 
            //fonksiyonlarıda bulunur.
            //Arama Özgeçmişi : Önceden girdiğimiz web sitelerini bu alanda görüntüleyebilir veya silebilirsiniz.
            //Gizli Pencere : Girdiğiniz web sitelerinin kayıtları arama geçmişinize kaydolmaz.
            //Yer İmleri : Sık sık ziyaret ettiğiniz sayfaları yer imlerine ekleyerek daha hızlı ulaşabilirsiniz.
            //Uzantılar: Web tarayıcılarına ekstra özellik eklemeye yarayan küçük yazılımlardır.
            //En çok kullanılan Tarayıcılar : Popüler tarayıcıların bazıları şunlardır; Google Chrome, Mozilla Firefox, Opera, Microsoft Edge
            //Tarayıcılar, hayatımızın vazgeçilmez bir parçası haline gelmiş durumda.İnternet dünyasında gezinmek için bu araçları kullanmak oldukça önemlidir. 


            #endregion

            #region Bilgisayarın anladığı dil 
            //Bilgisayar biz insanların konuştuğu dili anlamazlar. Yani günlük hayatta kullandığımız sözcükleri, renkleri, sesleri, sayıları bilgisayarlar anlamazlar.
            //Peki bilgisayarların anladığı dil nedir? Bilgisayarlar sadece 0 ve 1 rakamlarını anlar ve üzerinde işlem yapar.Bizler günlük hayatta 10luk sayı sistemini 
            //kullanırken bilgisayarlar ikilik sayı sistemini kullanmaktadır. Bizim girdiğimiz sayılar, sözcükler, renkler ve sesler bilgisayarlar ikilik sayı sistemini
            //kullanmaktadır. Bizim girdiğimiz sayılar, sözcükler, renkler ve sesler bilgisayarlar tarafından 0 ve 1 rakamlarına dönüştürülerek işlem yapılır ve yine 
            //bizim anlayacağımız dile çevrilir.

            //Sayısal dönüşümler olur fakat metinsel ifadeler de mi ikilik sayı sistemine dönüştürülür? Bilgisayarda renklerin ve karakterlerin sayısal karşılıkları bulunur.

            //Bilgisayar elektronik aygıt olduğu için elektrik sinyalleri ile işlem yapmaktadır ve 0 elektrik sinyalinin yokluğunu ve 1 elektrik sinyalinin varlığını gösterir.
            //İşlemci içinde bulunan milyarlarca transistörler girilen verileri 0 ve 1 rakamlarına dönüştürür.

            //0 ve 1 rakamlarına bilgisayar alanında bit denilmektedir.Ve 8 tane bit bir araya gelerek bir karakteri oluşturur. 8 bitlik bir bilgi aynı zamanda 1 byte olarak
            //adlandırılır.Bilgisayarda bir karakter 1 byte alan kaplamaktadır.

            //Tekrar edecek olursak bilgisayarlar bizim gördüğümüz şekilde algılamaz.O tamamen 1 ve 0lar üzerine kurulmuştur.Girmiş olduğumuz bütün bilgiler metinsel ifadeler
            //olabilir görsel ifadeler olabilir videolar olabilir sesler olabilir hepsini 0 ve 1'lere otomatik olarak dönüştürüyor.

            //Bu dönüşümü sağlayan nedir ? İşlemcidir.İşlemcide bulunan milyalarca transistör gelen veriyi otomatik olarak 0 ve 1'lere ayrıştırır.

            //0 nedir elektrik akımının yokluğu 1 elektrik akımının varlığını gösterir.Elektrik var yok var yok şeklinde bize milyarlarca varyasyon üretebilir.

            //Yan yana dizilen 0 ve 1'ler bize bir bilgiyi oluşturur aslında.Biz bunu program yazarken görmeyiz.Çünkü 0 ve 1'lere dönüştürecek olan derleyici dediğimiz
            //programlar vardır.C# komutları metinsel şekilde yazıyoruz bilgisayar bunları metinsel olarak algılamaz bunları derleyici dediğimiz yorumlayıcı dediğimiz
            //ara program bilgisayarla bizim aramızda bağlantıyı kuran bir programdır.Otomatik olarak 0 ve 1'lere dönüştürür.Biz kod yazarken 0 ve 1 diye yazmayız.

            //Ve bu bitlerin 8 tanesi bir araya gelerek bir karakteri oluşturur.
            //Klavyeden basılan bir a harfi aslında 8 bitlik bir veri saklar.
            #endregion

            #region 10 Tabanındaki Sayıyı 2 Tabanına Dönüştürmek

            //Bu tip dönüşümleri lise matematik aslında görmüşüzdür.Verilen 10 tabanındaki sayıyı 2 tabanına dönüştürmek için 2 sayısı ile bölme işlemi yapılır ve
            //sağdan sola doğru kalan sayılar yan yana yazılır.

            //35 sayısının ikilik tabandaki karşılığını hesaplayalım.
            //Bunun için verilen sayıyı sürekli ikiye böleriz.

            //35 = (100011)2 //Günlük hayatta kullandığımız 35 sayısı bilgisayar dilinde 35 olarak algılanmaz 100011 haliyle algılanır.

            //Biz ne demiştik bir karakterin 8 bitten oluştuğunu söylemiştik ama yukarda 6 tane 1 ve 0 var ?
            //Bunu bilgisayar otomatik olarak 8 bite tamamlamaktadır az sonra onuda göreceğiz.

            #endregion

            #region 2 Tabanındaki Sayıyı 10 Tabanına Dönüştürmek

            //(100011)2 sayısının 10 tabanındaki karşılığı nedir?
            //35 tir.

            #endregion

            #region Negatif sayıların bitsel gösterimi

            //Bilgisayarda verilerimiz 8 bit şeklinde gösterilmektedir.Az önce bulduğumuz 100011 sayısı bilgisayar tarafından 8 bite tamamlanmaktadır.

            //Yani 35 sayısı bilgisayarda 00100011 şeklinde saklanmaktadır.Bilgisayarda pozitif ve negatif kavramı olmadığından negatif sayıları saklamak için bit
            //değeri işaret biti olarak ayarlanmaktadır.

            //00100011
            //sol baştaki sayı işaret biti(sign bit) 0 ise sayının pozitif olduğunu 1 ise negatif olduğunu göstermektedir.

            //-35 sayısını bilgisayarda bitsel olarak ifade etmek için farklı yöntemler bulunmaktadır.
            //1. Yöntem : İşaret biti 1 yapılırsa sayımız -35 olur.Yani 10100011 sayısı -35 olur.Bilgisayarlar tarafından çok kullanılan bir yöntem değildir. 
            //2. Yöntem : 1'e tümleme yöntemi:bitler 0 ise 1'e,1 ise 0'a dönüştürülerek yapılır.Yani 11011100 olacaktır.
            //3. Yöntem : 2'ye tümleme yöntemi:bilgisayarda ve bilimde en sık kullanılan yöntemdir.

            //3.Yöntem 2'ye tümleme yöntemi en sık kullanılan gösterimdir.Sağdan sola doğru ilk 1 bitini görene kadar sayımız yazılır 1 de dahildir.Sonrasında kalan
            //tüm bitler terse çevrilir yani 1 ise 0 0 ise 1 e dönüştürülür.

            //10011000 sayımızı 2'ye tümleme yöntemi ile negatife dönüştürelim.
            //01101000 olarak karşımıza gelecektir.

            //Bu konu algoritma eğitimimiz için çok iyi bilinmesine gerek yoktur.Bizim yazdığımız programlar derleyiciler tarafından 1 ve 0 lara dönüştürülmektedir.
            //Sizlere genel kültür olması açısından bu bilgiler verildi.Eğer daha detaylı olarak öğrenmek istersek internette araştırma yapabilirsiniz.

            #endregion

            #region Karakterlerin 2lik sayı tabanına dönüştürülmesi

            //Karakterler sayısal olmayan ifadelerdir.A-Z veya noktalama işaretleri gibi. Her karakterin bilgisayarda bir sayısal karşılığı vardır.
            //Ve ortak dil olarak ASCII sayısal kodlar kabul edilmiştir.Örneğin A karakterinin karşılığı 10luk sayı tabanında ki karşılıktır o da 65'tir.
            //Detaylı bilgi için ASCII kodlar şeklinde arama motorlarında arama yapılabilir.

            //Bizler klavyeden A karakterine bastığımız zaman otomatik olarak ikili sayı tabanına dönüşmektedir.

            //Her karakter ve basılmamış karakterlerin sayısal karşılığı vardır.Sayısal karşılıkları sayesinde bilgisayarda yine 0 ve 1 lere dönüştürerek yazılmasını 
            //sağlayacaktır.
            #endregion

            #region Renklerin Sayısal karşılıkları 

            //Bilgisayarda oluşturulan görüntüler dijital görüntülerdir. Yine 0 ve 1 (bitler) den oluşmaktadır.Her rengin bir sayısal karşılığı bulunmaktadır.
            //RGB, CMYK, Hexadecimal sayısal cinsinden karşılıkları bulunmaktadır.

            //Bir resmi oluşturan en küçük birime pixel ismi verilmektedir.Ve pixel dediğimiz kutucuklar renkler ile doludur. 

            #endregion

            #region Programların amacı nedir ?

            //Bilgisayarda kullanmış olduğumuz programlar aslında bir sorunu veya bir problemi çözmek için oluşturulan kodlar bütünüdür.

            //Örneğin resimler üzerinde işlem yapabilmek için Photoshop Programı 

            //Video izlemek için Windows Media Player veya GOM Player Programı

            //Ses düzenlemek için Audacity gibi programlar aslında bir problemi ortadan kaldırmak için üretilmiş programlardır.

            //O zaman problem doğrultusunda bir program oluşturmamız gerekiyor

            //Yazılımcılar kodları yazıyorlar örneğin videoyu dönüştürecek o videoyu bilgisayarın anlayabileceği kıvama getirmemiz gerekiyor.Bunun içinde yazılımcılar
            //Windows Media Player adında bir program üretmişlerdir.

            #endregion

            #region Program 

            //Belirli bir işi gerçekleştirmek için gerekli komutlar dizisi olarak tanımlanabilir.

            #endregion

            #region Programlama 

            //Bir programı oluşturabilmek için gerekli komutların belirlenmesi ve uygun biçimde kullanılmasıdır.

            #endregion

            #region Programlama dilleri

            //Bir programın oluşturulmasında kullanılan komutlar,tanımlar ve kuralların belirtildiği programlama araçlarıdır.
            //Bilgisayara ne yapmaları gerektiğini söylememizi sağlayan özel bir dil.

            #endregion

            #region Problem nedir ? 

            //Karşılaşılabilecek soruna veya çözülmesi gereken duruma problem denir.

            //Örneğin ilk kez gideceğiniz yerde yolu kaybetmeniz, telefonunuzun kitlenmesi, online alışveriş sitesinden aldığınız ürünün yanlış gelmesi gibi durumlar
            //aslında günlük hayatta karşılaştığımız problemlerdir.Bu problemleri aşmak için farklı çözüm yolları deneriz.

            //Bir problemi çözmesi beklenen alternatif yollar arasından en doğru olanı seçebilmeye problem çözme denir.

            //Problemi ortaya koyma aşamasından, problemin çözümünün tamamlanmasına kadar geçen zaman ise problem çözme süreci olarak adlandırılır.

            //Problemleri çözmek için genellikle iki farklı yöntem kullanılır:
            //1. Deneme yanılma ya da tahminde bulunma yoluyla çözme 
            //2. Algoritma geliştirme yoluyla çözme

            //Probleme çözüm bulmak aşamasında algoritma mantığı başlıyor.Gündelik hayatta algoritmayı her yerde kullanıyoruz
            //Yolumuzu kaybedersek birilerine sorarız navigasyonu kurarız telefon edip tarif ederiz vs

            //Bilgisayarda problemleri çözerken yaptığımız şey de algoritmadır mesele bir problemin bir çözümü yoktur birden fazla çözümü vardır biz de 
            //Problemi çözmek ve en hızlı sonuca ulaşmak için algoritma tasarlayacağız 
            #endregion

            #region Problem Çözme Süreci

            //1.PROBLEMİ TANIMLAMA 
            //Problemin ne olduğu belirgin bir şekilde ortaya konulmalıdır.

            //2.PROBLEMİ ANLAMA
            //Problemin kaynağının ne olduğu belirlenmelidir.Bir problem ne kadar iyi anlaşılırsa çözümü o kadar kolay olacaktır.

            //3.ALTERNATİF ÇÖZÜM YOLLARINI BELİRLEME 
            //Problemleri çözmesi beklenen tüm alternatifler sıralanmalıdır.

            //4.EN UYGUN ÇÖZÜMÜ SEÇME
            //Bir önceki adımda belirlenen alternatifler arasından en uygun olanının seçilmesi gerekir.

            //5.ÇÖZÜMÜ UYGULAMA
            //Bir önceki adımda belirlenen çözüm yöntemi kullanılarak problemi çözme işi gerçekleştirilir.

            //6.ÇÖZÜMÜ TEST ETME
            //Uygulanan çözümün beklentileri yerine getirip getirmediği test edilmelidir.

            #endregion

            #region Algoritma Kavramı

            //Algoritma kelimesi bir İslam Bilgini olan El-Harezmi'nin isminin latince karşılığından gelmektedir.El-Harezmi matematik, gök bilim ve coğrafya
            //alanlarında çalışmış, cebirin temelini oluşturmuş, bugünkü bilgisayar bilimi ve elektroniğin temeli olan 2'lik (binary) sayı sistemini ve 0'ı (sıfır)
            //bulmuş önemli bir bilim insanıdır.

            //Programlamanın öğrenilebilmesi için öncelikle algoritmanın ne olduğu ve nasıl geliştirilmesi gerektiğine cevap bulunmalıdır.

            //Problem çözme yöntemlerinden biri olan algoritma geliştirmek kodlamaya atılan ilk adımdır.Algoritma mantığı iyice kavrandıktan sonra bu mantık ile birlikte
            //bir programlama dili kullanılarak yazılım geliştirme süreci başlar.

            //Algoritma bir problemin adım adım çözülmesidir aslında 

            //Algoritma, belirli bir mantığı olan, farklı düşünebilmeyi ve problem çözmeyi öğretmek için tasarlanan bir yoldur. Başka bir ifadeyle bir problemi
            //çözmeye giden yolun basit, net ve belirli bir sıraya göre tasarlanmış halidir.

            //Açık ve net olmalıdır.
            //Kullanılacak olan girdiler iyi tanımlanmış olmalıdır.
            //Çıktılar açık ve anlaşılır olmalıdır.
            //Algoritmalar hızlı olmalıdır.
            //Sonlu ve uygulanabilir olmalıdır.

            //Algoritmaların program haline getirilmesi için programlama dilleri kullanılır.

            //Programlama dilleri kullanılarak yazılımlar geliştirilir.

            #endregion

            #region Programlamaya ilişkin kavramlar

            //1.Kaynak Kod: Herhangi bir yazılımın, makine diline dönüştürülerek işlenip yorumlanmasından önce insanların okuyabildikleri ve üzerinde çalışabildikleri
            //kodlar olarak tanımlanabilmektedir.Başka bir tanımla bir editör tarafından yazmış olduğumuz kodlardır.İnsanların anlayabileceği dildeki kodlardır.

            //#include<stdio.h>
            //main()
            //{
            //   printf("HelloWorld")
            //}

            //2.Kod Editörü: Yazılım geliştirmek isteyen kullanıcıların bu yazılımları ortaya çıkarmak için kod yazarak üzerinde çalıştığı platformdur. Her yazılımcının
            //kod yazmak için düzenleyiciye (kod editörüne) ihtiyacı vardır.Bazı kod editörleri yalnızca bir veya iki dili desteklemektedir. Bazı kod editörleri
            //ise çoklu dilleri ve platformlarıda desteklemektedir.Örneğin Visual Studio

            //3.Amaç Program: Kaynak programın derlenmesi ile elde edilen makine diline dönüştürülmüş programa amaç program (object program) denir.Programlama dili ile
            //yazılan kaynak programları makine dili ile yazılan amaç programlara çevirmek için derleyiciler kullanılır.

            //4.Derleyici(Compiler): Geliştiricilerin herhangi bir programlama dilini kullanarak yazdığı kaynak kodu bilgisayarın anlayabileceği makine diline yani
            //0 ve 1'lere çeviren aracı yazılımdır.Derleyici sayesinde geliştiriciler farklı programlama dillerini kullanarak aynı işlevi yerine getiren yazılımlar
            //üretebilirler.

            //5.Yorumlayıcı(interpreter): Yüksek seviyeli programlama dili ile yazılmış bir programı adım adım makine diline çeviren ve makine dilindeki talimatları
            //çalıştıran programdır.

            //Derleyici ve yorumlayıcı arasındaki fark 
            //Derleyiciler, yorumlayıcılara göre daha hızlıdır.Çünkü yorumlayıcılar ilk kod satırından son kod satırına kadar her satırı teker teker yorumlar ve 
            //kodun karşılığındaki işlemi gerçekleştirir.Derleyiciler ise kodların tamamını bilgisayar diline çevirir.Eğer hata varsa, tüm hataları programcıya bildirir.

            //Biz 0 ve 1'leri kullanarak program yazamayız biz ne yapıyoruz konuşma diline yakın bir dilde komutları giriyoruz onlar derleyiciler dediğimiz ara programlar
            //sayesinde amaç programa dönüştürülüyor yani 0 ve 1'lere dönüştürülüyor.Bilgisayar o şekilde çalışmaya devam ediyor.

            //Programlama dillerinde iki farklı 0 ve 1'lere dönüştürme yolları vardır.Birisi derleyiciler sayesinde birisi ise yorumlayıcılar sayesinde.

            //Derleyiciler bilgisayarımızda programı yazdırdıktan sonra programın tamamını 0 ve 1'lere dönüştürerek çalıştırır.C,C++ derleyiciler tarafından çalıştırılır.
            //Program baştan sona bir kerede 0 ve 1'lere tamamı dönüştürülür.Eğer bir hata varsa program çalıştırılmadan gösterilir der ki bu satırda bir hata var. 

            //Yorumlayıcılar ise komutları satır satır 0 ve 1'lere dönüştürerek çalıştırırlar.Python programı yorumlayıcı tarafından çalıştırılır.Yani her satır çalışma 
            //esnasında 0 ve 1'lere dönüştürülerek çalıştırılır.Yorumlayıcılarda satır satır çalıştırılır hangi satıra geldi nerede hata varsa program orada yarıda kesilir.

            #endregion

            #region Algoritma gösterim şekilleri

            //Düz yazı ile gösterim
            //Sözde kod(pseudo kod) ile gösterim
            //Akış şeması ile gösterim

            //Düz yazı ile gösterim
            //Adım1 : Başla
            //Adım2 : Birinci sayıyı oku
            //Adım3 : İkinci sayıyı oku
            //Adım4 : Birinci sayı ve İkinci Sayıyı Topla
            //Adım5 : Toplamı Ekrana yaz
            //Adım6 : Bitir

            //Sözde kod(Pseudo kod) ile gösterim
            //A1 : Başla
            //A2 : sayi1 oku
            //A3 : sayi2 oku
            //A4 : sonuc = sayi1 + sayi2
            //A5 : Yaz sonuc
            //A6 : Bitir

            #endregion

            #region Kullanılan Operatörler

            //Operatörler, uygulamalarımızda matematiksel veya mantıksal işlemleri gerçekleştirmemizi sağlayan özel karakter ve karakter gruplarıdır.

            //Matematiksel işlemleri yapmak için kullanılan operatörler
            //Toplama ve birleştirme Operatörü --> + --> 3+2 metinsel ifadeleri birleştirmek içinde kullanılır.
            //Çıkarma Operatörü --> - --> 9-7
            //Çarpma Operatörü --> * --> 6*3
            //Bölme Operatörü --> / --> 9/3
            //Mod Operatörü --> % --> Kalan bulma oparatörüdür. 10%3 kalanı 1dir.Kalan bizim için çok önemlidir.Tam bölünebilme, sayı tek mi çift mi olduğunu kontrol ederiz.

            //Karşılaştırma Operatörleri
            //Program içinde ifadelerin karşılaştırılması için kullanılır.Karşılaştırma ifadelerinin sonucu ya TRUE - DOĞRU ya da FALSE - YANLIŞ olur.Üçüncü bir ihtimal 
            //yoktur.
            //Eşit mi ==      3==3 işlem sonucu True, 3==4 işlem sonucu False
            //Eşit değil mi !=      4!=5 True, 5!=5 False
            //Büyük mü >      6>4 True, 6<4 False 
            //Büyük veya Eşit mi >=   5>=3 True, 5>=5 True, 5>=6 False
            //Küçük mü <      6<8 True, 6<4 False 
            //Küçük veya Eşit mi <=  5<=6 True, 5<=5 True, 5<=4 False

            //Mantıksal Operatörler
            //Birden fazla karşılaştırma ifadesini birleştirmek için kullanılır.
            //ve && //Birden fazla karşılaştırma ifadesinin hepsinin doğru olması durumunda True sonucunu verir.Şartlardan birisinin yanlış olması durumunda False
            //sonucunu verir.

            //veya || //Birden fazla koşuldan bir tanesinin doğru olması durumunda True sonucunu verir.Şartların tümünün yanlış olması durumunda false sonucunu verir

            //değil ! //True ifadesini False, False ifadesini True yapar.İşlemi tersine çevirir.


            //ve(&&) 
            // a --> 1.Şart b --> 2. Şart 
            // a == 1(True) b == 1(True) a and b == True
            // 0 - 1 --> 0
            // 1 - 0 --> 0
            // 0 - 0 --> 0

            //veya(||)
            //1 - 1 --> 1
            //0 - 1 --> 1
            //1 - 0 --> 1
            //0 - 0 --> 0 

            //Mantıksal Operatörler mantıksal birleştirme ve mantıksal karşılaştırma için kullanıldığını anlamış olduk.Yerine göre bir tane şart için mantıksal 
            //çıkarım yapacağız yerine göre birden fazla koşulu karşılaştıracağız.Günlük konuşma, talep vb şeyleri düşünürsek ve ve veya operatörlerinin farkını çok
            //net anlarız.

            //Örneğin ali ve veli gelsinde işimize bakalım dersem ve sadece ali gelirse isteğim sağlanmış olur mu ?
            //Facebook sisteminde giriş yapacağız kullanıcı adı ve şifreyi doğru girince kişisel sayfamıza geçiş sağlarız sistem veri tabanından bilgilerimizi
            //karşılaştırıp bizi sisteme dahil eder burada karşılaştırılan ve kontrol edilen iki şartın yani kullanıcı adı ve şifrenin doğru olması gerekir değil mi.

            //Bir iş yerine müracaat ediyor kişiler yabancı dillerini soruyoruz kimisi ingilizce, almanca, rusça, fransızca
            //Yabancı dili ingilizce veya almanca olanları işe alacağım diyorum 
            //Dikkat edilirse hem almanca hem ingilizce veya ingilizce ve almanca olanları işe alacağım demiyorum 
            //İngilizce veya almanca yabancı dili olanların herhangi birisini alacağım diyorum 

            //Tekrarlarsak örneğin Facebook hesabınıza giriş yaparken kullanıcı adınızın ve şifrenizin doğru olması denetlenir.

            //kullaniciAdi = Volkan && sifre = 123

            //Eğer girilen bilgilerden birisi yanlış olursa sistem false sonucunu döndürür ve sizi hatalı giriş sayfasına yönlendirir.

            #endregion

            #region Matematiksel işlemlerde işlem önceliği

            //Matematiksel işlemleri algoritmada her zaman yazıldığı gibi kullanamayız.Bilgisayar mantığına göre matematiksel ifadelerin tek satır halinde yazılmaları
            //gerekir. Algoritmada işlem öncelik sırası kuralları aşağıda verilmiştir. Parantez kullanılarak işlem öncelik sıraları değiştirilir. İç içe kullanılan
            //parantezlerde öncelik en içtekindedir. Aynı işlem önceliğine sahip elemanlarda işlem soldan sağa doğrudur.

            //İşlem öncesi sırası kuralları 
            //ilk olarak parantez içleri sonra üslü ifadeler sonra çarpma ve bölme işlemleri sonra toplama ve çıkarma işlemleri

            #endregion

            #region Değişkenler

            //Program içerisinde verilerimiz RAM bellek üzerinde tutulmaktadır. Ve tutulan bilginin türüne farklı tiplerde değişkenler bulunmaktadır. 
            //Program içerisinde bir değişken oluşturduğumuz zaman RAM Bellek üzerinde değişken adı ile bir alan açılmaktadır.RAM bellek, bankalardaki kiralık kasalara
            //benzetebiliriz. Değerli eşyalarımızı orada saklayabilir ve ihtiyacımız olduğu zaman alıp kullanabiliriz.

            //Kullanıcı tarafından girilen veya program tarafından üretilen verilerin bilgisayarda tutulmasını sağlayan yapılardır.Saklayacağı veri türüne göre
            //değişken tipleri bulunmaktadır.

            //Tekrar edecek ve birkaç şey ekleyecek olursak değişkenler her programlama dilinde varolan yapılardır.Kullanıcıdan alınan bilgileri veya program içinde 
            //üretilen bilgileri RAM bellekte depolamayı sağlar.RAM bellek bizim geçici hafızamızdır.Yani bilgisayar kapanıp açıldığı zaman RAM bellekteki bütün bilgiler
            //silinmektedir.Program çalıştığı sürece bellek üzerinde verilerin tutulmasını sağlar.

            //RAM bellek bankalardaki kiralık kasalar gibi düşünebiliriz nasıl ki eşyalarımızı saklayabiliyorsak istediğimiz zaman alıp kullanabiliyorsak RAM 
            //bellekte depoladığımız bilgileri gerektiği zaman kullanabiliriz.Kiralık kasalarda kalıcıyken RAM bellek geçici veri depolanan bellektir farkı budur.

            //RAM bellek çalışma açısında HARD DİSKten kat ve kat hızlıdır.O yüzden veriler bellekte geçici olarak depolanır.

            //Zaten işletim sistemide HARD DİSKTEN okunur RAM belleğe yüklenir.Bundan sonra biz windows ya da başka bir işletim sistemini kullanırken RAM bellek
            //Üzerinden kullanırız.Bütün programlar aynı şekilde programa çift tıkladığımız zaman o program işlemci tarafından hemen RAM belleğe yüklenilmesi 
            //komutunu veriyor.Ve o programı RAM bellek üzerinden kullanıyoruz.

            //Örneğin kullanıcıdan bir kullanıcı adı alacaksak değişken adı oluşturuyoruz değişken adını biz uyduruyoruz fakat işlevsel olması için anlamlı bir
            //ad vermemiz gerekiyor uyumlu bir ad vermemiz gerekiyor bunuda ihtiyaca uygun biçimde gerçekleştiriyoruz.Örneğin ad, sayi, derece, islem....

            //Değişkenin hangi bilgiyi sakladığını bilmemiz için uygun bir isim veriyoruz.

            //Volkan Şener sözcükleri için sayi adında bir değişken adı verirsek unutabiliriz ve mantıklı olmaz.
            //Sayı saklamıyorsam isim saklıyorsam isimleri tutan bir veri türünde uygun bir değişken adıyla değişkenimizi tanımlayıp tutacağımız metinsel veriyi atamalıyız.

            //Böylelikle ihtiyacımıza göre daha sonra kullanmak için RAM bellekte verimizi tutmuş oluruz.

            //Anlayacağımız o ki saklanan veriyi anımsatacak bir ad girmemiz önemli bir nokta.

            //Daha sonra ad bilgisini okumak istersek ya da gerekirse örneğin RAM bellekte depoladığımız ad isimli değişkeni çağırıp içinde ki Volkan Şener'i yazdırıp
            //okuyabiliriz örneğin.

            #endregion

            #region Değişken tipleri ve tanımlama

            //Program dillerinde saklanacak veriler tiplerine göre değişiklik göstermektedir.Algoritma eğitiminde temel olarak 4 farklı başlık altında inceleyeceğiz.
            //Fakat programlama dili eğitimine geçtiğimizde bu değişken tiplerindeki farklılıkları inceleyeceğiz.

            //TAMSAYI DEĞİŞKENLERİ
            //Tamsayı türündeki verileri saklamak için kullanılır.byte, sbyte, short, int, long veri tipinde ki değişkenler tamsayı verilerini saklamak için kullanılır.
            //Bu veri tipleri de tamsayı değerlerini tutan veri tipleridir.Bu veri tiplerini kullanıp tanımladığımız değişkenlerle ancak tamsayıları depolayabiliriz.
            //ihtiyaç duyduğumuzda kullanabiliriz.

            //int sayi = 30; //C# programlama dilinde değişken bu şekilde tanımlanır. veri tipi seçilir değişken adı verilip değişken tanımlanır atama operatörü yazılır
            //biz girdiysek eşittirin sağına değişkene atayacağımız veriyi girip ; ile satır kapama yaparız.

            //ONDALIK SAYI DEĞİŞKENLERİ
            //Ondalıklı sayı verilerini saklamak için kullanılır.double, float, decimal veri tipinde ki değişkenler ondalık sayıları saklamak için kullanılır.
            //Bu veri tipleri de ondalık sayı değerlerini tutan veri tipleridir.

            //vergi = 235.26 örneğin 

            //METİNSEL DEĞİŞKENLER
            //Metinsel ifadeleri(verileri) saklamak için kullanılır.string, char veri tipinde ki değişkenler metinsel verileri saklamak için kullanılır.
            //Bu veri tipleri de metinsel değerleri tutan ve bir başka tanımla tanımlayan veri tipleridir.

            //ad = "Volkan"

            //KARAR DEĞİŞKENLERİ 
            //Sadece TRUE veya FALSE değerlerini saklamak için kullanılır.Bu iki ihtimalin olduğu yerde kullanılır.bool(boolean) veri tipinde değişkende saklanır.
            //Bir mantıksal niceliği simgeler (doğru veya yanlış).

            //islem = TRUE

            //NOT: Tekrarlarsak yukarda detaylı bir açıklama olsa da başka şekilde ifade edelim sayi = 30 ifadesindeki = iki ifadenin eşit olduğunu göstermez.
            //Sağ taraftaki değerin sol taraftaki değişkene ismine yazıldığını veya değişkene atandığını gösterir o eşittir atama operatörüdür.RAM bellekte sayi adında
            //bir alan(değişken) oluşturulur ve bu alana 10 sayısının yazıldığını gösterir.

            //Veri tipleri farklı değer aralıklarında değerleri alabilir ve RAM bellekte kapladıkları alan farklıdır.

            #endregion

            #region Değişken Tanımlama Kuralları

            //Değişken ismi içerisinde boşluk kullanılmaz.
            //Adi_Soyadi - Doğru , Adi Soyadi - Yanlış

            //Değişken isimleri rakam veya özel karakter ile başlayamaz, harf ile başlamalıdır.
            //Doğru - Sozlu1 Yanlış - 1.Sozlu

            //Programa dilinin kullandığı komut satırları değişken ismi olarak kullanılamaz.Programlama dilinde kullanılan metotlar,fonksiyon isimlerini değişken olarak
            //tanımlayamıyoruz.
            //int, void, string, try

            //Değişken isminin 255 karakterden fazla olmaması gerekir.

            //Değişken ismi içerisinde harf,rakam ve alt çizgi dışındaki karakterler kullanılmamalıdır.
            //Doğru - Adi_Soyadi Yanlış - Adi+Soyadi

            //Birden fazla kelimeden oluşan değişken isimlendirmede kabul görmüş kural camel case(deve hörgücü) ilk kelime küçük harfle başlar diğer kelimelerin ilk 
            //harfi büyük yazılır
            //adSoyadi, okulNo, musteriNo, ogrenciAdSoyad

            #endregion

            #region Şart(Koşul)

            //Programlamada belli koşullara göre işlem yapılmasını sağlar.Karşılaştırma ifadelerini kullanarak programın dallanmasını sağlar.
            //Örneğin girilen sayı 0 dan büyükse doğru(true) ve bize sayı pozitiftir mesajı verecek işlemi yapabiliriz büyükse pozitif küçükse
            //koşulun sonucu false olur negatif mesajını ekrana verir gibi.

            #endregion

            #region Döngüler

            //Programda tekrarlanması istenen işlemler için döngü oluşturur.
            //Örneğin veri tabanından 100 kişiyi çek dediğimiz zaman bunları satır satır yazdırmaktansa tekrarlar işin içine girdiği için döngüyü kullanarak istediğim
            //işlemi gerçekleştirebiliyorum

            #endregion

            #region Flowgorithm

            //Akış diyagramları oluşturup test etmemizi sağlayan güncel programdır.Akış diyagramında oluşturduğumuz şekillerin programlama dillerinde ki karşılığıda 
            //mevcuttur.Programın nerelerde ayrıldığını programın akışını görsellerle okumak daha kolay olduğunda program oldukça kullanışlıdır.

            #endregion

            //Visual Studio geliştirme döngüsünün tamamını tek bir yerde tamamlamak için kullanabileceğiniz güçlü bir geliştirici aracıdır.
            //Kod yazmak, düzenlemek, hata ayıklamak ve derlemek ve ardından uygulamanızı dağıtmak için kullanabileceğiniz kapsamlı bir tümleşik geliştirme ortamıdır

            //Progress Bar uygulama yükleme ve indirme esnasında dolan çubuktur ilerleme çubuğu türkçesidir

            //Tümleşik geliştirme ortamı(Integrated Development Environment) yani IDE, bilgisayar programcılarının hızlı ve rahat bir şekilde yazılım geliştirebilmesini amaçlayan,
            //geliştirme sürecini organize edebilen birçok araç ile birlikte geliştirme sürecinin verimli kullanılmasına katkıda bulunan araçların tamamını içerisinde barındıran bir yazılım türüdür.Visual Studio örneğin

            //Programlama dili yazılımcının bir algoritmayı ifade etmek amacıyla, bir bilgisayara ne yapmasını istediğini anlatmasının tektipleştirilmiş yoludur.
            //Programlama dilleri, yazılımcının bilgisayara hangi veri üzerinde işlem yapacağını, verinin nasıl depolanıp iletileceğini, hangi koşullarda hangi işlemlerin yapılacağını tam olarak anlatmasını sağlar.

            //Framework, bilgisayar programlamada yazılım iskeleti, yazılım çerçevesi ya da yazılım çatısı,
            //standart fonksiyonların hazır olarak sunulduğu ancak programcı tarafından bu fonksiyonlardan arzu edilen kısımların ek kodlarla istenildiği şekilde güncellenebildiği sistemlerdir.

            #region Visual Studio Arayüz tanımı

            //2022 sürümünü kullanıyoruz ilk başta istenen şekilde kurmuştuk.İlk gelen sekmede Create a new project ile yeni bir proje oluştura tıklıyoruz.
            //Başlangıç için konsol uygulaması yazmak en faydalı başlangıç olacağı için temeli burada oturtmaya başladık 
            //Console App (.Net Framework) tıklıyoruz.Projemizin ismini kaydedileceği konumu Framework sürümü seçiyoruz

            #endregion
        }
    }
}
