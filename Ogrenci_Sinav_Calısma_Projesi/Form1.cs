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
    public partial class Frm_Giris : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        public Frm_Giris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_uye_ol uye_ol = new Frm_uye_ol();
            uye_ol.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar where KullaniciAd=@p1 and KullaniciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Ana_Sayfa frm = new Ana_Sayfa();
                frm.kullaniciad= textBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }

            bgl.baglanti().Close();
        }

    }
}
