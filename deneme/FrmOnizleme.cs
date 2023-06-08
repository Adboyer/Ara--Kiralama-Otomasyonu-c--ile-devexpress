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
using DevExpress.XtraLayout.Filtering.Templates;

namespace deneme
{
    public partial class FrmOnizleme : DevExpress.XtraEditors.XtraForm
    {
        public FrmOnizleme()
        {
            InitializeComponent();
        }
        FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
        FrmAraclar k = (FrmAraclar)Application.OpenForms["FrmAraclar"];
        FrmMusteriler m = (FrmMusteriler)Application.OpenForms["FrmMusteriler"];
        private void FrmOnizleme_Load(object sender, EventArgs e)
        {
            try
            {
                txt_aracinalindigisube.Text = q.aracinalindigisube;
                txt_birakilacagisube.Text = q.aracinbirakilacaksube;
                txt_baslamatarih.Text = q.alistarih.ToString();
                txt_bitistarih.Text = q.iadetarih.ToString();
                txt_aracplaka.Text = q.aracplaka.ToString();
                txt_aracmarka.Text = q.aracmarka;
                txt_aracmodel.Text = q.aracmodel;
                txt_gunsayisi.Text = q.gunsayisi.ToString();
                txt_gunlukucret.Text = q.gunlukucret.ToString();
                txt_depozito.Text = q.depozito.ToString();


                int kiralamaucreti = (Convert.ToInt32(q.gunsayisi)) * (Convert.ToInt32(q.gunlukucret));
                txt_kiralamaucreti.Text = kiralamaucreti.ToString();

                int toplamucret = (Convert.ToInt32(q.depozito)) + kiralamaucreti;
                txt_alinicaktoplamucret.Text = toplamucret.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }

        private void tarihDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            q.anasayfacagır();
        }

        private void aracıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            q.araclarcagır();
        }

        private void müşteriBilgileriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            q.musterilercagır();
        }

        ProjeBaglanti bgl = new ProjeBaglanti();

        private void ödemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int müsteriid = q.müsteriid;
                int subeid = Convert.ToInt32(q.subeID);
                int personelid = Convert.ToInt32(q.personelid);
                int depozito = Convert.ToInt32(txt_depozito.Text);
                int gunsayisi = Convert.ToInt32(txt_gunsayisi.Text);
                int alinicakucret = Convert.ToInt32(txt_alinicaktoplamucret.Text);


                if (txt_aracplaka.Text == null || txt_alinicaktoplamucret.Text == null || Convert.ToInt32(txt_gunsayisi.Text) >= 0)
                {
                    //Kiralama İşlemi kaydetme 
                    bgl.Baglanti();
                    SqlCommand kaydetcmd = new SqlCommand("insert into TblKiradakiAraclar (müsteri_id,arac_plaka,sube_id,personel_id,kiralama_baslamatarih,kiralama_bitistarih,kiralama_alinandepozito,kiralama_günsayisi,kiralama_alinanücret,kiralama_acıklama,kiradurum) values ('" + müsteriid + "','" + txt_aracplaka.Text.ToString() + "','" + subeid + "','" + personelid + "','" + txt_baslamatarih.Text.ToString() + "','" + txt_bitistarih.Text.ToString() + "','" + depozito + "','" + gunsayisi + "','" + alinicakucret + "','" + txt_acıklama.Text.ToString() + "','True')", bgl.Baglanti());
                    kaydetcmd.ExecuteNonQuery();

                    //kullanılan aracın diğer tabloda pasif hale getir
                    SqlCommand arackontrol = new SqlCommand("UPDATE TblEldekiAraclar SET arac_aktifdurum='False' WHERE arac_plaka='" + txt_aracplaka.Text + "'", bgl.Baglanti());
                    arackontrol.ExecuteNonQuery();

                    bgl.Baglanti().Close();
                    MessageBox.Show("Kiralama Gerçekleşti Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    if (q.rbnlbl_personelturu.Caption != "Müşteri")
                    {
                        m.sayfakapat();
                    }

                    q.anasayfacagır();
                }
                else
                {
                    MessageBox.Show("Lütfen Bilgileri Kontrol Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
    }
}