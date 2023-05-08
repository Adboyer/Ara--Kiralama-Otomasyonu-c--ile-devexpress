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
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmAnasayfa anasayfa;
        public void formcagir()
        {
            if (anasayfa == null)
            {
                anasayfa = new FrmAnasayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();

            }
        }
    private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formcagir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
