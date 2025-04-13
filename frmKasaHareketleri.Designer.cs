namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaHareketleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketleri));
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DevirKartiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TahsilatOdemeDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ACIKLAMA.AppearanceCell.Options.UseBackColor = true;
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 6;
            this.ACIKLAMA.Width = 291;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(312, 86);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(58, 20);
            this.txtBakiye.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(272, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Bakiye ";
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(193, 86);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(58, 20);
            this.txtCikis.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(163, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Çıkış ";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(87, 86);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(58, 20);
            this.txtGiris.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Giriş ";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(87, 60);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(283, 20);
            this.txtKasaAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kasa Ad ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kod ";
            // 
            // GIRIS
            // 
            this.GIRIS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GIRIS.AppearanceCell.Options.UseBackColor = true;
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 4;
            this.GIRIS.Width = 100;
            // 
            // EVRAKID
            // 
            this.EVRAKID.AppearanceCell.BackColor = System.Drawing.Color.Fuchsia;
            this.EVRAKID.AppearanceCell.Options.UseBackColor = true;
            this.EVRAKID.Caption = "EVRAK ID";
            this.EVRAKID.FieldName = "EVRAKID";
            this.EVRAKID.Name = "EVRAKID";
            // 
            // EVRAKTURU
            // 
            this.EVRAKTURU.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EVRAKTURU.AppearanceCell.Options.UseBackColor = true;
            this.EVRAKTURU.Caption = "EVRAK TÜRÜ";
            this.EVRAKTURU.FieldName = "EVRAKTURU";
            this.EVRAKTURU.Name = "EVRAKTURU";
            this.EVRAKTURU.OptionsColumn.AllowEdit = false;
            this.EVRAKTURU.OptionsColumn.AllowFocus = false;
            this.EVRAKTURU.OptionsColumn.FixedWidth = true;
            this.EVRAKTURU.Visible = true;
            this.EVRAKTURU.VisibleIndex = 2;
            this.EVRAKTURU.Width = 100;
            // 
            // BELGENO
            // 
            this.BELGENO.AppearanceCell.BackColor = System.Drawing.Color.Lime;
            this.BELGENO.AppearanceCell.Options.UseBackColor = true;
            this.BELGENO.Caption = "BELGE NO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 1;
            this.BELGENO.Width = 100;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(87, 34);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(283, 20);
            this.txtKasaKodu.TabIndex = 1;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTURU,
            this.EVRAKID,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA,
            this.TARIH});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // ID
            // 
            this.ID.AppearanceCell.BackColor = System.Drawing.Color.Red;
            this.ID.AppearanceCell.Options.UseBackColor = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // CIKIS
            // 
            this.CIKIS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CIKIS.AppearanceCell.Options.UseBackColor = true;
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 5;
            this.CIKIS.Width = 100;
            // 
            // TARIH
            // 
            this.TARIH.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TARIH.AppearanceCell.Options.UseBackColor = true;
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 3;
            this.TARIH.Width = 100;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.ContextMenuStrip = this.SagTik;
            this.Liste.EmbeddedNavigator.ContextMenuStripChanged += new System.EventHandler(this.gridView1_Click);
            this.Liste.Location = new System.Drawing.Point(2, 23);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(814, 353);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevirKartiDuzenle,
            this.TahsilatOdemeDuzenle});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(247, 48);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // DevirKartiDuzenle
            // 
            this.DevirKartiDuzenle.Name = "DevirKartiDuzenle";
            this.DevirKartiDuzenle.Size = new System.Drawing.Size(246, 22);
            this.DevirKartiDuzenle.Text = "Devir Kartı İşlemini Düzenle";
            this.DevirKartiDuzenle.Click += new System.EventHandler(this.DevirKartiDuzenle_Click);
            // 
            // TahsilatOdemeDuzenle
            // 
            this.TahsilatOdemeDuzenle.Name = "TahsilatOdemeDuzenle";
            this.TahsilatOdemeDuzenle.Size = new System.Drawing.Size(246, 22);
            this.TahsilatOdemeDuzenle.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.TahsilatOdemeDuzenle.Click += new System.EventHandler(this.TahsilatOdemeDuzenle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 118);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(818, 378);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtCikis);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtGiris);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(818, 118);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 496);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmKasaHareketleri.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.SagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKID;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTURU;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStripMenuItem DevirKartiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TahsilatOdemeDuzenle;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
    }
}