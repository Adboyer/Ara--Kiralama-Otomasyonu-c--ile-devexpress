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
using deneme.Models;

namespace deneme
{
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        void personellerilistele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TblPersonel where personeldurum='True'", bgl.Baglanti());
                da.Fill(dt);
                GridPersoneller.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        void combobaxlistele()
        {
            try
            {
                //şubeler için liste oluşturuyor
                List<SubeModel> subeList = new List<SubeModel>();
                //combobaxa subeleleri listeleme
                bgl.Baglanti();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM TblSubeler";
                komut.Connection = bgl.Baglanti();
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    //verileri aktarıp idlerini atıyor 
                    //id lerinide diğer bölmelerde kullanıyor
                    int subeID = (int)dr[0];
                    string subeil = (string)dr[1];
                    string subeilce = (string)dr[2];

                    subeList.Add(new SubeModel { SUBEID = subeID, SUBEIL = subeil, SUBEILCE = subeilce });

                }
                cmb_sube.DataSource = subeList;
                cmb_sube.DisplayMember = "SUBEILCE";
                cmb_sube.ValueMember = "SUBEID";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personellerilistele();
            combobaxlistele();
        }

        private void cmb_sube_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_personelturu.Text == "Personel")
                {
                    int a = Convert.ToInt32(cmb_sube.SelectedIndex);
                    lbl_subeıd.Text = (a + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }


        }
        private void cmb_personelturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_personelturu.Text == "Personel")
                {
                    cmb_sube.Visible = true;
                    lbl_sube.Visible = true;
                    lbl_personelturuid.Text = "1";
                }
                else
                {
                    cmb_sube.Visible = false;
                    lbl_sube.Visible = false;
                    lbl_personelturuid.Text = "2";
                    lbl_subeıd.Text = "0";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void cmb_personelturu_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {

                    txt_id.Text = dr["personel_id"].ToString();
                    txt_adi.Text = dr["personel_adi"].ToString();
                    txt_soyadi.Text = dr["personel_soyadi"].ToString();
                    txt_tel.Text = dr["personel_telefon"].ToString();
                    txt_tc.Text = dr["personel_tc"].ToString();
                    datetime_dogumtarih.Text = dr["personel_dogumtarih"].ToString();
                    txt_email.Text = dr["personel_eposta"].ToString();
                    txt_adres.Text = dr["personel_adres"].ToString();
                    txt_sifre.Text = dr["personel_sifre"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }


        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int subeid = Convert.ToInt32(lbl_subeıd.Text.ToString());
                DateTime dogumtarih = DateTime.Parse(datetime_dogumtarih.Text.ToString());
                char personelturu = Convert.ToChar(lbl_personelturuid.Text.ToString());
                bgl.Baglanti();
                SqlCommand kaydetcmd = new SqlCommand("insert into TblPersonel (personel_adi,personel_soyadi,personel_telefon,personel_tc,personel_dogumtarih,personel_eposta,personel_adres,personel_sifre,sube_id,personelturu,personeldurum) values ('" + txt_adi.Text.ToString() + "','" + txt_soyadi.Text.ToString() + "','" + txt_tel.Text.ToString() + "','" + txt_tc.Text.ToString() + "','" + dogumtarih + "','" + txt_email.Text.ToString() + "','" + txt_adres.Text.ToString() + "','" + txt_sifre.Text.ToString() + "','" + subeid + "','" + personelturu + "','0')", bgl.Baglanti());

                kaydetcmd.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Personel Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdsil = new SqlCommand("update TblPersonel set personeldurum='0' where personel_id='" + txt_id.Text + "'", bgl.Baglanti());
                cmdsil.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                personellerilistele();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdupdate = new SqlCommand("update TblPersonel set personel_adi='" + txt_adi.Text + "',personel_soyadi='" + txt_soyadi.Text + "',personel_telefon='" + txt_tel.Text + "',personel_tc='" + txt_tc.Text + "',personel_dogumtarih='" + DateTime.Parse(datetime_dogumtarih.Text.ToString()) + "',personel_eposta='" + txt_email.Text + "',personel_adres='" + txt_adres.Text + "',personel_sifre='" + txt_sifre.Text + "' where personel_id='" + txt_id.Text + "'", bgl.Baglanti());
                cmdupdate.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Personel Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
    }
}