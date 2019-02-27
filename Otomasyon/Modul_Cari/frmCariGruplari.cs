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
using System.Data.Linq;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;


        public frmCariGruplari()
        {
            InitializeComponent();
        }

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CARIGRUPLARIs
                      select s;
            Liste1.DataSource = lst;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = AnaForm.UserID;
                DB.TBL_CARIGRUPLARIs.InsertOnSubmit(Grup); // kayıt ekle
                DB.SubmitChanges();  // işlemi onayla
                Mesajlar.YeniKayit("Yeni Cari Grup Kaydı Oluşturuldu");
                Temizle();  
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID);
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPEDITDATE = DateTime.Now;
                Grup.GRUPEDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true; 
                SecimID = int.Parse(gridView3.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView3.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView3.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                Edit = false;
                SecimID = -1;
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_CARIGRUPLARIs.DeleteOnSubmit(DB.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(Edit &&  SecimID>0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && SecimID>0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();    
            }
        }

        private void Liste1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmCariGruplari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}