using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ogrenci_Sinav_Calısma_Projesi
{
    public partial class Frm_ders_secimi : Form
    {
        public Frm_ders_secimi()
        {
            InitializeComponent();
        }

        private void Frm_ders_secimi_Load(object sender, EventArgs e)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1]);
                comboBox2.Items.Add(dr[1]);
                comboBox3.Items.Add(dr[1]);
                comboBox4.Items.Add(dr[1]);
            }
        dr.Close();
        }
        
        public string kullaniciad;
        private void button1_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Update Tbl_Kullanicilar Set Ders1=@p1,Ders2=@p2,Ders3=@p3,Ders4=@p4 Where KullaniciAd=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut.Parameters.AddWithValue("@p3", comboBox3.Text);
            komut.Parameters.AddWithValue("@p4", comboBox4.Text);
            komut.Parameters.AddWithValue("@p5", kullaniciad);
            komut.ExecuteNonQuery();

            Ana_Sayfa frm = new Ana_Sayfa();
            frm.kullaniciad= kullaniciad;
            frm.Show();
            this.Hide();
        }
    }
}
