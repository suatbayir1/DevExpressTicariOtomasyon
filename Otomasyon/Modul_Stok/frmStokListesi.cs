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
using System.Data.Linq;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {

        public bool Secim = false;
        int SecimID = -1;

        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
            Mesajlar.FormAcilis(this.Text);
        }

        void Listele()
        {
            /* Stoklar tablosundaki verileri çek ve listele  burdaki contains komutu SQL deki LIKE ile aynı işi yapar*/
            var lst = from s in DB.TBL_STOKLARs
                      where s.STOKADI.Contains(txtStokAdi.Text) && s.STOKBARKOD.Contains(txtStokBarkod.Text) && s.STOKKODU.Contains(txtStokKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
        }

        void Sec()
        {
            try
            {
                SecimID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
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

        private void frmStokListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }

        private void btnPrintToPDF_Click(object sender, EventArgs e)
        {
            /* pdf aktarma */
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Acrobat Reader|*.pdf";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToPdf(sf.FileName);
                }
            }

        }

        private void btnPrintToXls_Click(object sender, EventArgs e)
        {
            /* excel aktarma */
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Excel|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToXls(sf.FileName);
                }
            }
        }
    }
}