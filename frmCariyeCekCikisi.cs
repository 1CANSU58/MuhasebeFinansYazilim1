using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Cek
{
    public partial class frmCariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frmCariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void frmCariyeCekCikisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarih.Text = DateTime.Now.ToShortDateString();
        }

        void CariAc(int ID)
        {
            string txtAciklamaKontrol1;
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKODU;
                txtAciklamaKontrol1 = Cari.ACIKLAMA;
                if (txtAciklamaKontrol1 == "" || txtAciklamaKontrol1 == null)
                {
                    txtCariAciklama.Text = " Cari İle ilgili herhangi bir AÇIKLAMA verisi yok/Veri Girilmedi";
                }
                else
                {
                    txtCariAciklama.Text = Cari.ACIKLAMA;
                }

            }
            catch (Exception ex)
            {

                Mesajlar.Hata(ex);
            }
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKA;
                txtCekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarih.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                if (Cek.VERILENCARIID != null) {

                    if (Cek.VERILENCARIID.Value > 0)
                    {
                        CariAc(Cek.VERILENCARIID.Value);
                        txtBelgeNo.Text = Cek.VERILENCARI_BELGENO;
                        txtTarih.Text = Cek.VERILENCARI_TARIHI.Value.ToString();
                    }
                }

            }
            catch (Exception sx)
            {
                Mesajlar.Hata(sx);
            }
        }

        void Temizle()
        {
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            txtVadeTarih.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUM = "CARIDE";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareketi = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareketi.ACIKLAMA = txtCekNo.Text + " Çek Numaralı ve " + txtBelgeNo.Text + " Belge NO'lu Çek ";
                CariHareketi.BORC = decimal.Parse(txtTutar.Text);
                CariHareketi.CARIID = CariID;
                CariHareketi.EVRAKID = CekID;
                CariHareketi.EVRAKTURU = "CARIYE CEK";
                CariHareketi.TARIH = DateTime.Now;
                CariHareketi.TIPI = "CEK ISLEMI";
                CariHareketi.SAVEDATE = DateTime.Now;
                CariHareketi.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(" Cariye Çek Çıkışı İşleminin Hareket kaydı ve Çek Kaydı Güncelleme İşlemi Yapıldı ");
                Temizle();
            }
            catch (Exception et)
            {
                Mesajlar.Hata(et);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUM = "CARIDE";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareketi = DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKTURU == "CARIYE CEK" && s.EVRAKID == CekID);
                CariHareketi.ACIKLAMA = txtCekNo.Text + " Çek Numaralı ve " + txtBelgeNo.Text + " Belge NO'lu Çek ";
                CariHareketi.BORC = decimal.Parse(txtTutar.Text);
                CariHareketi.CARIID = CariID;
                CariHareketi.EVRAKID = CekID;
                CariHareketi.EVRAKTURU = "CARIYE CEK";
                CariHareketi.TARIH = DateTime.Now;
                CariHareketi.TIPI = "CEK ISLEMI";
                CariHareketi.EDITDATE = DateTime.Now;
                CariHareketi.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception et)
            {
                Mesajlar.Hata(et);
            }
        }

        public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                CekGetir(CekID);
                Edit = true;
            }
            catch (Exception ab)
            {

                Mesajlar.Hata(ab);
                Temizle();
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0) CariAc(id);
            AnaForm.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            int id = Formlar.CariListesi(true);
            if (id > 0) CekGetir(id);
            AnaForm.Aktarma = -1;
            
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            if (Edit && Mesajlar.Guncelle() == DialogResult.Yes && CariID > 0 && CekID > 0) Guncelle();
            else if (CariID > 0 && CekID > 0) YeniKaydet();
            else MessageBox.Show(" Çek veya Cari Seçimi Yapılmadı/Yok");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit && Mesajlar.Sil() == DialogResult.Yes && CariID > 0 && CekID > 0)
                {
                    DB.TBL_CARIHAREKETLERI.DeleteOnSubmit(DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKTURU == "CARIYE CEK" && s.EVRAKID == CekID));
                    Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                    Cek.VERILENCARI_BELGENO = "";
                    Cek.VERILENCARIID = -1;
                    DB.SubmitChanges();
                }
            }
            catch (Exception tx)
            {
                Mesajlar.Hata(tx);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}