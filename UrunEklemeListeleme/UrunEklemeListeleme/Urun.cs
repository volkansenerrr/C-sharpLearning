using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunEklemeListeleme
{
    internal class Urun
    {
        public string Isim { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public short StokMiktari { get; set; }
    }
}
