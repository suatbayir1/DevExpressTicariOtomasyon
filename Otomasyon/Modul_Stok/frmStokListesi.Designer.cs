namespace Otomasyon.Modul_Stok
{
    partial class frmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.txtBarkod = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrintToPDF = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintToXls = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.txtBarkod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(825, 446);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.txtBarkod;
            this.xtraTabControl1.Size = new System.Drawing.Size(187, 446);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.txtBarkod});
            // 
            // txtBarkod
            // 
            this.txtBarkod.Controls.Add(this.btnPrintToXls);
            this.txtBarkod.Controls.Add(this.btnSil);
            this.txtBarkod.Controls.Add(this.btnPrintToPDF);
            this.txtBarkod.Controls.Add(this.btnAra);
            this.txtBarkod.Controls.Add(this.txtStokBarkod);
            this.txtBarkod.Controls.Add(this.labelControl3);
            this.txtBarkod.Controls.Add(this.txtStokAdi);
            this.txtBarkod.Controls.Add(this.labelControl2);
            this.txtBarkod.Controls.Add(this.txtStokKodu);
            this.txtBarkod.Controls.Add(this.labelControl1);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(181, 418);
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
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Location = new System.Drawing.Point(11, 126);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(160, 20);
            this.txtStokBarkod.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Barkod";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(11, 81);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(160, 20);
            this.txtStokAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(11, 36);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(160, 20);
            this.txtStokKodu.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(633, 446);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.STOKBARKOD});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOK KODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.OptionsColumn.AllowEdit = false;
            this.STOKKODU.OptionsColumn.AllowFocus = false;
            this.STOKKODU.OptionsColumn.FixedWidth = true;
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 1;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOK ADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.OptionsColumn.AllowEdit = false;
            this.STOKADI.OptionsColumn.AllowFocus = false;
            this.STOKADI.OptionsColumn.FixedWidth = true;
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 0;
            // 
            // STOKBARKOD
            // 
            this.STOKBARKOD.Caption = "BARKOD";
            this.STOKBARKOD.FieldName = "STOKBARKOD";
            this.STOKBARKOD.Name = "STOKBARKOD";
            this.STOKBARKOD.OptionsColumn.AllowEdit = false;
            this.STOKBARKOD.OptionsColumn.AllowFocus = false;
            this.STOKBARKOD.OptionsColumn.FixedWidth = true;
            this.STOKBARKOD.Visible = true;
            this.STOKBARKOD.VisibleIndex = 2;
            // 
            // btnPrintToPDF
            // 
            this.btnPrintToPDF.BackgroundImage = global::Otomasyon.Properties.Resources.ara;
            this.btnPrintToPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintToPDF.Location = new System.Drawing.Point(11, 222);
            this.btnPrintToPDF.Name = "btnPrintToPDF";
            this.btnPrintToPDF.Size = new System.Drawing.Size(160, 47);
            this.btnPrintToPDF.TabIndex = 6;
            this.btnPrintToPDF.Text = "Listeyi Yazdır(PDF)";
            this.btnPrintToPDF.Click += new System.EventHandler(this.btnPrintToPDF_Click);
            // 
            // btnPrintToXls
            // 
            this.btnPrintToXls.BackgroundImage = global::Otomasyon.Properties.Resources.ara;
            this.btnPrintToXls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintToXls.Location = new System.Drawing.Point(11, 275);
            this.btnPrintToXls.Name = "btnPrintToXls";
            this.btnPrintToXls.Size = new System.Drawing.Size(160, 47);
            this.btnPrintToXls.TabIndex = 7;
            this.btnPrintToXls.Text = "Excel\'e Aktar";
            this.btnPrintToXls.Click += new System.EventHandler(this.btnPrintToXls_Click);
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 446);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStokListesi_FormClosed);
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.txtBarkod.ResumeLayout(false);
            this.txtBarkod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage txtBarkod;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtStokBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.Columns.GridColumn STOKBARKOD;
        private DevExpress.XtraEditors.SimpleButton btnPrintToPDF;
        private DevExpress.XtraEditors.SimpleButton btnPrintToXls;
    }
}