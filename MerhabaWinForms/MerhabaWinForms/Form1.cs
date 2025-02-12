using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label lbl_murtaza = new Label();
            lbl_murtaza.Text = "Ben Murtaza Nasılsınız?";
            lbl_murtaza.AutoSize = true;
            lbl_murtaza.Location = new Point(40, 100);
            this.Controls.Add(lbl_murtaza);
        }

        
    }
}
