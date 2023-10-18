using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms101
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxAd.Text);
            listBox2.Items.Add(textBoxSoyad.Text);
            listBox3.Items.Add(textBoxVize.Text);
            listBox4.Items.Add(textBoxFinal.Text);
            double ortalama = Convert.ToDouble(textBoxVize.Text) * 0.4 + Convert.ToDouble(textBoxFinal.Text) * 0.6;
            listBox5.Items.Add(ortalama);
            if(ortalama >= 50)
                listBox6.Items.Add("Başarılı");
            else
                listBox6.Items.Add("Başarısız");

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxVize.Text = "";
            textBoxFinal.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
    }
}
