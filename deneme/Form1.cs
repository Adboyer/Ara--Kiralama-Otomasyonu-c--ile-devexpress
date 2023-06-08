using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace deneme
{
    public partial class FrmGiris : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        FrmAnasayfa anasayfa;
        FrmKiralanabilirAraclar kiralanabilirAraclar;
        FrmMusteriler musteriler;
        FrmSube subeler;
        FrmAraclar araclar;
        FrmKiradakiAraclar kiradakiaraclar;
        FrmBitmisKiralamalar bitmiskiralamalar;
        FrmPersonel personel;
        FrmHakkında hakkında;
        Frmiletisim iletisim;
        FrmYardım yardım;
        FrmKvk kvk;
        public void Musteriyetki()
        {
            try
            {
                ustpanel.Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }
        public void personelyetki()
        {
            try
            {
                ustpanel.Visible = true;
                rbn_yonetici.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }


        }
        public void yoneticiyetki()
        {
            try
            {
                ustpanel.Visible = true;
                rbn_yonetici.Visible = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }

        #region MdiFormKontrol Metodu
        //açılacak formları açık mı değil mi kontrol eden metod
        public void FormKontrol(Form fr, string e)
        {
            bool durum = false;
            try
            {
                foreach (Form main in MdiChildren)
                {
                    if (main.Text == fr.Text)
                    {
                        durum = true;
                        main.Activate();
                        DialogResult ok = XtraMessageBox.Show(main.Text + " Formu Açık Durumda !", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (ok == DialogResult.OK)
                        {
                            main.WindowState = FormWindowState.Maximized;
                            main.Tag = e;
                            main.Show();
                        }
                    }
                }
                if (durum == false)
                {
                    fr.MdiParent = this;
                    fr.Tag = e;
                    fr.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }
        #endregion

        public string subeID = "";
        public int personelid = 0;
        public string aracinalindigisube = string.Empty;
        public string aracinbirakilacaksube = string.Empty;
        public string alistarih = string.Empty;
        public string iadetarih = string.Empty;
        public string aracmarka = string.Empty;
        public string aracmodel = string.Empty;
        public string aracplaka = string.Empty;
        public string gunsayisi = string.Empty;
        public int müsteriid = 0;
        public int gunlukucret = 0;
        public int depozito = 0;


        public void araclarcagır()
        {
            try
            {
                araclar = new FrmAraclar();
                FormKontrol(araclar, "Araçlar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        public void müsteridekiaraclar()
        {
            try
            {
                kiradakiaraclar = new FrmKiradakiAraclar();
                FormKontrol(kiradakiaraclar, "Araçlar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }
        public void musterilercagır()
        {
            try
            {
                musteriler = new FrmMusteriler();
                FormKontrol(musteriler, "Müşteriler");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        public void anasayfacagır()
        {
            try
            {
                anasayfa = new FrmAnasayfa();
                FormKontrol(anasayfa, "Anasayfa");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        public void araclarcagır(string subeIDD)
        {
            try
            {
                araclar = new FrmAraclar
                {
                    // subeID = subeID
                };
                subeID = subeIDD;
                FormKontrol(araclar, "Araçlar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                anasayfa = new FrmAnasayfa();
                FormKontrol(anasayfa, "Anasayfa");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                anasayfacagır();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }


        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                musterilercagır();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        public void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                araclar = new FrmAraclar();
                FormKontrol(araclar, "Araçlar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        public void BtnKiralanabilirAraclar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                kiralanabilirAraclar = new FrmKiralanabilirAraclar();
                FormKontrol(kiralanabilirAraclar, "Kiralanabilir Araçlarımız");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void BtnSubeislemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                subeler = new FrmSube();
                FormKontrol(subeler, "Şubeler");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void BtnKiralananAraclar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                müsteridekiaraclar();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bitmiskiralamalar = new FrmBitmisKiralamalar();
                FormKontrol(bitmiskiralamalar, "Bitmiş Kiralamalar");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void ustpanel_Click(object sender, EventArgs e)
        {

        }

        private void rbnlbl_personeladi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                personel = new FrmPersonel();
                FormKontrol(personel, "Personellerimiz");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void BtnHakkında_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                hakkında = new FrmHakkında();
                FormKontrol(hakkında, "Hakkında");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }

        private void Btniletisim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                iletisim = new Frmiletisim();
                FormKontrol(iletisim, "İletişim");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                yardım = new FrmYardım();
                FormKontrol(yardım, "Yardım");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                kvk = new FrmKvk();
                FormKontrol(kvk, "Kvk");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }
        }
    }
}
