using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class MetinIslem
    {
        public bool iceriyormu (string metin, char karakter) 
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
        #region boşluk temizle
        public string boslukTemizle(string metin) 
        {
            int index = -1;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    index = i;
                    break;
                }
            }

            string bosluksuz = "";

            for (int i = index; i < metin.Length; i++)
            {
                if (metin[i] == ' ')
                {
                    break;
                }
                else
                {
                    bosluksuz += metin[i];
                }
            }
            return bosluksuz;
        }
        #endregion

        #region karakter değiştir
        public string karakterDegistir (string metin)
        {
            char[] turkceHarfler = { 'ç', 'ğ', 'ş', 'ı', 'ü', 'ö' };
            char[] ingilizceHarfler = { 'c', 'g', 's', 'i', 'u', 'o' };
            char[] cMetin = new char[metin.Length];

            for (int i = 0; i < metin.Length; i++)
            {
                cMetin[i] = metin[i]; 
            }

            for (int i = 0; i < metin.Length; i++)
            {
                for (int j = 0; j < turkceHarfler.Length; j++)
                {
                    if (cMetin[i] == turkceHarfler[j])
                    {
                        cMetin[i] = ingilizceHarfler[j];
                    }
                }
            }

            string ingMetin = "";

            for (int i = 0; i < cMetin.Length; i++)
            {
                ingMetin += cMetin[i];
            }
            return ingMetin;
        }


        #endregion
       
        #region karakteri küçült
        public char krktr(char karakter)
        {
            int kucuksayisal = karakter + 32;

            char kucuk = (char)kucuksayisal;

            return kucuk;
        }
        public char kucuk(char karakter)
        {
            int buyuksayisal = karakter - 32;
            char buyuk = (char)buyuksayisal;
            return buyuk;
        }
        #endregion
    }
}
