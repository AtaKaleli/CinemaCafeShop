using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_4_Sinema_Büfe_Satış_Uygulaması_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, su, cay, bilet, fiyat;

            mısır = Convert.ToInt32(textBox1.Text);
            su = Convert.ToInt32(textBox2.Text);
            cay = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);

            fiyat = mısır * 4 + su * 1 + cay * 2 + bilet * 10;
            label9.Text = ("Borcunuz "+ fiyat.ToString() + " TL dir");

            toplam = toplam + fiyat;
            label11.Text = ("Toplam borcunuz " + toplam.ToString() + " TL dir");
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
