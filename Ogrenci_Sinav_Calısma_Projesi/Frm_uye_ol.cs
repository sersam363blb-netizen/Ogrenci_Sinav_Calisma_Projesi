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
    public partial class Frm_uye_ol : Form
    {
        public Frm_uye_ol()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar where KullaniciAd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                    MessageBox.Show("Bu Kullanıcı Adı Zaten Alınmış");
                    dr.Close();
                    bgl.baglanti().Close();
                    return;
            }
            dr.Close();
            
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Kullanicilar (KullaniciAd,KullaniciSifre) values (@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBox1.Text);
            komut2.Parameters.AddWithValue("@p2", textBox2.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Üyelik İşleminiz Gerçekleşmiştir.");
            this.Close();
        }
    }
}
