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
using DevExpress.XtraBars.ViewInfo;

namespace deneme
{
    public partial class FrmKiralanabilirAraclar : DevExpress.XtraEditors.XtraForm
    {
        public FrmKiralanabilirAraclar()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        void araclarlistele()
        {
            //datagride verileri sql den alma
            if (cmb_sube.Text == "" || cmb_sube.Text == "Tümü")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblEldekiAraclar", bgl.Baglanti());
                da.Fill(dt);
                GridAraclar.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblEldekiAraclar where sube_id='" + cmb_sube.SelectedIndex + "'", bgl.Baglanti());
                da.Fill(dt);
                GridAraclar.DataSource = dt;
            }


        }
        void temizle()
        {
            cmb_sube.Text = "";
            label1.Text="";
            txt_plaka.Clear();
            cmb_yakit.Text = "";
            cmb_vites.Text = "";
            txt_marka.Clear();
            txt_model.Clear();
            txt_gunlukucret.Clear();
            txt_depozito.Clear();
            txt_mevcutkm.Clear();
            txt_bakimkm.Clear();

        }
        void combobaxlistele()
        {
            //combobaxa subeleleri atama
            bgl.Baglanti();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM TblSubeler";
            komut.Connection = bgl.Baglanti();
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_sube.Items.Add(dr["sube_ilce"]);


            }
        }
        private void FrmKiralanabilirAraclar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracKiralamaDataSet1.TblSubeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSubelerTableAdapter1.Fill(this.aracKiralamaDataSet1.TblSubeler);
            // TODO: Bu kod satırı 'aracKiralamaDataSet.TblSubeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSubelerTableAdapter.Fill(this.aracKiralamaDataSet.TblSubeler);
            araclarlistele();
            combobaxlistele();
            temizle();



        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            araclarlistele();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            araclarlistele();


        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //dtagriddeki verileri textboxalara yerleştirme
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            cmb_sube.Text = dr["sube_id"].ToString();

            txt_plaka.Text = dr["arac_plaka"].ToString();
            cmb_yakit.Text = dr["arac_yakitturu"].ToString();
            cmb_vites.Text = dr["arac_vitestipi"].ToString();
            txt_marka.Text = dr["arac_marka"].ToString();
            txt_model.Text = dr["arac_model"].ToString();
            txt_gunlukucret.Text = dr["arac_gunlukucret"].ToString();
            txt_depozito.Text = dr["arac_depozito"].ToString();
            txt_mevcutkm.Text = dr["arac_km"].ToString();
            txt_bakimkm.Text = dr["arac_bakimkm"].ToString();
            // SqlCommand cmd = new SqlCommand("select * from TblEldekiAraclar inner join TblSubeler on TblEldekiAraclar.sube_id=TblSubeler.sube_id where arac_plaka='" + txt_plaka + "'");

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //combobaxın verisini alma
            label1.Text = cmb_sube.SelectedIndex.ToString();
            //verileri kaydetme 
            bgl.Baglanti();
            SqlCommand kaydetcmd = new SqlCommand("insert into TblEldekiAraclar (arac_plaka,arac_yakitturu,arac_vitestipi,arac_marka,arac_model,sube_id,arac_gunlukucret,arac_depozito,arac_km,arac_bakimkm) values" +
                " ('"+txt_plaka.Text+"','"+cmb_yakit.Text+"','"+cmb_vites.Text+"','"+txt_marka.Text+"','"+txt_model.Text+"','"+int.Parse((label1.Text).ToString())+"','"+int.Parse((txt_gunlukucret.Text).ToString())+"','"+int.Parse((txt_depozito.Text).ToString())+"','"+int.Parse((txt_mevcutkm.Text).ToString())+"','"+int.Parse((txt_bakimkm.Text).ToString())+"')", bgl.Baglanti());
            kaydetcmd.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Araç Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            araclarlistele();


        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            //verileri silme
            //bgl.Baglanti();
            SqlCommand cmdsil = new SqlCommand("delete from TblEldekiAraclar where arac_plaka='"+txt_plaka.Text+"'", bgl.Baglanti());
            cmdsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Araç Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            araclarlistele();


        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdupdate = new SqlCommand("update TblEldekiAraclar set arac_plaka='"+txt_plaka.Text+"',arac_yakitturu='"+cmb_yakit.Text+"',arac_vitestipi='"+cmb_vites.Text+"',arac_marka='"+txt_marka.Text+"',arac_model='"+txt_model.Text+"',sube_id='"+int.Parse((cmb_sube.SelectedIndex).ToString())+"',arac_gunlukucret='"+int.Parse((txt_gunlukucret.Text).ToString())+"',arac_depozito='"+int.Parse((txt_depozito.Text).ToString())+"',arac_km='"+int.Parse((txt_mevcutkm.Text).ToString())+"',arac_bakimkm='"+int.Parse((txt_bakimkm.Text).ToString())+"' where arac_plaka='"+txt_plaka.Text+"'", bgl.Baglanti());
            cmdupdate.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Araç Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            araclarlistele();

        }

        private void Btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}