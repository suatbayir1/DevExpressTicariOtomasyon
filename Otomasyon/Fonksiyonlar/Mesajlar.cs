using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Fonksiyonlar
{
    class Mesajlar
    {

        AnaForm MesajForm = new AnaForm();

        /* Genel Mesaj Fonksiyonları */
        public void YeniKayit(string Mesaj)
        {
            // anaforma parametre gönderip popup açıyoruz
            MesajForm.Mesaj("Yeni Kayıt Giriş",Mesaj);
        }
        
        public DialogResult Guncelle() {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Güncellenecektir\nDevam Etmek İstiyor Musunuz ?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Silinecektir.\nDevam Etmek İstiyor Musunuz ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme","Kayıt Güncellenmiştir");
        }

        public void Hata(Exception Hata)
        {
            MesajForm.Mesaj("Hata Oluştu",Hata.Message);
            //MessageBox.Show(Hata.Message,"Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void FormAcilis(string FormAdi)
        {
            MesajForm.Mesaj("",FormAdi +" formu açıldı.");
        }

        public void FormKapanis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu kapatıldı.");
        }
    }
}
