using deneme.Models;
using DevExpress.Utils;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace deneme
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        ProjeBaglanti bgl = new ProjeBaglanti();
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
                cmb_teslimsube.DataSource = subeList;
                cmb_teslimsube.DisplayMember = "SUBEILCE";
                cmb_teslimsube.ValueMember = "SUBEID";

                cmb_iadesube.DataSource = subeList;
                cmb_iadesube.DisplayMember = "SUBEILCE";
                cmb_iadesube.ValueMember = "SUBEID";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            try
            {
                if (q.rbnlbl_personelturu.Caption == "Müşteri")
                {
                    btnClose.Visible = true;
                }
                if (q.rbnlbl_personelturu.Caption == "Personel")
                {
                    cmb_teslimsube.Enabled = false;
                    cmb_iadesube.Enabled = false;
                    combobaxlistele();
                    cmb_iadesube.Text = q.rbnlbl_subeadi.Caption;
                    cmb_teslimsube.Text = q.rbnlbl_subeadi.Caption;
                }

                else
                {
                    combobaxlistele();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }


        Kiralamaİslemleri kiralamaİslemleri = new Kiralamaİslemleri();
        FrmGiris giris = new FrmGiris();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_teslimsube.Text == "" || cmb_iadesube.Text == "" || date_alis.Text == "" || date_teslim.Text == "")
                {
                    XtraMessageBox.Show("Lütfen Bilgileri Kontrol ediniz.", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    kiralamaİslemleri.aracinalindigisube = cmb_teslimsube.SelectedValue.ToString();

                    //Açık Olan Formdaki Okunabilir Herşeyi okuyabilirsin//
                    FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
                    q.araclarcagır(kiralamaİslemleri.aracinalindigisube.ToString());
                    q.aracinalindigisube = cmb_teslimsube.Text;

                    q.aracinbirakilacaksube = cmb_iadesube.Text;
                    q.alistarih = date_alis.Text;
                    q.iadetarih = date_teslim.Text;
                    q.gunsayisi = lbl_gunsayisi.Text;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        public string gunsayisi = "";
        private void date_teslim_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                //kiralanan gün sayısı
                DateTime baslangıctarihi = date_alis.DateTime;
                DateTime bitistarihi = date_teslim.DateTime;
                TimeSpan fark = bitistarihi - baslangıctarihi;
                lbl_gunsayisi.Text = fark.Days.ToString();
                gunsayisi = fark.Days.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

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
    }
}
