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
    public partial class FrmDuzenle : Form
    {
        public FrmDuzenle()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Cihaz Set Ad=@ad, Soyad=@soyad, Telefon=@telefon, Mail=@mail, CihazTipi=@tipi, Markasi=@markasi, Yasi=@yasi, Sorunu=@sorunu, TeslimTarih=@teslimtarih, tutar=@tutar where Id=@id",conn);
            komutguncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@soyad", txtSyd.Text);
            komutguncelle.Parameters.AddWithValue("@telefon", mskTel.Text);
            komutguncelle.Parameters.AddWithValue("@mail", txtMail.Text);
            komutguncelle.Parameters.AddWithValue("@tipi", txtTuru.Text);
            komutguncelle.Parameters.AddWithValue("@markasi", txtMarkasi.Text);
            komutguncelle.Parameters.AddWithValue("@yasi", txtYasi.Text);
            komutguncelle.Parameters.AddWithValue("@sorunu", txtSorunu.Text);
            komutguncelle.Parameters.AddWithValue("@teslimtarih", DateTime.Parse(mskTarih.Text));
            komutguncelle.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komutguncelle.Parameters.AddWithValue("@id", txtId.Text);
            komutguncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void FrmDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
