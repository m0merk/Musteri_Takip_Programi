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

namespace Stajprojesi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        void captcha()
        {
            //captcha
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };

            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);

            label4.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }

        private void FrmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where Kullaniciad=@q1 and Sifre=@q2", conn);
            komut.Parameters.AddWithValue("@q1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@q2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (label4.Text == textBox1.Text)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Güvenlik Sorusunu Tekrar Deneyiniz");
                    captcha();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            conn.Close();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            captcha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            captcha();
        }
    }
}

