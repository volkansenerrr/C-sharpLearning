using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerIntOgrenciNotOrtalamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birinciNot, ikinciNot, ucuncuNot, notOrtalamasi;

            birinciNot = int.Parse(textBox1.Text);

            ikinciNot = int.Parse(textBox2.Text);

            ucuncuNot = int.Parse(textBox3.Text);

            if (birinciNot >= 0 && birinciNot <= 100 && ikinciNot >= 0 && ikinciNot <= 100 && ucuncuNot >= 0 && ucuncuNot <=100)
            {
                notOrtalamasi = (birinciNot + ikinciNot + ucuncuNot) / 3;

                label5.Text = notOrtalamasi.ToString();
            }
            else
            {
                MessageBox.Show("Hatalı not girişi yaptınız.Tekrar deneyin.");
            }
        }
    }
}
