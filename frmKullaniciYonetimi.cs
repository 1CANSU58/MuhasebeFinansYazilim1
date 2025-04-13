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

namespace Otomasyon.Modul_Kullanici
{
    public partial class frmKullaniciYonetimi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int Secim = -1;

        public frmKullaniciYonetimi()
        {
            InitializeComponent();
            this.Shown += frmKullaniciYonetimi_Shown;
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KULLANICILAR
                      select s;
            gridControl1.DataSource = lst;
        }

        void frmKullaniciYonetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            Formlar.KullaniciPanel(true, Secim);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_KULLANICILAR.DeleteOnSubmit(DB.TBL_KULLANICILAR.First(s => s.ID == Secim));
                DB.SubmitChanges();
                MessageBox.Show(" İlgili Veri Silinid ");
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Secim = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
        }
    }
}