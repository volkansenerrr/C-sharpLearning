using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosullar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# dilinde koşullar, programın akışını kontrol etmek ve belirli durumlarda farklı işlemler gerçekleştirmek için kullanılır.


            // if(koşul parantezi)
            // Koşul parantezi içerisindeki ifade mutlaka boolean değer üretmelidir
            // En yaygın kullanılan koşul yapısı if-else ve switch-case yapısıdır.

            //if (true)
            //{
            //Koşul sağlanırsa derleyici bu parantezler içerisindeki işlemleri gerçekleştirir.
            //}
            //Koşul alanı dışı bölge

            // Bazı durumlarda datalarımızı(verilerimizi) koşullara sokabiliriz
            // Mesela öğrencimizin notu 50den büyükse öğrencimiz başarılı öğrencimizin notu 50den büyük değilse başarısız 
            // gibi kontrol aşamalarından geçirmek isteyebiliriz.

            // Nasıl kullanılıyor peki ?
            // En başta if kelimesi kullanıyoruz türkçede eğer anlamına geliyor 
            // else if aksi takdirde anlamına geliyor
            // else aksi halde anlamına gelebilir
            // Parantezleri açıyoruz ve buraya bir koşul yazıyoruz

            // if(koşul) --> mesela öğrencimizin notu notDegeri > 50 dense bu bir koşuldur benim öğrencimin notu 50'den büyük mü büyükse devam ediyoruz
            // tam anlamıyla karşılaştırma yapıyoruz bilgisayar bakıyor benim notumun 70 olduğunu düşünelim 70 > 50 olduğu için koşul doğru true
            // sonra kodları çalıştıran program if parantezleri içine girip oradaki kodları çalıştırıyor koşulum sağlanmasaydı if blokları içindeki
            // kodlarım çalışmayacaktı parantez dışından devam edecekti.

            // else aksi halde anlamında ki ifade if koşulu sağlanmadığı zaman koşul belirtmeden kullanılabilir.İf koşulu sağlanmadığı zaman else bloklarının
            // içinde ki kodları işlevsel olacak şekilde kullanabiliriz.İf koşulu false olursa if blokları dışına çıkan derleyici else bloklarına girer
            // anlamlı bir çıktı vermek için yazdığımız kodları çalıştırır ve anlamlı işlevsel bir çıktı vermemiz sağlanabilir zorunlu değildir.

            // En temel haliyle koşul yapısı budur.Birden fazla koşullu durumlarda if koşulundan sonra ikinci koşulu else if kelimesini yazarak belirtebiliriz
            // aynı yapı işler anlamlı ve işlevsel çıktılar için ekstra koşullandırma yapıp programımızın ilerleyişini dallandırırız.Progralama da şuana kadar
            // doğrusal algoritmik yapıyı gördük kodlar yukardan aşağı düz bir şekilde çalışıyor yavaş yavaş ilerliyoruz.Her şey ihtiyaç halinde adım adım.

            // ÖRNEKLER

            // Sayı değişkeni içerisinde ki değer pozitif mi?
            int sayi = 29;
            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitiftir");
            }
            else
            {
                Console.WriteLine("Sayı negatiftir");
            }

            // Konsoldan alınan veri çift mi?
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }

            // Konsoldan doğum yılını istiyoruz. Yaş değeri 12 üstünde ise merhaba kullanıcı
            Console.WriteLine("Doğum yılınızı giriniz:");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            if (DateTime.Now.Year - dogumYili >= 12)
            {
                Console.WriteLine("Merhaba Kullanıcı, nasılsın?");
            }
            else
            {
                Console.WriteLine("Yaş değeri uygun değil, büyüyünce gel.");
            }

            // Konsoldan kullanıcı adı alınacak ve şifre alınacak
            Console.WriteLine("Lütfen Kullanıcı Adınızı giriniz:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            int sifre = Convert.ToInt32(Console.ReadLine());
            if (kullaniciAdi == "admin" && sifre == 1234)
            {
                Console.WriteLine("Hoşgeldin Admin :)");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifrenizi yanlış girdiniz, bilgilerinizi kontrol edip tekrar deneyiniz.");
            }

            // Ortalama hesaba göre geçti kaldı
            Console.WriteLine("Lütfen Vize notunuzu giriniz:");
            double vizeNot = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Final notunuzu giriniz:");
            double finalNot = Convert.ToDouble(Console.ReadLine());
            double ortalama = (vizeNot + finalNot) / 2;
            if (ortalama >= 50)
            {
                Console.WriteLine("Geçtiniz :)");
            }
            else
            {
                Console.WriteLine("Kaldınız :(");
            }

            // Kullanıcıdan alınan 2 sayının toplamı 100'ü geçiyorsa yüzde 20 arttır, geçmiyorsa yüzde 10 arttır
            Console.WriteLine("Lütfen 1. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            if (toplam >= 100)
            {
                toplam += toplam * 20 / 100;
            }
            else
            {
                toplam += toplam * 10 / 100;
            }
            Console.WriteLine("Sonuç: " + toplam);

            // Kullanıcıdan 3 tane not alıp, ortalamaya göre harf notu yazdıran örnek
            Console.WriteLine("Lütfen 1. Sınav notunuzu giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sınav notunuzu giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3. Sınav notunuzu giriniz:");
            int not3 = Convert.ToInt32(Console.ReadLine());
            double ortalamaNot = (not1 + not2 + not3) / 3.0;
            if (ortalamaNot >= 80)
            {
                Console.WriteLine("A+");
            }
            else if (ortalamaNot >= 60)
            {
                Console.WriteLine("A");
            }
            else if (ortalamaNot >= 40)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("F");
            }

            // Beden Kitle İndeksi (BMI) uygulaması
            Console.WriteLine("Hoşgeldiniz, hadi Vücut Kitle İndeksi'nizi hesaplayalım :)");
            Console.WriteLine("Lütfen kilonuzu giriniz (kg):");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu giriniz (m):");
            double boy = Convert.ToDouble(Console.ReadLine());
            double vki = kilo / (boy * boy);
            if (vki < 18.5)
            {
                Console.WriteLine("Vücut Kitle İndeksiniz: " + vki + " (İdeal kilonun altında)");
            }
            else if (vki <= 24.9)
            {
                Console.WriteLine("Vücut Kitle İndeksiniz: " + vki + " (İdeal kiloda)");
            }
            else if (vki <= 29.9)
            {
                Console.WriteLine("Vücut Kitle İndeksiniz: " + vki + " (İdeal kilonun üstünde)");
            }
            else if (vki <= 39.9)
            {
                Console.WriteLine("Vücut Kitle İndeksiniz: " + vki + " (Obez)");
            }
            else
            {
                Console.WriteLine("Vücut Kitle İndeksiniz: " + vki + " (Morbid obez)");
            }


            // Dikdörtgenin alanı ve çevresi
            Console.WriteLine("Lütfen kısa kenar uzunluğunu giriniz.");
            double kisaKenar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenar uzunluğunu giriniz.");
            double uzunKenar = Convert.ToDouble(Console.ReadLine());

            double cevre = 2 * (uzunKenar + kisaKenar);
            double alan = uzunKenar * kisaKenar;

            Console.WriteLine("Dikdörtgenin çevresi = " + cevre);
            Console.WriteLine("Dikdörtgenin alanı = " + alan);

            // Ehliyet kontrolü
            Console.WriteLine("Ehliyet alıp alamadığınızı kontrol etmem için lütfen yaşınızı giriniz.");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız.");
            }

            // Sayı pozitif mi negatif mi kontrolü
            Console.WriteLine("Lütfen bir sayı giriniz.");
            double sayi4 = Convert.ToDouble(Console.ReadLine());

            if (sayi4 > 0)
            {
                Console.WriteLine("Girdiğiniz sayı pozitiftir.");
            }
            else if (sayi4 < 0)
            {
                Console.WriteLine("Girdiğiniz sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı sıfır.");
            }

            // İşe alım kriterleri
            Console.WriteLine("Öncelikle yaşınızı öğrenebilir miyim?");
            yas = Convert.ToInt32(Console.ReadLine());

            if (yas >= 40)
            {
                Console.WriteLine("Üzgünüz, kriterlerimize uymuyorsunuz.");
            }
            else
            {
                Console.WriteLine("B sınıfı sürücü belgesine sahip misiniz? (Evet/Hayır)");
                string surucuBelgesi = Console.ReadLine();

                Console.WriteLine("Mezuniyetinizi öğrenebilir miyim? (Üniversite mezunuyum/Hayır)");
                string mezuniyetBelgesi = Console.ReadLine();

                if (surucuBelgesi == "Evet" && mezuniyetBelgesi == "Üniversite mezunuyum")
                {
                    Console.WriteLine("Kriterlerimize uygun bir adaysınız. Sizinle çalışmak çok isteriz.");
                }
                else
                {
                    Console.WriteLine("Üzgünüz, kriterlerimize uymuyorsunuz.");
                }
            }

            // Parçalı fonksiyon hesaplama
            Console.WriteLine("Lütfen fonksiyonun çözümü için kullanacağınız x değerini giriniz.");
            double x = Convert.ToDouble(Console.ReadLine());

            double y;

            if (x < 1)
            {
                y = 3 * x - 4;
            }
            else if (x <= 10)
            {
                y = x + 2;
            }
            else
            {
                y = 2 * x + 4;
            }

            Console.WriteLine("Fonksiyonun sonucu = " + y);

            // 2. dereceden denklemin köklerini bulma
            Console.WriteLine("a değerini giriniz.");
            double aDegeri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b değerini giriniz.");
            double bDegeri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c değerini giriniz.");
            double cDegeri = Convert.ToDouble(Console.ReadLine());

            double diskriminant = (bDegeri * bDegeri) - (4 * aDegeri * cDegeri);
            double diskriminantKareKoku = Math.Sqrt(diskriminant);

            if (aDegeri == 0)
            {
                Console.WriteLine("Denklem ikinci dereceden değildir (a sıfır olamaz).");
            }
            else if (diskriminant > 0)
            {
                double x1 = (-bDegeri + diskriminantKareKoku) / (2 * aDegeri);
                double x2 = (-bDegeri - diskriminantKareKoku) / (2 * aDegeri);
                Console.WriteLine("Denklemin iki gerçek ve farklı kökü vardır.");
                Console.WriteLine("Köklerden biri " + x1 + " diğeri " + x2);
            }
            else if (diskriminant == 0)
            {
                double x1 = -bDegeri / (2 * aDegeri);
                Console.WriteLine("Denklemin iki gerçek ve eşit kökü vardır.");
                Console.WriteLine("Kökler " + x1);
            }
            else
            {
                Console.WriteLine("Denklemin iki gerçek kökü yoktur (kökler karmaşık sayı olabilir).");
            }

            // Notu 5'lik sisteme çevirme
            Console.WriteLine("Notunu gir bakalım.");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not >= 85 && not <= 100)
            {
                Console.WriteLine("5 aldın.");
            }
            else if (not >= 75)
            {
                Console.WriteLine("4 aldın.");
            }
            else if (not >= 60)
            {
                Console.WriteLine("3 aldın.");
            }
            else if (not >= 45)
            {
                Console.WriteLine("2 aldın.");
            }
            else if (not >= 1)
            {
                Console.WriteLine("1 aldın.");
            }
            else if (not == 0)
            {
                Console.WriteLine("0 aldın, kaldın.");
            }
            else
            {
                Console.WriteLine("Notunu yanlış girdin, tekrar dene.");
            }

            // Mutlak değer hesaplama
            Console.WriteLine("Mutlak değerini bulacağımız sayıyı gir.");
            double sayi5 = Convert.ToDouble(Console.ReadLine());

            if (sayi >= 0)
            {
                Console.WriteLine("Sayının mutlak değeri = " + sayi);
            }
            else
            {
                Console.WriteLine("Sayının mutlak değeri = " + (sayi * -1));
            }

            // Switch Case nedir ? if else koşul yapılarının alternatifidir denilebilir.Yeri gelir if else kullanırız yeri gelir switch case kullanırız.
            // ister if ister switch case kullanın yapılan iş aynıdır.Yapıları farklıdır.
            // Peki yapısı nasıldır ?

            // Matematiksel işlem seçimi
            Console.WriteLine("İşlem yapmak istediğin birinci sayıyı gir.");
            double sayi6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İşlem yapmak istediğin ikinci sayıyı gir.");
            double sayi7 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bu sayılarla yapmak istediğin matematiksel işlemi seç (+, -, *, /).");
            char karakter = Convert.ToChar(Console.ReadLine());

            switch (karakter)
            {
                case '+':
                    Console.WriteLine("Sayıların toplamı = " + (sayi6 + sayi7));
                    break;
                case '-':
                    Console.WriteLine("Sayıların farkı = " + (sayi6 - sayi7));
                    break;
                case '*':
                    Console.WriteLine("Sayıların çarpımı = " + (sayi6 * sayi7));
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        Console.WriteLine("Sayıların bölümü = " + (sayi6 / sayi7));
                    }
                    else
                    {
                        Console.WriteLine("Bölen sayı sıfır olamaz.");
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdin.");
                    break;
            }


             //Mini ATM
             //1- Bakiye görüntüle
             //2- Para çek
             //3- Para Yatır
             //4- Çıkış yap 
             //1234 dışında bir değer girilmiş ise hata versin
            
             // Kullanıcı bilgileri
             int kullaniciSifre = 1234;
             double bakiye = 10000;
             
             Console.WriteLine("Mini ATM'ye hoşgeldiniz..");
             
             // Şifre girişi
             Console.Write("Şifre: ");
             int girilenKullaniciSifre = Convert.ToInt32(Console.ReadLine());
             
             Console.Clear();
             
             if (girilenKullaniciSifre == kullaniciSifre)
             {
                 Console.WriteLine("[1]-Bakiye Görüntüleme");
                 Console.WriteLine("[2]-Para Çekme");
                 Console.WriteLine("[3]-Para Yatırma");
                 Console.WriteLine("[4]-Çıkış Yapma");
                 Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                 int secim;
                 bool gecerliSecim = int.TryParse(Console.ReadLine(), out secim);
             
                 Console.Clear();
             
                 if (gecerliSecim)
                 {
                     switch (secim)
                     {
                         case 1:
                             Console.WriteLine("Bakiye = " + bakiye);
                             break;
                         case 2:
                             Console.WriteLine("Bakiye = " + bakiye);
                             Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                             double cekilmekIstenenTutar;
                             bool gecerliTutar = double.TryParse(Console.ReadLine(), out cekilmekIstenenTutar);
             
                             Console.Clear();
             
                             if (gecerliTutar)
                             {
                                 if (cekilmekIstenenTutar > bakiye)
                                 {
                                     Console.WriteLine("Hesabınızda bu kadar para yok.");
                                 }
                                 else if (cekilmekIstenenTutar > 0)
                                 {
                                     bakiye -= cekilmekIstenenTutar; // Bakiyeden çekilen tutarı düş
                                     Console.WriteLine("Çekilen tutar: " + cekilmekIstenenTutar);
                                     Console.WriteLine("Yeni Bakiye: " + bakiye);
                                 }
                                 else
                                 {
                                     Console.WriteLine("Hatalı işlem.");
                                 }
                             }
                             else
                             {
                                 Console.WriteLine("Geçersiz tutar girdiniz.");
                             }
                             break;
                         case 3:
                             Console.WriteLine("Bakiye = " + bakiye);
                             Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                             double yatirilmakIstenenTutar;
                             bool gecerliYatirTutar = double.TryParse(Console.ReadLine(), out yatirilmakIstenenTutar);
             
                             Console.Clear();
             
                             if (gecerliYatirTutar)
                             {
                                 if (yatirilmakIstenenTutar > 0 && yatirilmakIstenenTutar <= 10000000)
                                 {
                                     bakiye += yatirilmakIstenenTutar; // Bakiyeye yatırılan tutarı ekle
                                     Console.WriteLine("Yatırılan tutar: " + yatirilmakIstenenTutar);
                                     Console.WriteLine("Yeni Bakiye: " + bakiye);
                                 }
                                 else
                                 {
                                     Console.WriteLine("Hatalı işlem. Yatırılan tutar sınırı aşıyor.");
                                 }
                             }
                             else
                             {
                                 Console.WriteLine("Geçersiz tutar girdiniz.");
                             }
                             break;
                         case 4:
                             Console.WriteLine("Hoşçakalın.");
                             break;
                         default:
                             Console.WriteLine("Hatalı işlem. Lütfen 1-4 arası bir seçim yapınız.");
                             break;
                     }
                 }
                 else
                 {
                     Console.WriteLine("Hatalı işlem. Lütfen 1-4 arası bir sayı giriniz.");
                 }
             }
            else
            {
                Console.WriteLine("Şifrenizi hatalı girdiniz.");
            }


            //Klavyeden girilen sayının hangi güne ait olduğunu bulan program.

            Console.WriteLine("Girdiğin sayının haftanın hangi günü olduğunu söyleyeyim..");
            Console.Write("Bir sayı giriniz : ");
            int intSayi = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (intSayi > 0 && intSayi <= 7)
            {
                switch (intSayi)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Cuma");
                        break;
                    case 6:
                        Console.WriteLine("Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine("Pazar");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Alakasız bir sayı girdin.");
            }
        }

    }
}

  
