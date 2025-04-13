using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Cek
{
    public partial class frmMusteriCeki : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frmMusteriCeki()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtAsilBorclu.Text = "";
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtCekTuru.SelectedIndex = 0;
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            AnaForm.Aktarma = -1;
            Edit = false;

        }

        private void frmMusteriCeki_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void YeniCekKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();
                Cek.ACIKLAMA = txtAciklama.Text;
                if (txtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (txtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariID;
                Cek.BANKA = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUM = "PORTFOY";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "HAYIR";
                Cek.TARIH = DateTime.Now;
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.TIPI = "MUSTERI CEKI";
                Cek.ASILBORCLU = txtAsilBorclu.Text;
                Cek.SAVEDATE = DateTime.Now;
                Cek.SAVEUSER = AnaForm.UserID;
                DB.TBL_CEKLER.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " No'lu Müşteri Çeki Kaydı Oluşturuldu");
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " Belge Numaralı ve " + txtCekNo.Text + " Çek Numaralı Müşteri çeki ";
                //CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = Cek.ID;
                CariHareket.EVRAKTURU = "MUSTERI CEKI";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "MC";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " No'lu Müşteri Çeki - CARİ - Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                Cek.ACIKLAMA = txtAciklama.Text;
                if (txtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (txtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariID;
                Cek.BANKA = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUM = "PORTFOY";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "HAYIR";
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.TIPI = "MUSTERI CEKI";
                Cek.ASILBORCLU = txtAsilBorclu.Text;
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "MUSTERI CEKI" && s.TIPI == "MC");
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " Belge Numaralı ve " + txtCekNo.Text + " Çek Numaralı Müşteri çeki ";
                //CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = Cek.ID;
                CariHareket.EVRAKTURU = "MUSTERI CEKI";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "MC";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void CariAc(int ID)
        {
            CariID = ID;
            Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
            txtCariAdi.Text = Cari.CARIADI;
            txtCariKodu.Text = Cari.CARIKODU;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if(id > 0)
            {
                CariAc(id);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            
            if (Edit) Guncelle(); else YeniCekKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit & CekID > 0 & Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_CEKLER.DeleteOnSubmit(DB.TBL_CEKLER.First(s => s.ID == CekID));
                DB.TBL_CARIHAREKETLERI.DeleteOnSubmit(DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "MUSTERI CEKI"));
                Temizle();
            }
        }

        public void Ac(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                txtAciklama.Text = Cek.ACIKLAMA;
                if (Cek.ACKODU == "A") txtCekTuru.SelectedIndex = 0;
                if (Cek.ACKODU == "C") txtCekTuru.SelectedIndex = 1;
                txtAsilBorclu.Text = Cek.ASILBORCLU;
                txtBanka.Text = Cek.BANKA;
                txtBelgeNo.Text = Cek.BELGENO;
                txtCekNo.Text = Cek.CEKNO;
                txtHesapNo.Text = Cek.HESAPNO;
                txtSube.Text = Cek.SUBE;
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                CariAc(Cek.ALINANCARIID.Value);
                Edit = true;

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}