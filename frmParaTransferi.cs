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

namespace Otomasyon.Modul_Banka
{
    public partial class frmParaTransferi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;

        public frmParaTransferi()
        {
            InitializeComponent();
        }

        private void txtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTuru.SelectedIndex == 0)
            {
                rBtnGelen.Text = "Gelen Havale";
                rBtnGiden.Text = "Giden Havale";
            }
            else if(txtTransferTuru.SelectedIndex == 1)
            {
                rBtnGelen.Text = "Gelen EFT";
                rBtnGiden.Text = "Giden EFT";
            }
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERI.First(s => s.ID == IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARIID.Value);
                txtAciklama.Text = Banka.ACIKLAMA;
                txtBelgeNo.Text = Banka.BELGENO;
                txtTarih.Text = Banka.TARIH.Value.ToShortDateString();
                txtTransferTuru.Text = Banka.EVRAKTURU;
                txtTutar.Text = Banka.TUTAR.ToString();
                if (Banka.GCKODU == "G") rBtnGelen.Checked = true;
                if (Banka.GCKODU == "C") rBtnGiden.Checked = true;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).HESAPNO;

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.TBL_CARILER.First(s => s.ID == CariID).CARIKODU;
                txtCariAdi.Text = DB.TBL_CARILER.First(s => s.ID == CariID).CARIADI;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rBtnGelen.Checked) Banka.GCKODU = "G";
                if (rBtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERI.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rBtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rBtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Para Transfer Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERI.First(s => s.ID == IslemID);
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rBtnGelen.Checked) Banka.GCKODU = "G";
                if (rBtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID);
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rBtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rBtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
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
               DB.TBL_CARIHAREKETLERI.DeleteOnSubmit(DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID));
                DB.TBL_BANKAHAREKETLERI.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERI.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
                
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0) CariAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}