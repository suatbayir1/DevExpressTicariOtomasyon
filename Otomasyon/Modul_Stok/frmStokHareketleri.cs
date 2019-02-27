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

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        private void frmStokHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            Mesajlar.FormAcilis(this.Text);
        }
    }
}