namespace Otomasyon.Modul_Banka
{
    partial class frmBankaAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaAcilisKarti));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayitEt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTemsilciEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTemsilci = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaAdres = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemsilciEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemsilci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.txtIban);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKayitEt);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtTemsilciEmail);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtTemsilci);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtBankaTelefon);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtBankaSube);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtHesapAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBankaAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBankaAdres);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(488, 331);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(366, 230);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(91, 39);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(83, 110);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(243, 20);
            this.txtIban.TabIndex = 17;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(366, 165);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 39);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitEt.ImageOptions.Image")));
            this.btnKayitEt.Location = new System.Drawing.Point(366, 100);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(91, 39);
            this.btnKayitEt.TabIndex = 10;
            this.btnKayitEt.Text = "Kayıt Et";
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 113);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "IBAN No ";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(83, 84);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(243, 20);
            this.txtHesapNo.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 87);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Hesap No ";
            // 
            // txtTemsilciEmail
            // 
            this.txtTemsilciEmail.Location = new System.Drawing.Point(83, 300);
            this.txtTemsilciEmail.Name = "txtTemsilciEmail";
            this.txtTemsilciEmail.Size = new System.Drawing.Size(243, 20);
            this.txtTemsilciEmail.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 303);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Y/T E-MAIL";
            // 
            // txtTemsilci
            // 
            this.txtTemsilci.Location = new System.Drawing.Point(83, 274);
            this.txtTemsilci.Name = "txtTemsilci";
            this.txtTemsilci.Size = new System.Drawing.Size(243, 20);
            this.txtTemsilci.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 277);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Yetkili/Temsilci";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 191);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Banka Adres ";
            // 
            // txtBankaTelefon
            // 
            this.txtBankaTelefon.Location = new System.Drawing.Point(83, 162);
            this.txtBankaTelefon.Name = "txtBankaTelefon";
            this.txtBankaTelefon.Size = new System.Drawing.Size(243, 20);
            this.txtBankaTelefon.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Banka Telefon ";
            // 
            // txtBankaSube
            // 
            this.txtBankaSube.Location = new System.Drawing.Point(83, 136);
            this.txtBankaSube.Name = "txtBankaSube";
            this.txtBankaSube.Size = new System.Drawing.Size(243, 20);
            this.txtBankaSube.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 139);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Banka Şubesi ";
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(83, 58);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(243, 20);
            this.txtHesapAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hesap Ad/Tür ";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(83, 32);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(243, 20);
            this.txtBankaAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Banka Adı ";
            // 
            // txtBankaAdres
            // 
            this.txtBankaAdres.Location = new System.Drawing.Point(83, 188);
            this.txtBankaAdres.Name = "txtBankaAdres";
            this.txtBankaAdres.Size = new System.Drawing.Size(243, 80);
            this.txtBankaAdres.TabIndex = 9;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 331);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(488, 205);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Banka Listesi";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 23);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(484, 180);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BANKAADI,
            this.HESAPADI,
            this.BAKIYE});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 65;
            // 
            // BANKAADI
            // 
            this.BANKAADI.Caption = "BANKA ADI";
            this.BANKAADI.FieldName = "BANKAADI";
            this.BANKAADI.Name = "BANKAADI";
            this.BANKAADI.OptionsColumn.AllowEdit = false;
            this.BANKAADI.OptionsColumn.AllowFocus = false;
            this.BANKAADI.Visible = true;
            this.BANKAADI.VisibleIndex = 1;
            this.BANKAADI.Width = 200;
            // 
            // HESAPADI
            // 
            this.HESAPADI.Caption = "HESAP ADI";
            this.HESAPADI.FieldName = "HESAPADI";
            this.HESAPADI.Name = "HESAPADI";
            this.HESAPADI.OptionsColumn.AllowEdit = false;
            this.HESAPADI.OptionsColumn.AllowFocus = false;
            this.HESAPADI.Visible = true;
            this.HESAPADI.VisibleIndex = 2;
            this.HESAPADI.Width = 107;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 3;
            this.BAKIYE.Width = 89;
            // 
            // frmBankaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 536);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmBankaAcilisKarti.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaAcilisKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Açılış Kartı";
            this.Load += new System.EventHandler(this.frmBankaAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemsilciEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemsilci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtBankaSube;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHesapAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKayitEt;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTemsilciEmail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTemsilci;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBankaTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtBankaAdres;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAADI;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPADI;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
    }
}