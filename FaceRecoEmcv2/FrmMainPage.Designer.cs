namespace FaceRecoEmcv2
{
    partial class FrmMainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TapControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TpAnaSayfa = new System.Windows.Forms.TabPage();
            this.dGWMPList2 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRaporAl = new MetroFramework.Controls.MetroButton();
            this.dTPTarih = new MetroFramework.Controls.MetroDateTime();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbAy = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TpPersonelEkle = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.dgwPersonelList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTDogumTarih = new MetroFramework.Controls.MetroDateTime();
            this.btnFaceInsert = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartman = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.TpAracCikis = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbGosterGizle = new System.Windows.Forms.CheckBox();
            this.btnHesapEkle = new MetroFramework.Controls.MetroButton();
            this.txtKulAdi2 = new System.Windows.Forms.TextBox();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.txtParola2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGosterGizle2 = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnYenile = new MetroFramework.Controls.MetroButton();
            this.btnCikisYap = new MaterialSkin.Controls.MaterialFlatButton();
            this.TapControl.SuspendLayout();
            this.TpAnaSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMPList2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TpPersonelEkle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TpAracCikis.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TapControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1249, 30);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.TpAnaSayfa);
            this.TapControl.Controls.Add(this.TpPersonelEkle);
            this.TapControl.Controls.Add(this.TpAracCikis);
            this.TapControl.Depth = 0;
            this.TapControl.Location = new System.Drawing.Point(12, 95);
            this.TapControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(1197, 458);
            this.TapControl.TabIndex = 1;
            // 
            // TpAnaSayfa
            // 
            this.TpAnaSayfa.Controls.Add(this.dGWMPList2);
            this.TpAnaSayfa.Controls.Add(this.groupBox3);
            this.TpAnaSayfa.Controls.Add(this.groupBox2);
            this.TpAnaSayfa.Location = new System.Drawing.Point(4, 22);
            this.TpAnaSayfa.Name = "TpAnaSayfa";
            this.TpAnaSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.TpAnaSayfa.Size = new System.Drawing.Size(1189, 432);
            this.TpAnaSayfa.TabIndex = 0;
            this.TpAnaSayfa.Text = "AnaSayfa";
            this.TpAnaSayfa.UseVisualStyleBackColor = true;
            this.TpAnaSayfa.Click += new System.EventHandler(this.TpAnaSayfa_Click);
            // 
            // dGWMPList2
            // 
            this.dGWMPList2.BackgroundColor = System.Drawing.Color.White;
            this.dGWMPList2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGWMPList2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGWMPList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMPList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dGWMPList2.Location = new System.Drawing.Point(92, 173);
            this.dGWMPList2.Name = "dGWMPList2";
            this.dGWMPList2.Size = new System.Drawing.Size(980, 248);
            this.dGWMPList2.TabIndex = 17;
            this.dGWMPList2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWMPList2_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Personel Ad";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Personel Soyad";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Departman";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Giriş Tarihi";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Giriş Saati";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Çıkış Tarihi";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Çıkış Saati";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Çalıştığı Saat";
            this.Column16.Name = "Column16";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRaporAl);
            this.groupBox3.Controls.Add(this.dTPTarih);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAra);
            this.groupBox3.Controls.Add(this.cmbAy);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(266, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 118);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Günlük";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRaporAl.Location = new System.Drawing.Point(312, 48);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(137, 40);
            this.btnRaporAl.TabIndex = 18;
            this.btnRaporAl.Text = "Doküman Oluştur";
            this.btnRaporAl.UseSelectable = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // dTPTarih
            // 
            this.dTPTarih.Location = new System.Drawing.Point(16, 20);
            this.dTPTarih.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dTPTarih.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dTPTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dTPTarih.Name = "dTPTarih";
            this.dTPTarih.Size = new System.Drawing.Size(158, 29);
            this.dTPTarih.TabIndex = 9;
            this.dTPTarih.Value = new System.DateTime(2000, 1, 29, 0, 0, 0, 0);
            this.dTPTarih.ValueChanged += new System.EventHandler(this.dTPTarih_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "isim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Aylık Döküman";
            // 
            // txtAra
            // 
            this.txtAra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAra.Location = new System.Drawing.Point(238, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(150, 22);
            this.txtAra.TabIndex = 12;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.ItemHeight = 23;
            this.cmbAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Location = new System.Drawing.Point(130, 58);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(156, 29);
            this.cmbAy.TabIndex = 7;
            this.cmbAy.UseSelectable = true;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(83, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgilendirme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "İşe gelmedi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "İşte";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(101, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 13);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(101, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 13);
            this.panel1.TabIndex = 3;
            // 
            // TpPersonelEkle
            // 
            this.TpPersonelEkle.BackColor = System.Drawing.Color.White;
            this.TpPersonelEkle.Controls.Add(this.groupBox4);
            this.TpPersonelEkle.Controls.Add(this.groupBox1);
            this.TpPersonelEkle.Location = new System.Drawing.Point(4, 22);
            this.TpPersonelEkle.Name = "TpPersonelEkle";
            this.TpPersonelEkle.Padding = new System.Windows.Forms.Padding(3);
            this.TpPersonelEkle.Size = new System.Drawing.Size(1189, 432);
            this.TpPersonelEkle.TabIndex = 1;
            this.TpPersonelEkle.Text = "PERSONEL EKLE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtIsim);
            this.groupBox4.Controls.Add(this.dgwPersonelList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(408, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 374);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgi Güncelle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "isim";
            // 
            // txtIsim
            // 
            this.txtIsim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIsim.Location = new System.Drawing.Point(57, 20);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(150, 22);
            this.txtIsim.TabIndex = 13;
            this.txtIsim.TextChanged += new System.EventHandler(this.txtIsim_TextChanged);
            // 
            // dgwPersonelList
            // 
            this.dgwPersonelList.BackgroundColor = System.Drawing.Color.White;
            this.dgwPersonelList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPersonelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelList.Location = new System.Drawing.Point(6, 44);
            this.dgwPersonelList.Name = "dgwPersonelList";
            this.dgwPersonelList.Size = new System.Drawing.Size(763, 312);
            this.dgwPersonelList.TabIndex = 1;
            this.dgwPersonelList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonelList_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTDogumTarih);
            this.groupBox1.Controls.Add(this.btnFaceInsert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDepartman);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 374);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // dTDogumTarih
            // 
            this.dTDogumTarih.CustomFormat = "yyyy-MM-dd";
            this.dTDogumTarih.Location = new System.Drawing.Point(159, 132);
            this.dTDogumTarih.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dTDogumTarih.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dTDogumTarih.MinimumSize = new System.Drawing.Size(4, 29);
            this.dTDogumTarih.Name = "dTDogumTarih";
            this.dTDogumTarih.Size = new System.Drawing.Size(158, 29);
            this.dTDogumTarih.TabIndex = 2;
            this.dTDogumTarih.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnFaceInsert
            // 
            this.btnFaceInsert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFaceInsert.Location = new System.Drawing.Point(159, 265);
            this.btnFaceInsert.Name = "btnFaceInsert";
            this.btnFaceInsert.Size = new System.Drawing.Size(158, 33);
            this.btnFaceInsert.TabIndex = 5;
            this.btnFaceInsert.Text = "EKLE";
            this.btnFaceInsert.UseSelectable = true;
            this.btnFaceInsert.Click += new System.EventHandler(this.btnFaceInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Maaş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad:";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(159, 213);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(158, 22);
            this.txtMaas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Soyad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.ItemHeight = 23;
            this.cmbDepartman.Location = new System.Drawing.Point(159, 173);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(158, 29);
            this.cmbDepartman.TabIndex = 3;
            this.cmbDepartman.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Departman:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(159, 92);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(158, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(159, 55);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(158, 22);
            this.txtAd.TabIndex = 0;
            // 
            // TpAracCikis
            // 
            this.TpAracCikis.BackColor = System.Drawing.Color.White;
            this.TpAracCikis.Controls.Add(this.groupBox6);
            this.TpAracCikis.Controls.Add(this.groupBox5);
            this.TpAracCikis.Location = new System.Drawing.Point(4, 22);
            this.TpAracCikis.Name = "TpAracCikis";
            this.TpAracCikis.Padding = new System.Windows.Forms.Padding(3);
            this.TpAracCikis.Size = new System.Drawing.Size(1189, 432);
            this.TpAracCikis.TabIndex = 2;
            this.TpAracCikis.Text = "Hesap İşlemleri";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.cbGosterGizle);
            this.groupBox6.Controls.Add(this.btnHesapEkle);
            this.groupBox6.Controls.Add(this.txtKulAdi2);
            this.groupBox6.Controls.Add(this.txtParolaTekrar);
            this.groupBox6.Controls.Add(this.txtParola2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(611, 98);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(293, 318);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hesap Ekle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Parola Tekrar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Parola:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Kullanıcı Adı:";
            // 
            // cbGosterGizle
            // 
            this.cbGosterGizle.AutoSize = true;
            this.cbGosterGizle.Location = new System.Drawing.Point(159, 141);
            this.cbGosterGizle.Name = "cbGosterGizle";
            this.cbGosterGizle.Size = new System.Drawing.Size(113, 20);
            this.cbGosterGizle.TabIndex = 3;
            this.cbGosterGizle.Text = "Göster/Gizle";
            this.cbGosterGizle.UseVisualStyleBackColor = true;
            this.cbGosterGizle.CheckedChanged += new System.EventHandler(this.cbGosterGizle_CheckedChanged);
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.Location = new System.Drawing.Point(50, 260);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(102, 24);
            this.btnHesapEkle.TabIndex = 2;
            this.btnHesapEkle.Text = "Hesap Ekle";
            this.btnHesapEkle.UseSelectable = true;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // txtKulAdi2
            // 
            this.txtKulAdi2.Location = new System.Drawing.Point(50, 71);
            this.txtKulAdi2.Name = "txtKulAdi2";
            this.txtKulAdi2.Size = new System.Drawing.Size(100, 22);
            this.txtKulAdi2.TabIndex = 0;
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(50, 215);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Size = new System.Drawing.Size(100, 22);
            this.txtParolaTekrar.TabIndex = 1;
            this.txtParolaTekrar.UseSystemPasswordChar = true;
            // 
            // txtParola2
            // 
            this.txtParola2.Location = new System.Drawing.Point(50, 139);
            this.txtParola2.Name = "txtParola2";
            this.txtParola2.Size = new System.Drawing.Size(100, 22);
            this.txtParola2.TabIndex = 1;
            this.txtParola2.UseSystemPasswordChar = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cbGosterGizle2);
            this.groupBox5.Controls.Add(this.btnGuncelle);
            this.groupBox5.Controls.Add(this.txtKulAdi);
            this.groupBox5.Controls.Add(this.txtParola);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(270, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 318);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bilgi Güncelle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Parola:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Kullanıcı Adı:";
            // 
            // cbGosterGizle2
            // 
            this.cbGosterGizle2.AutoSize = true;
            this.cbGosterGizle2.Location = new System.Drawing.Point(161, 164);
            this.cbGosterGizle2.Name = "cbGosterGizle2";
            this.cbGosterGizle2.Size = new System.Drawing.Size(113, 20);
            this.cbGosterGizle2.TabIndex = 3;
            this.cbGosterGizle2.Text = "Göster/Gizle";
            this.cbGosterGizle2.UseVisualStyleBackColor = true;
            this.cbGosterGizle2.CheckedChanged += new System.EventHandler(this.cbGosterGizle2_CheckedChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(55, 203);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(55, 96);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKulAdi.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(55, 164);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 22);
            this.txtParola.TabIndex = 1;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(555, 43);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 23);
            this.btnYenile.TabIndex = 39;
            this.btnYenile.Text = "SEKMEYİ YENİLE";
            this.btnYenile.UseSelectable = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click_1);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.AutoSize = true;
            this.btnCikisYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikisYap.Depth = 0;
            this.btnCikisYap.Location = new System.Drawing.Point(1174, 53);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCikisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Primary = false;
            this.btnCikisYap.Size = new System.Drawing.Size(75, 36);
            this.btnCikisYap.TabIndex = 18;
            this.btnCikisYap.Text = "ÇIKIŞ YAP";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 545);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TapControl);
            this.Controls.Add(this.label9);
            this.Name = "FrmMainPage";
            this.Load += new System.EventHandler(this.FrmMainPage_Load);
            this.TapControl.ResumeLayout(false);
            this.TpAnaSayfa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGWMPList2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TpPersonelEkle.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TpAracCikis.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialFlatButton btnCikisYap;
        private MetroFramework.Controls.MetroButton btnYenile;
        private MaterialSkin.Controls.MaterialTabControl TapControl;
        private System.Windows.Forms.TabPage TpAnaSayfa;
        private System.Windows.Forms.DataGridView dGWMPList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnRaporAl;
        private MetroFramework.Controls.MetroDateTime dTPTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAra;
        private MetroFramework.Controls.MetroComboBox cmbAy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage TpPersonelEkle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgwPersonelList;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dTDogumTarih;
        private MetroFramework.Controls.MetroButton btnFaceInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbDepartman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabPage TpAracCikis;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtKulAdi2;
        private System.Windows.Forms.TextBox txtParola2;
        private MetroFramework.Controls.MetroButton btnHesapEkle;
        private System.Windows.Forms.TextBox txtParolaTekrar;
        private System.Windows.Forms.CheckBox cbGosterGizle;
        private System.Windows.Forms.CheckBox cbGosterGizle2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}