namespace Otomasyon.Modul_Banka
{
    partial class frmBankaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaListesi));
            this.txtIBAN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtBarkod = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            this.txtBarkod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(11, 126);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(160, 20);
            this.txtIBAN.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "IBAN";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(11, 81);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(160, 20);
            this.txtHesapNo.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BANKAADI,
            this.HESAPADI,
            this.IBAN,
            this.HESAPNO,
            this.BAKIYE,
            this.GIRIS,
            this.CIKIS});
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
            // BANKAADI
            // 
            this.BANKAADI.Caption = "BANKA ADI";
            this.BANKAADI.FieldName = "BANKAADI";
            this.BANKAADI.Name = "BANKAADI";
            this.BANKAADI.OptionsColumn.AllowEdit = false;
            this.BANKAADI.OptionsColumn.AllowFocus = false;
            this.BANKAADI.Visible = true;
            this.BANKAADI.VisibleIndex = 1;
            this.BANKAADI.Width = 124;
            // 
            // HESAPADI
            // 
            this.HESAPADI.Caption = "HESAP ADI";
            this.HESAPADI.FieldName = "HESAPADI";
            this.HESAPADI.Name = "HESAPADI";
            this.HESAPADI.OptionsColumn.AllowEdit = false;
            this.HESAPADI.OptionsColumn.AllowFocus = false;
            this.HESAPADI.Visible = true;
            this.HESAPADI.VisibleIndex = 0;
            this.HESAPADI.Width = 124;
            // 
            // IBAN
            // 
            this.IBAN.Caption = "IBAN";
            this.IBAN.FieldName = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.OptionsColumn.AllowEdit = false;
            this.IBAN.OptionsColumn.AllowFocus = false;
            this.IBAN.Visible = true;
            this.IBAN.VisibleIndex = 2;
            this.IBAN.Width = 124;
            // 
            // HESAPNO
            // 
            this.HESAPNO.Caption = "HESAP NO";
            this.HESAPNO.FieldName = "HESAPNO";
            this.HESAPNO.Name = "HESAPNO";
            this.HESAPNO.OptionsColumn.AllowEdit = false;
            this.HESAPNO.OptionsColumn.AllowFocus = false;
            this.HESAPNO.Visible = true;
            this.HESAPNO.VisibleIndex = 3;
            this.HESAPNO.Width = 124;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 4;
            this.BAKIYE.Width = 125;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 5;
            this.GIRIS.Width = 100;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 6;
            this.CIKIS.Width = 100;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(814, 450);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hesap No";
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(11, 36);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(160, 20);
            this.txtHesapAdi.TabIndex = 1;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Controls.Add(this.btnSil);
            this.txtBarkod.Controls.Add(this.btnAra);
            this.txtBarkod.Controls.Add(this.txtIBAN);
            this.txtBarkod.Controls.Add(this.labelControl3);
            this.txtBarkod.Controls.Add(this.txtHesapNo);
            this.txtBarkod.Controls.Add(this.labelControl2);
            this.txtBarkod.Controls.Add(this.txtHesapAdi);
            this.txtBarkod.Controls.Add(this.labelControl1);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(181, 422);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hesap Adı/Türü";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.txtBarkod;
            this.xtraTabControl1.Size = new System.Drawing.Size(187, 450);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.txtBarkod});
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1006, 450);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmBankaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankaListesi_FormClosed);
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            this.txtBarkod.ResumeLayout(false);
            this.txtBarkod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn IBAN;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAADI;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtIBAN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHesapAdi;
        private DevExpress.XtraTab.XtraTabPage txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPNO;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
    }
}