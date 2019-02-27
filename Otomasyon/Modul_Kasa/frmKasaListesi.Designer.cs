namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaListesi
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaListesi));
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KASAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtBarkod = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            this.txtBarkod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.GIRIS.VisibleIndex = 4;
            this.GIRIS.Width = 80;
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
            this.CIKIS.VisibleIndex = 5;
            this.CIKIS.Width = 80;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.FixedWidth = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 3;
            this.BAKIYE.Width = 80;
            // 
            // KASAKODU
            // 
            this.KASAKODU.Caption = "KASA KODU";
            this.KASAKODU.FieldName = "KASAKODU";
            this.KASAKODU.Name = "KASAKODU";
            this.KASAKODU.OptionsColumn.AllowEdit = false;
            this.KASAKODU.OptionsColumn.AllowFocus = false;
            this.KASAKODU.OptionsColumn.FixedWidth = true;
            this.KASAKODU.Visible = true;
            this.KASAKODU.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Otomasyon.Properties.Resources.ara;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.temizle;
            this.btnSil.Location = new System.Drawing.Point(94, 120);
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
            this.btnAra.Location = new System.Drawing.Point(11, 120);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(77, 47);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(11, 81);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(160, 20);
            this.txtKasaAdi.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KASAKODU,
            this.KASAADI,
            this.GIRIS,
            this.CIKIS,
            this.BAKIYE,
            this.ACIKLAMA});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.GIRIS;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = "0";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.CIKIS;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue2.Value1 = "0";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.Column = this.BAKIYE;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue3.Appearance.Options.UseFont = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue3.Value1 = "0";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // KASAADI
            // 
            this.KASAADI.Caption = "KASA ADI";
            this.KASAADI.FieldName = "KASAADI";
            this.KASAADI.Name = "KASAADI";
            this.KASAADI.OptionsColumn.AllowEdit = false;
            this.KASAADI.OptionsColumn.AllowFocus = false;
            this.KASAADI.OptionsColumn.FixedWidth = true;
            this.KASAADI.Visible = true;
            this.KASAADI.VisibleIndex = 1;
            this.KASAADI.Width = 200;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 2;
            this.ACIKLAMA.Width = 208;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(802, 484);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kasa Adı";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(11, 36);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(160, 20);
            this.txtKasaKodu.TabIndex = 1;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Controls.Add(this.btnSil);
            this.txtBarkod.Controls.Add(this.btnAra);
            this.txtBarkod.Controls.Add(this.txtKasaAdi);
            this.txtBarkod.Controls.Add(this.labelControl2);
            this.txtBarkod.Controls.Add(this.txtKasaKodu);
            this.txtBarkod.Controls.Add(this.labelControl1);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(181, 456);
            this.txtBarkod.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.txtBarkod;
            this.xtraTabControl1.Size = new System.Drawing.Size(187, 484);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(994, 484);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmKasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 484);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKasaListesi_FormClosed);
            this.Load += new System.EventHandler(this.frmKasaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            this.txtBarkod.ResumeLayout(false);
            this.txtBarkod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn KASAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KASAADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraTab.XtraTabPage txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
    }
}