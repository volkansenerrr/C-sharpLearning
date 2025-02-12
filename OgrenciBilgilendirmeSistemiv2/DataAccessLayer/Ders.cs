using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Ders
    {
        public int DersID { get; set; }
        public string ad { get; set; }
        public Int16 saat { get; set; }
        public Int16 kredi { get; set; }
        public int OgretmenID { get; set; }   
    }
}
