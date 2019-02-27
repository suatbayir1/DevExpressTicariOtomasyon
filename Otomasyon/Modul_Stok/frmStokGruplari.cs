using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Listele()
        {
            /* veritabanından StokGrupları bilgileri çekildi ve listelendi */
            var lst = from s in DB.TBL_STOKGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }

        void Temizle()
        {
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            Edit = false;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = new Fonksiyonlar.TBL_STOKGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = AnaForm.UserID;  // Anaformdan gelen Kullanıcının ID si
                DB.TBL_STOKGRUPLARIs.InsertOnSubmit(Grup); // Yukarıdaki bilgileri Butona basıldıgında ekler
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kayıt Oluşturuldu");
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
                /* İlk Kayıttaki Grubu alıyoruz */
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = DB.TBL_STOKGRUPLARIs.First(s => s.ID == SecimID);
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPEDITUSER = AnaForm.UserID;
                Grup.GRUPEDITDATE = DateTime.Now;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_STOKGRUPLARIs.DeleteOnSubmit(DB.TBL_STOKGRUPLARIs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Mesajlar.Sil();
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
                SecimID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception e)
            {
                Edit = false;
                SecimID = -1;
                Mesajlar.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID >0 && Mesajlar.Sil()==DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void frmStokGruplari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}