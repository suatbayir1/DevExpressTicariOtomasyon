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
    public partial class frmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();

        bool Edit = false;
        int SecimID = -1;

        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarası();
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }


        void Temizle()
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarası();
            txtKasaAdi.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = new Fonksiyonlar.TBL_KASALAR();
                Kasa.ACIKLAMA = txtAciklama.Text;
                Kasa.KASAADI = txtKasaAdi.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.SAVEDATE = DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASALARs.InsertOnSubmit(Kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kasa Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_KASALAR Kasa = DB.TBL_KASALARs.First(s => s.ID == SecimID);
                Kasa.KASAADI = txtKasaAdi.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.ACIKLAMA = txtAciklama.Text;
                Kasa.EDITDATE = DateTime.Now;
                Kasa.EDITUSER = AnaForm.UserID;
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
                DB.TBL_KASALARs.DeleteOnSubmit(DB.TBL_KASALARs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
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
                //Gridview den bilgileri çekiyoruz
                Edit = true; // seçme yapıldığı için güncelleme veya silme yapılabilir
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KASALARs
                      select s;
            Liste.DataSource = lst;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text !="" && txtKasaAdi.Text !="")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
                {
                    Guncelle();
                }
                else
                {
                    YeniKaydet();
                } 
            }
            else
            {
                MessageBox.Show("Lütfen açıklama ve kasa adı'nı doldurunuz", "İşlem Hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text!="" && txtKasaAdi.Text!="")
            {
                if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
                {
                    Sil();
                } 
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

        private void frmKasaAcilisKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}