using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Soru
    {
        public string metin;
        public string secenekA;
        public string secenekB;
        public string secenekC;
        public string secenekD;
        public string dogru;

        public Soru(string metin, string secenekA, string secenekB, string secenekC, string secenekD, string dogru)
        {
            //this anahtar sözcüğü "bu sınıfa ait olan" anlamında kullanılır
            this.metin = metin;
            this.secenekA = secenekA;
            this.secenekB = secenekB;
            this.secenekC = secenekC;
            this.secenekD = secenekD;
            this.dogru = dogru;
        }
    }
}
