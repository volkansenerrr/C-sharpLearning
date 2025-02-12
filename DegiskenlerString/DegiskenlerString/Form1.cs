using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad, meslek, babaAdi, sehir;

            adSoyad = "Volkan Şener";
            label1.Text = adSoyad;

            meslek = "Web Developer";
            label2.Text = meslek;

            babaAdi = textBox1.Text;
            label3.Text = babaAdi;

            sehir = textBox2.Text;
            label8.Text = sehir;
        }

     
    }
}
