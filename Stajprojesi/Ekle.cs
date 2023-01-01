using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stajprojesi
{
    public partial class FrmEkle : Form
    {
        public FrmEkle()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();


        void temizle()
         {
            txtId.Clear();
            txtAd.Clear();
            txtSyd.Clear();
            txtMail.Clear();
            mskTel.Clear();
            txtYasi.Clear();
            txtMarkasi.Text = "";
            mskTarih.Text = "";
            txtSorunu.Clear();
            txtTutar.Text = "";
            txtTuru.Clear();
            txtAd.Focus();

            //********************************

            //Böyle de yapabiliriz

            //txtId.Text = "";
            //txtAd.Text = "";
            //txtSyd.Text = "";
            //txtMeslek.Text ="";
            //mskTel.Text = "";
            //cmbSehir.Text ="";
            //txtAd.Focus();
         }

        FrmAnaForm af = ActiveForm as FrmAnaForm;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Cihaz(Ad,Soyad,Telefon,Mail,CihazTipi,Markasi,Yasi,Sorunu,TeslimTarih,Tutar) values (@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)", conn);

            komutekle.Parameters.AddWithValue("@d2", txtAd.Text);
            komutekle.Parameters.AddWithValue("@d3", txtSyd.Text);
            komutekle.Parameters.AddWithValue("@d4", mskTel.Text);
            komutekle.Parameters.AddWithValue("@d5", txtMail.Text);
            komutekle.Parameters.AddWithValue("@d6", txtTuru.Text);
            komutekle.Parameters.AddWithValue("@d7", txtMarkasi.Text);
            komutekle.Parameters.AddWithValue("@d8", txtYasi.Text);
            komutekle.Parameters.AddWithValue("@d9", txtSorunu.Text);
            komutekle.Parameters.AddWithValue("@d10", DateTime.Parse(mskTarih.Text));
            komutekle.Parameters.AddWithValue("@d11", txtTutar.Text);
            komutekle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Ve Cihazı Eklenmiştir");

              this.tbl_CihazTableAdapter1.Fill(this.musteriTakipVTDataSet5.Tbl_Cihaz);

           
               af = new FrmAnaForm();
               af.PerFormStep();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void FrmEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
