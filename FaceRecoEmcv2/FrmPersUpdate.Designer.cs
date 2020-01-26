namespace FaceRecoEmcv2
{
    partial class FrmPersUpdate
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
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.Faces_Found_Panel = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dTDogumTarih = new MetroFramework.Controls.MetroDateTime();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartman = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKameraDurdur = new MetroFramework.Controls.MetroButton();
            this.btnKameraAc = new MetroFramework.Controls.MetroButton();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnResimCek = new MetroFramework.Controls.MetroButton();
            this.imgYuz = new System.Windows.Forms.PictureBox();
            this.imgKamera = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgYuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSil.Location = new System.Drawing.Point(122, 309);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Seçili Resimleri sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Faces_Found_Panel
            // 
            this.Faces_Found_Panel.AutoScroll = true;
            this.Faces_Found_Panel.Location = new System.Drawing.Point(6, 15);
            this.Faces_Found_Panel.Name = "Faces_Found_Panel";
            this.Faces_Found_Panel.Size = new System.Drawing.Size(211, 416);
            this.Faces_Found_Panel.TabIndex = 4;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.dTDogumTarih);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDepartman);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 437);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(137, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // dTDogumTarih
            // 
            this.dTDogumTarih.CustomFormat = "yyyy-MM-dd";
            this.dTDogumTarih.Location = new System.Drawing.Point(122, 137);
            this.dTDogumTarih.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dTDogumTarih.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dTDogumTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dTDogumTarih.Name = "dTDogumTarih";
            this.dTDogumTarih.Size = new System.Drawing.Size(158, 29);
            this.dTDogumTarih.TabIndex = 2;
            this.dTDogumTarih.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGuncelle.Location = new System.Drawing.Point(122, 270);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 33);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Maaş:";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(122, 218);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(158, 22);
            this.txtMaas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Soyad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.ItemHeight = 23;
            this.cmbDepartman.Location = new System.Drawing.Point(122, 178);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(158, 29);
            this.cmbDepartman.TabIndex = 3;
            this.cmbDepartman.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Departman:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(122, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(158, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Faces_Found_Panel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(345, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 437);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resimler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKameraDurdur);
            this.groupBox3.Controls.Add(this.btnKameraAc);
            this.groupBox3.Controls.Add(this.lblAdet);
            this.groupBox3.Controls.Add(this.btnResimCek);
            this.groupBox3.Controls.Add(this.imgYuz);
            this.groupBox3.Controls.Add(this.imgKamera);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(579, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 437);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Resim Ekle";
            // 
            // btnKameraDurdur
            // 
            this.btnKameraDurdur.Location = new System.Drawing.Point(111, 23);
            this.btnKameraDurdur.Name = "btnKameraDurdur";
            this.btnKameraDurdur.Size = new System.Drawing.Size(104, 23);
            this.btnKameraDurdur.TabIndex = 42;
            this.btnKameraDurdur.Text = "Kamerayı Durdur";
            this.btnKameraDurdur.UseSelectable = true;
            this.btnKameraDurdur.Click += new System.EventHandler(this.btnKameraDurdur_Click);
            // 
            // btnKameraAc
            // 
            this.btnKameraAc.Location = new System.Drawing.Point(11, 23);
            this.btnKameraAc.Name = "btnKameraAc";
            this.btnKameraAc.Size = new System.Drawing.Size(75, 23);
            this.btnKameraAc.TabIndex = 41;
            this.btnKameraAc.Text = "Kamerayı Aç";
            this.btnKameraAc.UseSelectable = true;
            this.btnKameraAc.Click += new System.EventHandler(this.btnKameraAc_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(393, 302);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(60, 16);
            this.lblAdet.TabIndex = 34;
            this.lblAdet.Text = ".............";
            // 
            // btnResimCek
            // 
            this.btnResimCek.Location = new System.Drawing.Point(342, 256);
            this.btnResimCek.Name = "btnResimCek";
            this.btnResimCek.Size = new System.Drawing.Size(144, 27);
            this.btnResimCek.TabIndex = 33;
            this.btnResimCek.Text = "Resim Çek";
            this.btnResimCek.UseSelectable = true;
            this.btnResimCek.Click += new System.EventHandler(this.btnResimCek_Click);
            // 
            // imgYuz
            // 
            this.imgYuz.Location = new System.Drawing.Point(305, 52);
            this.imgYuz.Name = "imgYuz";
            this.imgYuz.Size = new System.Drawing.Size(212, 180);
            this.imgYuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgYuz.TabIndex = 32;
            this.imgYuz.TabStop = false;
            // 
            // imgKamera
            // 
            this.imgKamera.Location = new System.Drawing.Point(6, 52);
            this.imgKamera.Name = "imgKamera";
            this.imgKamera.Size = new System.Drawing.Size(293, 379);
            this.imgKamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKamera.TabIndex = 31;
            this.imgKamera.TabStop = false;
            // 
            // FrmPersUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPersUpdate";
            this.Load += new System.EventHandler(this.FrmPersUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgYuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSil;
        private System.Windows.Forms.Panel Faces_Found_Panel;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dTDogumTarih;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbDepartman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAdet;
        private MetroFramework.Controls.MetroButton btnResimCek;
        private System.Windows.Forms.PictureBox imgYuz;
        private System.Windows.Forms.PictureBox imgKamera;
        private MetroFramework.Controls.MetroButton btnKameraAc;
        private MetroFramework.Controls.MetroButton btnKameraDurdur;
    }
}