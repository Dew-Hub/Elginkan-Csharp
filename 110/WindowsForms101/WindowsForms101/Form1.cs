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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double girilenTutar = Convert.ToDouble(textTutar.Text);
            double indirimliTutar = 0;

            if(radioButton5.Checked)   
                indirimliTutar = girilenTutar -  girilenTutar * 0.05;
            if (radioButton10.Checked)
                indirimliTutar = girilenTutar - girilenTutar * 0.10;
            if (radioButton15.Checked)
                indirimliTutar = girilenTutar - girilenTutar * 0.15;
            if (radioButton25.Checked)
                indirimliTutar = girilenTutar - girilenTutar * 0.25;

            label5.Text = (girilenTutar - indirimliTutar).ToString();
            label6.Text = (indirimliTutar).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
