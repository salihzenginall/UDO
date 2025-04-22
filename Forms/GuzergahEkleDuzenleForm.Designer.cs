namespace UDO.Forms
{
    partial class GuzergahEkleDuzenleForm
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
            this.panelUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelGuzergahBilgileri = new System.Windows.Forms.Panel();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtTahminiSure = new System.Windows.Forms.TextBox();
            this.lblTahminiSure = new System.Windows.Forms.Label();
            this.txtMesafe = new System.Windows.Forms.TextBox();
            this.lblMesafe = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtGuzergahAdi = new System.Windows.Forms.TextBox();
            this.lblGuzergahAdi = new System.Windows.Forms.Label();
            this.txtGuzergahKodu = new System.Windows.Forms.TextBox();
            this.lblGuzergahKodu = new System.Windows.Forms.Label();
            this.panelIskeleler = new System.Windows.Forms.Panel();
            this.lblIskelelerBaslik = new System.Windows.Forms.Label();
            this.panelIskeleEkleme = new System.Windows.Forms.Panel();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.btnIskeleEkle = new System.Windows.Forms.Button();
            this.txtDurakAciklama = new System.Windows.Forms.TextBox();
            this.lblDurakAciklama = new System.Windows.Forms.Label();
            this.chkZorunluDurak = new System.Windows.Forms.CheckBox();
            this.numBeklemeSuresi = new System.Windows.Forms.NumericUpDown();
            this.lblBeklemeSuresi = new System.Windows.Forms.Label();
            this.cmbMevcutIskeleler = new System.Windows.Forms.ComboBox();
            this.lblMevcutIskeleler = new System.Windows.Forms.Label();
            this.panelGuzergahIskeleler = new System.Windows.Forms.Panel();
            this.lblDurakSayisi = new System.Windows.Forms.Label();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnIskeleDuzenle = new System.Windows.Forms.Button();
            this.btnIskeleSil = new System.Windows.Forms.Button();
            this.lstGuzergahIskeleler = new System.Windows.Forms.ListView();
            this.colSiraNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIskeleAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBeklemeSuresi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZorunlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAlt = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelUst.SuspendLayout();
            this.panelGuzergahBilgileri.SuspendLayout();
            this.panelIskeleler.SuspendLayout();
            this.panelIskeleEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBeklemeSuresi)).BeginInit();
            this.panelGuzergahIskeleler.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(800, 50);
            this.panelUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 14);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(169, 21);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ GÜZERGAH EKLE";
            // 
            // panelGuzergahBilgileri
            // 
            this.panelGuzergahBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGuzergahBilgileri.Controls.Add(this.chkAktif);
            this.panelGuzergahBilgileri.Controls.Add(this.txtTahminiSure);
            this.panelGuzergahBilgileri.Controls.Add(this.lblTahminiSure);
            this.panelGuzergahBilgileri.Controls.Add(this.txtMesafe);
            this.panelGuzergahBilgileri.Controls.Add(this.lblMesafe);
            this.panelGuzergahBilgileri.Controls.Add(this.txtAciklama);
            this.panelGuzergahBilgileri.Controls.Add(this.lblAciklama);
            this.panelGuzergahBilgileri.Controls.Add(this.txtGuzergahAdi);
            this.panelGuzergahBilgileri.Controls.Add(this.lblGuzergahAdi);
            this.panelGuzergahBilgileri.Controls.Add(this.txtGuzergahKodu);
            this.panelGuzergahBilgileri.Controls.Add(this.lblGuzergahKodu);
            this.panelGuzergahBilgileri.Location = new System.Drawing.Point(12, 62);
            this.panelGuzergahBilgileri.Name = "panelGuzergahBilgileri";
            this.panelGuzergahBilgileri.Size = new System.Drawing.Size(776, 160);
            this.panelGuzergahBilgileri.TabIndex = 1;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(591, 13);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(51, 19);
            this.chkAktif.TabIndex = 4;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtTahminiSure
            // 
            this.txtTahminiSure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahminiSure.Location = new System.Drawing.Point(591, 74);
            this.txtTahminiSure.Name = "txtTahminiSure";
            this.txtTahminiSure.Size = new System.Drawing.Size(100, 23);
            this.txtTahminiSure.TabIndex = 3;
            this.txtTahminiSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamSayi_KeyPress);
            // 
            // lblTahminiSure
            // 
            this.lblTahminiSure.AutoSize = true;
            this.lblTahminiSure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminiSure.Location = new System.Drawing.Point(474, 77);
            this.lblTahminiSure.Name = "lblTahminiSure";
            this.lblTahminiSure.Size = new System.Drawing.Size(111, 15);
            this.lblTahminiSure.TabIndex = 8;
            this.lblTahminiSure.Text = "Tahmini Süre (Dak.):";
            // 
            // txtMesafe
            // 
            this.txtMesafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesafe.Location = new System.Drawing.Point(591, 45);
            this.txtMesafe.Name = "txtMesafe";
            this.txtMesafe.Size = new System.Drawing.Size(100, 23);
            this.txtMesafe.TabIndex = 2;
            this.txtMesafe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayisal_KeyPress);
            // 
            // lblMesafe
            // 
            this.lblMesafe.AutoSize = true;
            this.lblMesafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesafe.Location = new System.Drawing.Point(474, 48);
            this.lblMesafe.Name = "lblMesafe";
            this.lblMesafe.Size = new System.Drawing.Size(78, 15);
            this.lblMesafe.TabIndex = 6;
            this.lblMesafe.Text = "Mesafe (KM):";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(124, 74);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(328, 73);
            this.txtAciklama.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(19, 77);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 15);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtGuzergahAdi
            // 
            this.txtGuzergahAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuzergahAdi.Location = new System.Drawing.Point(124, 45);
            this.txtGuzergahAdi.Name = "txtGuzergahAdi";
            this.txtGuzergahAdi.Size = new System.Drawing.Size(328, 23);
            this.txtGuzergahAdi.TabIndex = 0;
            // 
            // lblGuzergahAdi
            // 
            this.lblGuzergahAdi.AutoSize = true;
            this.lblGuzergahAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuzergahAdi.Location = new System.Drawing.Point(19, 48);
            this.lblGuzergahAdi.Name = "lblGuzergahAdi";
            this.lblGuzergahAdi.Size = new System.Drawing.Size(80, 15);
            this.lblGuzergahAdi.TabIndex = 2;
            this.lblGuzergahAdi.Text = "Güzergah Adı:";
            // 
            // txtGuzergahKodu
            // 
            this.txtGuzergahKodu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuzergahKodu.Location = new System.Drawing.Point(124, 16);
            this.txtGuzergahKodu.MaxLength = 10;
            this.txtGuzergahKodu.Name = "txtGuzergahKodu";
            this.txtGuzergahKodu.Size = new System.Drawing.Size(100, 23);
            this.txtGuzergahKodu.TabIndex = 0;
            // 
            // lblGuzergahKodu
            // 
            this.lblGuzergahKodu.AutoSize = true;
            this.lblGuzergahKodu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuzergahKodu.Location = new System.Drawing.Point(19, 19);
            this.lblGuzergahKodu.Name = "lblGuzergahKodu";
            this.lblGuzergahKodu.Size = new System.Drawing.Size(93, 15);
            this.lblGuzergahKodu.TabIndex = 0;
            this.lblGuzergahKodu.Text = "Güzergah Kodu:";
            // 
            // panelIskeleler
            // 
            this.panelIskeleler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIskeleler.Controls.Add(this.lblIskelelerBaslik);
            this.panelIskeleler.Controls.Add(this.panelIskeleEkleme);
            this.panelIskeleler.Controls.Add(this.panelGuzergahIskeleler);
            this.panelIskeleler.Location = new System.Drawing.Point(12, 228);
            this.panelIskeleler.Name = "panelIskeleler";
            this.panelIskeleler.Size = new System.Drawing.Size(776, 313);
            this.panelIskeleler.TabIndex = 2;
            // 
            // lblIskelelerBaslik
            // 
            this.lblIskelelerBaslik.AutoSize = true;
            this.lblIskelelerBaslik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIskelelerBaslik.Location = new System.Drawing.Point(19, 10);
            this.lblIskelelerBaslik.Name = "lblIskelelerBaslik";
            this.lblIskelelerBaslik.Size = new System.Drawing.Size(141, 17);
            this.lblIskelelerBaslik.TabIndex = 2;
            this.lblIskelelerBaslik.Text = "Güzergah İskeleleri";
            // 
            // panelIskeleEkleme
            // 
            this.panelIskeleEkleme.Controls.Add(this.btnIptalEt);
            this.panelIskeleEkleme.Controls.Add(this.btnIskeleEkle);
            this.panelIskeleEkleme.Controls.Add(this.txtDurakAciklama);
            this.panelIskeleEkleme.Controls.Add(this.lblDurakAciklama);
            this.panelIskeleEkleme.Controls.Add(this.chkZorunluDurak);
            this.panelIskeleEkleme.Controls.Add(this.numBeklemeSuresi);
            this.panelIskeleEkleme.Controls.Add(this.lblBeklemeSuresi);
            this.panelIskeleEkleme.Controls.Add(this.cmbMevcutIskeleler);
            this.panelIskeleEkleme.Controls.Add(this.lblMevcutIskeleler);
            this.panelIskeleEkleme.Location = new System.Drawing.Point(19, 30);
            this.panelIskeleEkleme.Name = "panelIskeleEkleme";
            this.panelIskeleEkleme.Size = new System.Drawing.Size(741, 111);
            this.panelIskeleEkleme.TabIndex = 1;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.BackColor = System.Drawing.Color.Gray;
            this.btnIptalEt.FlatAppearance.BorderSize = 0;
            this.btnIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptalEt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.ForeColor = System.Drawing.Color.White;
            this.btnIptalEt.Location = new System.Drawing.Point(666, 74);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
            this.btnIptalEt.TabIndex = 8;
            this.btnIptalEt.Text = "İptal";
            this.btnIptalEt.UseVisualStyleBackColor = false;
            this.btnIptalEt.Visible = false;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // btnIskeleEkle
            // 
            this.btnIskeleEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnIskeleEkle.FlatAppearance.BorderSize = 0;
            this.btnIskeleEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIskeleEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIskeleEkle.ForeColor = System.Drawing.Color.White;
            this.btnIskeleEkle.Location = new System.Drawing.Point(666, 45);
            this.btnIskeleEkle.Name = "btnIskeleEkle";
            this.btnIskeleEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIskeleEkle.TabIndex = 7;
            this.btnIskeleEkle.Text = "Ekle";
            this.btnIskeleEkle.UseVisualStyleBackColor = false;
            this.btnIskeleEkle.Click += new System.EventHandler(this.btnIskeleEkle_Click);
            // 
            // txtDurakAciklama
            // 
            this.txtDurakAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurakAciklama.Location = new System.Drawing.Point(105, 74);
            this.txtDurakAciklama.Name = "txtDurakAciklama";
            this.txtDurakAciklama.Size = new System.Drawing.Size(555, 23);
            this.txtDurakAciklama.TabIndex = 6;
            // 
            // lblDurakAciklama
            // 
            this.lblDurakAciklama.AutoSize = true;
            this.lblDurakAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurakAciklama.Location = new System.Drawing.Point(3, 77);
            this.lblDurakAciklama.Name = "lblDurakAciklama";
            this.lblDurakAciklama.Size = new System.Drawing.Size(96, 15);
            this.lblDurakAciklama.TabIndex = 5;
            this.lblDurakAciklama.Text = "Durak Açıklama:";
            // 
            // chkZorunluDurak
            // 
            this.chkZorunluDurak.AutoSize = true;
            this.chkZorunluDurak.Checked = true;
            this.chkZorunluDurak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZorunluDurak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkZorunluDurak.Location = new System.Drawing.Point(450, 47);
            this.chkZorunluDurak.Name = "chkZorunluDurak";
            this.chkZorunluDurak.Size = new System.Drawing.Size(104, 19);
            this.chkZorunluDurak.TabIndex = 4;
            this.chkZorunluDurak.Text = "Zorunlu Durak";
            this.chkZorunluDurak.UseVisualStyleBackColor = true;
            // 
            // numBeklemeSuresi
            // 
            this.numBeklemeSuresi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numBeklemeSuresi.Location = new System.Drawing.Point(360, 45);
            this.numBeklemeSuresi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numBeklemeSuresi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBeklemeSuresi.Name = "numBeklemeSuresi";
            this.numBeklemeSuresi.Size = new System.Drawing.Size(60, 23);
            this.numBeklemeSuresi.TabIndex = 3;
            this.numBeklemeSuresi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblBeklemeSuresi
            // 
            this.lblBeklemeSuresi.AutoSize = true;
            this.lblBeklemeSuresi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeklemeSuresi.Location = new System.Drawing.Point(247, 47);
            this.lblBeklemeSuresi.Name = "lblBeklemeSuresi";
            this.lblBeklemeSuresi.Size = new System.Drawing.Size(107, 15);
            this.lblBeklemeSuresi.TabIndex = 2;
            this.lblBeklemeSuresi.Text = "Bekleme Sür. (Dk.):";
            // 
            // cmbMevcutIskeleler
            // 
            this.cmbMevcutIskeleler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMevcutIskeleler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMevcutIskeleler.FormattingEnabled = true;
            this.cmbMevcutIskeleler.Location = new System.Drawing.Point(105, 15);
            this.cmbMevcutIskeleler.Name = "cmbMevcutIskeleler";
            this.cmbMevcutIskeleler.Size = new System.Drawing.Size(250, 23);
            this.cmbMevcutIskeleler.TabIndex = 1;
            // 
            // lblMevcutIskeleler
            // 
            this.lblMevcutIskeleler.AutoSize = true;
            this.lblMevcutIskeleler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutIskeleler.Location = new System.Drawing.Point(3, 18);
            this.lblMevcutIskeleler.Name = "lblMevcutIskeleler";
            this.lblMevcutIskeleler.Size = new System.Drawing.Size(41, 15);
            this.lblMevcutIskeleler.TabIndex = 0;
            this.lblMevcutIskeleler.Text = "İskele:";
            // 
            // panelGuzergahIskeleler
            // 
            this.panelGuzergahIskeleler.Controls.Add(this.lblDurakSayisi);
            this.panelGuzergahIskeleler.Controls.Add(this.btnAsagi);
            this.panelGuzergahIskeleler.Controls.Add(this.btnYukari);
            this.panelGuzergahIskeleler.Controls.Add(this.btnIskeleDuzenle);
            this.panelGuzergahIskeleler.Controls.Add(this.btnIskeleSil);
            this.panelGuzergahIskeleler.Controls.Add(this.lstGuzergahIskeleler);
            this.panelGuzergahIskeleler.Location = new System.Drawing.Point(19, 147);
            this.panelGuzergahIskeleler.Name = "panelGuzergahIskeleler";
            this.panelGuzergahIskeleler.Size = new System.Drawing.Size(741, 154);
            this.panelGuzergahIskeleler.TabIndex = 0;
            // 
            // lblDurakSayisi
            // 
            this.lblDurakSayisi.AutoSize = true;
            this.lblDurakSayisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurakSayisi.ForeColor = System.Drawing.Color.Gray;
            this.lblDurakSayisi.Location = new System.Drawing.Point(3, 134);
            this.lblDurakSayisi.Name = "lblDurakSayisi";
            this.lblDurakSayisi.Size = new System.Drawing.Size(122, 15);
            this.lblDurakSayisi.TabIndex = 5;
            this.lblDurakSayisi.Text = "Toplam Durak Sayısı: 0";
            // 
            // btnAsagi
            // 
            this.btnAsagi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnAsagi.FlatAppearance.BorderSize = 0;
            this.btnAsagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.ForeColor = System.Drawing.Color.White;
            this.btnAsagi.Location = new System.Drawing.Point(666, 70);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(75, 23);
            this.btnAsagi.TabIndex = 4;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = false;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnYukari.FlatAppearance.BorderSize = 0;
            this.btnYukari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.ForeColor = System.Drawing.Color.White;
            this.btnYukari.Location = new System.Drawing.Point(666, 41);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(75, 23);
            this.btnYukari.TabIndex = 3;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = false;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnIskeleDuzenle
            // 
            this.btnIskeleDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnIskeleDuzenle.FlatAppearance.BorderSize = 0;
            this.btnIskeleDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIskeleDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIskeleDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnIskeleDuzenle.Location = new System.Drawing.Point(666, 12);
            this.btnIskeleDuzenle.Name = "btnIskeleDuzenle";
            this.btnIskeleDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnIskeleDuzenle.TabIndex = 2;
            this.btnIskeleDuzenle.Text = "Düzenle";
            this.btnIskeleDuzenle.UseVisualStyleBackColor = false;
            this.btnIskeleDuzenle.Click += new System.EventHandler(this.btnIskeleDuzenle_Click);
            // 
            // btnIskeleSil
            // 
            this.btnIskeleSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIskeleSil.FlatAppearance.BorderSize = 0;
            this.btnIskeleSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIskeleSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIskeleSil.ForeColor = System.Drawing.Color.White;
            this.btnIskeleSil.Location = new System.Drawing.Point(666, 99);
            this.btnIskeleSil.Name = "btnIskeleSil";
            this.btnIskeleSil.Size = new System.Drawing.Size(75, 23);
            this.btnIskeleSil.TabIndex = 1;
            this.btnIskeleSil.Text = "Sil";
            this.btnIskeleSil.UseVisualStyleBackColor = false;
            this.btnIskeleSil.Click += new System.EventHandler(this.btnIskeleSil_Click);
            // 
            // lstGuzergahIskeleler
            // 
            this.lstGuzergahIskeleler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSiraNo,
            this.colIskeleAdi,
            this.colBeklemeSuresi,
            this.colZorunlu,
            this.colAciklama});
            this.lstGuzergahIskeleler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGuzergahIskeleler.FullRowSelect = true;
            this.lstGuzergahIskeleler.HideSelection = false;
            this.lstGuzergahIskeleler.Location = new System.Drawing.Point(3, 3);
            this.lstGuzergahIskeleler.MultiSelect = false;
            this.lstGuzergahIskeleler.Name = "lstGuzergahIskeleler";
            this.lstGuzergahIskeleler.Size = new System.Drawing.Size(657, 128);
            this.lstGuzergahIskeleler.TabIndex = 0;
            this.lstGuzergahIskeleler.UseCompatibleStateImageBehavior = false;
            this.lstGuzergahIskeleler.View = System.Windows.Forms.View.Details;
            // 
            // colSiraNo
            // 
            this.colSiraNo.Text = "Sıra";
            this.colSiraNo.Width = 40;
            // 
            // colIskeleAdi
            // 
            this.colIskeleAdi.Text = "İskele Adı";
            this.colIskeleAdi.Width = 200;
            // 
            // colBeklemeSuresi
            // 
            this.colBeklemeSuresi.Text = "Bekleme Süresi";
            this.colBeklemeSuresi.Width = 100;
            // 
            // colZorunlu
            // 
            this.colZorunlu.Text = "Zorunlu";
            this.colZorunlu.Width = 60;
            // 
            // colAciklama
            // 
            this.colAciklama.Text = "Açıklama";
            this.colAciklama.Width = 250;
            // 
            // panelAlt
            // 
            this.panelAlt.Controls.Add(this.btnIptal);
            this.panelAlt.Controls.Add(this.btnKaydet);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 547);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(800, 53);
            this.panelAlt.TabIndex = 3;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(693, 15);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 30);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(589, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 30);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // GuzergahEkleDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelIskeleler);
            this.Controls.Add(this.panelGuzergahBilgileri);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuzergahEkleDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Güzergah Ekle/Düzenle";
            this.Load += new System.EventHandler(this.GuzergahEkleDuzenleForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelGuzergahBilgileri.ResumeLayout(false);
            this.panelGuzergahBilgileri.PerformLayout();
            this.panelIskeleler.ResumeLayout(false);
            this.panelIskeleler.PerformLayout();
            this.panelIskeleEkleme.ResumeLayout(false);
            this.panelIskeleEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBeklemeSuresi)).EndInit();
            this.panelGuzergahIskeleler.ResumeLayout(false);
            this.panelGuzergahIskeleler.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelGuzergahBilgileri;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.TextBox txtTahminiSure;
        private System.Windows.Forms.Label lblTahminiSure;
        private System.Windows.Forms.TextBox txtMesafe;
        private System.Windows.Forms.Label lblMesafe;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtGuzergahAdi;
        private System.Windows.Forms.Label lblGuzergahAdi;
        private System.Windows.Forms.TextBox txtGuzergahKodu;
        private System.Windows.Forms.Label lblGuzergahKodu;
        private System.Windows.Forms.Panel panelIskeleler;
        private System.Windows.Forms.Panel panelGuzergahIskeleler;
        private System.Windows.Forms.ListView lstGuzergahIskeleler;
        private System.Windows.Forms.ColumnHeader colSiraNo;
        private System.Windows.Forms.ColumnHeader colIskeleAdi;
        private System.Windows.Forms.ColumnHeader colBeklemeSuresi;
        private System.Windows.Forms.ColumnHeader colZorunlu;
        private System.Windows.Forms.ColumnHeader colAciklama;
        private System.Windows.Forms.Button btnIskeleSil;
        private System.Windows.Forms.Button btnIskeleDuzenle;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Panel panelIskeleEkleme;
        private System.Windows.Forms.Label lblMevcutIskeleler;
        private System.Windows.Forms.ComboBox cmbMevcutIskeleler;
        private System.Windows.Forms.Label lblBeklemeSuresi;
        private System.Windows.Forms.NumericUpDown numBeklemeSuresi;
        private System.Windows.Forms.CheckBox chkZorunluDurak;
        private System.Windows.Forms.TextBox txtDurakAciklama;
        private System.Windows.Forms.Label lblDurakAciklama;
        private System.Windows.Forms.Button btnIskeleEkle;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Label lblIskelelerBaslik;
        private System.Windows.Forms.Label lblDurakSayisi;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
    }
}