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

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;
        public frmCariGruplari()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtGrupAd.Text = "";
            txtGrupKod.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CARIGRUPLARI
                      select s;
            Liste.DataSource = lst;
        }

        void YeniLKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                Grup.GRUPADI = txtGrupAd.Text;
                Grup.GRUPKODU = txtGrupKod.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIGRUPLARI.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Grup Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARI.First(s => s.ID == SecimID);
                Grup.GRUPADI = txtGrupAd.Text;
                Grup.GRUPKODU = txtGrupKod.Text;
                Grup.EDITDATE = DateTime.Now;
                Grup.EDITUSER = AnaForm.UserID;
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
                DB.TBL_CARIGRUPLARI.DeleteOnSubmit(DB.TBL_CARIGRUPLARI.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }

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
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }



        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKayitEt_Click_1(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniLKaydet();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
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