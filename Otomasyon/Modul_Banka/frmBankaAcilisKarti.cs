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
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int SecimID = -1;

        public frmBankaAcilisKarti()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.KODU == "Normal")
            {
                btnSil.Enabled = false;
            }
        }

        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtYTMail.Text = "";
            txtYT.Text = "";
            txtSubeTelefon.Text = "";
            txtSubeAdres.Text = "";
            txtIBAN.Text = "";
            txtHesapTuruAdi.Text = "";
            txtHesapNo.Text = "";
            txtBankaSubesi.Text = "";
            txtBankaAdi.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_BANKALARs
                      select s;
            Liste.DataSource = lst;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = new Fonksiyonlar.TBL_BANKALAR();
                Banka.ADRES = txtSubeAdres.Text;
                Banka.BANKAADI = txtBankaAdi.Text;
                Banka.HESAPADI = txtHesapTuruAdi.Text;
                Banka.HESAPNO = txtHesapNo.Text;
                Banka.IBAN = txtIBAN.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                Banka.SUBE = txtBankaSubesi.Text;
                Banka.TEL = txtSubeTelefon.Text;
                Banka.TEMSILCI = txtYT.Text;
                Banka.TEMSILCIEMAIL = txtYTMail.Text;
                DB.TBL_BANKALARs.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Banka Kaydı Oluşturulmuştur");
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
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == SecimID);
                Banka.ADRES = txtSubeAdres.Text;
                Banka.BANKAADI = txtBankaAdi.Text;
                Banka.HESAPADI = txtHesapTuruAdi.Text;
                Banka.HESAPNO = txtHesapNo.Text;
                Banka.IBAN = txtIBAN.Text;
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
                Banka.SUBE = txtBankaSubesi.Text;
                Banka.TEL = txtSubeTelefon.Text;
                Banka.TEMSILCI = txtYT.Text;
                Banka.TEMSILCIEMAIL = txtYTMail.Text;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                throw;
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_BANKALARs.DeleteOnSubmit(DB.TBL_BANKALARs.First(s => s.ID == SecimID));
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
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                if(SecimID>0) Ac();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == SecimID);
                txtSubeAdres.Text = Banka.ADRES;
                txtBankaAdi.Text = Banka.BANKAADI;
                txtHesapTuruAdi.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtIBAN.Text = Banka.IBAN;
                txtBankaSubesi.Text = Banka.SUBE;
                txtSubeTelefon.Text = Banka.TEL;
                txtYT.Text = Banka.TEMSILCI;
                txtYTMail.Text = Banka.TEMSILCIEMAIL;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit && SecimID>0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void frmBankaAcilisKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}