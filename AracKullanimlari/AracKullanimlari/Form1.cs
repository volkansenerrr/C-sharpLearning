using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Click tıklama -- Butona tıklandığında ne olsun ?
            //Mesaj kutusunda(MessageBox) bir şey göstersin.

            MessageBox.Show("Merhaba Dünya"); //Programlamada komutları nokta sembolüyle bağlıyoruz.Noktadan sonra kullabileceğin kodlar
            //benim karşıma geldi.Bana göster yani ingilizcedeki gösteri kelimesinden gelen Show.Message sınıfının Show metoduyla tıklama
            //eyleminden sonra karşıma gelecek mesajı yazabiliyorum.
            //Bir komutun solunda küp sembolü varsa o komutun sonunda parantez açıp kapatılır.Bu komutun bir metot olduğunu bildirir.
            //Programı çalıştırdığımda tıklama yapıldığında karşıma çıkan mesaj kutusunda Merhaba Dünya metnini görmüş oldum.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Volkan";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Murtaza";
            label6.Text = "Şuayipoğlu";
            label8.Text = "Güvenlik Görevlisi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Web Yazılım Uzmanlığı";
            label9.Text = textBox1.Text;
        }
    }
}
