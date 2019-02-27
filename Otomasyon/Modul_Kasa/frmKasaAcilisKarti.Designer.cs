namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaAcilisKarti));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 184);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(417, 210);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Banka Listesi";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 20);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(413, 188);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KASAKODU,
            this.KASAADI,
            this.BAKIYE,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
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
            this.KASAKODU.Width = 150;
            // 
            // KASAADI
            // 
            this.KASAADI.Caption = "KASA ADI";
            this.KASAADI.FieldName = "KASAADI";
            this.KASAADI.Name = "KASAADI";
            this.KASAADI.OptionsColumn.AllowEdit = false;
            this.KASAADI.OptionsColumn.AllowFocus = false;
            this.KASAADI.Visible = true;
            this.KASAADI.VisibleIndex = 1;
            this.KASAADI.Width = 155;
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
            this.BAKIYE.VisibleIndex = 2;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.kaydet;
            this.btnKaydet.Location = new System.Drawing.Point(316, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 33);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.sil;
            this.btnSil.Location = new System.Drawing.Point(316, 80);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.kapat;
            this.btnKapat.Location = new System.Drawing.Point(316, 127);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 33);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 103);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Açıklama :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kasa Adı :";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(98, 65);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(202, 20);
            this.txtKasaAdi.TabIndex = 0;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(98, 33);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(202, 20);
            this.txtKasaKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(417, 184);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Banka İşlemleri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(98, 100);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 60);
            this.txtAciklama.TabIndex = 0;
            // 
            // frmKasaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 394);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaAcilisKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Açılış Kartı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKasaAcilisKarti_FormClosed);
            this.Load += new System.EventHandler(this.frmKasaAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KASAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn KASAADI;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
    }
}