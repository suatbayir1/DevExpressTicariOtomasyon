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

namespace Otomasyon.Modul_Cek
{
    public partial class frmCariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;


        public frmCariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void frmCariyeCekCikisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            Mesajlar.FormAcilis(this.Text);
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKODU;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtCekNo.Text = Cek.CEKNO;
                txtBanka.Text = Cek.BANKASI;
                txtSube.Text = Cek.SUBE;
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                if (Cek.VERILENCARIID!=null)
                {
                    if (Cek.VERILENCARIID.Value > 0)
                    {
                        CariAc(Cek.VERILENCARIID.Value);
                        txtBelgeNo.Text = Cek.VERILENCARI_BELGENO;
                        txtTarih.Text = Cek.VERILENCARI_TARIHI.Value.ToShortDateString();
                    }  
                }
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Temizle()
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUMU = "Caride";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtCekNo.Text + " çek numaralı ve" + txtBelgeNo.Text + " belge numaralı çek ";
                CariHareket.BORC = decimal.Parse( txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = CekID;
                CariHareket.EVRAKTURU = "Cariye Çek";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "Çek İşlemi";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Cariye Çek Çıkışı İşleminin hareket kaydı ve çek kaydı güncellemesi yapılmıştır..");
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUMU = "Caride";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == "Cariye Çek" && s.EVRAKID == CekID);
                CariHareket.ACIKLAMA = txtCekNo.Text + " çek numaralı ve" + txtBelgeNo.Text + " belge numaralı çek ";
                CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = CekID;
                CariHareket.EVRAKTURU = "Cariye Çek";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "Çek İşlemi";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                CekGetir(CekID);
                Edit = true;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
                Temizle();
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0) CariAc(ID);
            AnaForm.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CekListesi(true);
            if (ID > 0) CekGetir(ID);
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && CariID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else if (CariID > 0 && CekID > 0) YeniKaydet();
            else MessageBox.Show("Çek veya Cari seçimi yapmamışsınız..");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit && CekID>0 && CariID>0 && Mesajlar.Sil()==DialogResult.Yes)
            {
                try
                {
                    DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == "Cariye Çek" && s.EVRAKID == CekID));
                    Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                    Cek.BELGENO = "";
                    Cek.VERILENCARIID = -1;
                    DB.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Mesajlar.Hata(ex);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCariyeCekCikisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}