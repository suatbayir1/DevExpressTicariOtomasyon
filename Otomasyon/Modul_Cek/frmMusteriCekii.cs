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
    public partial class frmMusteriCekii : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public void Ac(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtAciklama.Text = Cek.ACIKLAMA;
                if (Cek.ACKODU == "A") txtCekTuru.SelectedIndex = 0;
                if (Cek.ACKODU == "C") txtCekTuru.SelectedIndex = 1;
                Cek.ASILBORCLU = Cek.BANKASI;
                txtBelgeNo.Text = Cek.BELGENO;
                txtCekNo.Text = Cek.CEKNO;
                txtHesapNo.Text = Cek.HESAPNO;
                txtSube.Text = Cek.SUBE;
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                CariAc(Cek.ALINANCARIID.Value);
                Edit = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                Temizle();
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtAsilBorclu.Text = "";
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtCekTuru.SelectedIndex = 0;
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void YeniCekKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();
                Cek.ACIKLAMA = txtAciklama.Text;
                if (txtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (txtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariID;
                Cek.BANKASI = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.ASILBORCLU = txtAsilBorclu.Text;
                Cek.DURUMU = "Portföy"; // muhasabeyle ilgili bir terim
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.TIPI = "Müşteri Çeki";
                Cek.SAVEUSER = AnaForm.UserID;
                Cek.SAVEDATE = DateTime.Now;
                DB.TBL_CEKLERs.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " No'lu müşteri çeki kaydı gerçekleştirildi..");

                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı ve" + txtCekNo.Text + " çek numaralı müşteri çeki";
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = Cek.ID;
                CariHareket.EVRAKTURU = "Müşteri Çeki";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "MÇ";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " No'lu müşteri çeki cari kaydı gerçekleştirildi..");
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
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.ACIKLAMA = txtAciklama.Text;
                if (txtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (txtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariID;
                Cek.BANKASI = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.ASILBORCLU = txtAsilBorclu.Text;
                Cek.DURUMU = "Portföy"; // muhasabeyle ilgili bir terim
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.TIPI = "Müşteri Çeki";
                Cek.EDITUSER = AnaForm.UserID;
                Cek.EDITDATE = DateTime.Now;
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Müşteri Çeki" && s.TIPI == "MÇ");
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı ve" + txtCekNo.Text + " çek numaralı müşteri çeki";
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = Cek.ID;
                CariHareket.EVRAKTURU = "Müşteri Çeki";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "MÇ";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void CariAc(int ID)
        {
            CariID = ID;
            Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
            txtCariAdi.Text = Cari.CARIADI;
            txtCariKodu.Text = Cari.CARIKODU;
        }


        public frmMusteriCekii()
        {
            InitializeComponent();
        }

        private void frmMusteriCekii_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            Mesajlar.FormAcilis(this.Text);
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0)
            {
                CariAc(id);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_CEKLERs.DeleteOnSubmit(DB.TBL_CEKLERs.First(s => s.ID == CekID));
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Müşteri Çeki"));
                Temizle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text != null)
            {
                if (Edit) Guncelle();
                else YeniCekKaydet();
            }
        }

        private void frmMusteriCekii_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}