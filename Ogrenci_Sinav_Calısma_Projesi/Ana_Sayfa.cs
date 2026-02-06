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

namespace Ogrenci_Sinav_Calısma_Projesi
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }
        
        public string kullaniciad;
        
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ders_secimi fr = new Frm_ders_secimi();
            fr.kullaniciad = kullaniciad;
            fr.Show();
            this.Hide();

        }
        
        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar where KullaniciAd=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciad);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr[3].ToString()+":";
                label3.Text = dr[4].ToString()+":";
                label4.Text = dr[5].ToString()+":";
                label5.Text = dr[6].ToString()+":";
            }
            dr.Close();
        }

        public string sinavturu;
        private void button1_Click(object sender, EventArgs e)
        {
            sinavturu = "TYT";
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label2.Text.TrimEnd(':'));
            komut.Parameters.AddWithValue("@p2", sinavturu);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Sorular fr= new Frm_Sorular();
                fr.sinavturu = sinavturu;
                fr.dersad = label2.Text.TrimEnd(':');
                fr.kullanici = kullaniciad;
                fr.Show();
                this.Hide();
            }
            dr.Close();
            
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sinavturu = "TYT";
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text.TrimEnd(':'));
            komut.Parameters.AddWithValue("@p2", sinavturu);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Sorular fr = new Frm_Sorular();
                fr.sinavturu = sinavturu;
                fr.dersad = label3.Text.TrimEnd(':');
                fr.Show();
                this.Hide();
            }
            dr.Close();

            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                sinavturu = "TYT";
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label4.Text.TrimEnd(':'));
                komut.Parameters.AddWithValue("@p2", sinavturu);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Frm_Sorular fr = new Frm_Sorular();
                    fr.sinavturu = sinavturu;
                    fr.dersad = label4.Text.TrimEnd(':');
                    fr.Show();
                    this.Hide();
                }
                dr.Close();

                button6.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                sinavturu = "TYT";
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label5.Text.TrimEnd(':'));
                komut.Parameters.AddWithValue("@p2", sinavturu);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Frm_Sorular fr = new Frm_Sorular();
                    fr.sinavturu = sinavturu;
                    fr.dersad = label5.Text.TrimEnd(':');
                    fr.Show();
                    this.Hide();
                }
                dr.Close();

                button8.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                sinavturu = "AYT";
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label2.Text.TrimEnd(':'));
                komut.Parameters.AddWithValue("@p2", sinavturu);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Frm_Sorular fr = new Frm_Sorular();
                    fr.sinavturu = sinavturu;
                    fr.dersad = label2.Text.TrimEnd(':');
                    fr.Show();
                    this.Hide();
                }
                dr.Close();

                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                sinavturu = "AYT";
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label3.Text.TrimEnd(':'));
                komut.Parameters.AddWithValue("@p2", sinavturu);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Frm_Sorular fr = new Frm_Sorular();
                    fr.sinavturu = sinavturu;
                    fr.dersad = label3.Text.TrimEnd(':');
                    fr.Show();
                    this.Hide();
                }
                dr.Close();

                button3.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                sinavturu = "AYT";
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label3.Text.TrimEnd(':'));
                komut.Parameters.AddWithValue("@p2", sinavturu);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Frm_Sorular fr = new Frm_Sorular();
                    fr.sinavturu = sinavturu;
                    fr.dersad = label3.Text.TrimEnd(':');
                    fr.Show();
                    this.Hide();
                }
                dr.Close();

                button5.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                sinavturu = "AYT";
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Ders=@p1 and SinavTuru=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label5.Text.TrimEnd(':'));
                komut.Parameters.AddWithValue("@p2", sinavturu);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Frm_Sorular fr = new Frm_Sorular();
                    fr.sinavturu = sinavturu;
                    fr.dersad = label5.Text.TrimEnd(':');
                    fr.Show();
                    this.Hide();
                }
                dr.Close();

                button7.Enabled = false;
            }
        }
    }
}
