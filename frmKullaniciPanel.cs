using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using Otomasyon.Fonksiyonlar;

namespace Otomasyon.Modul_Kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        bool Ac = false;
        int KullaniciID = -1;
        public frmKullaniciPanel(int ID, bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID = ID;
            if (Ac)
            {
                KullaniciGetir(ID);
                txtKullaniciAdi.Enabled = false;
            }
        }

        void Temizle()
        {

            txtKullaniciAdi.Text = "";
            txtKullaniciSifre.Text = "";
            txtKullaniciSifreTekrar.Text = "";
            txtKullaniciIsim.Text = "";
            txtKullaniciSoyisim.Text = "";
            txtKullaniciKodu.SelectedIndex = 1;
            rBtnPasif.Checked = true;
            Ac = false;
            KullaniciID = -1;
            MessageBox.Show(" İlgili Form Temizlendi ");
        }

        void KullaniciGetir(int ID)
        {
            KullaniciID = ID;
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR kullanici = DB.TBL_KULLANICILAR.First(s => s.ID == KullaniciID);
                txtKullaniciIsim.Text = kullanici.ISIM;
                txtKullaniciSoyisim.Text = kullanici.SOYISIM;
                txtKullaniciAdi.Text = kullanici.KULLANICI;
                txtKullaniciSifre.Text = kullanici.SIFRE;
                txtKullaniciSifreTekrar.Text = kullanici.SIFRE;
                if (kullanici.KODU == "NORMAL") txtKullaniciKodu.SelectedIndex = 1;
                if (kullanici.KODU == "YONETICI") txtKullaniciKodu.SelectedIndex = 0;
                if (kullanici.AKTIF.Value) rBtnAktif.Checked = true;
                if (!kullanici.AKTIF.Value) rBtnPasif.Checked = true;
            }
            catch (Exception ty)
            {

                Mesajlar.Hata(ty);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKullaniciSifre.Text.Trim() == txtKullaniciSifreTekrar.Text.Trim())
            {
                if (txtKullaniciIsim.Text == "")
                {
                    MessageBox.Show(" İsim Alanı Boş Bırakılamaz ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtKullaniciSoyisim.Text == "")
                {
                    MessageBox.Show(" Soyisim Alanı Boş Bırakılamaz ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else if (txtKullaniciAdi.Text == "")
                {
                    MessageBox.Show(" Kullanıcı Adı Alanı Boş Bırakılamaz ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else if (txtKullaniciSifre.Text == "")
                {
                    MessageBox.Show(" Şifre Alanı Boş Bırakılamaz ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                DialogResult DR = MessageBox.Show(txtKullaniciKodu.Text + " Türünde , " + txtKullaniciAdi.Text + " Kullanıcı Adında Yeni Bir Kullanıcı Açmak Üzeresiniz. İşlemi ONayla ? ", " Kullanıcı Kaydı Tamamlama ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (!Ac)
                        {

                            if (DB.TBL_KULLANICILAR.Where(s => s.KULLANICI == txtKullaniciAdi.Text).Count() > 0)
                            {
                                MessageBox.Show(" Sistemde " + txtKullaniciAdi.Text + " Adında bir Kullanıcı Adı Mevcut ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        Fonksiyonlar.TBL_KULLANICILAR kullanici;
                        if (!Ac) kullanici = new Fonksiyonlar.TBL_KULLANICILAR();
                        else kullanici = DB.TBL_KULLANICILAR.First(s => s.ID == KullaniciID);
                        if (rBtnAktif.Checked) kullanici.AKTIF = true;
                        if (rBtnPasif.Checked) kullanici.AKTIF = false;
                        kullanici.ISIM = txtKullaniciIsim.Text;
                        kullanici.SOYISIM = txtKullaniciSoyisim.Text;
                        kullanici.KULLANICI = txtKullaniciAdi.Text;
                        kullanici.KODU = txtKullaniciKodu.Text;
                        if (Ac) kullanici.EDITDATE = DateTime.Now;
                        else kullanici.SAVEDATE = DateTime.Now;
                        kullanici.SIFRE = txtKullaniciSifre.Text;
                        if (!Ac) DB.TBL_KULLANICILAR.InsertOnSubmit(kullanici);
                        DB.SubmitChanges();
                        if (Ac) Mesajlar.Guncelle(true);
                        else Mesajlar.YeniKayit(txtKullaniciAdi.Text + " Adlı Yeni Kullanıcı Oluşturuldu ");
                        Temizle();
                    }
                    catch (Exception ex)
                    {

                        Mesajlar.Hata(ex);
                    }
                }
            }
            else
            {
                MessageBox.Show(" Girilen Şifreler Uyuşmuyor ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //YeniKaydet();
        }

        /*
        void YeniKaydet()
        {

        }
        */
    }
}