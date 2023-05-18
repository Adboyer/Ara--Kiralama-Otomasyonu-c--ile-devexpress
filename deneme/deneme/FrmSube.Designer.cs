namespace deneme
{
    partial class FrmSube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSube));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grpbx_Subeislemleri = new DevExpress.XtraEditors.GroupControl();
            this.txt_ilce = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ilce = new System.Windows.Forms.Label();
            this.txt_ili = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ili = new System.Windows.Forms.Label();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grpbx_Subeislemleri)).BeginInit();
            this.Grpbx_Subeislemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(21, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(453, 563);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Şube İd";
            this.gridColumn1.FieldName = "sube_id";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "İli";
            this.gridColumn2.FieldName = "sube_il";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "İlçe";
            this.gridColumn3.FieldName = "sube_ilce";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // Grpbx_Subeislemleri
            // 
            this.Grpbx_Subeislemleri.Controls.Add(this.txt_ilce);
            this.Grpbx_Subeislemleri.Controls.Add(this.gridControl1);
            this.Grpbx_Subeislemleri.Controls.Add(this.lbl_ilce);
            this.Grpbx_Subeislemleri.Controls.Add(this.txt_ili);
            this.Grpbx_Subeislemleri.Controls.Add(this.lbl_ili);
            this.Grpbx_Subeislemleri.Controls.Add(this.Btn_Guncelle);
            this.Grpbx_Subeislemleri.Controls.Add(this.Btn_Sil);
            this.Grpbx_Subeislemleri.Controls.Add(this.Btn_Kaydet);
            this.Grpbx_Subeislemleri.Controls.Add(this.txt_id);
            this.Grpbx_Subeislemleri.Controls.Add(this.lbl_id);
            this.Grpbx_Subeislemleri.Location = new System.Drawing.Point(12, 12);
            this.Grpbx_Subeislemleri.Name = "Grpbx_Subeislemleri";
            this.Grpbx_Subeislemleri.Size = new System.Drawing.Size(912, 681);
            this.Grpbx_Subeislemleri.TabIndex = 5;
            this.Grpbx_Subeislemleri.Text = "Şubelerimiz";
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(592, 147);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_ilce.Properties.Appearance.Options.UseFont = true;
            this.txt_ilce.Size = new System.Drawing.Size(213, 34);
            this.txt_ilce.TabIndex = 27;
            // 
            // lbl_ilce
            // 
            this.lbl_ilce.AutoSize = true;
            this.lbl_ilce.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilce.Location = new System.Drawing.Point(500, 152);
            this.lbl_ilce.Name = "lbl_ilce";
            this.lbl_ilce.Size = new System.Drawing.Size(89, 21);
            this.lbl_ilce.TabIndex = 26;
            this.lbl_ilce.Text = "Şube İlçe :";
            // 
            // txt_ili
            // 
            this.txt_ili.Location = new System.Drawing.Point(592, 107);
            this.txt_ili.Name = "txt_ili";
            this.txt_ili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_ili.Properties.Appearance.Options.UseFont = true;
            this.txt_ili.Size = new System.Drawing.Size(213, 34);
            this.txt_ili.TabIndex = 25;
            // 
            // lbl_ili
            // 
            this.lbl_ili.AutoSize = true;
            this.lbl_ili.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ili.Location = new System.Drawing.Point(513, 112);
            this.lbl_ili.Name = "lbl_ili";
            this.lbl_ili.Size = new System.Drawing.Size(76, 21);
            this.lbl_ili.TabIndex = 24;
            this.lbl_ili.Text = "Şube İli :";
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Appearance.Options.UseBackColor = true;
            this.Btn_Guncelle.Appearance.Options.UseFont = true;
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(640, 299);
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
            this.Btn_Sil.Location = new System.Drawing.Point(596, 243);
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
            this.Btn_Kaydet.Location = new System.Drawing.Point(564, 187);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(164, 50);
            this.Btn_Kaydet.TabIndex = 21;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(592, 67);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(213, 34);
            this.txt_id.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_id.Location = new System.Drawing.Point(552, 72);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(36, 21);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Id :";
            // 
            // FrmSube
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1917, 884);
            this.Controls.Add(this.Grpbx_Subeislemleri);
            this.DoubleBuffered = true;
            this.Name = "FrmSube";
            this.Text = "Şubelerimiz";
            this.Load += new System.EventHandler(this.FrmSube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grpbx_Subeislemleri)).EndInit();
            this.Grpbx_Subeislemleri.ResumeLayout(false);
            this.Grpbx_Subeislemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.GroupControl Grpbx_Subeislemleri;
        private DevExpress.XtraEditors.TextEdit txt_ilce;
        private System.Windows.Forms.Label lbl_ilce;
        private DevExpress.XtraEditors.TextEdit txt_ili;
        private System.Windows.Forms.Label lbl_ili;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}