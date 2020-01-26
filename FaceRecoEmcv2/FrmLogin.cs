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

namespace FaceRecoEmcv2
{
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
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
        bool kontrol = false;

        private void btnGiris_Click(object sender, EventArgs e)
        {

            reader = prc.PrcGiris(txtKulAdi.Text, txtParola.Text);
            while (reader.Read())
            {
                if (reader[0].ToString() == "1")
                {
                    FrmMainPage frm = new FrmMainPage();
                    frm.kulId = Convert.ToInt32(reader[1].ToString());
                    frm.Show();
                    
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            {
                MetroMessageBox.Show(this, "\n", "Kullanıcı Adı veya Şifre Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }
    }
}
