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
    public partial class frmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CekID = -1;
        int BankaID = -1;

        Fonksiyonlar.TBL_CEKLER Cek;

        public frmBankayaCekCikisi()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //disabled
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            if(Cek != null && CekID > 0 && BankaID > 0)
            {
                YeniKaydet();
            }
        }

        private void frmBankayaCekCikisi_Load(object sender, EventArgs e)
        {
            txtVadeTarih.Text = DateTime.Now.ToShortDateString();
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarih.Text = "";
            txtTutar.Text = "";
            txtSube.Text = "";
            txtHesapNo.Text = "";
            txtCekNo.Text = "";
            txtBelgeNo.Text = "";
            txtBankaAdi.Text = "";
            txtBanka.Text = "";
            AnaForm.Aktarma = -1;
            Cek = null;

        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKA;
                txtCekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarih.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();

            }
            catch (Exception sx)
            {
                Mesajlar.Hata(sx);
            }
        }

        void BankaGetir(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapNo.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).HESAPNO;
                txtBankaAdi.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).BANKAADI;

            }
            catch (Exception tx2)
            {

                Mesajlar.Hata(tx2);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtBelgeNo.Text + " Belge Numaralı ve " + txtCekNo.Text + " Numaralı Çekin Bankaya Çıkışı";
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKID = CekID;
                Hareket.EVRAKTURU = "BANKAYA CEK";
                Hareket.GCKODU = "G";
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERI.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " Numaralı Çekin Banka Kaydı Oluşturuldu ");
                Cek.VERILENBANKA_BELGENO = txtBelgeNo.Text;
                Cek.VERILENBANKA_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENBANKAID = BankaID;
                Cek.DURUM = "BANKADA";
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " Numaralı Çekin Durum Günçellemsi Oluşturuldu ");
                Temizle();
            }
            catch (Exception ux)
            {

                Mesajlar.Hata(ux);
            }
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.BankaListesi(true);
            if(id > 0)
            {
                BankaGetir(id);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CekListesi(true);
            if (id > 0)
            {
                CekGetir(id);
            }
            AnaForm.Aktarma = -1;
        }


    }
}