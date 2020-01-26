#region LIB
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************
using System.Data;
using System.Data.SqlClient;
using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Drawing.Imaging;
using System.Xml;
using System.Threading;
#endregion
namespace FaceRecoEmcv2
{
    class DbProcess
    {

        public const string Baglanti = "Data Source=.;Initial Catalog=DbPKS; Integrated Security=True;";
        SqlCommand cmd;
        SqlDataReader reader;

        #region Sql bağlantı işlemleri
        public SqlCommand CreateCommand()//sql ile bağlantıyı sağlayan fonksiyon
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Baglanti;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }        
        // Prosedüre bağlanma işlemi hep tekrarlandığı için connection fonksiyonu yazarak çağırma işlemini gerçekleştirdik.
        public void Connection(string prc)//prosedüre bağlanma işlemi
        {
            cmd = CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = prc;
            if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
        }
        #endregion

       

        #region Listeleme işlemi İşlemler tablosudnaki verileri listeleme işlemi
        public SqlDataReader PrcListele(DateTime tarih)
        {          
            Connection("PrcListele");
            cmd.Parameters.AddWithValue("@tarih",tarih);
            reader=cmd.ExecuteReader();      
            return reader;
        }
        #endregion


        #region Personelleri listeler
        public SqlDataReader prcPersonelList()
        {
            Connection("prcPersoneList");
            reader = cmd.ExecuteReader();
            return reader;
        }
        #endregion

        #region departmanları comboboxta listelemek için
        public SqlDataReader PrcDepartmanList()
        {
            Connection("prcDepartmanList");
            reader = cmd.ExecuteReader();
            return reader;
        }
        #endregion

        #region Aylık listeleme
        public SqlDataReader prcAylikList(int ay)
        {
            Connection("prcAylikList");
            cmd.Parameters.AddWithValue("@ay", ay);
            reader = cmd.ExecuteReader();
            return reader;
        }
        #endregion



        #region personellerin detaylı bilgilerini listelemek için
        public SqlDataReader prcPersonelDetayList(int persId,int ay)
        {
            Connection("prcPersonelDetayList");
            cmd.Parameters.AddWithValue("@persId", persId);
            cmd.Parameters.AddWithValue("@ay", ay);
            reader = cmd.ExecuteReader();
            return reader;
        }
        #endregion


        #region Kişi ekleme kısmı
        public void prcPersonelInsert(string persAd, string persSoyad, string dt, string departman, double maas)
        {
            Connection("prcPersonelInsert ");
            cmd.Parameters.AddWithValue("@persAd", persAd);
            cmd.Parameters.AddWithValue("@persSoyad", persSoyad);
            cmd.Parameters.AddWithValue("@persDt", dt);
            cmd.Parameters.AddWithValue("@departman", departman);
            cmd.Parameters.AddWithValue("@maas", maas);            
            cmd.ExecuteNonQuery();
        }
        #endregion


        #region Kişi ekleme kısmı
        public void prcPersonelUpdate(int persId, string persSoyad, string dt, string departman, double maas)
        {
            Connection("prcPersonelUpdate");
            cmd.Parameters.AddWithValue("@persId", persId);
            cmd.Parameters.AddWithValue("@persSoyad", persSoyad);
            cmd.Parameters.AddWithValue("@persDt", dt);
            cmd.Parameters.AddWithValue("@departman", departman);
            cmd.Parameters.AddWithValue("@maas", maas);
            cmd.ExecuteNonQuery();
        }
        #endregion


        #region Hesap işlemleri

        public void prcHesapOlustur(string kulAdi, string kulParola)
        {
            Connection("prcHesapOlustur");
            cmd.Parameters.AddWithValue("@KulAdi", kulAdi);
            cmd.Parameters.AddWithValue("@Parola", kulParola);
            cmd.ExecuteNonQuery();
        }

        public void prcHesapGuncelle(int kulId,string kulAdi, string kulParola)
        {
            Connection("prcHesapGuncelle");
            cmd.Parameters.AddWithValue("@KulId", kulId);
            cmd.Parameters.AddWithValue("@KulAdi", kulAdi);
            cmd.Parameters.AddWithValue("@Parola", kulParola);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader prcHesapListele()//Kullanıcı Giriş kontrolü
        {
            Connection("prcHesapListele");
            reader = cmd.ExecuteReader();
            return reader;
        }

        #endregion
        #region Login kontrolü
        public SqlDataReader PrcGiris(String KulAdi, String Parola)//Kullanıcı Giriş kontrolü
        {
            Connection("PrcGiris");
            cmd.Parameters.AddWithValue("@KulAdi", KulAdi);
            cmd.Parameters.AddWithValue("@Parola", Parola);
            reader = cmd.ExecuteReader();
            return reader;
        }
        #endregion



    }
}
