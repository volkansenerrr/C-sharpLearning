using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kareKenar, kareAlan, kareCevre;

            kareKenar = Convert.ToInt32(textBox1.Text);

            kareAlan = kareKenar * kareKenar;

            kareCevre = kareKenar * 4;

            label5.Text = kareCevre.ToString();
            label4.Text = kareAlan.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int dikdortgenKisaKenar, dikdortgenUzunKenar, dikdortgenAlan, dikdortgenCevre;

            dikdortgenKisaKenar = Convert.ToInt32(textBox2.Text);

            dikdortgenUzunKenar = Convert.ToInt32(textBox3.Text);

            if (dikdortgenUzunKenar > dikdortgenKisaKenar)
            {
                dikdortgenAlan = dikdortgenKisaKenar * dikdortgenUzunKenar;

                dikdortgenCevre = (dikdortgenKisaKenar * 2) + (dikdortgenUzunKenar * 2);

                label6.Text = dikdortgenCevre.ToString();
                label7.Text = dikdortgenAlan.ToString();
            }
            else 
            {
                MessageBox.Show("Hatalı işlem.Girdiğin kenar uzunluklarını kontrol et!");
            }  
        }
    }
}
