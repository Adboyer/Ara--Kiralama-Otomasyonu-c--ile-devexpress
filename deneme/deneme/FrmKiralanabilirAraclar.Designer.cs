namespace deneme
{
    partial class FrmKiralanabilirAraclar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKiralanabilirAraclar));
            this.GridAraclar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_sube = new System.Windows.Forms.ComboBox();
            this.tblSubelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new deneme.AracKiralamaDataSet();
            this.tblSubelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet1 = new deneme.AracKiralamaDataSet1();
            this.tblSubelerTableAdapter = new deneme.AracKiralamaDataSetTableAdapters.TblSubelerTableAdapter();
            this.tblSubelerTableAdapter1 = new deneme.AracKiralamaDataSet1TableAdapters.TblSubelerTableAdapter();
            this.lbl_sube = new System.Windows.Forms.Label();
            this.Grpbx_Aracislemler = new DevExpress.XtraEditors.GroupControl();
            this.Btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_bakimkm = new System.Windows.Forms.Label();
            this.txt_bakimkm = new DevExpress.XtraEditors.TextEdit();
            this.lbl_depozito = new System.Windows.Forms.Label();
            this.lbl_gunlukucret = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.lbl_vites = new System.Windows.Forms.Label();
            this.lbl_mevcutkm = new System.Windows.Forms.Label();
            this.lbl_yakit = new System.Windows.Forms.Label();
            this.txt_mevcutkm = new DevExpress.XtraEditors.TextEdit();
            this.txt_depozito = new DevExpress.XtraEditors.TextEdit();
            this.txt_gunlukucret = new DevExpress.XtraEditors.TextEdit();
            this.txt_model = new DevExpress.XtraEditors.TextEdit();
            this.txt_marka = new DevExpress.XtraEditors.TextEdit();
            this.cmb_vites = new System.Windows.Forms.ComboBox();
            this.cmb_yakit = new System.Windows.Forms.ComboBox();
            this.txt_plaka = new DevExpress.XtraEditors.TextEdit();
            this.lbl_plaka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grpbx_Aracislemler)).BeginInit();
            this.Grpbx_Aracislemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bakimkm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mevcutkm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depozito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gunlukucret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_marka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_plaka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAraclar
            // 
            this.GridAraclar.Location = new System.Drawing.Point(12, 1);
            this.GridAraclar.MainView = this.gridView1;
            this.GridAraclar.Name = "GridAraclar";
            this.GridAraclar.Size = new System.Drawing.Size(1520, 848);
            this.GridAraclar.TabIndex = 0;
            this.GridAraclar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GridAraclar.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn6});
            this.gridView1.GridControl = this.GridAraclar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Araç Plaka";
            this.gridColumn1.FieldName = "arac_plaka";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Yakıt Türü";
            this.gridColumn2.FieldName = "arac_yakitturu";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Vites Tipi";
            this.gridColumn3.FieldName = "arac_vitestipi";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Araç Marka";
            this.gridColumn4.FieldName = "arac_marka";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Araç Model";
            this.gridColumn5.FieldName = "arac_model";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Günlük Ücreti";
            this.gridColumn7.FieldName = "arac_gunlukucret";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Depozito";
            this.gridColumn8.FieldName = "arac_depozito";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Araç Mevcut Km";
            this.gridColumn9.FieldName = "arac_km";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Araç Bakıma Alınıcak Km";
            this.gridColumn10.FieldName = "arac_bakimkm";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            this.gridColumn10.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Şube";
            this.gridColumn6.FieldName = "sube_id";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            this.gridColumn6.Width = 94;
            // 
            // cmb_sube
            // 
            this.cmb_sube.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_sube.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblSubelerBindingSource, "sube_ilce", true));
            this.cmb_sube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sube.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sube.FormattingEnabled = true;
            this.cmb_sube.Items.AddRange(new object[] {
            "Tümü"});
            this.cmb_sube.Location = new System.Drawing.Point(130, 52);
            this.cmb_sube.Name = "cmb_sube";
            this.cmb_sube.Size = new System.Drawing.Size(213, 36);
            this.cmb_sube.TabIndex = 1;
            this.cmb_sube.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmb_sube.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // tblSubelerBindingSource
            // 
            this.tblSubelerBindingSource.DataMember = "TblSubeler";
            this.tblSubelerBindingSource.DataSource = this.aracKiralamaDataSet;
            // 
            // aracKiralamaDataSet
            // 
            this.aracKiralamaDataSet.DataSetName = "AracKiralamaDataSet";
            this.aracKiralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSubelerBindingSource1
            // 
            this.tblSubelerBindingSource1.DataMember = "TblSubeler";
            this.tblSubelerBindingSource1.DataSource = this.aracKiralamaDataSet1;
            // 
            // aracKiralamaDataSet1
            // 
            this.aracKiralamaDataSet1.DataSetName = "AracKiralamaDataSet1";
            this.aracKiralamaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSubelerTableAdapter
            // 
            this.tblSubelerTableAdapter.ClearBeforeFill = true;
            // 
            // tblSubelerTableAdapter1
            // 
            this.tblSubelerTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_sube
            // 
            this.lbl_sube.AutoSize = true;
            this.lbl_sube.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sube.Location = new System.Drawing.Point(64, 58);
            this.lbl_sube.Name = "lbl_sube";
            this.lbl_sube.Size = new System.Drawing.Size(62, 21);
            this.lbl_sube.TabIndex = 2;
            this.lbl_sube.Text = "Şube : ";
            // 
            // Grpbx_Aracislemler
            // 
            this.Grpbx_Aracislemler.Controls.Add(this.Btn_temizle);
            this.Grpbx_Aracislemler.Controls.Add(this.label1);
            this.Grpbx_Aracislemler.Controls.Add(this.Btn_Guncelle);
            this.Grpbx_Aracislemler.Controls.Add(this.Btn_Sil);
            this.Grpbx_Aracislemler.Controls.Add(this.Btn_Kaydet);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_bakimkm);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_bakimkm);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_depozito);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_gunlukucret);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_model);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_marka);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_vites);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_mevcutkm);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_yakit);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_mevcutkm);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_depozito);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_gunlukucret);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_model);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_marka);
            this.Grpbx_Aracislemler.Controls.Add(this.cmb_vites);
            this.Grpbx_Aracislemler.Controls.Add(this.cmb_yakit);
            this.Grpbx_Aracislemler.Controls.Add(this.txt_plaka);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_plaka);
            this.Grpbx_Aracislemler.Controls.Add(this.cmb_sube);
            this.Grpbx_Aracislemler.Controls.Add(this.lbl_sube);
            this.Grpbx_Aracislemler.Location = new System.Drawing.Point(1538, 1);
            this.Grpbx_Aracislemler.Name = "Grpbx_Aracislemler";
            this.Grpbx_Aracislemler.Size = new System.Drawing.Size(370, 848);
            this.Grpbx_Aracislemler.TabIndex = 3;
            this.Grpbx_Aracislemler.Text = "Araç İşlemleri";
            this.Grpbx_Aracislemler.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Btn_temizle
            // 
            this.Btn_temizle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_temizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_temizle.Appearance.Options.UseBackColor = true;
            this.Btn_temizle.Appearance.Options.UseFont = true;
            this.Btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_temizle.ImageOptions.Image")));
            this.Btn_temizle.Location = new System.Drawing.Point(263, 531);
            this.Btn_temizle.Name = "Btn_temizle";
            this.Btn_temizle.Size = new System.Drawing.Size(38, 50);
            this.Btn_temizle.TabIndex = 25;
            this.Btn_temizle.Click += new System.EventHandler(this.Btn_temizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(346, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cmboxid";
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Appearance.Options.UseBackColor = true;
            this.Btn_Guncelle.Appearance.Options.UseFont = true;
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(137, 587);
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
            this.Btn_Sil.Location = new System.Drawing.Point(93, 531);
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
            this.Btn_Kaydet.Location = new System.Drawing.Point(57, 475);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(164, 50);
            this.Btn_Kaydet.TabIndex = 21;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // lbl_bakimkm
            // 
            this.lbl_bakimkm.AutoSize = true;
            this.lbl_bakimkm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakimkm.Location = new System.Drawing.Point(27, 424);
            this.lbl_bakimkm.Name = "lbl_bakimkm";
            this.lbl_bakimkm.Size = new System.Drawing.Size(95, 21);
            this.lbl_bakimkm.TabIndex = 20;
            this.lbl_bakimkm.Text = "Bakım Km :";
            // 
            // txt_bakimkm
            // 
            this.txt_bakimkm.Location = new System.Drawing.Point(130, 418);
            this.txt_bakimkm.Name = "txt_bakimkm";
            this.txt_bakimkm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_bakimkm.Properties.Appearance.Options.UseFont = true;
            this.txt_bakimkm.Size = new System.Drawing.Size(213, 34);
            this.txt_bakimkm.TabIndex = 19;
            // 
            // lbl_depozito
            // 
            this.lbl_depozito.AutoSize = true;
            this.lbl_depozito.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_depozito.Location = new System.Drawing.Point(34, 346);
            this.lbl_depozito.Name = "lbl_depozito";
            this.lbl_depozito.Size = new System.Drawing.Size(87, 21);
            this.lbl_depozito.TabIndex = 18;
            this.lbl_depozito.Text = "Depozito :";
            // 
            // lbl_gunlukucret
            // 
            this.lbl_gunlukucret.AutoSize = true;
            this.lbl_gunlukucret.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunlukucret.Location = new System.Drawing.Point(2, 303);
            this.lbl_gunlukucret.Name = "lbl_gunlukucret";
            this.lbl_gunlukucret.Size = new System.Drawing.Size(121, 21);
            this.lbl_gunlukucret.TabIndex = 17;
            this.lbl_gunlukucret.Text = "Günlük Ücret : ";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_model.Location = new System.Drawing.Point(57, 263);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(65, 21);
            this.lbl_model.TabIndex = 16;
            this.lbl_model.Text = "Model :";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_marka.Location = new System.Drawing.Point(58, 223);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(66, 21);
            this.lbl_marka.TabIndex = 15;
            this.lbl_marka.Text = "Marka :";
            // 
            // lbl_vites
            // 
            this.lbl_vites.AutoSize = true;
            this.lbl_vites.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vites.Location = new System.Drawing.Point(34, 183);
            this.lbl_vites.Name = "lbl_vites";
            this.lbl_vites.Size = new System.Drawing.Size(90, 21);
            this.lbl_vites.TabIndex = 14;
            this.lbl_vites.Text = "Vites Tipi :";
            // 
            // lbl_mevcutkm
            // 
            this.lbl_mevcutkm.AutoSize = true;
            this.lbl_mevcutkm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mevcutkm.Location = new System.Drawing.Point(19, 385);
            this.lbl_mevcutkm.Name = "lbl_mevcutkm";
            this.lbl_mevcutkm.Size = new System.Drawing.Size(103, 21);
            this.lbl_mevcutkm.TabIndex = 13;
            this.lbl_mevcutkm.Text = "Mevcut Km :";
            // 
            // lbl_yakit
            // 
            this.lbl_yakit.AutoSize = true;
            this.lbl_yakit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yakit.Location = new System.Drawing.Point(27, 140);
            this.lbl_yakit.Name = "lbl_yakit";
            this.lbl_yakit.Size = new System.Drawing.Size(97, 21);
            this.lbl_yakit.TabIndex = 12;
            this.lbl_yakit.Text = "Yakıt Türü :";
            // 
            // txt_mevcutkm
            // 
            this.txt_mevcutkm.Location = new System.Drawing.Point(130, 378);
            this.txt_mevcutkm.Name = "txt_mevcutkm";
            this.txt_mevcutkm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_mevcutkm.Properties.Appearance.Options.UseFont = true;
            this.txt_mevcutkm.Size = new System.Drawing.Size(213, 34);
            this.txt_mevcutkm.TabIndex = 11;
            // 
            // txt_depozito
            // 
            this.txt_depozito.Location = new System.Drawing.Point(130, 338);
            this.txt_depozito.Name = "txt_depozito";
            this.txt_depozito.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_depozito.Properties.Appearance.Options.UseFont = true;
            this.txt_depozito.Size = new System.Drawing.Size(213, 34);
            this.txt_depozito.TabIndex = 10;
            // 
            // txt_gunlukucret
            // 
            this.txt_gunlukucret.Location = new System.Drawing.Point(130, 298);
            this.txt_gunlukucret.Name = "txt_gunlukucret";
            this.txt_gunlukucret.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_gunlukucret.Properties.Appearance.Options.UseFont = true;
            this.txt_gunlukucret.Size = new System.Drawing.Size(213, 34);
            this.txt_gunlukucret.TabIndex = 9;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(130, 258);
            this.txt_model.Name = "txt_model";
            this.txt_model.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_model.Properties.Appearance.Options.UseFont = true;
            this.txt_model.Size = new System.Drawing.Size(213, 34);
            this.txt_model.TabIndex = 8;
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(130, 218);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_marka.Properties.Appearance.Options.UseFont = true;
            this.txt_marka.Size = new System.Drawing.Size(213, 34);
            this.txt_marka.TabIndex = 7;
            // 
            // cmb_vites
            // 
            this.cmb_vites.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_vites.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblSubelerBindingSource, "sube_ilce", true));
            this.cmb_vites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vites.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_vites.FormattingEnabled = true;
            this.cmb_vites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.cmb_vites.Location = new System.Drawing.Point(130, 176);
            this.cmb_vites.Name = "cmb_vites";
            this.cmb_vites.Size = new System.Drawing.Size(213, 36);
            this.cmb_vites.TabIndex = 6;
            // 
            // cmb_yakit
            // 
            this.cmb_yakit.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_yakit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblSubelerBindingSource, "sube_ilce", true));
            this.cmb_yakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yakit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_yakit.FormattingEnabled = true;
            this.cmb_yakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin"});
            this.cmb_yakit.Location = new System.Drawing.Point(130, 134);
            this.cmb_yakit.Name = "cmb_yakit";
            this.cmb_yakit.Size = new System.Drawing.Size(213, 36);
            this.cmb_yakit.TabIndex = 5;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(130, 94);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_plaka.Properties.Appearance.Options.UseFont = true;
            this.txt_plaka.Size = new System.Drawing.Size(213, 34);
            this.txt_plaka.TabIndex = 4;
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_plaka.Location = new System.Drawing.Point(64, 99);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(60, 21);
            this.lbl_plaka.TabIndex = 3;
            this.lbl_plaka.Text = "Plaka :";
            // 
            // FrmKiralanabilirAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 884);
            this.Controls.Add(this.Grpbx_Aracislemler);
            this.Controls.Add(this.GridAraclar);
            this.Name = "FrmKiralanabilirAraclar";
            this.Text = "Kiralanabilir Araçlarımız";
            this.Load += new System.EventHandler(this.FrmKiralanabilirAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grpbx_Aracislemler)).EndInit();
            this.Grpbx_Aracislemler.ResumeLayout(false);
            this.Grpbx_Aracislemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bakimkm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mevcutkm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depozito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gunlukucret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_marka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_plaka.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridAraclar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.ComboBox cmb_sube;
        private AracKiralamaDataSet aracKiralamaDataSet;
        private System.Windows.Forms.BindingSource tblSubelerBindingSource;
        private AracKiralamaDataSetTableAdapters.TblSubelerTableAdapter tblSubelerTableAdapter;
        private AracKiralamaDataSet1 aracKiralamaDataSet1;
        private System.Windows.Forms.BindingSource tblSubelerBindingSource1;
        private AracKiralamaDataSet1TableAdapters.TblSubelerTableAdapter tblSubelerTableAdapter1;
        private System.Windows.Forms.Label lbl_sube;
        private DevExpress.XtraEditors.GroupControl Grpbx_Aracislemler;
        private System.Windows.Forms.Label lbl_plaka;
        private System.Windows.Forms.Label lbl_bakimkm;
        private DevExpress.XtraEditors.TextEdit txt_bakimkm;
        private System.Windows.Forms.Label lbl_depozito;
        private System.Windows.Forms.Label lbl_gunlukucret;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.Label lbl_vites;
        private System.Windows.Forms.Label lbl_mevcutkm;
        private System.Windows.Forms.Label lbl_yakit;
        private DevExpress.XtraEditors.TextEdit txt_mevcutkm;
        private DevExpress.XtraEditors.TextEdit txt_depozito;
        private DevExpress.XtraEditors.TextEdit txt_gunlukucret;
        private DevExpress.XtraEditors.TextEdit txt_model;
        private DevExpress.XtraEditors.TextEdit txt_marka;
        private System.Windows.Forms.ComboBox cmb_vites;
        private System.Windows.Forms.ComboBox cmb_yakit;
        private DevExpress.XtraEditors.TextEdit txt_plaka;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton Btn_temizle;
    }
}