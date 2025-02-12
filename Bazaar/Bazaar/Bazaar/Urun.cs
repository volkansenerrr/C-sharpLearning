using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazaar
{
    internal class Urun
    {
        public string urunAdi;
        public string kategori;
        public string birim;
        public double fiyat;
        public int stok;

        public Urun(string urunAdi, string birim , string kategori, double fiyat, int stok)
        {
            this.urunAdi = urunAdi;
            this.kategori = kategori;
            this.fiyat = fiyat;
            this.stok = stok;
            this.birim = birim;
        }
    }
}
