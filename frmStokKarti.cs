using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokKarti : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupID = -1;
        int StokID = -1;

        public frmStokKarti()
        {
            InitializeComponent();
        }

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            txtStokKod.Text = Numaralar.StokKodNumarasi();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtStokKod.Text = Numaralar.StokKodNumarasi();
            txtStokAd.Text = "";
            txtFiyatSatis.Text = "0";
            txtKdvSatis.Text = "0";
            txtGrupKod.Text = "";
            txtGrupAd.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            txtKdvAlis.Text = "0";
            txtFiyatAlis.Text = "0";
            Edit = false;
            pictureBox1.Image = null;
            //ResimSec = false;
            Resim = false;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|jpeg(*.jpeg)|*.jpeg";
            if(Dosya.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
            GrupAc(Stok.STOKGRUPID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.STOKRESIM.ToArray());
            txtFiyatAlis.Text = Stok.STOKALISFIYAT.ToString();
            txtKdvAlis.Text = Stok.STOKALISKDV.ToString();
            txtBarkod.Text = Stok.STOKBARKOD;
            txtBirim.Text = Stok.STOKBIRIM;
            txtFiyatSatis.Text = Stok.STOKSATISFIYAT.ToString();
            txtKdvSatis.Text = Stok.STOKSATISKDV.ToString();
            txtStokAd.Text = Stok.STOKADI;
            txtStokKod.Text = Stok.STOKKODU;

        }

        void Yenikaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = new Fonksiyonlar.TBL_STOKLAR();
                Stok.STOKADI = txtStokAd.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtFiyatAlis.Text);
                Stok.STOKALISKDV = decimal.Parse(txtKdvAlis.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKod.Text;
                Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(txtFiyatSatis.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtKdvSatis.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = AnaForm.UserID;
                DB.TBL_STOKLAR.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Stok Kaydı Oluşturuldu");
                Temizle();
            }
            catch (Exception ex2)
            {
                Mesajlar.Hata(ex2);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
                Stok.STOKADI = txtStokAd.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtFiyatAlis.Text);
                Stok.STOKALISKDV = decimal.Parse(txtKdvAlis.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKod.Text;
                if(Resim) Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(txtFiyatSatis.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtKdvSatis.Text);
                Stok.STOKEDITDATE = DateTime.Now;
                Stok.STOKEDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception ex2)
            {
                Mesajlar.Hata(ex2);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_STOKLAR.DeleteOnSubmit(DB.TBL_STOKLAR.First(s => s.ID == StokID));
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            txtGrupAd.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupID).GRUPADI;
            txtGrupKod.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupID).GRUPKODU;
            
        }

        private void txtStokKod_EditValueChanged(object sender, EventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if(ID > 0)
            {
                Ac(ID);
                
            }
            AnaForm.Aktarma = -1;
        }

        private void txtGrupKod_EditValueChanged(object sender, EventArgs e)
        {
            int Id = Formlar.StokGruplari(true);
            if(Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            if(Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                Yenikaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void frmStokKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}