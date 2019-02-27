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

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int KasaID = -1;
        int CariID = -1;
        int CariHareketID = -1;

        public frmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Mesajlar.FormAcilis(this.Text);
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        
        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeMakbuzNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            KasaID = -1;
            CariID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                CariHareketID = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == KasaHareketi.EVRAKTURU && s.EVRAKID == IslemID).ID;
                MessageBox.Show("Cari hareket ıd : " + CariHareketID.ToString());
                txtAciklama.Text = KasaHareketi.ACIKLAMA;
                txtBelgeMakbuzNo.Text = KasaHareketi.BELGENO;
                if (KasaHareketi.EVRAKTURU == "Kasa Tahsilat") txtIslemTuru.SelectedIndex = 0;
                if (KasaHareketi.EVRAKTURU == "Kasa Ödeme") txtIslemTuru.SelectedIndex = 1;
                txtTarih.Text = KasaHareketi.TARIH.Value.ToShortDateString();
                txtTutar.Text = KasaHareketi.TUTAR.Value.ToString();
                KasaAc(KasaHareketi.KASAID.Value);
                CariAc(KasaHareketi.CARIID.Value);
            }
            catch (Exception e)
            {
                Temizle();
                Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception)
            {
                KasaID = -1;

            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIKODU;
            }
            catch (Exception)
            {
                CariID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                /* KASAHAREKETLERİ TABLOSUNA EKLEME */
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                KasaHareketi.ACIKLAMA = txtAciklama.Text;
                KasaHareketi.BELGENO = txtBelgeMakbuzNo.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex==0) KasaHareketi.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex==1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.SAVEDATE = DateTime.Now;
                KasaHareketi.SAVEUSER = AnaForm.Aktarma;
                KasaHareketi.TARIH = DateTime.Parse(txtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txtTutar.Text);
                DB.TBL_KASAHAREKETLERIs.InsertOnSubmit(KasaHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString()+" yeni kasa hareketi gerçekleştirilmiştir");

                /* CARİ HAREKETLERİ TABLOSUNA EKLEME */
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareketi = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareketi.ACIKLAMA = txtBelgeMakbuzNo.Text + " Belge numaralı " + txtIslemTuru.SelectedItem.ToString() + " işlemi ";
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.BORC = decimal.Parse(txtTutar.Text);
                CariHareketi.CARIID = CariID;
                CariHareketi.EVRAKID = KasaHareketi.ID;
                CariHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                CariHareketi.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.TIPI = "KÖ";
                CariHareketi.SAVEDATE = DateTime.Now;
                CariHareketi.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString() + " yeni cari hareketi gerçekleştirilmiştir");

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
                /* KASAHAREKETLERİ TABLOSUNA EKLEME */
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                KasaHareketi.ACIKLAMA = txtAciklama.Text;
                KasaHareketi.BELGENO = txtBelgeMakbuzNo.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.EDITDATE = DateTime.Now;
                KasaHareketi.EDITUSER = AnaForm.Aktarma;
                KasaHareketi.TARIH = DateTime.Parse(txtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);

                /* CARİ HAREKETLERİ TABLOSUNA EKLEME */
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareketi = DB.TBL_CARIHAREKETLERIs.First(s => s.ID==CariHareketID);
                CariHareketi.ACIKLAMA = txtBelgeMakbuzNo.Text + " Belge numaralı " + txtIslemTuru.SelectedItem.ToString() + " işlemi ";
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.BORC = decimal.Parse(txtTutar.Text);
                CariHareketi.CARIID = CariID;
                CariHareketi.EVRAKID = KasaHareketi.ID;
                CariHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                CariHareketi.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.TIPI = "KÖ";
                CariHareketi.EDITDATE = DateTime.Now;
                CariHareketi.EDITUSER = AnaForm.UserID;
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
                DB.TBL_KASAHAREKETLERIs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID));
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID > 0)
            {
                KasaAc(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0)
            {
                CariAc(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && IslemID>0 && CariHareketID>0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit && IslemID>0 && CariHareketID>0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKasaTahsilatOdeme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}