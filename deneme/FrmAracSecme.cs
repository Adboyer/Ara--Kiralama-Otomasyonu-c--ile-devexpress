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
    public partial class FrmAracSecme : DevExpress.XtraEditors.XtraForm
    {
        public FrmAracSecme()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
        FrmAraclar k = (FrmAraclar)Application.OpenForms["FrmAraclar"];
        private void FrmAracSecme_Load(object sender, EventArgs e)
        {
            try
            {
                string subeid = q.subeID;
                string aracmarka = q.aracmarka;
                string aracmodel = q.aracmodel;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblEldekiAraclar where sube_id='" + subeid + "' and arac_marka='" + aracmarka + "' and arac_model='" + aracmodel + "' and arac_aktifdurum='True'", bgl.Baglanti());
                da.Fill(dt);
                GridAraclar.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void GridAraclar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (q.rbnlbl_personelturu.Caption == "Müşteri")
                {
                    q.aracplaka = dr["arac_plaka"].ToString();
                    q.gunlukucret = Convert.ToInt32(dr["arac_gunlukucret"]);
                    q.depozito = Convert.ToInt32(dr["arac_depozito"]);
                    this.Close();
                    FrmOnizleme onizle = new FrmOnizleme();
                    onizle.ShowDialog();
                }
                else
                {

                    q.aracplaka = dr["arac_plaka"].ToString();
                    q.gunlukucret = Convert.ToInt32(dr["arac_gunlukucret"]);
                    q.depozito = Convert.ToInt32(dr["arac_depozito"]);
                    this.Close();
                    k.sayfakapat();
                    q.musterilercagır();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }


        }


    }
}