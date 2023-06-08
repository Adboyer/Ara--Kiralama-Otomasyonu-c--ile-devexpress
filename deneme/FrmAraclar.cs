using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace deneme
{
    public partial class FrmAraclar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAraclar()
        {
            InitializeComponent();
        }
        public void sayfakapat()
        {
            Close();
        }

        ProjeBaglanti bgl = new ProjeBaglanti();
        // public string subeID = "";
        Kiralamaİslemleri kiralamaİslemleri = new Kiralamaİslemleri();
        public async void sorgu()
        {
            try
            {
                //sorgumuzda veri geliyor mu gelmiyor mu kontrol ediyoruz
                string model = q.aracmodel;
                string marka = q.aracmarka;
                string subeid = q.subeID;
                bgl.Baglanti();
                string sorgu = "select * from TblEldekiAraclar where arac_marka='" + marka + "' and arac_model='" + model + "' and sube_id=" + subeid + " and arac_aktifdurum='True'  ";
                SqlCommand cmd = new SqlCommand
                {
                    Connection = bgl.Baglanti(),
                    CommandText = sorgu,
                    CommandType = CommandType.Text
                };
                SqlDataReader _reader = cmd.ExecuteReader();

                if (!_reader.HasRows)
                {
                    MessageBox.Show("Seçtiğiniz Araç Belirttiğiniz Şubede Mevcut Değildir !!!", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    FrmAracSecme aracSecme = new FrmAracSecme();
                    aracSecme.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        //formu bu şekilde çağırırsak formun içindeki tüm herşeye ulaşırız
        FrmGiris q = (FrmGiris)Application.OpenForms["FrmGiris"];
        void aracbilgileri(string aracmarka, string aracmodel)
        {
            try
            {
                q.aracmarka = aracmarka;
                q.aracmodel = aracmodel;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        private void FrmAraclar_Load(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                if (q.rbnlbl_personelturu.Caption == "Müşteri")
                {
                    btn_geri.Visible = true;
                }
                else
                {
                    btn_geri.Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void BtnSayfaSayisi2_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void BtnSayfaSayisi3_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl24.Text, labelControl290.Text);
            sorgu();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl27.Text, labelControl291.Text);
            sorgu();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl39.Text, labelControl292.Text);
            sorgu();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl51.Text, labelControl296.Text);
            sorgu();
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl231.Text, labelControl293.Text);
            sorgu();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl3.Text, labelControl294.Text);
            sorgu();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl63.Text, labelControl295.Text);
            sorgu();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl75.Text, labelControl297.Text);
            sorgu();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl88.Text, labelControl298.Text);
            sorgu();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl112.Text, labelControl299.Text);
            sorgu();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl124.Text, labelControl300.Text);
            sorgu();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl136.Text, labelControl301.Text);
            sorgu();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl100.Text, labelControl302.Text);
            sorgu();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl160.Text, labelControl303.Text);
            sorgu();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl172.Text, labelControl304.Text);
            sorgu();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl148.Text, labelControl305.Text);
            sorgu();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl184.Text, labelControl306.Text);
            sorgu();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl208.Text, labelControl307.Text);
            sorgu();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl220.Text, labelControl308.Text);
            sorgu();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl244.Text, labelControl309.Text);
            sorgu();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl196.Text, labelControl310.Text);
            sorgu();
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl268.Text, labelControl311.Text);
            sorgu();
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl280.Text, labelControl312.Text);
            sorgu();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            aracbilgileri(labelControl256.Text, labelControl313.Text);
            sorgu();
        }

        private void txt_geri_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                q.anasayfacagır();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata :" + Environment.NewLine + ex.ToString());
            }

        }
    }
}