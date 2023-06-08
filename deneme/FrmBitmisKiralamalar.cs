using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace deneme
{
    public partial class FrmBitmisKiralamalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmBitmisKiralamalar()
        {
            InitializeComponent();
        }

        ProjeBaglanti bgl = new ProjeBaglanti();
        private void FrmBitmisKiralamalar_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblKiradakiAraclar where kiradurum='False' ", bgl.Baglanti());
                da.Fill(dt);
                GridAraclar.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
    }
}