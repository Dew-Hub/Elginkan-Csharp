using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WinForms102
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=okul3db");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void GridFill()
        {
            con.Open();
            string sorgu = "select * from ogrencikayittbl";
            cmd = new MySqlCommand(sorgu, con);
            dt = new DataTable();
            da = new MySqlDataAdapter();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            string sorgu = "insert into ogrencikayittbl (ogr_no,ogr_ad,ogr_soyad,ogr_sehir)" +
                " values(@ogrno,@ograd,@ogrsoyad,@ogrsehir)";
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ogrno", Convert.ToInt32(txtNo.Text));
            cmd.Parameters.AddWithValue("@ograd", Convert.ToInt32(txtAd.Text));
            cmd.Parameters.AddWithValue("@ogrsoyad", Convert.ToInt32(txtSoyad.Text));
            cmd.Parameters.AddWithValue("@ogrsehir", Convert.ToInt32(txtSehir.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            GridFill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridFill();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            string sorgu = "update ogrencikayittbl set ogr_no = @ogrno, ogr_ad = @ograd, ogr_soyad = @ogrsoyad, ogr_sehir = @ogrsehir";
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ogrno", Convert.ToInt32(txtNo.Text));
            cmd.Parameters.AddWithValue("@ograd", Convert.ToInt32(txtAd.Text));
            cmd.Parameters.AddWithValue("@ogrsoyad", Convert.ToInt32(txtSoyad.Text));
            cmd.Parameters.AddWithValue("@ogrsehir", Convert.ToInt32(txtSehir.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            GridFill();
        }
    }
}