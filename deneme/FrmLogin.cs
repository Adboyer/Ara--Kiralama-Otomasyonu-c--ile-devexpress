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
using deneme.Models;

namespace deneme
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
        FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        FrmGiris giris = new FrmGiris();
        string subeid;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                string sifre = txt_sifre.Text;
                //subeid = q.rbnlbl_subeid.Caption;
                bgl.Baglanti();
                if (comboBox1.Text == "Müşteri")
                {
                    SqlCommand cmd = new SqlCommand("select * from TblMusteriler where müsteri_tc='" + sifre + "' ", bgl.Baglanti());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        giris.Musteriyetki();
                        giris.rbnlbl_personelturu.Caption = "Müşteri";
                        giris.müsteriid = (int)dr[0];
                        giris.rbnlbl_subeadi.Caption = (string)dr[1];

                        Close();
                        giris.Show();
                    }
                    else
                    {

                        MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (comboBox1.Text == "Personel")
                    {
                        //personelturu=1 ise normal şube personeli
                        SqlCommand cmd = new SqlCommand("select * from TblPersonel where sube_id='" + subeid + "' and personel_sifre='" + sifre + "' and personelturu='1' ", bgl.Baglanti());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            giris.personelyetki();
                            giris.rbnlbl_personelturu.Caption = "Personel";
                            giris.rbnlbl_subeadi.Caption = cmb_sube.Text;
                            giris.personelid = (int)dr[0];
                            giris.rbnlbl_personeladi.Caption = (string)dr[1];
                            Close();
                            giris.Show();
                        }
                        else
                        {

                            MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if (comboBox1.Text == "Yönetici")
                    {
                        //personelturu=0 ise yönetici
                        SqlCommand cmd = new SqlCommand("select * from TblPersonel where sube_id='0 ' and personel_sifre='" + sifre + "' and personelturu='2' ", bgl.Baglanti());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            giris.yoneticiyetki();
                            giris.rbnlbl_personelturu.Caption = "Yönetici";
                            giris.rbnlbl_subeadi.Caption = "Tüm Şubeler";
                            giris.personelid = (int)dr[0];
                            giris.rbnlbl_personeladi.Caption = (string)dr[1];
                            Close();
                            giris.Show();
                        }
                        else
                        {

                            MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Personel")
                {
                    cmb_sube.Visible = true;
                    combobaxlistele();
                }
                else
                {
                    cmb_sube.Visible = false;
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
                int a = Convert.ToInt32(cmb_sube.SelectedIndex);
                giris.rbnlbl_subeid.Caption = (a + 1).ToString();
                subeid = (a + 1).ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
    }
}