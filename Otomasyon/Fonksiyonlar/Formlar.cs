using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors; // devexpress bileşenlerini import ederek liste kontrollerini yapıyoruz

namespace Otomasyon.Fonksiyonlar
{
    class Formlar
    {

        #region STOK FORMLARI
        public int StokListesi(bool Secim = false)
        {
            /* Stok listesi için yeni form oluştu */
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();

            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                /* UYGULAMA EKRANINDA LİSTELER AÇILDIYSA BİR DAHA AÇILMAYACAK */
                foreach (DevExpress.XtraEditors.XtraForm k in AnaForm.ActiveForm.MdiChildren)
                {
                    if (k.Text == "Stok Listesi")
                    {
                        k.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public int StokGruplari(bool Secim = false)
        {
            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {

        }

        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.frmStokKarti frm = new Modul_Stok.frmStokKarti();
            frm.ShowDialog();

        }
        #endregion

        #region CARİ FORMLARI
        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.frmCariGruplari frm = new Modul_Cari.frmCariGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();

            return AnaForm.Aktarma;
        }

        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {                /* UYGULAMA EKRANINDA LİSTELER AÇILDIYSA BİR DAHA AÇILMAYACAK */
                foreach (DevExpress.XtraEditors.XtraForm k in AnaForm.ActiveForm.MdiChildren)
                {
                    if (k.Text == "Cari Listesi")
                    {
                        k.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modul_Cari.frmCariAcilisKarti frm = new Modul_Cari.frmCariAcilisKarti();
            if (Ac)
            {
                frm.Ac(CariID);
            }
            frm.ShowDialog();
        }

        #endregion

        #region KASA FORMLARI
        public void KasaAcilisKarti()
        {
            Modul_Kasa.frmKasaAcilisKarti frm = new Modul_Kasa.frmKasaAcilisKarti();
            frm.ShowDialog();
        }

        public void KasaDevirIslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.frmKasaDevirIslem frm = new Modul_Kasa.frmKasaDevirIslem();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();

        }

        public int KasaListesi(bool Secim = false)
        {
            Modul_Kasa.frmKasaListesi frm = new Modul_Kasa.frmKasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                /* UYGULAMA EKRANINDA LİSTELER AÇILDIYSA BİR DAHA AÇILMAYACAK */
                foreach (DevExpress.XtraEditors.XtraForm k in AnaForm.ActiveForm.MdiChildren)
                {
                    if (k.Text == "Kasa Listesi")
                    {
                        k.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void KasaTahsilatOdemeKarti(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmKasaTahsilatOdeme frm = new Modul_Kasa.frmKasaTahsilatOdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        } 

        public void KasaHareketleri(bool Ac=false , int ID = -1)
        {
            Modul_Kasa.frmKasaHareketleri frm = new Modul_Kasa.frmKasaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.Ac(ID);
            frm.Show();
        }
        #endregion

        #region BANKA FORMLARI
        public void BankaAcilisKarti()
        {
            Modul_Banka.frmBankaAcilisKarti frm = new Modul_Banka.frmBankaAcilisKarti();
            frm.ShowDialog();
        }

        public void BankaIslem(bool Ac = false, int ID = -1)
        {
            Modul_Banka.frmBankaIslemi frm = new Modul_Banka.frmBankaIslemi();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public int BankaListesi(bool Secim = false)
        {
            Modul_Banka.frmBankaListesi frm = new Modul_Banka.frmBankaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                /* UYGULAMA EKRANINDA LİSTELER AÇILDIYSA BİR DAHA AÇILMAYACAK */
                foreach (DevExpress.XtraEditors.XtraForm k in AnaForm.ActiveForm.MdiChildren)
                {
                    if (k.Text == "Banka Listesi")
                    {
                        k.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void BankaParaTransfer(bool Ac = false, int ID = -1)
        {
            Modul_Banka.frmParaTransferi frm = new Modul_Banka.frmParaTransferi();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Banka.frmBankaHareketleri frm = new Modul_Banka.frmBankaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.BankaAc(ID);
            frm.Show();
        }

        #endregion

        #region ÇEK FORMLARI
        public void KendiCekimiz(int ID=0,bool Ac=false)
        {
            Modul_Cek.frmKendiCekimiz frm = new Modul_Cek.frmKendiCekimiz();
            //if (Ac)  ;
            frm.ShowDialog();
        }

        public void MusteriCeki(int ID = 0, bool Ac = false)
        {
            Modul_Cek.frmMusteriCekii frm = new Modul_Cek.frmMusteriCekii();
           // if(Ac) ;
            frm.ShowDialog();
        }

        public void CariyeCekCikisi(int ID=0,bool Ac = false)
        {
            Modul_Cek.frmCariyeCekCikisi frm = new Modul_Cek.frmCariyeCekCikisi();
            //if(Ac);
            frm.ShowDialog();
        }

        public void BankayaCekCikisi(int ID=0,bool Ac = false)
        {
            Modul_Cek.frmBankayaCekCikisi frm = new Modul_Cek.frmBankayaCekCikisi();
            //
            frm.ShowDialog();
        }

        public int CekListesi(bool secim = false)
        {
            Modul_Cek.frmCekListesi frm = new Modul_Cek.frmCekListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                /* UYGULAMA EKRANINDA LİSTELER AÇILDIYSA BİR DAHA AÇILMAYACAK */
                foreach(DevExpress.XtraEditors.XtraForm k in AnaForm.ActiveForm.MdiChildren)
                {
                    if(k.Text=="Çek Listesi")
                    {
                        k.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        #endregion

        #region FATURA FORMLARI
        public void Fatura(bool Ac = false, int ID = -1, bool Irsaliye = false)
        {
            Modul_Fatura.frmSatisFaturasi frm = new Modul_Fatura.frmSatisFaturasi(Ac, ID, Irsaliye);
            frm.MdiParent = AnaForm.ActiveForm;
            frm.Show();
        }

        public void FaturaListesi(bool Secim = false)
        {
            Modul_Fatura.frmFaturaListesi frm = new Modul_Fatura.frmFaturaListesi(Secim);
            if (Secim) frm.ShowDialog();
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        #endregion

        #region KULLANICI FORMLARI
        public void KullaniciYonetimi()
        {
            Modul_Kullanici.frmKullaniciYonetimi frm = new Modul_Kullanici.frmKullaniciYonetimi();
            frm.ShowDialog();
        }

        public void KullaniciPanel(bool Ac = false, int ID = -1)
        {
            Modul_Kullanici.frmKullaniciPanel frm = new Modul_Kullanici.frmKullaniciPanel(ID, Ac);
            frm.ShowDialog();
        } 
        #endregion
    }
}
