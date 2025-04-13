using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_STOKGRUPLARI
                      select s;
            Liste.DataSource = lst;
        }

        void Temizle()
        {
            txtGrupKod.Text = "";
            txtGrupAd.Text = "";
            Edit = false;
            Listele();
        }

        void YeniKayitEt()
        {
            try
            {
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = new Fonksiyonlar.TBL_STOKGRUPLARI();
                Grup.GRUPADI = txtGrupAd.Text;
                Grup.GRUPKODU = txtGrupKod.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = AnaForm.UserID;
                DB.TBL_STOKGRUPLARI.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Grup Kaydı Oluşturuldu");
                Temizle();
                //Listele();
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
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = DB.TBL_STOKGRUPLARI.First(s => s.ID == SecimID);
                Grup.GRUPKODU = txtGrupKod.Text;
                Grup.GRUPADI = txtGrupAd.Text;
                Grup.GRUPEDITUSER = AnaForm.UserID;
                Grup.GRUPEDITDATE = DateTime.Now;
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
                DB.TBL_STOKGRUPLARI.DeleteOnSubmit(DB.TBL_STOKGRUPLARI.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKayitEt();
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAd.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKod.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch(Exception)
            {
                Edit = false;
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
    }
}