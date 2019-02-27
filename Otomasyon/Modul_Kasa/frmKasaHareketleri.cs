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
    public partial class frmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        
        int HareketID = -1;
        int KasaID = -1;
        int EvrakID = -1;
        string EvrakTURU;

        public frmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Mesajlar.FormAcilis(this.Text);
        }

        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void DurumGetir()
        {
            Fonksiyonlar.VW_KASADURUM Kasa = DB.VW_KASADURUMs.First(s => s.KASAID == KasaID);
            txtGiris.Text = Kasa.GIRIS.Value.ToString();
            txtCikis.Text = Kasa.CIKIS.Value.ToString();
            txtBakiye.Text = Kasa.BAKIYE.Value.ToString();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASAHAREKETLERIs
                      where s.KASAID == KasaID
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridview1.GetFocusedRowCellValue("ID").ToString());

                try
                {
                    EvrakID = int.Parse(gridview1.GetFocusedRowCellValue("EVRAKID").ToString());
                }
                catch (Exception)
                {
                    EvrakID = -1;
                }   
                EvrakTURU=gridview1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakID = -1;
            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void gridview1_Click(object sender, EventArgs e)
        {

        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if(EvrakTURU=="Kasa Devir Karti")
            {
                DevirKartiDuzenle.Enabled = true;
                TahsilatOdemeDuzenle.Enabled = true;
            }
            else if (EvrakTURU=="Kasa Tahsilat" || EvrakTURU=="Kasa Ödeme")
            {
                DevirKartiDuzenle.Enabled = false;
                TahsilatOdemeDuzenle.Enabled = true;
            }
        }

        private void DevirKartiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaDevirIslemKarti(true, HareketID);
            Listele();
        }

        private void TahsilatOdemeDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti(true, HareketID);
            Listele();
        }

        private void frmKasaHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}