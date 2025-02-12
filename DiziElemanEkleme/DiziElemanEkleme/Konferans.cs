using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanEkleme
{
    internal class Konferans
    {
        public string[] katilimcilar;

        public Konferans() 
        {
            //Dizi RAM üzerinde Constructor ile otomatik olarak oluşturuldu.
            katilimcilar = new string[0];
        }

        public void katilimciEkle(string isim) 
        {
            string[] gecici = new string[katilimcilar.Length + 1];
            //Array.Copy(katilimcilar, gecici, katilimcilar.length);

            for (int i = 0; i < katilimcilar.Length; i++)
            {
                gecici[i] = katilimcilar[i]; 
            }
            gecici[gecici.Length - 1] = isim;
            katilimcilar = gecici;
        }

        public void Yazdir() 
        {
            for (int i = 0; i < katilimcilar.Length; i++)
            {
                Console.WriteLine(katilimcilar[i]);
            }
        }
    }
}
