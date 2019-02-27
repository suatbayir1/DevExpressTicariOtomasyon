namespace Otomasyon.Modul_Cek
{
    partial class frmBankayaCekCikisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankayaCekCikisi));
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.txtVadeTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekNo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtBanka = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtHesapNo = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 152);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Tutar :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 122);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Şube :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Banka :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(79, 149);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Properties.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(229, 20);
            this.txtTutar.TabIndex = 1;
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(79, 119);
            this.txtSube.Name = "txtSube";
            this.txtSube.Properties.ReadOnly = true;
            this.txtSube.Size = new System.Drawing.Size(229, 20);
            this.txtSube.TabIndex = 1;
            // 
            // txtVadeTarihi
            // 
            this.txtVadeTarihi.EditValue = null;
            this.txtVadeTarihi.Location = new System.Drawing.Point(79, 61);
            this.txtVadeTarihi.Name = "txtVadeTarihi";
            this.txtVadeTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVadeTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVadeTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtVadeTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtVadeTarihi.Properties.EditFormat.FormatString = "";
            this.txtVadeTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtVadeTarihi.Properties.Mask.EditMask = "";
            this.txtVadeTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtVadeTarihi.Properties.ReadOnly = true;
            this.txtVadeTarihi.Size = new System.Drawing.Size(229, 20);
            this.txtVadeTarihi.TabIndex = 1;
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(79, 117);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Properties.ReadOnly = true;
            this.txtBankaAdi.Size = new System.Drawing.Size(229, 20);
            this.txtBankaAdi.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Banka Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tarih : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Hesap No :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Belge No :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Vade Tarihi :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Çek No :";
            // 
            // txtCekNo
            // 
            this.txtCekNo.Location = new System.Drawing.Point(79, 33);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCekNo.Properties.ReadOnly = true;
            this.txtCekNo.Size = new System.Drawing.Size(229, 20);
            this.txtCekNo.TabIndex = 1;
            this.txtCekNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCekNo_ButtonClick);
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(79, 30);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBelgeNo.Size = new System.Drawing.Size(229, 20);
            this.txtBelgeNo.TabIndex = 1;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(79, 59);
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
            this.txtTarih.Properties.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(229, 20);
            this.txtTarih.TabIndex = 1;
            // 
            // txtBanka
            // 
            this.txtBanka.Location = new System.Drawing.Point(79, 91);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Properties.ReadOnly = true;
            this.txtBanka.Size = new System.Drawing.Size(229, 20);
            this.txtBanka.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txtCekNo);
            this.groupControl3.Controls.Add(this.txtTutar);
            this.groupControl3.Controls.Add(this.txtSube);
            this.groupControl3.Controls.Add(this.txtBanka);
            this.groupControl3.Controls.Add(this.txtVadeTarihi);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 155);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(323, 186);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Bankaya Çek Çıkışı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.kaydet;
            this.btnKaydet.Location = new System.Drawing.Point(54, 32);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 33);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Enabled = false;
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.sil;
            this.btnSil.Location = new System.Drawing.Point(143, 32);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 33);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.kapat;
            this.btnKapat.Location = new System.Drawing.Point(232, 32);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 33);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 341);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(323, 77);
            this.groupControl2.TabIndex = 4;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(79, 88);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesapNo.Properties.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(229, 20);
            this.txtHesapNo.TabIndex = 1;
            this.txtHesapNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHesapNo_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBankaAdi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(323, 155);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // frmBankayaCekCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 418);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankayaCekCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankaya Çek Çıkışı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankayaCekCikisi_FormClosed);
            this.Load += new System.EventHandler(this.frmBankayaCekCikisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.DateEdit txtVadeTarihi;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ButtonEdit txtCekNo;
        private DevExpress.XtraEditors.ButtonEdit txtBelgeNo;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtBanka;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ButtonEdit txtHesapNo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}