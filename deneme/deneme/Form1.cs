using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        FrmAraclar araclar;
        FrmKiralanabilirAraclar kiralanabilirAraclar;
        FrmMusteriler musteriler;
        FrmSube subeler;
        public  void anasayfacagir()
        {
            if (anasayfa == null)
            {
                anasayfa = new FrmAnasayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();

            }
        }
        public void araclarcagır()
        {
            if (araclar == null)
            {
                araclar = new FrmAraclar();
                araclar.MdiParent = this;
                araclar.Show();

            }
        }
        public void kiralanabiliraraclarcagır()
        {
            if (kiralanabilirAraclar == null)
            {
                kiralanabilirAraclar = new FrmKiralanabilirAraclar();
                kiralanabilirAraclar.MdiParent = this;
                kiralanabilirAraclar.Show();

            }
        }
        public void musterilercagir()
        {
            if (musteriler == null)
            {
                musteriler = new FrmMusteriler();
                musteriler.MdiParent = this;
                musteriler.Show();

            }
        }
        public void subelercagir()
        {
            if (subeler == null)
            {
                subeler = new FrmSube();
                subeler.MdiParent = this;
                subeler.Show();

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            anasayfacagir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            musterilercagir();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            araclarcagır();
        }

        private void BtnKiralanabilirAraclar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kiralanabiliraraclarcagır();
        }

        private void BtnSubeislemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            subelercagir();
        }
    }
}
