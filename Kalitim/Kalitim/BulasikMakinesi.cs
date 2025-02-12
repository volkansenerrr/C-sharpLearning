using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class BulasikMakinesi : BeyazEsya
    {
        public BulasikMakinesi() { }
        public BulasikMakinesi(string Isim, string Marka, double Fiyat, string EnerjiSinifi, int KisiSayisi)
            :base(Isim, Marka, Fiyat) 
        { 
            this.EnerjiSinifi = EnerjiSinifi;
            this.KisiSayisi = KisiSayisi; 
        }
        public string EnerjiSinifi {  get; set; }
        public int KisiSayisi { get; set; }
    }
}
