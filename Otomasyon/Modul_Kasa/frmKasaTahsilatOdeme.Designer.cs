namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaTahsilatOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaTahsilatOdeme));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeMakbuzNo = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCariKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtIslemTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeMakbuzNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslemTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtCariAdi);
            this.groupControl1.Controls.Add(this.textEdit6);
            this.groupControl1.Controls.Add(this.textEdit7);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeMakbuzNo);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(405, 196);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kasa Cari Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.kaydet;
            this.btnKaydet.Location = new System.Drawing.Point(309, 29);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 33);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.sil;
            this.btnSil.Location = new System.Drawing.Point(309, 81);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 33);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.kapat;
            this.btnKapat.Location = new System.Drawing.Point(309, 134);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 33);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 150);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Cari Adı :";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(107, 147);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Properties.ReadOnly = true;
            this.txtCariAdi.Size = new System.Drawing.Size(160, 20);
            this.txtCariAdi.TabIndex = 0;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(107, 147);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(160, 20);
            this.textEdit6.TabIndex = 0;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(107, 147);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(160, 20);
            this.textEdit7.TabIndex = 0;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(107, 147);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(160, 20);
            this.textEdit5.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Cari Kodu :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Kasa Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(107, 87);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(160, 20);
            this.txtKasaAdi.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Belge/Makbuz No :";
            // 
            // txtBelgeMakbuzNo
            // 
            this.txtBelgeMakbuzNo.Location = new System.Drawing.Point(107, 30);
            this.txtBelgeMakbuzNo.Name = "txtBelgeMakbuzNo";
            this.txtBelgeMakbuzNo.Size = new System.Drawing.Size(160, 20);
            this.txtBelgeMakbuzNo.TabIndex = 0;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(107, 59);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(160, 20);
            this.txtKasaKodu.TabIndex = 0;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(107, 116);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(160, 20);
            this.txtCariKodu.TabIndex = 0;
            this.txtCariKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCariKodu_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Controls.Add(this.txtIslemTuru);
            this.groupControl2.Controls.Add(this.txtTarih);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 196);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(405, 174);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Kasa İşlem Bilgileri";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 37);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Tarih :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(314, 34);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(82, 20);
            this.txtTutar.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(275, 37);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Tutar :";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 94);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Açıklama :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 66);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "İşlem Türü :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(107, 93);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(285, 68);
            this.txtAciklama.TabIndex = 0;
            // 
            // txtIslemTuru
            // 
            this.txtIslemTuru.EditValue = "Kasa Tahsilat";
            this.txtIslemTuru.Location = new System.Drawing.Point(107, 63);
            this.txtIslemTuru.Name = "txtIslemTuru";
            this.txtIslemTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIslemTuru.Properties.Items.AddRange(new object[] {
            "Kasa Tahsilat",
            "Kasa Ödeme"});
            this.txtIslemTuru.Size = new System.Drawing.Size(160, 20);
            this.txtIslemTuru.TabIndex = 0;
            this.txtIslemTuru.SelectedIndexChanged += new System.EventHandler(this.txtIslemTuru_SelectedIndexChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(107, 34);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(160, 20);
            this.txtTarih.TabIndex = 0;
            // 
            // frmKasaTahsilatOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 370);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaTahsilatOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Tahsilat Ödeme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKasaTahsilatOdeme_FormClosed);
            this.Load += new System.EventHandler(this.frmKasaTahsilatOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeMakbuzNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslemTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBelgeMakbuzNo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.ComboBoxEdit txtIslemTuru;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraEditors.ButtonEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}