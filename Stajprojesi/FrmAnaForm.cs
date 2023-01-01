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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Stajprojesi
{
    public partial class FrmAnaForm : Form
    {
       
        public FrmAnaForm()
        {
            InitializeComponent();

        }
        Baglanti bgl = new Baglanti();
        DataTable dt = new DataTable();
        public void PerFormStep()
        {
            //progressBar1.PerformStep();
        }
        private void FrmAnaForm_FormClosing(object sender, FormClosingEventArgs e)
         {
            Application.Exit();
         }

        private void btnListele_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            this.tbl_CihazTableAdapter1.Fill(this.musteriTakipVTDataSet5.Tbl_Cihaz);
        }
        //private void button2_Click(object sender, EventArgs e) //vazgeçildi
        //{
        //    axWindowsMediaPlayer1.Ctlcontrols.play();
        //}
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 4;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmEkle ekle = new FrmEkle();
            ekle.Show();

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //if (duzenle == null || duzenle.IsDisposed)
            //{
            //    duzenle= new FrmDuzenle();
            //    duzenle.Show();
            //}
            //else
            //{
            //    MessageBox.Show("zaten açık");
            //}
            MessageBox.Show("Güncellemek istediğiniz müşterinin verisine çift tıklayınız");
        }
        private void btnIstatistikveGrafik_Click(object sender, EventArgs e)
        {
            İstatistikveGrafik istgraf = new İstatistikveGrafik();
            istgraf.Show();
        }

    

        private void btnSil_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komutsil = new SqlCommand(" delete from Tbl_Cihaz where Id ='" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'", conn);
                komutsil.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("silindi");
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;

        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("201501040\nMuhammet Ömer Karabacak\nKocaeliS", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmDuzenle duzenle = new FrmDuzenle();
            duzenle.Show();

            duzenle.txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            duzenle.txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            duzenle.txtSyd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            duzenle.mskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            duzenle.txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            duzenle.txtTuru.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            duzenle.txtMarkasi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            duzenle.txtYasi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            duzenle.txtSorunu.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            duzenle.mskTarih.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            duzenle.txtTutar.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

       private void txtIdAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            if (txtIdAra.Text.Trim() == "")
            {
                
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();

            }
            else
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz where Id Like '%" + txtIdAra.Text + "%'", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            if (txtAdAra.Text.Trim() == "")
            {
                
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz where Ad Like '%" + txtAdAra.Text + "%'", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }
        private void txtSoyadAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            if (txtSoyadAra.Text.Trim() == "")
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz where Soyad Like '%" + txtSoyadAra.Text + "%'", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void txtMarkaAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            if (txtMarkaAra.Text.Trim() == "")
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz where Markasi Like '%" + txtMarkaAra.Text + "%'", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void txtTelAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            if (txtTelAra.Text.Trim() == "")
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From Tbl_Cihaz where Telefon Like '%" + txtTelAra.Text + "%'", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();

        }
    }
}
