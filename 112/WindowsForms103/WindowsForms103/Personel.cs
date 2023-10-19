using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsForms103
{
    internal class Personel
    {
        int _id;
        string _adsoyad;
        int _yas;
        string _telefon;
        string _cinsiyet;
        public int Id { get { return _id; } set { _id = value; } }
        public string AdSoyad { get { return _adsoyad; } set { _adsoyad = value; } }
        public int Yas { get { return _yas; } set { _yas = value; } }
        public string Telefon { get { return _telefon; } set { _telefon = value; } }
        public string Cinsiyet { get { return _cinsiyet; } set { _cinsiyet = value; } }
        
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=personeldb;Uid=root;");
        private static MySqlCommand cmd;
        MySqlDataAdapter da;
        private string sorgu = "insert into personeltbl (id,adsoyad,yas,telefon,cinsiyet) " +
            "values (@id,@adsoyad,@yas,@telefon,@cinsiyet)";

        public bool InsertPersonel(Personel personel)
        {
            int rows;
            using (con)
            {
                con.Open();
                using (cmd = new MySqlCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@id", personel.Id);
                    cmd.Parameters.AddWithValue("@adsoyad", personel.AdSoyad);
                    cmd.Parameters.AddWithValue("@yas", personel.Yas);
                    cmd.Parameters.AddWithValue("@telefon", personel.Telefon);
                    cmd.Parameters.AddWithValue("@cinsiyet", personel.Cinsiyet);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (con)
            {
                con.Open();
                using (cmd = new MySqlCommand("select * from personeltbl", con))
                {
                    using (da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
