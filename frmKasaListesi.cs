﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaListesi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public frmKasaListesi()
        {
            InitializeComponent();
        }

        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASALISTESI
                      where s.KASAKODU.Contains(txtKasaKodu.Text) && s.KASAADI.Contains(txtKasaAdi.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
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
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            MessageBox.Show("İlgili Form Temizlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}