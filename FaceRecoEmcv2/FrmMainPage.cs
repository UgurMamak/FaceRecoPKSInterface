#region LIB
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

using System.Data;
using System.Data.SqlClient;

using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

#endregion
namespace FaceRecoEmcv2
{
    public partial class FrmMainPage : MaterialForm
    {
        public FrmMainPage()
        {
            InitializeComponent();
            #region material tasarım
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
            #endregion
        }
        DbProcess prc = new DbProcess();
        SqlDataReader reader;
        public string resimBilgi;
        DataTable table;
        public int kulId { get; set; }


        // dGWMPList.RowsDefaultCellStyle.BackColor = Color.Red;//satırların arka rengini değiştirmek için kullanılır.

        #region Departman listeleme (combobox)
        void fnkDepartList()
        {
            reader = prc.PrcDepartmanList();
            while(reader.Read()){ cmbDepartman.Items.Add(reader[1].ToString());}
        }
        #endregion

        #region Günlük listeleme işlemi
       public void fnkListele(DateTime tarih, string isim)
        {
            table = new DataTable();
            table.Columns.Add("Personel Ad", typeof(string));
            table.Columns.Add("Personel Soyad", typeof(string));
            table.Columns.Add("Departman", typeof(string));
            table.Columns.Add("Giriş Tarihi", typeof(string));
            table.Columns.Add("Giriş Saati", typeof(string));
            table.Columns.Add("Çıkış Tarihi", typeof(string));
            table.Columns.Add("Çıkış Saati", typeof(string));
            table.Columns.Add("Çalıştığı Saat", typeof(string));
            table.Columns.Add("Şuan ki Ücreti", typeof(string));
            table.Columns.Add("Personel Id", typeof(string));
            reader = prc.PrcListele(tarih);
            //tüm listeleme işlemi için
            if(isim=="")
            {
                while (reader.Read())
                {
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString());
                }
            }
            else
            {
                while (reader.Read())
                {
                    if(reader[0].ToString()==isim)
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString());
                }
            }
            dGWMPList2.Columns.Clear();
            dGWMPList2.DataSource = table;
            dGWMPList2.Columns[9].Visible = false;//persId gizler
            for (int i = 0; i < dGWMPList2.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                if (Convert.ToString(dGWMPList2.Rows[i].Cells["Giriş Tarihi"].Value)=="")
                rowColor.BackColor = Color.OrangeRed;                                   
                else  rowColor.BackColor = Color.Green;                                 
                dGWMPList2.Rows[i].DefaultCellStyle = rowColor;
            }          
        }
        #endregion

        #region FrmMainPage_Load
        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            dTDogumTarih.Format = DateTimePickerFormat.Custom;
            dTDogumTarih.CustomFormat = "yyyy-MM-dd";

            dTPTarih.Value = DateTime.Today;
            dTPTarih.Format = DateTimePickerFormat.Custom;
            dTPTarih.CustomFormat = "dd.MM.yyyy HH:mm:ss";

            label9.Text=DateTime.Today.ToShortDateString();
            
          //  fnkListele(DateTime.Today); //sistem açıldığında ilk önce bugüne ait olan kayıtları getirecek.
            fnkDepartList();
            FnkPersonelList();
            fnkListele(Convert.ToDateTime(dTPTarih.Text), txtAra.Text);
            fnkHesapGoster();
        }
        #endregion

        #region Hesap işlemleri

        void fnkHesapGoster()
        {
            reader = prc.prcHesapListele();
            while(reader.Read())
            {
                if(kulId==Convert.ToInt32(reader[0].ToString()))
                {
                    txtKulAdi.Text = reader[1].ToString();
                    txtParola.Text = reader[2].ToString();
                    break;
                }               
            }
        }


        void fnkHesapGuncelle(string kuladi, string parola)
        {
            prc.prcHesapGuncelle(kulId,kuladi,parola);
        }

        void fnkHesapEkle(string kuladi, string parola)
        {
            prc.prcHesapOlustur(kuladi, parola);
        }


        #endregion


        #region Kaydı alınan kişinin resimlerini çekmek için form ekranını açar
        private void btnFaceInsert_Click(object sender, EventArgs e)
        {
            bool eklimi = false;
            if(txtAd.Text==""|| txtSoyad.Text=="" || txtMaas.Text=="" || cmbDepartman.Text=="")
            {
                MetroMessageBox.Show(this, "\n", "!!!Boş Alan Bırakmayınız!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reader = prc.prcPersonelList();
                while(reader.Read())
                {
                    if(reader[1].ToString()+" "+reader[2].ToString()==(txtAd.Text+" " + txtSoyad.Text).ToLower()) { eklimi = true; break; }
                }
                if(!eklimi)
                {
                    resimBilgi = (txtAd.Text + "_" + txtSoyad.Text).ToLower();// FrmFaceInsert formuna resim için label etiketi gönderir.(**)
                    FrmPersFaceInsert yeni = new FrmPersFaceInsert();
                    yeni.fnkImageLabel = resimBilgi;
                    yeni.persAd = txtAd.Text.ToLower();
                    yeni.persSoyad = txtSoyad.Text.ToLower();
                    yeni.dogumTarihi = dTDogumTarih.Text;
                    yeni.departman = cmbDepartman.SelectedItem.ToString();
                    yeni.maaş = Convert.ToDouble(txtMaas.Text);
                    yeni.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n", "!!!Ekleme Çalıştığınız Personel Zaten Var!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
            }
        }
        #endregion

        void fnkAylikList()
        {
            table = new DataTable();
            table.Columns.Add("Personel Id", typeof(string));
            table.Columns.Add("Personel Ad", typeof(string));
            table.Columns.Add("Personel Soyad", typeof(string));
            table.Columns.Add("Departman", typeof(string));
            table.Columns.Add("Maaş", typeof(string));
            table.Columns.Add("Ay", typeof(string));
            table.Columns.Add("Toplam Gün", typeof(string));    
            reader = prc.prcAylikList(cmbAy.SelectedIndex + 1);

            if(txtAra.Text=="")
            { 
            while (reader.Read())
            {
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),reader[6].ToString());
            }
            }
            else
            {
                while (reader.Read())
                {
                    if(reader[1].ToString()==txtAra.Text)
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                }
            }
            dGWMPList2.Columns.Clear();
            dGWMPList2.DataSource = table;            
            dGWMPList2.Columns[0].Visible = false;//persId gizler           
        }          
        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnkAylikList();//seçilen aya göre listeleme işlemi yapar.
        }

        private void dTPTarih_ValueChanged(object sender, EventArgs e)
        {          
            fnkListele(Convert.ToDateTime(dTPTarih.Text),txtAra.Text);//date time picker'dan seçilen güne ait göre bilgiler listelenir.
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Today.Month.ToString());

            /*
            int id = Convert.ToInt32(metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells["Personel Id"].Value);
            MessageBox.Show(id.ToString());
            */
        }

        //personel bilgilerini txt'de aramak için ve personelleri listelemek işlemi için
        public  void FnkPersonelList()
        {
            dgwPersonelList.Columns.Clear();
            table = new DataTable();
            table.Columns.Add("Personel Id", typeof(string));
            table.Columns.Add("Personel Ad", typeof(string));
            table.Columns.Add("Personel Soyad", typeof(string));
            table.Columns.Add("Doğum Tarihi", typeof(string));
            table.Columns.Add("Departman", typeof(string));
            table.Columns.Add("Maaş", typeof(string));
            txtAra.AutoCompleteSource = AutoCompleteSource.CustomSource;            
            txtIsim.AutoCompleteSource = AutoCompleteSource.CustomSource;            
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            reader = prc.prcPersonelList();
            while (reader.Read())
            {
                veri.Add(reader[1].ToString());                 
                txtAra.AutoCompleteCustomSource = veri;
                txtIsim.AutoCompleteCustomSource = veri;
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
            
            dgwPersonelList.DataSource = table;
        }

       

        
        //isim bilgisine göre arama işlemi
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            fnkListele(Convert.ToDateTime(dTPTarih.Text),txtAra.Text);//date time picker'dan seçilen güne ait göre bilgiler listelenir.

        }
        private void dGWMPList2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
                if(dGWMPList2.Rows.Count-1== dGWMPList2.CurrentCell.RowIndex)
                {
                }

                else
                {               
                    //seçilen personelin Idsini aldık.                       
                    FrmDetay yeni = new FrmDetay();
                    if (cmbAy.SelectedIndex < 0)
                        yeni.ay = Convert.ToInt32(DateTime.Today.Month.ToString());
                    else yeni.ay = cmbAy.SelectedIndex + 1;
                    yeni.persId = Convert.ToInt32(dGWMPList2.Rows[dGWMPList2.CurrentRow.Index].Cells["Personel Id"].Value);
                    yeni.ad = Convert.ToString(dGWMPList2.Rows[dGWMPList2.CurrentRow.Index].Cells["Personel Ad"].Value);
                    yeni.soyad = Convert.ToString(dGWMPList2.Rows[dGWMPList2.CurrentRow.Index].Cells["Personel Soyad"].Value);
                    yeni.Show();
                
                }        
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }


        void pdfKaydet(DataGridView veriTablosu)
        {
            string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
            BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf,8, iTextSharp.text.Font.NORMAL);
            PdfPTable pdfTablosu = new PdfPTable(veriTablosu.ColumnCount);
            pdfTablosu.DefaultCell.Padding = 3;
            pdfTablosu.WidthPercentage = 100;
            pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
            foreach (DataGridViewColumn sutun in veriTablosu.Columns)
            {
                PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, font));
                pdfTablosu.AddCell(pdfHucresi);
            }
            foreach (DataGridViewRow satir in veriTablosu.Rows)
            {
                foreach (DataGridViewCell cell in satir.Cells)
                {
                    if (!satir.IsNewRow)
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), font));                   
                }
            }
            Random a = new Random();
            int sayi = a.Next(0, 10000);
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            dosyakaydet.FileName = "Rapor" + sayi.ToString();
            dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            dosyakaydet.Filter = "PDF Dosyası|*.pdf";
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                {
                    DateTime bugun = DateTime.Now;                  
                   Paragraph ekle = new Paragraph("Doküman Oluşturma Tarihi: "+ DateTime.Now.ToString()+"\n"+" ",font);
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(ekle);
                    pdfDoc.Add(pdfTablosu);               
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Doküman Hazır.");                   
                }
            }
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            pdfKaydet(dGWMPList2);
        }

        private void dgwPersonelList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwPersonelList.Rows.Count - 1 == dgwPersonelList.CurrentCell.RowIndex)
            {
            }
            else
            {
                FrmPersUpdate yeni = new FrmPersUpdate();
                yeni.Id = Convert.ToInt32(dgwPersonelList.Rows[dgwPersonelList.CurrentRow.Index].Cells["Personel Id"].Value);
                yeni.Ad = Convert.ToString(dgwPersonelList.Rows[dgwPersonelList.CurrentRow.Index].Cells["Personel Ad"].Value);
                yeni.Soyad = Convert.ToString(dgwPersonelList.Rows[dgwPersonelList.CurrentRow.Index].Cells["Personel Soyad"].Value);
                yeni.DogumTarihi = Convert.ToString(dgwPersonelList.Rows[dgwPersonelList.CurrentRow.Index].Cells["Doğum Tarihi"].Value);
                yeni.Departman = Convert.ToString(dgwPersonelList.Rows[dgwPersonelList.CurrentRow.Index].Cells["Departman"].Value);
                yeni.Maas = Convert.ToString(dgwPersonelList.Rows[dgwPersonelList.CurrentRow.Index].Cells["Maaş"].Value);
                yeni.Show();
            }
        }

        private void TpAnaSayfa_Click(object sender, EventArgs e)
        {

        }      

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click_1(object sender, EventArgs e)
        {
            FnkPersonelList();
            fnkListele(DateTime.Today,"");
        }


        void FnkPersonelAra(string isim2)
        {
            dgwPersonelList.Columns.Clear();
            table = new DataTable();
            table.Columns.Add("Personel Id", typeof(string));
            table.Columns.Add("Personel Ad", typeof(string));
            table.Columns.Add("Personel Soyad", typeof(string));
            table.Columns.Add("Doğum Tarihi", typeof(string));
            table.Columns.Add("Departman", typeof(string));
            table.Columns.Add("Maaş", typeof(string));            
            reader = prc.prcPersonelList();

            if (isim2 == "")
            {
                while (reader.Read())
                {
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }
            }
            else
            {
                while (reader.Read())
                {
                    if (reader[1].ToString() == isim2)
                    {
                        table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

                    }
                }
            }            
            dgwPersonelList.DataSource = table;
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            FnkPersonelAra(txtIsim.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text == "" || txtParola.Text == "")
            {
                MetroMessageBox.Show(this, "\n", "!!!Boş Alan Bırakmayınız!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                fnkHesapGuncelle(txtKulAdi.Text.ToLower(), txtParola.Text.ToLower());
                MessageBox.Show("Bilgiler Güncellendi");
            }

        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            bool hesapkontrol = false;
            if (txtKulAdi2.Text == "" || txtParola2.Text == "")
            {
                MetroMessageBox.Show(this, "\n", "!!!Boş Alan Bırakmayınız!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txtParola2.Text.ToLower()!=txtParolaTekrar.Text.ToLower())
                {
                    MetroMessageBox.Show(this, "\n", "!!!Parola Eşleşmedi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader = prc.prcHesapListele();
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == txtKulAdi2.Text.ToLower())
                        {
                            hesapkontrol = true;
                            break;
                        }
                    }
                    if (hesapkontrol)
                    {
                        MetroMessageBox.Show(this, "\n", "!!!Kullanıcı Adı Kullanılmakta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        fnkHesapEkle(txtKulAdi2.Text.ToLower(), txtParola2.Text.ToLower());
                        MessageBox.Show("Hesap Eklendi.");
                    }
                }                               
            }
        }

        private void cbGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if(cbGosterGizle.Checked==true)
            {
                txtParola2.UseSystemPasswordChar = false;
                txtParolaTekrar.UseSystemPasswordChar = false;
            }
            else if(cbGosterGizle.Checked==false)
            {
                txtParola2.UseSystemPasswordChar = true;
                txtParolaTekrar.UseSystemPasswordChar = true;
            }
        }

        private void cbGosterGizle2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGosterGizle2.Checked == true)
            {
                txtParola.UseSystemPasswordChar = false;
               
            }
            else if (cbGosterGizle2.Checked == false)
            {
                txtParola.UseSystemPasswordChar = true;
               
            }
        }
    }
}
