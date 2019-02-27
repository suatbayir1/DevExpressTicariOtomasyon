﻿using System;
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
    public partial class frmKasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;


        public frmKasaDevirIslem()
        {
            InitializeComponent();
        }

        private void frmKasaDevirIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Mesajlar.FormAcilis(this.Text);
        }
        
        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            txtKasaKodu.Text = "";
            txtKasaAdi.Text = "";
            txtBelgeMakbuzNo.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeMakbuzNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Kasa Devir Kartı Oluşturuldu");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeMakbuzNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = AnaForm.UserID;
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
                DB.TBL_KASAHAREKETLERIs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;

            }
            catch (Exception )
            { 
                

            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeMakbuzNo.Text = Hareket.BELGENO;
                KasaAc(Hareket.KASAID.Value);
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.Value.ToString();
                if (Hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtnCikis.Checked = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && IslemID>0 && Mesajlar.Guncelle() == DialogResult.Yes)
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
            if(Edit && IslemID >0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID > 0)
            {
                KasaAc(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtBelgeMakbuzNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void frmKasaDevirIslem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}