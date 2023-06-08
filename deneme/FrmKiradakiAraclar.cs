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
using deneme.AracKiralamaDataSet1TableAdapters;
using deneme.Models;

namespace deneme
{
    public partial class FrmKiradakiAraclar : DevExpress.XtraEditors.XtraForm
    {
        public FrmKiradakiAraclar()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
        void listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblKiradakiAraclar where kiradurum='True'", bgl.Baglanti());
                da.Fill(dt);
                GridAraclar.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void FrmKiradakiAraclar_Load(object sender, EventArgs e)
        {
            try
            {
                if (q.rbnlbl_personelturu.Caption == "Yönetici")
                {
                    listele();
                    bgl.Baglanti();
                    SqlCommand komut = new SqlCommand("SELECT * FROM TblSubeler", bgl.Baglanti());
                    komut.CommandType = CommandType.Text;
                    SqlDataReader drk;
                    drk = komut.ExecuteReader();
                    while (drk.Read())
                    {
                        cmb_sube.Items.Add(drk["sube_ilce"]);
                    }
                }
                else
                {

                    cmb_sube.Visible = false;
                    lbl_sube.Visible = false;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from TblKiradakiAraclar where kiradurum='True' and sube_id='" + q.rbnlbl_subeid.Caption + "'", bgl.Baglanti());
                    da.Fill(dt);
                    GridAraclar.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }


        }
        private void gridView1_Click(object sender, EventArgs e)
        {


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    txt_aracplaka.Text = dr["arac_plaka"].ToString();
                    txt_baslangıctarih.Text = dr["kiralama_baslamatarih"].ToString();
                    txt_bitistarih.Text = dr["kiralama_bitistarih"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + Environment.NewLine + ex.ToString());
            }

        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                if (dt != DateTime.Parse(txt_bitistarih.Text))
                {
                    DialogResult secenek = MessageBox.Show("Kiralama İşlemi Bitmedi İşleme Devam Edilsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek == DialogResult.Yes)
                    {
                        bgl.Baglanti();
                        //listedeki kontrol
                        SqlCommand kirakontrol = new SqlCommand("UPDATE TblKiradakiAraclar SET kiradurum='False' WHERE arac_plaka='" + txt_aracplaka.Text + "'", bgl.Baglanti());
                        kirakontrol.ExecuteNonQuery();

                        //arac formundaki kontrol
                        SqlCommand arackontrol = new SqlCommand("UPDATE TblEldekiAraclar SET arac_aktifdurum='True' WHERE arac_plaka='" + txt_aracplaka.Text + "'", bgl.Baglanti());
                        arackontrol.ExecuteNonQuery();

                        MessageBox.Show("İşlem Gerçekleşti");
                        listele();

                        bgl.Baglanti().Close();
                    }
                    else if (secenek == DialogResult.No)
                    {
                        txt_aracplaka.Text = "";
                        txt_baslangıctarih.Text = "";
                        txt_bitistarih.Text = "";
                        listele();
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        private void cmb_sube_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //datagride verileri sql den alma
                if (cmb_sube.Text == "" || cmb_sube.Text == "Tümü")
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from TblKiradakiAraclar where kiradurum='True' ", bgl.Baglanti());
                    da.Fill(dt);
                    GridAraclar.DataSource = dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from TblKiradakiAraclar where sube_id='" + cmb_sube.SelectedIndex + "' and kiradurum='True' ", bgl.Baglanti());
                    da.Fill(dt);
                    GridAraclar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
    }
}