using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Otomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /* Burada Formlar grubunu çağırıyoruz bu sayede aşağıdaki formlar doğrudan açılacak */
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static Fonksiyonlar.TBL_KULLANICILAR Kullanici;
        public static int UserID = -1;
        public static int Aktarma = -1;

        public AnaForm()
        {
            InitializeComponent();
        }

        public AnaForm(Fonksiyonlar.TBL_KULLANICILAR GelenKullanici)
        {
            InitializeComponent();
            Kullanici = GelenKullanici;
            UserID = Kullanici.ID;
            txtAltKullanici.Caption = Kullanici.KULLANICI;
            if (Kullanici.KODU == "Normal")         // eğer kullanıcı normal ise yetkili değilse
            {
                barBtnKullanici.Visibility = BarItemVisibility.Never;   // asla gösterme
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        public void Mesaj(string Baslik,string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }

        #region STOK BUTONLARI
        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barBtnStokGrup_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void navBtnStokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void navBtnStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void navBtnStokGrupları_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void navBtnStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokHareketleri();
        }
        #endregion

        #region CARİ BUTONLARI
        private void barBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void barBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void barBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void navBtnCariAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void navBtnCariGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void navBtnCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void navBtnCariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        #endregion

        #region BANKA BUTONLARI
        private void barBtnBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void barBtnBankaIslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void barBtnBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void barBtnParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void barBtnBankaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaHareketleri();
        }

        private void navBtnBankaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void navBtnParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void navBtnBankaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void navBtnBankaIslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void navBtnBankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaHareketleri();
        }
        #endregion

        #region KASA BUTONLARI
        private void barBtnKasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void barBtnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void barBtnKasaDevirIslemKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void barBtnKasaTahsilatOdeme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void barBtnKasaHareketleri_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void navBtnKasaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void navBtnKasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void navBtnKasaDevirIslemKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void navBtnKasaTahsilatOdeme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void navBtnKasaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        #endregion

        #region ÇEK BUTONLARI
        private void barBtnMusteriCeki_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void barBtnKendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void barBtnBankayaCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankayaCekCikisi();
        }

        private void barBtnCariyeCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariyeCekCikisi();
        }

        private void navBtnKendiCekimiz_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void navBtnMusteriCeki_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void navBtnBankayaCekCikisi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankayaCekCikisi();
        }

        private void navBtnCariyeCekCikisi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariyeCekCikisi();
        }

        private void barBtnCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }

        #endregion

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barBtnSatisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Fatura();
        }

        private void barBtnSatisIadeFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.FaturaListesi();
        }

        private void barBtnKullanici_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KullaniciYonetimi();
        }
    }
}