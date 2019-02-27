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
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecilenID = -1;

        public frmCekListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CEKLERs
                      where s.TIPI.Contains(txtCekTuru.Text) && s.BANKASI.Contains(txtBanka.Text) && s.CEKNO.Contains(txtCekNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Sec()
        {
            try
            {
                SecilenID=int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecilenID>0)
            {
                AnaForm.Aktarma = SecilenID;
                this.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void frmCekListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}