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
    public partial class Frm_Sorular : Form
    {
        public Frm_Sorular()
        {
            InitializeComponent();
        }

        public string kullanici;
        public string dersad;
        public string sinavturu;

        int soruIndex = 0;
        int dogru = 0;
        int yanlis = 0;
        int sure = 0;

       
        void SoruyuGetir()
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlConnection conn = bgl.baglanti();

            SqlCommand komut = new SqlCommand(@"
                SELECT *
                FROM Tbl_Sorular
                WHERE Ders=@p1 AND SinavTuru=@p2
                ORDER BY SoruId
                OFFSET @p3 ROWS FETCH NEXT 1 ROWS ONLY
            ", conn);

            komut.Parameters.AddWithValue("@p1", dersad);
            komut.Parameters.AddWithValue("@p2", sinavturu);
            komut.Parameters.AddWithValue("@p3", soruIndex);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                richTextBox1.Text = dr["Soru"].ToString();
                button1.Text = dr["Asikki"].ToString();
                button2.Text = dr["Bsikki"].ToString();
                button3.Text = dr["Csikki"].ToString();
                button4.Text = dr["Dsikki"].ToString();
                label2.Text = dr["DogruSik"].ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Sınav Bitti!\n\nDoğru: {dogru}\nYanlış: {yanlis}");
                conn.Close();
                return;
            }

            dr.Close();
            conn.Close();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button5.Enabled = false;
            button5.Visible = false;

            SoruyuGetir();
        }

        
        void CevapKontrol(string secilen)
        {
            if (secilen == label2.Text)
            {
                dogru++;
                Dogru_sayaci.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                Yanlis_sayaci.Text = yanlis.ToString();
            }

            soruIndex++;
            SoruyuGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CevapKontrol(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CevapKontrol(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CevapKontrol(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CevapKontrol(button4.Text);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            int dakika = sure / 60;
            int saniye = sure % 60;
            label1.Text = dakika.ToString("00") + ":" + saniye.ToString("00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ana_Sayfa fr = new Ana_Sayfa();
            fr.kullaniciad = kullanici;
            fr.Show();
            this.Hide();
        }
    }
}