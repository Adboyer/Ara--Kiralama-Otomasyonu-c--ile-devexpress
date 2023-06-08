namespace deneme
{
    partial class FrmKiradakiAraclar
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
            this.GridAraclar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_baslangıctarih = new DevExpress.XtraEditors.TextEdit();
            this.lbl_plaka = new System.Windows.Forms.Label();
            this.txt_bitistarih = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_aracplaka = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_sube = new System.Windows.Forms.ComboBox();
            this.lbl_sube = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_baslangıctarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bitistarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_aracplaka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAraclar
            // 
            this.GridAraclar.Location = new System.Drawing.Point(12, 12);
            this.GridAraclar.MainView = this.gridView1;
            this.GridAraclar.Name = "GridAraclar";
            this.GridAraclar.Size = new System.Drawing.Size(1252, 860);
            this.GridAraclar.TabIndex = 1;
            this.GridAraclar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn6,
            this.gridColumn11});
            this.gridView1.GridControl = this.GridAraclar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Kiralama İd";
            this.gridColumn3.FieldName = "kiralama_id";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Müsteri";
            this.gridColumn2.FieldName = "müsteri_id";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
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
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Şube";
            this.gridColumn4.FieldName = "sube_id";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Personel";
            this.gridColumn5.FieldName = "personel_id";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Başlangıç Tarih";
            this.gridColumn7.FieldName = "kiralama_baslamatarih";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Bitiş Tarih";
            this.gridColumn8.FieldName = "kiralama_bitistarih";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Depozito";
            this.gridColumn9.FieldName = "kiralama_alinandepozito";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Gün Sayısı";
            this.gridColumn10.FieldName = "kiralama_günsayisi";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Alınan Ücret";
            this.gridColumn6.FieldName = "kiralama_alinanücret";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Açıklama";
            this.gridColumn11.FieldName = "kiralama_acıklama";
            this.gridColumn11.MinWidth = 25;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 94;
            // 
            // txt_baslangıctarih
            // 
            this.txt_baslangıctarih.Enabled = false;
            this.txt_baslangıctarih.Location = new System.Drawing.Point(1454, 156);
            this.txt_baslangıctarih.Name = "txt_baslangıctarih";
            this.txt_baslangıctarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_baslangıctarih.Properties.Appearance.Options.UseFont = true;
            this.txt_baslangıctarih.Size = new System.Drawing.Size(213, 34);
            this.txt_baslangıctarih.TabIndex = 6;
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_plaka.Location = new System.Drawing.Point(1311, 162);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(139, 21);
            this.lbl_plaka.TabIndex = 5;
            this.lbl_plaka.Text = "Başlanmış Tarih :";
            // 
            // txt_bitistarih
            // 
            this.txt_bitistarih.Enabled = false;
            this.txt_bitistarih.Location = new System.Drawing.Point(1454, 206);
            this.txt_bitistarih.Name = "txt_bitistarih";
            this.txt_bitistarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_bitistarih.Properties.Appearance.Options.UseFont = true;
            this.txt_bitistarih.Size = new System.Drawing.Size(213, 34);
            this.txt_bitistarih.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1355, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bitiş Tarih :";
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.Appearance.Options.UseBackColor = true;
            this.Btn_Kaydet.Appearance.Options.UseFont = true;
            this.Btn_Kaydet.Location = new System.Drawing.Point(1440, 269);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(164, 50);
            this.Btn_Kaydet.TabIndex = 22;
            this.Btn_Kaydet.Text = "Kiralamayı Bitir";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // txt_aracplaka
            // 
            this.txt_aracplaka.Enabled = false;
            this.txt_aracplaka.Location = new System.Drawing.Point(1454, 116);
            this.txt_aracplaka.Name = "txt_aracplaka";
            this.txt_aracplaka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_aracplaka.Properties.Appearance.Options.UseFont = true;
            this.txt_aracplaka.Size = new System.Drawing.Size(213, 34);
            this.txt_aracplaka.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1349, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Araç Plaka :";
            // 
            // cmb_sube
            // 
            this.cmb_sube.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_sube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sube.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sube.FormattingEnabled = true;
            this.cmb_sube.Items.AddRange(new object[] {
            "Tümü"});
            this.cmb_sube.Location = new System.Drawing.Point(1454, 74);
            this.cmb_sube.Name = "cmb_sube";
            this.cmb_sube.Size = new System.Drawing.Size(213, 36);
            this.cmb_sube.TabIndex = 25;
            this.cmb_sube.SelectedIndexChanged += new System.EventHandler(this.cmb_sube_SelectedIndexChanged);
            // 
            // lbl_sube
            // 
            this.lbl_sube.AutoSize = true;
            this.lbl_sube.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sube.Location = new System.Drawing.Point(1391, 82);
            this.lbl_sube.Name = "lbl_sube";
            this.lbl_sube.Size = new System.Drawing.Size(57, 21);
            this.lbl_sube.TabIndex = 26;
            this.lbl_sube.Text = "Şube :";
            // 
            // FrmKiradakiAraclar
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 884);
            this.Controls.Add(this.lbl_sube);
            this.Controls.Add(this.cmb_sube);
            this.Controls.Add(this.txt_aracplaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Kaydet);
            this.Controls.Add(this.txt_bitistarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_baslangıctarih);
            this.Controls.Add(this.lbl_plaka);
            this.Controls.Add(this.GridAraclar);
            this.Name = "FrmKiradakiAraclar";
            this.Text = "FrmKiradakiAraclar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKiradakiAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_baslangıctarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bitistarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_aracplaka.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.TextEdit txt_baslangıctarih;
        private System.Windows.Forms.Label lbl_plaka;
        private DevExpress.XtraEditors.TextEdit txt_bitistarih;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.TextEdit txt_aracplaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_sube;
        private System.Windows.Forms.Label lbl_sube;
    }
}