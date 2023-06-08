namespace deneme
{
    partial class FrmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.GridMusteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grpbx_Müsteriİslemler = new DevExpress.XtraEditors.GroupControl();
            this.txt_ehliyetno = new System.Windows.Forms.MaskedTextBox();
            this.txt_kartno = new System.Windows.Forms.MaskedTextBox();
            this.txt_karttarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_kartcvv = new System.Windows.Forms.MaskedTextBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.datetime_EhliyetAlis = new DevExpress.XtraEditors.DateEdit();
            this.Btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_kartcvv = new System.Windows.Forms.Label();
            this.lbl_karttarih = new System.Windows.Forms.Label();
            this.lbl_kartno = new System.Windows.Forms.Label();
            this.txt_adres = new DevExpress.XtraEditors.TextEdit();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_ehliyetAlisTarih = new System.Windows.Forms.Label();
            this.lbl_ehliyetno = new System.Windows.Forms.Label();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.txt_soyadi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.txt_adi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grpbx_Müsteriİslemler)).BeginInit();
            this.Grpbx_Müsteriİslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_EhliyetAlis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_EhliyetAlis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMusteriler
            // 
            this.GridMusteriler.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridMusteriler.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GridMusteriler.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.GridMusteriler.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            this.GridMusteriler.Location = new System.Drawing.Point(14, 12);
            this.GridMusteriler.MainView = this.gridView1;
            this.GridMusteriler.Name = "GridMusteriler";
            this.GridMusteriler.Size = new System.Drawing.Size(1451, 860);
            this.GridMusteriler.TabIndex = 0;
            this.GridMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GridMusteriler.DoubleClick += new System.EventHandler(this.GridMusteriler_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.GridMusteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Müşteri Id";
            this.gridColumn6.FieldName = "müsteri_id";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Müşteri Adı";
            this.gridColumn1.FieldName = "müsteri_adi";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Soyadı";
            this.gridColumn2.FieldName = "müsteri_soyadi";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TC";
            this.gridColumn3.FieldName = "müsteri_tc";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "E-mail";
            this.gridColumn4.FieldName = "müsteri_eposta";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ehliyet No";
            this.gridColumn7.FieldName = "müsteri_ehliyet_no";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ehliyet Alış Tarihi";
            this.gridColumn8.FieldName = "müsteri_ehliyet_alistarih";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Adres";
            this.gridColumn5.FieldName = "müsteri_adres";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Kart no";
            this.gridColumn9.FieldName = "müsteri_kartno";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Kart Tarih";
            this.gridColumn10.FieldName = "müsteri_karttarih";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Width = 94;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Kart CVV";
            this.gridColumn11.FieldName = "müsteri_kartcvv";
            this.gridColumn11.MinWidth = 25;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Width = 94;
            // 
            // Grpbx_Müsteriİslemler
            // 
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_ehliyetno);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_kartno);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_karttarih);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_kartcvv);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_tel);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_tc);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.datetime_EhliyetAlis);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.Btn_temizle);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_kartcvv);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_karttarih);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_kartno);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_adres);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_adres);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_ehliyetAlisTarih);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_ehliyetno);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_email);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_email);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_tel);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_tc);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_soyadi);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_soyadi);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_adi);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_adi);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.Btn_Guncelle);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.Btn_Sil);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.Btn_Kaydet);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.txt_id);
            this.Grpbx_Müsteriİslemler.Controls.Add(this.lbl_id);
            this.Grpbx_Müsteriİslemler.Location = new System.Drawing.Point(1469, 12);
            this.Grpbx_Müsteriİslemler.Name = "Grpbx_Müsteriİslemler";
            this.Grpbx_Müsteriİslemler.Size = new System.Drawing.Size(440, 860);
            this.Grpbx_Müsteriİslemler.TabIndex = 4;
            this.Grpbx_Müsteriİslemler.Text = "Müşteri Bilgileri";
            this.Grpbx_Müsteriİslemler.Paint += new System.Windows.Forms.PaintEventHandler(this.Grpbx_Müsteriİslemler_Paint);
            // 
            // txt_ehliyetno
            // 
            this.txt_ehliyetno.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_ehliyetno.Location = new System.Drawing.Point(169, 267);
            this.txt_ehliyetno.Mask = "0000000000";
            this.txt_ehliyetno.Name = "txt_ehliyetno";
            this.txt_ehliyetno.Size = new System.Drawing.Size(220, 35);
            this.txt_ehliyetno.TabIndex = 52;
            // 
            // txt_kartno
            // 
            this.txt_kartno.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_kartno.Location = new System.Drawing.Point(167, 390);
            this.txt_kartno.Mask = "0000000000000000";
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(222, 35);
            this.txt_kartno.TabIndex = 51;
            // 
            // txt_karttarih
            // 
            this.txt_karttarih.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_karttarih.Location = new System.Drawing.Point(167, 429);
            this.txt_karttarih.Mask = "00-00";
            this.txt_karttarih.Name = "txt_karttarih";
            this.txt_karttarih.Size = new System.Drawing.Size(80, 35);
            this.txt_karttarih.TabIndex = 50;
            // 
            // txt_kartcvv
            // 
            this.txt_kartcvv.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_kartcvv.Location = new System.Drawing.Point(167, 470);
            this.txt_kartcvv.Mask = "000";
            this.txt_kartcvv.Name = "txt_kartcvv";
            this.txt_kartcvv.Size = new System.Drawing.Size(52, 35);
            this.txt_kartcvv.TabIndex = 49;
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_tel.Location = new System.Drawing.Point(167, 187);
            this.txt_tel.Mask = "00000000000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(222, 35);
            this.txt_tel.TabIndex = 48;
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_tc.Location = new System.Drawing.Point(167, 148);
            this.txt_tc.Mask = "00000000000";
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(222, 35);
            this.txt_tc.TabIndex = 5;
            // 
            // datetime_EhliyetAlis
            // 
            this.datetime_EhliyetAlis.EditValue = null;
            this.datetime_EhliyetAlis.Location = new System.Drawing.Point(167, 310);
            this.datetime_EhliyetAlis.Name = "datetime_EhliyetAlis";
            this.datetime_EhliyetAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.datetime_EhliyetAlis.Properties.Appearance.Options.UseFont = true;
            this.datetime_EhliyetAlis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetime_EhliyetAlis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetime_EhliyetAlis.Size = new System.Drawing.Size(222, 34);
            this.datetime_EhliyetAlis.TabIndex = 47;
            // 
            // Btn_temizle
            // 
            this.Btn_temizle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_temizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_temizle.Appearance.Options.UseBackColor = true;
            this.Btn_temizle.Appearance.Options.UseFont = true;
            this.Btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_temizle.ImageOptions.Image")));
            this.Btn_temizle.Location = new System.Drawing.Point(317, 578);
            this.Btn_temizle.Name = "Btn_temizle";
            this.Btn_temizle.Size = new System.Drawing.Size(38, 50);
            this.Btn_temizle.TabIndex = 46;
            this.Btn_temizle.Click += new System.EventHandler(this.Btn_temizle_Click);
            // 
            // lbl_kartcvv
            // 
            this.lbl_kartcvv.AutoSize = true;
            this.lbl_kartcvv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kartcvv.Location = new System.Drawing.Point(85, 476);
            this.lbl_kartcvv.Name = "lbl_kartcvv";
            this.lbl_kartcvv.Size = new System.Drawing.Size(87, 21);
            this.lbl_kartcvv.TabIndex = 44;
            this.lbl_kartcvv.Text = "Kart CVV :";
            // 
            // lbl_karttarih
            // 
            this.lbl_karttarih.AutoSize = true;
            this.lbl_karttarih.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_karttarih.Location = new System.Drawing.Point(70, 436);
            this.lbl_karttarih.Name = "lbl_karttarih";
            this.lbl_karttarih.Size = new System.Drawing.Size(95, 21);
            this.lbl_karttarih.TabIndex = 42;
            this.lbl_karttarih.Text = "Kart Tarih :";
            // 
            // lbl_kartno
            // 
            this.lbl_kartno.AutoSize = true;
            this.lbl_kartno.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kartno.Location = new System.Drawing.Point(88, 396);
            this.lbl_kartno.Name = "lbl_kartno";
            this.lbl_kartno.Size = new System.Drawing.Size(77, 21);
            this.lbl_kartno.TabIndex = 40;
            this.lbl_kartno.Text = "Kart No :";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(167, 350);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_adres.Properties.Appearance.Options.UseFont = true;
            this.txt_adres.Size = new System.Drawing.Size(222, 34);
            this.txt_adres.TabIndex = 39;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(100, 356);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(64, 21);
            this.lbl_adres.TabIndex = 38;
            this.lbl_adres.Text = "Adres :";
            // 
            // lbl_ehliyetAlisTarih
            // 
            this.lbl_ehliyetAlisTarih.AutoSize = true;
            this.lbl_ehliyetAlisTarih.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ehliyetAlisTarih.Location = new System.Drawing.Point(29, 316);
            this.lbl_ehliyetAlisTarih.Name = "lbl_ehliyetAlisTarih";
            this.lbl_ehliyetAlisTarih.Size = new System.Drawing.Size(135, 21);
            this.lbl_ehliyetAlisTarih.TabIndex = 36;
            this.lbl_ehliyetAlisTarih.Text = "Ehliyet A. Tarih :";
            // 
            // lbl_ehliyetno
            // 
            this.lbl_ehliyetno.AutoSize = true;
            this.lbl_ehliyetno.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ehliyetno.Location = new System.Drawing.Point(67, 276);
            this.lbl_ehliyetno.Name = "lbl_ehliyetno";
            this.lbl_ehliyetno.Size = new System.Drawing.Size(96, 21);
            this.lbl_ehliyetno.TabIndex = 34;
            this.lbl_ehliyetno.Text = "Ehliyet No :";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(167, 230);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_email.Properties.Appearance.Options.UseFont = true;
            this.txt_email.Size = new System.Drawing.Size(222, 34);
            this.txt_email.TabIndex = 33;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(94, 235);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(68, 21);
            this.lbl_email.TabIndex = 32;
            this.lbl_email.Text = "E-mail :";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel.Location = new System.Drawing.Point(119, 196);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(44, 21);
            this.lbl_tel.TabIndex = 30;
            this.lbl_tel.Text = "Tel :";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.Location = new System.Drawing.Point(122, 156);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(41, 21);
            this.lbl_tc.TabIndex = 28;
            this.lbl_tc.Text = "TC :";
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(167, 110);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_soyadi.Properties.Appearance.Options.UseFont = true;
            this.txt_soyadi.Size = new System.Drawing.Size(222, 34);
            this.txt_soyadi.TabIndex = 27;
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadi.Location = new System.Drawing.Point(94, 115);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(69, 21);
            this.lbl_soyadi.TabIndex = 26;
            this.lbl_soyadi.Text = "Soyadı :\r\n";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(167, 70);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_adi.Size = new System.Drawing.Size(222, 34);
            this.txt_adi.TabIndex = 25;
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adi.Location = new System.Drawing.Point(118, 76);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(45, 21);
            this.lbl_adi.TabIndex = 24;
            this.lbl_adi.Text = "Adı :";
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Appearance.Options.UseBackColor = true;
            this.Btn_Guncelle.Appearance.Options.UseFont = true;
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(191, 634);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(164, 50);
            this.Btn_Guncelle.TabIndex = 23;
            this.Btn_Guncelle.Text = "GÜNCELLE";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Appearance.Options.UseBackColor = true;
            this.Btn_Sil.Appearance.Options.UseFont = true;
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(147, 578);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(164, 50);
            this.Btn_Sil.TabIndex = 22;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.Appearance.Options.UseBackColor = true;
            this.Btn_Kaydet.Appearance.Options.UseFont = true;
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(115, 522);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(164, 50);
            this.Btn_Kaydet.TabIndex = 21;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(167, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(222, 34);
            this.txt_id.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_id.Location = new System.Drawing.Point(124, 35);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(36, 21);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Id :";
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 884);
            this.Controls.Add(this.Grpbx_Müsteriİslemler);
            this.Controls.Add(this.GridMusteriler);
            this.Name = "FrmMusteriler";
            this.Text = "Müşterilerimiz";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grpbx_Müsteriİslemler)).EndInit();
            this.Grpbx_Müsteriİslemler.ResumeLayout(false);
            this.Grpbx_Müsteriİslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_EhliyetAlis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_EhliyetAlis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.GroupControl Grpbx_Müsteriİslemler;
        private System.Windows.Forms.Label lbl_kartcvv;
        private System.Windows.Forms.Label lbl_karttarih;
        private System.Windows.Forms.Label lbl_kartno;
        private DevExpress.XtraEditors.TextEdit txt_adres;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_ehliyetAlisTarih;
        private System.Windows.Forms.Label lbl_ehliyetno;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_tc;
        private DevExpress.XtraEditors.TextEdit txt_soyadi;
        private System.Windows.Forms.Label lbl_soyadi;
        private DevExpress.XtraEditors.TextEdit txt_adi;
        private System.Windows.Forms.Label lbl_adi;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private System.Windows.Forms.Label lbl_id;
        private DevExpress.XtraEditors.SimpleButton Btn_temizle;
        private DevExpress.XtraEditors.DateEdit datetime_EhliyetAlis;
        private System.Windows.Forms.MaskedTextBox txt_tc;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.MaskedTextBox txt_ehliyetno;
        private System.Windows.Forms.MaskedTextBox txt_kartno;
        private System.Windows.Forms.MaskedTextBox txt_karttarih;
        private System.Windows.Forms.MaskedTextBox txt_kartcvv;
    }
}