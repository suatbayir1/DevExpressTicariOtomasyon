using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public frmLoginForm()
        {
            InitializeComponent();
            txtKullanici.Focus();   // açıldığında pointer burayı göstersin
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(s => s.KULLANICI == txtKullanici.Text.Trim() && s.SIFRE==txtSifre.Text.Trim());
                Kullanici.LASTLOGIN = DateTime.Now;
                DB.SubmitChanges();
                this.Hide();
                AnaForm frm = new AnaForm(Kullanici);
                frm.Show(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılamadı.\nKullanıcı adı veya şifreniz geçersiz olabilir");
                return;
            }
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            frmAyar frm = new frmAyar();
            frm.ShowDialog();
        }
    }
}