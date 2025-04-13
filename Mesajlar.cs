using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Fonksiyonlar
{
    internal class Mesajlar
    {
        AnaForm MesajForm = new AnaForm();

        public void YeniKayit(string Mesaj)
        {
            MesajForm.Mesaj("Yeni Kayıt Girişi", Mesaj);
            //MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Kalıcı Olarak Güncellenecektir\n Güncelleme İşlemini Onaylıyor Musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Olan Kayıt Kalıcı Olarak Silinecektir\n Silme İşlemini Onaylıyor Musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme", "Kayıt Güncellenmiştir");
           //MessageBox.Show("Kayıt Başarıyla Güncellenmiştir", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Hata(Exception Hata)
        {
            MesajForm.Mesaj("Hata Oluştu", Hata.Message);
            //MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FormAcilis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " Formu Açıldı ");
        }

        public void FormKapanis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " Formu Kapatıldı ");
        }
    }
}
