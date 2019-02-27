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
using System.Linq;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;

        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CARILERs
                      where s.CARIADI.Contains(txtCariAdi.Text) && s.CARIKODU.Contains(txtCariKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception e)
            {
                SecimID = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void frmCariListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}