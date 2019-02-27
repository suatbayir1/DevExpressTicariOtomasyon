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

namespace Otomasyon.Modul_Kullanici
{
    public partial class frmKullaniciYonetimi : DevExpress.XtraEditors.XtraForm
    {
        int secim=-1;

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public frmKullaniciYonetimi()
        {
            InitializeComponent();
            this.Shown += frmKullaniciYonetimi_Shown; 
        }

        private void frmKullaniciYonetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KULLANICILARs
                      select s;
            gridControl1.DataSource = lst;
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel(); // kullanıcıpaneli getir yeni kaydetme
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel(true, secim);   // ID'yle birlikte kullanıcı paneli getir yeni güncelleme
            Listele(); 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_KULLANICILARs.DeleteOnSubmit(DB.TBL_KULLANICILARs.First(s => s.ID == secim));
                DB.SubmitChanges();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            secim = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());  // gridview'dan ID'yi al

        }
    }
}