using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Matematik
    {
        public void Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("Toplam = " + toplam);
        }
        public void Topla(double s1, double s2)
        {
            double toplam = s1 + s2;
            Console.WriteLine("Toplam = " + toplam);
        }
        public void Topla(string s1, string s2)
        {
            double toplam = Convert.ToDouble(s1) + Convert.ToDouble(s2);
            Console.WriteLine("Toplam = " + toplam);
        }

        //public double DoubleTopla(double s1, double s2)
        //{
        //    double toplam = s1 + s2;
        //    return toplam;
        //}
    }
}
