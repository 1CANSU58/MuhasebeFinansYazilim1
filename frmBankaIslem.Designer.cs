namespace Otomasyon.Modul_Banka
{
    partial class frmBankaIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaIslem));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayitEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtHesapAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rBtnGiris = new System.Windows.Forms.RadioButton();
            this.rBtnCikis = new System.Windows.Forms.RadioButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKayitEt);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.txtHesapAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(458, 162);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Temel Bilgiler";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Hesap No ";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(77, 112);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Properties.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(243, 20);
            this.txtHesapNo.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Hesap Ad/Tür";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Belge No ";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(77, 45);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(243, 20);
            this.txtBelgeNo.TabIndex = 13;
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(340, 116);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(91, 39);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitEt.ImageOptions.Image")));
            this.btnKayitEt.Location = new System.Drawing.Point(340, 26);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(91, 39);
            this.btnKayitEt.TabIndex = 10;
            this.btnKayitEt.Text = "Kayıt Et";
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(340, 71);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 39);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(77, 76);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesapAdi.Properties.ReadOnly = true;
            this.txtHesapAdi.Size = new System.Drawing.Size(243, 20);
            this.txtHesapAdi.TabIndex = 15;
            this.txtHesapAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHesapAdi_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Controls.Add(this.txtTarih);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 162);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(458, 222);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "İşlem Bilgiler";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rBtnGiris);
            this.groupControl3.Controls.Add(this.rBtnCikis);
            this.groupControl3.Location = new System.Drawing.Point(243, 26);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(210, 46);
            this.groupControl3.TabIndex = 25;
            this.groupControl3.Text = "İşlem Türü ";
            // 
            // rBtnGiris
            // 
            this.rBtnGiris.AutoSize = true;
            this.rBtnGiris.Checked = true;
            this.rBtnGiris.Location = new System.Drawing.Point(19, 25);
            this.rBtnGiris.Name = "rBtnGiris";
            this.rBtnGiris.Size = new System.Drawing.Size(78, 17);
            this.rBtnGiris.TabIndex = 0;
            this.rBtnGiris.TabStop = true;
            this.rBtnGiris.Text = "Giriş İşlemi ";
            this.rBtnGiris.UseVisualStyleBackColor = true;
            // 
            // rBtnCikis
            // 
            this.rBtnCikis.AutoSize = true;
            this.rBtnCikis.Location = new System.Drawing.Point(124, 25);
            this.rBtnCikis.Name = "rBtnCikis";
            this.rBtnCikis.Size = new System.Drawing.Size(79, 17);
            this.rBtnCikis.TabIndex = 1;
            this.rBtnCikis.Text = "Çıkış İşlemi ";
            this.rBtnCikis.UseVisualStyleBackColor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Açıklama ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Tutar ";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(77, 52);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTutar.Properties.MaskSettings.Set("mask", "c");
            this.txtTutar.Size = new System.Drawing.Size(160, 20);
            this.txtTutar.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Tarih ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(77, 78);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(376, 133);
            this.txtAciklama.TabIndex = 23;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(77, 26);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(160, 20);
            this.txtTarih.TabIndex = 19;
            // 
            // frmBankaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 384);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmBankaIslem.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka İşlem";
            this.Load += new System.EventHandler(this.frmBankaIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKayitEt;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rBtnGiris;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.RadioButton rBtnCikis;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.ButtonEdit txtHesapAdi;
        private DevExpress.XtraEditors.DateEdit txtTarih;
    }
}