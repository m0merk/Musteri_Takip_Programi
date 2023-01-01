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
    public partial class İstatistikveGrafik : Form
    {
        public İstatistikveGrafik()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();


        private void İstatistikveGrafik_Load(object sender, EventArgs e)
        {
            //grafik1
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutg1 = new SqlCommand("Select Markasi,Count(*) From Tbl_Cihaz group by Markasi", conn);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Cihaz Markası"].Points.AddXY(dr1[0], dr1[1]);
            }
            conn.Close();

            //grafik2
            conn.Open();
            SqlCommand komutg2 = new SqlCommand("Select Yasi,Count(*) From Tbl_Cihaz group by Yasi", conn);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Cihaz Yaşı"].Points.AddXY(dr2[0], dr2[1]);
            }
            conn.Close();

            //grafik3
            conn.Open();
            SqlCommand komutg3 = new SqlCommand("Select TeslimTarih,Count(*) From Tbl_Cihaz group by TeslimTarih ",conn);
            SqlDataReader dr3 = komutg3.ExecuteReader();
            while (dr3.Read())
            {
                chart3.Series["İş Yoğunluğu"].Points.AddXY(dr3[0],dr3[1]);
            }
            conn.Close();

            //istatistik1
            conn.Open();
            SqlCommand issayisi = new SqlCommand("Select Count(*)From Tbl_Cihaz", conn);
            SqlDataReader dr4 = issayisi.ExecuteReader();
            while (dr4.Read())
            {
                lblToplamis.Text = dr4[0].ToString();
            }
            conn.Close();

            //istatistik2
            conn.Open();
            SqlCommand toplamg = new SqlCommand("Select sum(Tutar) From Tbl_Cihaz ", conn);
            SqlDataReader dr5 = toplamg.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamGelir.Text = dr5[0].ToString();
            }
            conn.Close();

            //istatistik3
            conn.Open();
            SqlCommand marka = new SqlCommand("Select Count(distinct(Markasi)) From Tbl_Cihaz ", conn);
            SqlDataReader dr6 = marka.ExecuteReader();
            while (dr6.Read())
            {
                lblMarkaSayisi.Text = dr6[0].ToString();
            }
            conn.Close();

        }

       
    }
}
