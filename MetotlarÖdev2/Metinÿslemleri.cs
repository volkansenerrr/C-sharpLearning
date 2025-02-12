using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarÖdev2
{
    public class Metinİslemleri
    {
        #region Metnin boşluksuz halini yazdırma
        public string BoslukKırp(string metin)
        {
            int baslangicIndex = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    baslangicIndex = i;
                    break;
                }
            }
            string yeniMetin = "";

            for (int i = baslangicIndex;i < metin.Length; i++)
            {
                yeniMetin += metin[i];
            }
            return yeniMetin;
        }
        #endregion

        #region Metnin sonundaki boşluğu kırpma
        public string SondakiBoslukKırp(string metin)
        {
            int bitisIndex = 0;

            for (int i = metin.Length -1 ; i >= 0; i--)
            {
                if (metin[i] != ' ')
                {
                    bitisIndex = i;
                    break;
                }
            }
            string yeniMetin = "";

            for (int i = 0; i <= bitisIndex; i++)
            {
                yeniMetin += metin[i];
            }
            return yeniMetin;
        }
        #endregion

        #region Metnin hem sonundaki boşluğu hemde başındaki boşluğu kırpma
        public string Kirp(string metin)
        {
            return BoslukKırp(SondakiBoslukKırp(metin));
        }
        #endregion

        #region Metin içerisinde metin var mı?
        public bool varmi(string metin,string aranacak)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                bool varmi = true;
                for (int j = 0; j < aranacak.Length; j++)
                {
                    if (metin[i+j] != aranacak[j])
                    {
                        varmi = false;
                        break;
                    }
                }
                if (varmi == true)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Metin İçerisinde karakter var mı?
        public bool karakterAra(string metin, char karakter)
        {
            bool varmi = false;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == karakter)
                {
                    varmi = true;
                }
            }
            return varmi;
        }
        #endregion

        #region Metin Büyültme
        public string KarakterBuyut(string metin)
        {
            string buyukMetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                int sayisal = (int)metin[i];
                if (sayisal >= 97 && sayisal <= 122)
                {
                    sayisal -= 32;
                    buyukMetin += (char)sayisal;
                }
                else
                {
                    buyukMetin += metin[i];
                }
            }
            return buyukMetin;
        }


        #endregion

        #region Metin Küçültme
        public string KarakterKucult(string metin)
        {
            string kucukMetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                int sayisal = (int)metin[i];
                if (sayisal >= 65 && sayisal <= 90)
                {
                    sayisal += 32;
                    kucukMetin += (char)sayisal;
                }
                else
                {
                    kucukMetin += metin[i];
                }
            }
            return kucukMetin;
        }

        #endregion

        #region Karakter Değiştirme
        public string KarakterDegistir(string metin)
        {
            char[] metinArray = metin.ToCharArray();
            for (int i = 0; i < metinArray.Length; i++)
            {
                switch (metinArray[i])
                {
                    case 'ç':
                        metinArray[i] = 'c';
                        break;
                    case 'ğ':
                        metinArray[i] = 'g';
                        break;
                    case 'ı':
                        metinArray[i] = 'i';
                        break;
                    case 'ö':
                        metinArray[i] = 'o';
                        break;
                    case 'ş':
                        metinArray[i] = 's';
                        break;
                    case 'ü':
                        metinArray[i] = 'u';
                        break;
                }
            }
            return new string(metinArray);
        }
    }

        #endregion


    
}
