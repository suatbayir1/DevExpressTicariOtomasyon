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
    public partial class frmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();


        public bool Secim = false;
        int SecimID = -1;

        public frmBankaListesi()
        {
            InitializeComponent();
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Listele()
        {
            var lst = from s in DB.VW_BANKALISTESIs
                      where s.HESAPADI.Contains(txtHesapAdi.Text) && s.IBAN.Contains(txtIBAN.Text) && s.HESAPNO.Contains(txtHesapNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception )
            {
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void frmBankaListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}