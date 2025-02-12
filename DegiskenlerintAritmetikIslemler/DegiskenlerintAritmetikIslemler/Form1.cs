using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerintAritmetikIslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 + sayi2;

            textBox3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 - sayi2;

            textBox3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 * sayi2;

            textBox3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 / sayi2;

            textBox3.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = label4.Text;
        }

        
    }
}
