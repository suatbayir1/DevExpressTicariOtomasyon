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
    public partial class frmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CekID = -1;
        int BankaID = -1;

        public frmBankayaCekCikisi()
        {
            InitializeComponent();
        }

        private void frmBankayaCekCikisi_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtBanka.Text = "";
            txtBankaAdi.Text = "";
            txtBelgeNo.Text = "";
            txtCekNo.Text = "";
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            CekID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKASI;
                txtCekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void BankaGetir(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == BankaID);
                txtHesapNo.Text = Banka.HESAPNO;
                txtBankaAdi.Text = Banka.BANKAADI;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtBelgeNo.Text + " belge no'lu ve" + txtCekNo.Text + " cek no'lu çekin bankaya çıkışı";
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKID = CekID;
                Hareket.EVRAKTURU = "Bankaya Çek";
                Hareket.GCKODU = "G";
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = Decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text+" çek no'lu çekin banka hareket kaydı işlenmiştir..");

                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.VERILENBANKA_BELGENO = txtBelgeNo.Text;
                Cek.VERILENBANKA_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENBANKAID = BankaID;
                Cek.DURUMU = "Bankada";
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text+" no'lu çekin durum güncellemesi yapılmıştır..");
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.BankaListesi(true);
            if (ID > 0)
            {
                BankaGetir(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CekListesi(true);
            if (ID > 0)
            {
                CekGetir(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(CekID>0 && BankaID > 0)
            {
                YeniKaydet();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBankayaCekCikisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}