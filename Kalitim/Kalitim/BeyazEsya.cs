using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public abstract class BeyazEsya
    {
        public BeyazEsya() { }
        public BeyazEsya(string Isim, string Marka, double Fiyat)
        {
            this.Isim = Isim;
            this.Marka = Marka;
            this.Fiyat = Fiyat;
        }
        public string Isim { get; set; }
        public string Marka { get; set; }
        public double Fiyat { get; set; }
    }
}
