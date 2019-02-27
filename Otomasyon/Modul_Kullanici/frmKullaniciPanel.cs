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

namespace Otomasyon.Modul_Kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        bool Ac = false;
        int KullanıcıID = -1;

        public frmKullaniciPanel(int ID,bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullanıcıID = ID;
            if (Ac)
            {
                KullanıcıGetir(ID);
                txtKullanici.Enabled = false;
            }
        }

        void Temizle()
        {
            txtIsim.Text = "";
            txtKullanici.Text = "";
            txtKullaniciKodu.SelectedIndex = 1;
            txtSifre.Text = "";
            txtSifreT.Text = "";
            txtSoyisim.Text = "";
            rbtnPasif.Checked = true;
            Ac = false;
            KullanıcıID = -1; 
        }

        void KullanıcıGetir(int ID)
        {
            KullanıcıID = ID;
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullanıcıID);
                txtIsim.Text = Kullanici.ISIM;
                txtKullanici.Text = Kullanici.KULLANICI;
                if (Kullanici.KODU == "Normal") txtKullaniciKodu.SelectedIndex = 1;
                if (Kullanici.KODU == "Yonetici") txtKullaniciKodu.SelectedIndex = 0;
                txtSoyisim.Text = Kullanici.SOYISIM;
                txtSifre.Text = Kullanici.SIFRE;
                txtSifreT.Text = Kullanici.SIFRE;
                if (Kullanici.AKTIF.Value) rbtnAktif.Checked = true;
                if (!Kullanici.AKTIF.Value) rbtnPasif.Checked = true;

            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Trim() == txtSifreT.Text.Trim())  // 2 şifre de birbirine eşitse
            {
                if (txtIsim.Text == "")
                {
                    MessageBox.Show("İsim alanı boş bırakılamaz");
                    return;
                }
                else if (txtSoyisim.Text == "")
                {
                    MessageBox.Show("Soyisim alanı boş bırakılamaz");
                    return;
                }
                else if (txtKullanici.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz");
                    return;
                }
                else if (txtSifre.Text == "")
                {
                    MessageBox.Show("Şifre boş bırakılamaz");
                    return;
                }
                DialogResult DR = MessageBox.Show(txtKullaniciKodu.Text + " türünde bir kullanıcı açmak üzeresiniz.Devam etmek istiyor musunuz ?",
                    "Kullanıcı Kaydı Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    try
                    {
                        if (!Ac)
                        {
                            if (DB.TBL_KULLANICILARs.Where(s => s.KULLANICI == txtKullanici.Text).Count() > 0)  // veritabanında simdiki kullanıcı adında bir değer var ise yani bu kullanıcı adı zaten alınmışsa
                            {
                                MessageBox.Show("Bu kullanıcı adı daha önce alınmış");
                                return;
                            } 
                        }
                        Fonksiyonlar.TBL_KULLANICILAR Kullanici;
                        if (!Ac) Kullanici = new Fonksiyonlar.TBL_KULLANICILAR();       // daha önce açılmamışsa yeni kayıt yapıyoruz demektir
                        else Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullanıcıID);   // daha önce açılmışsa güncelleme yapacağız
                        if (rbtnAktif.Checked) Kullanici.AKTIF = true;
                        if (rbtnPasif.Checked) Kullanici.AKTIF = false;
                        Kullanici.ISIM = txtIsim.Text;
                        Kullanici.SOYISIM = txtSoyisim.Text;
                        Kullanici.KULLANICI = txtKullanici.Text;
                        Kullanici.KODU = txtKullaniciKodu.Text;
                        if (Ac) Kullanici.EDITDATE = DateTime.Now;  // şayet dışarıdan açılıyorsa güncelleme yap
                        else Kullanici.SAVEDATE = DateTime.Now;     // ilk defa açılıyorsa yeni kaydet
                        Kullanici.SIFRE = txtSifre.Text;
                        if (!Ac) DB.TBL_KULLANICILARs.InsertOnSubmit(Kullanici);    // eğer önceden açılmamışsa yeni kayıt demektir
                        DB.SubmitChanges(); // her halükarda güncelleme işlemini yap
                        if (Ac) Mesajlar.Guncelle(true);
                        else Mesajlar.YeniKayit(txtKullanici.Text+ " yeni üye kaydı gerçekleştirildi");
                        Temizle(); 
                    }
                    catch (Exception ex)
                    {
                        Mesajlar.Hata(ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Şifreler Birbiriyle Eşleşmiyor");
            }
        }


    }
}