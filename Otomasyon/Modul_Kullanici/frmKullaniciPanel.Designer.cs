namespace Otomasyon.Modul_Kullanici
{
    partial class frmKullaniciPanel
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
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rbtnAktif = new System.Windows.Forms.RadioButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifreT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIsim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyisim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciKodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnPasif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyisim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.kaydet;
            this.btnKaydet.Location = new System.Drawing.Point(267, 7);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 38);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(108, 9);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(135, 20);
            this.txtKullanici.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // rbtnAktif
            // 
            this.rbtnAktif.AutoSize = true;
            this.rbtnAktif.Location = new System.Drawing.Point(267, 151);
            this.rbtnAktif.Name = "rbtnAktif";
            this.rbtnAktif.Size = new System.Drawing.Size(47, 17);
            this.rbtnAktif.TabIndex = 3;
            this.rbtnAktif.TabStop = true;
            this.rbtnAktif.Text = "Aktif";
            this.rbtnAktif.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(108, 37);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(135, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre :";
            // 
            // txtSifreT
            // 
            this.txtSifreT.Location = new System.Drawing.Point(108, 67);
            this.txtSifreT.Name = "txtSifreT";
            this.txtSifreT.Size = new System.Drawing.Size(135, 20);
            this.txtSifreT.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Şifre(Tekrar) :";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(108, 95);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(135, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "İsim :";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(108, 124);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(135, 20);
            this.txtSoyisim.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Soyisim :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 155);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Kullanıcı Türü :";
            // 
            // txtKullaniciKodu
            // 
            this.txtKullaniciKodu.EditValue = "Normal";
            this.txtKullaniciKodu.Location = new System.Drawing.Point(108, 152);
            this.txtKullaniciKodu.Name = "txtKullaniciKodu";
            this.txtKullaniciKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKullaniciKodu.Properties.Items.AddRange(new object[] {
            "Yonetici",
            "Normal"});
            this.txtKullaniciKodu.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciKodu.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::Otomasyon.Properties.Resources.temizle;
            this.btnTemizle.Location = new System.Drawing.Point(267, 51);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(91, 41);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.kapat;
            this.btnKapat.Location = new System.Drawing.Point(267, 98);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(91, 30);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // rbtnPasif
            // 
            this.rbtnPasif.AutoSize = true;
            this.rbtnPasif.Checked = true;
            this.rbtnPasif.Location = new System.Drawing.Point(320, 151);
            this.rbtnPasif.Name = "rbtnPasif";
            this.rbtnPasif.Size = new System.Drawing.Size(48, 17);
            this.rbtnPasif.TabIndex = 3;
            this.rbtnPasif.TabStop = true;
            this.rbtnPasif.Text = "Pasif";
            this.rbtnPasif.UseVisualStyleBackColor = true;
            // 
            // frmKullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 183);
            this.Controls.Add(this.rbtnPasif);
            this.Controls.Add(this.rbtnAktif);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSifreT);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKullaniciKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKullaniciPanel";
            this.ShowInTaskbar = false;
            this.Text = "Kullanıcı Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyisim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rbtnAktif;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSifreT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIsim;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoyisim;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txtKullaniciKodu;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.RadioButton rbtnPasif;
    }
}