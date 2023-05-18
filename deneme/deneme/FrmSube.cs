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
    public partial class FrmSube : DevExpress.XtraEditors.XtraForm
    {
        public FrmSube()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        void subelerlistele()
        {
            //datagride verileri sql den alma
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblSubeler", bgl.Baglanti());
                da.Fill(dt);
                gridControl1.DataSource = dt;
        }
        private void FrmSube_Load(object sender, EventArgs e)
        {
            subelerlistele();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Müşteri kaydetme 
            bgl.Baglanti();
            SqlCommand kaydetcmd = new SqlCommand("insert into TblSubeler (sube_il,sube_ilce) values ('"+txt_ili.Text+"','"+txt_ilce.Text+"')  ", bgl.Baglanti());
            kaydetcmd.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Şube Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            subelerlistele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            //sube silme
            SqlCommand cmdsil = new SqlCommand("delete from TblSubeler where sube_id='" + txt_id.Text + "'", bgl.Baglanti());
            cmdsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Şube Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            subelerlistele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdupdate = new SqlCommand("update TblSubeler set sube_il='" + txt_ili.Text + "',sube_ilce='" + txt_ilce.Text + "' where sube_id='" + txt_id.Text + "'", bgl.Baglanti());
            cmdupdate.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Şube Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            subelerlistele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_id.Text = dr["sube_id"].ToString();
            txt_ili.Text = dr["sube_il"].ToString();
            txt_ilce.Text = dr["sube_ilce"].ToString();
           
        }
    }
}