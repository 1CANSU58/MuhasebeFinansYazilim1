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
using Otomasyon.Fonksiyonlar;

namespace Otomasyon.Modul_Cek
{
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int SecimID = -1;
        public bool Secim = false;

        public frmCekListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CEKLER
                      where s.TIPI.Contains(txtCekTuru.Text) && s.BANKA.Contains(txtBanka.Text) && s.CEKNO.Contains(txtCekNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception yt)
            {

                Mesajlar.Hata(yt);
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCekTuru.SelectedIndex = 0;
            txtCekNo.Text = "";
            txtBanka.Text = "";
            MessageBox.Show(" İlgili Form Temizlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}