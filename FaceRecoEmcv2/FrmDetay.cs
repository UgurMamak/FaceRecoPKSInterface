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

using System.Data;
using System.Data.SqlClient;
#endregion
namespace FaceRecoEmcv2
{
    public partial class FrmDetay : MaterialForm
    {
        public FrmDetay()
        {
            InitializeComponent();
            #region material tasarım
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
            #endregion
        }

        #region değişkenler ve sınıf çağırımları
        DbProcess prc = new DbProcess();
        SqlDataReader reader;
        #endregion

        //anasayfadan gelen ay ve personelId bilgisi
        public int persId { get; set; }
        public int ay { get; set; }
        public string ad { get; set; }
        public string soyad{ get; set; }

        private void FrmDetay_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = (ad + "  " + soyad).ToUpper();
            reader =prc.prcPersonelDetayList(persId,ay);
            while (reader.Read())
            {
                
                metroLabel10.Text = reader[3].ToString();
                metroLabel11.Text = reader[4].ToString();
                metroLabel12.Text = reader[5].ToString();
                metroLabel13.Text = reader[6].ToString();
                metroLabel14.Text = reader[7].ToString();
                metroLabel15.Text = reader[8].ToString();
                metroLabel16.Text = reader[9].ToString();
                metroLabel17.Text = reader[10].ToString();
                metroLabel18.Text = reader[11].ToString();
              
            }
        }
    }
}
