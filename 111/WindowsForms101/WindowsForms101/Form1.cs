using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsForms101
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=okul2db");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader dr;
        string cinsiyet;
        public Form1()
        {
            InitializeComponent();
        }
        void Verigetir()
        {

            con.Open();
            string sorgu = "select * from ogrencitbl";
            cmd = new MySqlCommand(sorgu, con);
            da = new MySqlDataAdapter(sorgu, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Verigetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into ogrencitbl (ogrno,ograd,ogrsoyad,ogrcinsiyet,sinif,dtarih,puan) values ('" + txtNo.Text+"','" + txtAd.Text + "','" + txtSoyad.Text + "','" + cinsiyet + "', @sinif,@dtarih,@puan)";
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@sinif", comboBoxSinif.Text);
            cmd.Parameters.AddWithValue("@dtarih", ogrdtp.Value);
            cmd.Parameters.AddWithValue("@puan", Convert.ToInt32(txtPuan.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            con.Close();
            Verigetir();


        }

        private void radioButtonErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "E";
        }

        private void radioButtonKiz_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "K";
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string cinsiyet = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (cinsiyet == "E")
                {
                    radioButtonErkek.Checked = true;
                    radioButtonKiz.Checked = false;
                }
                else
                {
                    radioButtonKiz.Checked = true;
                    radioButtonErkek.Checked = false;
                }
                ogrdtp.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                comboBoxSinif.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtPuan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            string sorgu = "update ogrencitbl set ograd = @ograd, ogrsoyad = @ogrsoyad, ogrcinsiyet = @ogrcinsiyet, sinif = @sinif, dtarih = @dtarih, puan = @puan where ogrno = @ogrno";
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ograd", txtAd.Text);
            cmd.Parameters.AddWithValue("@ogrsoyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@ogrcinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@ogrno", txtNo.Text);
            cmd.Parameters.AddWithValue("@sinif", comboBoxSinif.Text);
            cmd.Parameters.AddWithValue("@dtarih", ogrdtp.Value);
            cmd.Parameters.AddWithValue("@puan", Convert.ToInt32(txtPuan.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            con.Close();
            Verigetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from ogrencitbl where ogrno = @ogrno";
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ogrno", Convert.ToInt32(txtNo.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            con.Close();
            Verigetir();
        }
    }
}
