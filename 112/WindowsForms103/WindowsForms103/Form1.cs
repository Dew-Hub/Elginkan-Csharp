using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms103
{
    public partial class Form1 : Form
    {
        Personel personel = new Personel();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel.Id = Convert.ToInt32(txtID.Text);
            personel.AdSoyad = txtAdSoyad.Text;
            personel.Yas = Convert.ToInt32(txtYas.Text);
            personel.Telefon = txtTelefon.Text;
            personel.Cinsiyet = comboBoxCinsiyet.Text;
            var kontrol = personel.InsertPersonel(personel);
            if (kontrol)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }

        }
    }
}
