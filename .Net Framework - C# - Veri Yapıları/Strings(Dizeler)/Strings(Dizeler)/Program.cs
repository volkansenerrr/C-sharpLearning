using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Dizeler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string name = "Volkan";
            // string surname = "Şener";
            // int age = 30;

            // ** string str = "My name is " + name + " " + surname + " and I'm " + age +  " years old."; // En temel yöntemlerden biri, stringleri + operatörü ile birleştirmektir. Bu yöntem, birden fazla string değerini tek bir string içinde toplamak için kullanılır.
            // Bu yöntem basit ve anlaşılırdır, ancak çok sayıda string birleştirme işlemi gerektiğinde performans sorunlarına yol açabilir.

            // ** string str = string.Format("My name is {0} {1} and I'm {2} years old.", name, surname, age); // string.Format metodu, bir format şablonu kullanarak string birleştirme işlemi yapar. Şablonda {0}, {1}, {2} gibi yer tutucular (placeholders) kullanılır ve bu yer tutucular sırayla verilen argümanlarla değiştirilir.
            // Bu yöntem, daha okunabilir ve bakımı kolay kod yazmanı sağlar, çünkü string içindeki değişkenlerin yerini açıkça belirleyebilirsin.

            // string str = $"My name is {name} {surname} and I'm {age} years old."; // String Interpolation (String İç İçe Geçirme) C# 6.0 ile tanıtılan bu özellik, string birleştirmeyi daha da kolaylaştırır. $ karakteri ile başlayan stringlerde, süslü parantez {} içine değişken adları yazarak string içinde yerleştirilen verileri doğrudan kullanabilirsin.
            // Bu yöntem, hem performans açısından verimlidir hem de kodu daha temiz ve okunabilir hale getirir.

            // Console.Write("İsim giriniz : ");
            // string name = Console.ReadLine();

            // Console.Write("Soyisminizi giriniz : ");
            // string surname = Console.ReadLine();

            // Console.Write("Yaşınızı giriniz : ");
            // int age = Convert.ToInt32(Console.ReadLine());

            // string kisiBilgileri = string.Format("My name is {0} {1} and I'm {2} years old.", name, surname, age);
            // string kisiBilgileri = $"My name is {name} {surname} and I'm {age} years old.";

            // Console.WriteLine("Kişi Hakkında : " + kisiBilgileri);

            // Console.WriteLine(string.Format("My name is {0} {1} and I'm {2} years old.", name, surname, age));

            
        }
    }
}
