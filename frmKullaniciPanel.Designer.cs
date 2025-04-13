namespace Otomasyon.Modul_Kullanici
{
    partial class frmKullaniciPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciPanel));
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.rBtnAktif = new System.Windows.Forms.RadioButton();
            this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciIsim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciSoyisim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciKodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.rBtnPasif = new System.Windows.Forms.RadioButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyisim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(304, 81);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 38);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = " Kaydet ";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Adı ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(85, 22);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(182, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // rBtnAktif
            // 
            this.rBtnAktif.AutoSize = true;
            this.rBtnAktif.Location = new System.Drawing.Point(85, 190);
            this.rBtnAktif.Name = "rBtnAktif";
            this.rBtnAktif.Size = new System.Drawing.Size(47, 17);
            this.rBtnAktif.TabIndex = 3;
            this.rBtnAktif.Text = "Aktif";
            this.rBtnAktif.UseVisualStyleBackColor = true;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(85, 48);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(182, 20);
            this.txtKullaniciSifre.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Şifre ";
            // 
            // txtKullaniciIsim
            // 
            this.txtKullaniciIsim.Location = new System.Drawing.Point(85, 100);
            this.txtKullaniciIsim.Name = "txtKullaniciIsim";
            this.txtKullaniciIsim.Size = new System.Drawing.Size(182, 20);
            this.txtKullaniciIsim.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "İsim ";
            // 
            // txtKullaniciSifreTekrar
            // 
            this.txtKullaniciSifreTekrar.Location = new System.Drawing.Point(85, 74);
            this.txtKullaniciSifreTekrar.Name = "txtKullaniciSifreTekrar";
            this.txtKullaniciSifreTekrar.Size = new System.Drawing.Size(182, 20);
            this.txtKullaniciSifreTekrar.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Şifre (Tekrar) ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Kullanıcı Türü ";
            // 
            // txtKullaniciSoyisim
            // 
            this.txtKullaniciSoyisim.Location = new System.Drawing.Point(85, 126);
            this.txtKullaniciSoyisim.Name = "txtKullaniciSoyisim";
            this.txtKullaniciSoyisim.Size = new System.Drawing.Size(182, 20);
            this.txtKullaniciSoyisim.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 129);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Soyisim ";
            // 
            // txtKullaniciKodu
            // 
            this.txtKullaniciKodu.EditValue = "NORMAL";
            this.txtKullaniciKodu.Location = new System.Drawing.Point(85, 152);
            this.txtKullaniciKodu.Name = "txtKullaniciKodu";
            this.txtKullaniciKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKullaniciKodu.Properties.Items.AddRange(new object[] {
            "YONETICI",
            "NORMAL"});
            this.txtKullaniciKodu.Size = new System.Drawing.Size(182, 20);
            this.txtKullaniciKodu.TabIndex = 13;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Location = new System.Drawing.Point(304, 125);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 38);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = " Temizle ";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseBackColor = true;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Location = new System.Drawing.Point(304, 169);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 38);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = " KAPAT ";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // rBtnPasif
            // 
            this.rBtnPasif.AutoSize = true;
            this.rBtnPasif.Checked = true;
            this.rBtnPasif.Location = new System.Drawing.Point(153, 190);
            this.rBtnPasif.Name = "rBtnPasif";
            this.rBtnPasif.Size = new System.Drawing.Size(48, 17);
            this.rBtnPasif.TabIndex = 16;
            this.rBtnPasif.TabStop = true;
            this.rBtnPasif.Text = "Pasif";
            this.rBtnPasif.UseVisualStyleBackColor = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(40, 194);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Durum ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(105, 249);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(179, 16);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "GENEL YAZILIM OTOMASYON";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(304, 18);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(75, 50);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 19;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // frmKullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 277);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.rBtnPasif);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtKullaniciSoyisim);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtKullaniciIsim);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKullaniciSifreTekrar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rBtnAktif);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKullaniciKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmKullaniciPanel.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Panel";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyisim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private System.Windows.Forms.RadioButton rBtnAktif;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciIsim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSifreTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSoyisim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txtKullaniciKodu;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.RadioButton rBtnPasif;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
    }
}