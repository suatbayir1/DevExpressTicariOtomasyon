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

namespace Otomasyon.Modul_Banka
{
    public partial class frmParaTransferi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;

        public frmParaTransferi()
        {
            InitializeComponent();
        }

        private void txtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTuru.SelectedIndex == 0)
            {
                rbtnGelenHavale.Text = "Gelen Havale";
                rbtnGidenHavale.Text = "Giden Havale";
            }
            else if (txtTransferTuru.SelectedIndex == 1)
            {
                rbtnGelenHavale.Text = "Gelen EFT";
                rbtnGidenHavale.Text = "Giden EFT";
            }
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            Edit = false;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIKODU;
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rbtnGelenHavale.Checked) Banka.GCKODU = "G";
                if (rbtnGidenHavale.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Banka);
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelenHavale.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGidenHavale.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(Cari);
                DB.SubmitChanges();

                Mesajlar.YeniKayit("Yeni Para Transferi Gerçekleştirildi");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rbtnGelenHavale.Checked) Banka.GCKODU = "G";
                if (rbtnGidenHavale.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU ==txtTransferTuru.SelectedItem.ToString() && s.EVRAKID==IslemID);
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelenHavale.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGidenHavale.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
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
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKID == IslemID && s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString()));
                // DB.SUBMİTCHANGES()  EKLENEBİLİR
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARIID.Value);
                txtAciklama.Text = Banka.ACIKLAMA;
                txtBelgeNo.Text = Banka.BELGENO;
                txtTarih.Text = Banka.TARIH.Value.ToShortDateString();
                txtTransferTuru.Text = Banka.EVRAKTURU;
                txtTutar.Text = Banka.TUTAR.ToString();
                if (Banka.GCKODU == "G") rbtnGelenHavale.Checked=true;
                if (Banka.GCKODU == "C") rbtnGidenHavale.Checked=true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.BankaListesi(true);
            if (ID > 0) BankaAc(ID);
            AnaForm.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0) CariAc(ID);
            AnaForm.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void frmParaTransferi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}