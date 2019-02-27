namespace Otomasyon
{
    partial class frmAyar
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.txtSunucu = new DevExpress.XtraEditors.TextEdit();
            this.btnYeniAyarlariKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkYeniGiris = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYeniGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtDatabase);
            this.groupControl1.Controls.Add(this.txtUserID);
            this.groupControl1.Controls.Add(this.txtSunucu);
            this.groupControl1.Controls.Add(this.btnYeniAyarlariKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.chkYeniGiris);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 71);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(519, 138);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(340, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Enabled = false;
            this.txtDatabase.Location = new System.Drawing.Point(86, 65);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(169, 20);
            this.txtDatabase.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(340, 35);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(169, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // txtSunucu
            // 
            this.txtSunucu.Enabled = false;
            this.txtSunucu.Location = new System.Drawing.Point(86, 35);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(169, 20);
            this.txtSunucu.TabIndex = 1;
            // 
            // btnYeniAyarlariKaydet
            // 
            this.btnYeniAyarlariKaydet.Enabled = false;
            this.btnYeniAyarlariKaydet.Location = new System.Drawing.Point(340, 91);
            this.btnYeniAyarlariKaydet.Name = "btnYeniAyarlariKaydet";
            this.btnYeniAyarlariKaydet.Size = new System.Drawing.Size(169, 36);
            this.btnYeniAyarlariKaydet.TabIndex = 2;
            this.btnYeniAyarlariKaydet.Text = "Yeni Ayarları Kaydet";
            this.btnYeniAyarlariKaydet.Click += new System.EventHandler(this.btnYeniAyarlariKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(275, 68);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Password :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Database :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(275, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "User ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Sunucu :";
            // 
            // chkYeniGiris
            // 
            this.chkYeniGiris.Location = new System.Drawing.Point(180, 99);
            this.chkYeniGiris.Name = "chkYeniGiris";
            this.chkYeniGiris.Properties.Caption = "Yeni Giriş";
            this.chkYeniGiris.Size = new System.Drawing.Size(75, 19);
            this.chkYeniGiris.TabIndex = 2;
            this.chkYeniGiris.CheckedChanged += new System.EventHandler(this.chkYeniGiris_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(519, 71);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(50, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "CS";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CS :";
            // 
            // frmAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 209);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAyar";
            this.Text = "frmAyar";
            this.Load += new System.EventHandler(this.frmAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkYeniGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.TextEdit txtUserID;
        private DevExpress.XtraEditors.TextEdit txtSunucu;
        private DevExpress.XtraEditors.SimpleButton btnYeniAyarlariKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkYeniGiris;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}