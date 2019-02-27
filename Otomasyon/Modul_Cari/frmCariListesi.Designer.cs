namespace Otomasyon.Modul_Cari
{
    partial class frmCariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.txtBarkod = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariGrup = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.txtBarkod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(956, 423);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.txtBarkod;
            this.xtraTabControl1.Size = new System.Drawing.Size(187, 423);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.txtBarkod});
            // 
            // txtBarkod
            // 
            this.txtBarkod.Controls.Add(this.btnSil);
            this.txtBarkod.Controls.Add(this.btnAra);
            this.txtBarkod.Controls.Add(this.txtCariGrup);
            this.txtBarkod.Controls.Add(this.labelControl3);
            this.txtBarkod.Controls.Add(this.txtCariAdi);
            this.txtBarkod.Controls.Add(this.labelControl2);
            this.txtBarkod.Controls.Add(this.txtCariKodu);
            this.txtBarkod.Controls.Add(this.labelControl1);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(181, 395);
            this.txtBarkod.Text = "Arama";
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Otomasyon.Properties.Resources.ara;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.temizle;
            this.btnSil.Location = new System.Drawing.Point(94, 169);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 47);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::Otomasyon.Properties.Resources.ara;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAra.ImageOptions.Image = global::Otomasyon.Properties.Resources.ara1;
            this.btnAra.Location = new System.Drawing.Point(11, 169);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(77, 47);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            // 
            // txtCariGrup
            // 
            this.txtCariGrup.Location = new System.Drawing.Point(11, 126);
            this.txtCariGrup.Name = "txtCariGrup";
            this.txtCariGrup.Size = new System.Drawing.Size(160, 20);
            this.txtCariGrup.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cari Grup";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(11, 81);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(160, 20);
            this.txtCariAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cari Adı";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(11, 36);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(160, 20);
            this.txtCariKodu.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(764, 423);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARIADI});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARI KODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 1;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARI ADI";
            this.CARIADI.FieldName = "CARIADI";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.OptionsColumn.AllowFocus = false;
            this.CARIADI.OptionsColumn.FixedWidth = true;
            this.CARIADI.Visible = true;
            this.CARIADI.VisibleIndex = 0;
            // 
            // frmCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 423);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCariListesi_FormClosed);
            this.Load += new System.EventHandler(this.frmCariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.txtBarkod.ResumeLayout(false);
            this.txtBarkod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage txtBarkod;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtCariGrup;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI;
    }
}