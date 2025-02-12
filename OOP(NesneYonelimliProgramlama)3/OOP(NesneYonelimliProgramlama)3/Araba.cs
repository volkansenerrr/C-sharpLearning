using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneYonelimliProgramlama_3
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaMarka;
        public string arabaRengi;
        

        public void motorCalistir() 
        {
            Console.WriteLine("Motor çalışıyor..."); 
        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor..."); 
        }
    }
}
