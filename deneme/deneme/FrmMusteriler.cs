using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace deneme
{
    public partial class FrmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        void musterilerilistele()
        {
            //datagride verileri sql den alma
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblMusteriler", bgl.Baglanti());
                da.Fill(dt);
                GridMusteriler.DataSource = dt;
           
        }
        void temizle()
        {
            txt_id.Clear();
            txt_adi.Clear();
            txt_soyadi.Clear();
            txt_tc.Clear();
            txt_tel.Clear();
            txt_email.Clear();
            txt_ehliyetno.Clear();
            datetime_EhliyetAlis.Clear();
            txt_adres.Clear();
            txt_kartno.Clear();
            txt_karttarih.Clear();
            txt_kartcvv.Clear();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            musterilerilistele();
            temizle();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_id.Text = dr["müsteri_id"].ToString();
            txt_adi.Text = dr["müsteri_adi"].ToString();
            txt_soyadi.Text = dr["müsteri_soyadi"].ToString();
            txt_tc.Text = dr["müsteri_tc"].ToString();
            txt_tel.Text = dr["müsteri_tel"].ToString();
            txt_email.Text = dr["müsteri_eposta"].ToString();
            txt_ehliyetno.Text = dr["müsteri_ehliyet_no"].ToString();
            datetime_EhliyetAlis.Text = dr["müsteri_ehliyet_alistarih"].ToString();
            txt_adres.Text = dr["müsteri_adres"].ToString();
            txt_kartno.Text = dr["müsteri_kartno"].ToString();
            txt_karttarih.Text = dr["müsteri_karttarih"].ToString();
            txt_kartcvv.Text = dr["müsteri_kartcvv"].ToString();
        }

        private void Btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Müşteri kaydetme 
            bgl.Baglanti();
            SqlCommand kaydetcmd = new SqlCommand("insert into TblMusteriler (müsteri_adi,müsteri_soyadi,müsteri_tc,müsteri_tel,müsteri_eposta,müsteri_ehliyet_no,müsteri_ehliyet_alistarih,müsteri_adres,müsteri_kartno,müsteri_karttarih,müsteri_kartcvv) values" +
                " ('" + txt_adi.Text + "','" + txt_soyadi.Text + "','" + txt_tc.Text + "','"+txt_tel.Text+"','"+txt_email.Text+"','"+txt_ehliyetno.Text+"','"+DateTime.Parse(datetime_EhliyetAlis.Text.ToString())+"','"+txt_adres.Text+"','"+txt_kartno.Text+"','"+txt_karttarih.Text+"','"+txt_kartcvv.Text+"')", bgl.Baglanti());
          
            kaydetcmd.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Müşteri Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            musterilerilistele();
        }
        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            //verileri silme
            //bgl.Baglanti();
            SqlCommand cmdsil = new SqlCommand("delete from TblMusteriler where müsteri_id='" + txt_id.Text + "'", bgl.Baglanti());
            cmdsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musterilerilistele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdupdate = new SqlCommand("update TblMusteriler set müsteri_adi='"+txt_adi.Text+"',müsteri_soyadi='"+txt_soyadi.Text+"',müsteri_tc='"+txt_tc.Text+"',müsteri_tel='"+txt_tel.Text+"',müsteri_eposta='"+txt_email.Text+"',müsteri_ehliyet_no='"+txt_ehliyetno.Text+"',müsteri_ehliyet_alistarih='"+ DateTime.Parse(datetime_EhliyetAlis.Text.ToString()) + "',müsteri_adres='"+txt_adres.Text+"',müsteri_kartno='"+txt_kartno.Text+"',müsteri_karttarih='"+txt_karttarih.Text+"',müsteri_kartcvv='"+txt_kartcvv.Text+"' where müsteri_id='" + txt_id.Text + "'", bgl.Baglanti());
            cmdupdate.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musterilerilistele();
        }

        private void Grpbx_Müsteriİslemler_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}