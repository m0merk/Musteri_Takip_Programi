
namespace Stajprojesi
{
    partial class FrmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEkle));
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSorunu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTuru = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSyd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.musteriTakipVTDataSet5 = new Stajprojesi.MusteriTakipVTDataSet5();
            this.tblCihazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CihazTableAdapter1 = new Stajprojesi.MusteriTakipVTDataSet5TableAdapters.Tbl_CihazTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipVTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCihazBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(168, 535);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(157, 34);
            this.mskTarih.TabIndex = 10;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(168, 251);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(157, 34);
            this.txtMail.TabIndex = 4;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(168, 580);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(157, 34);
            this.txtTutar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Geliş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sorunu :";
            // 
            // txtSorunu
            // 
            this.txtSorunu.Location = new System.Drawing.Point(168, 486);
            this.txtSorunu.Name = "txtSorunu";
            this.txtSorunu.Size = new System.Drawing.Size(157, 34);
            this.txtSorunu.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 50;
            this.label3.Text = "Yaşı :";
            // 
            // txtYasi
            // 
            this.txtYasi.Location = new System.Drawing.Point(168, 439);
            this.txtYasi.Name = "txtYasi";
            this.txtYasi.Size = new System.Drawing.Size(157, 34);
            this.txtYasi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tutar :";
            // 
            // txtMarkasi
            // 
            this.txtMarkasi.Location = new System.Drawing.Point(168, 392);
            this.txtMarkasi.Name = "txtMarkasi";
            this.txtMarkasi.Size = new System.Drawing.Size(157, 34);
            this.txtMarkasi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Markası :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(173, 629);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 54);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEkle.Location = new System.Drawing.Point(271, 629);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(54, 54);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(168, 298);
            this.mskTel.Mask = "9990000000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(157, 34);
            this.mskTel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefon no:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cihaz Türü :";
            // 
            // txtTuru
            // 
            this.txtTuru.Location = new System.Drawing.Point(168, 345);
            this.txtTuru.Name = "txtTuru";
            this.txtTuru.Size = new System.Drawing.Size(157, 34);
            this.txtTuru.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 29);
            this.label13.TabIndex = 6;
            this.label13.Text = "Mail :";
            // 
            // txtSyd
            // 
            this.txtSyd.Location = new System.Drawing.Point(168, 201);
            this.txtSyd.Name = "txtSyd";
            this.txtSyd.Size = new System.Drawing.Size(157, 34);
            this.txtSyd.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(69, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 29);
            this.label14.TabIndex = 4;
            this.label14.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(168, 154);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 34);
            this.txtAd.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 29);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ad :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(168, 107);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 34);
            this.txtId.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Müşteri ID :";
            // 
            // musteriTakipVTDataSet5
            // 
            this.musteriTakipVTDataSet5.DataSetName = "MusteriTakipVTDataSet5";
            this.musteriTakipVTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCihazBindingSource1
            // 
            this.tblCihazBindingSource1.DataMember = "Tbl_Cihaz";
            this.tblCihazBindingSource1.DataSource = this.musteriTakipVTDataSet5;
            // 
            // tbl_CihazTableAdapter1
            // 
            this.tbl_CihazTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 38);
            this.label6.TabIndex = 58;
            this.label6.Text = "Kayıt Ekleme Formu";
            // 
            // FrmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 716);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTarih);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSorunu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSyd);
            this.Controls.Add(this.txtYasi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTuru);
            this.Controls.Add(this.txtMarkasi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekleme";
            this.Load += new System.EventHandler(this.FrmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriTakipVTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCihazBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTuru;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSyd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSorunu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarkasi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private MusteriTakipVTDataSet5 musteriTakipVTDataSet5;
        private System.Windows.Forms.BindingSource tblCihazBindingSource1;
        private MusteriTakipVTDataSet5TableAdapters.Tbl_CihazTableAdapter tbl_CihazTableAdapter1;
        public System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
    }
}