using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class CamasirMakinesi : BeyazEsya
    {
        public CamasirMakinesi() { } //default Constructor

        public CamasirMakinesi(string isim, string marka, double fiyat, int programSayisi, bool kurutma)
        {
            base.Isim = isim;
            base.Marka = marka;
            base.Fiyat = fiyat;
            this.ProgramSayisi = programSayisi;
            this.Kurutma = kurutma;
        }
        // c# çoklu kalıtım kabul etmez 
        public int ProgramSayisi { get; set; }
        public bool Kurutma { get; set; }
    }
}
