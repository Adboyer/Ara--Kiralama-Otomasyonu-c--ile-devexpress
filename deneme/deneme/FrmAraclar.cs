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

namespace deneme
{
    public partial class FrmAraclar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAraclar()
        {
            InitializeComponent();
        }

        private void FrmAraclar_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BtnSayfaSayisi1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSayfaSayisi2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void BtnSayfaSayisi2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void BtnSayfaSayisi3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true ;
        }
    }
}