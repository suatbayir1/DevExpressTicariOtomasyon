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
    public partial class frmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        int IslemID = -1;
        int BankaID = -1;
        string EvrakTuru = "";

        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtBakiye.Text = "";
            txtCikis.Text = "";
            txtGiris.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            IslemID = -1;
            BankaID = -1;
        }

        void Listele()
        {
            var lst = from s in DB.VW_BANKAHAREKETLERIs
                      where s.BANKAID==BankaID
                      select s;
            Liste.DataSource = lst;
        }

        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALISTESI Banka = DB.VW_BANKALISTESIs.First(s => s.ID == BankaID);
                txtHesapAdi.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtGiris.Text = Banka.GIRIS.Value.ToString();
                txtCikis.Text = Banka.CIKIS.Value.ToString();
                txtBakiye.Text = Banka.BAKIYE.Value.ToString();
                Listele();
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

        void Sec()
        {
            try
            {
                IslemID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                EvrakTuru = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                IslemID = -1;
                EvrakTuru = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (IslemID>0)
            {
                if (EvrakTuru == "Banka İşlem")
                {
                    BankaIslemiDuzenle.Enabled = true;
                    ParaTransferiDuzenle.Enabled = false;
                }
                else if (EvrakTuru == "Banka Havale" || EvrakTuru == "Banka EFT")
                {
                    BankaIslemiDuzenle.Enabled = false;
                    ParaTransferiDuzenle.Enabled = true;
                } 
            }
        }

        private void BankaIslemiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem(true,IslemID);
            Listele();
        }

        private void ParaTransferiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaParaTransfer(true, IslemID);
            Listele();
        }

        private void frmBankaHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}