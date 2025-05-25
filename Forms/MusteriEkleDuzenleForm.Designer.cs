namespace UDO.Forms
{
    partial class MusteriEkleDuzenleForm
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
            this.panelAlt = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.groupBoxIstatistikler = new System.Windows.Forms.GroupBox();
            this.txtSadakatPuani = new System.Windows.Forms.TextBox();
            this.lblSadakatPuani = new System.Windows.Forms.Label();
            this.txtToplamHarcama = new System.Windows.Forms.TextBox();
            this.lblToplamHarcama = new System.Windows.Forms.Label();
            this.txtToplamSeyahat = new System.Windows.Forms.TextBox();
            this.lblToplamSeyahat = new System.Windows.Forms.Label();
            this.groupBoxEkBilgiler = new System.Windows.Forms.GroupBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtKayitKanali = new System.Windows.Forms.TextBox();
            this.lblKayitKanali = new System.Windows.Forms.Label();
            this.numIndirimOrani = new System.Windows.Forms.NumericUpDown();
            this.lblIndirimOrani = new System.Windows.Forms.Label();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.chkDogumTarihiVar = new System.Windows.Forms.CheckBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.groupBoxIletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBoxTemelBilgiler = new System.Windows.Forms.GroupBox();
            this.btnMusteriNoOlustur = new System.Windows.Forms.Button();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.panelSifre = new System.Windows.Forms.Panel();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.panelIcerik.SuspendLayout();
            this.groupBoxIstatistikler.SuspendLayout();
            this.groupBoxEkBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndirimOrani)).BeginInit();
            this.groupBoxIletisimBilgileri.SuspendLayout();
            this.groupBoxTemelBilgiler.SuspendLayout();
            this.panelSifre.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(900, 60);
            this.panelUst.TabIndex = 0;

            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(20, 18);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(221, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ MÜŞTERİ EKLE";

            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelAlt.Controls.Add(this.btnIptal);
            this.panelAlt.Controls.Add(this.btnKaydet);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 650);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Padding = new System.Windows.Forms.Padding(20);
            this.panelAlt.Size = new System.Drawing.Size(900, 70);
            this.panelAlt.TabIndex = 1;

            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(765, 20);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(115, 35);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(640, 20);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 35);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // 
            // panelIcerik
            // 
            this.panelIcerik.AutoScroll = true;
            this.panelIcerik.BackColor = System.Drawing.Color.White;
            this.panelIcerik.Controls.Add(this.groupBoxIstatistikler);
            this.panelIcerik.Controls.Add(this.groupBoxEkBilgiler);
            this.panelIcerik.Controls.Add(this.groupBoxIletisimBilgileri);
            this.panelIcerik.Controls.Add(this.groupBoxTemelBilgiler);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 60);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Padding = new System.Windows.Forms.Padding(20);
            this.panelIcerik.Size = new System.Drawing.Size(900, 590);
            this.panelIcerik.TabIndex = 2;

            // 
            // groupBoxTemelBilgiler
            // 
            this.groupBoxTemelBilgiler.Controls.Add(this.btnMusteriNoOlustur);
            this.groupBoxTemelBilgiler.Controls.Add(this.txtMusteriNo);
            this.groupBoxTemelBilgiler.Controls.Add(this.lblMusteriNo);
            this.groupBoxTemelBilgiler.Controls.Add(this.panelSifre);
            this.groupBoxTemelBilgiler.Controls.Add(this.txtTCKN);
            this.groupBoxTemelBilgiler.Controls.Add(this.lblTCKN);
            this.groupBoxTemelBilgiler.Controls.Add(this.txtSoyad);
            this.groupBoxTemelBilgiler.Controls.Add(this.lblSoyad);
            this.groupBoxTemelBilgiler.Controls.Add(this.txtAd);
            this.groupBoxTemelBilgiler.Controls.Add(this.lblAd);
            this.groupBoxTemelBilgiler.Controls.Add(this.txtKullaniciAdi);
            this.groupBoxTemelBilgiler.Controls.Add(this.lblKullaniciAdi);
            this.groupBoxTemelBilgiler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxTemelBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.groupBoxTemelBilgiler.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTemelBilgiler.Name = "groupBoxTemelBilgiler";
            this.groupBoxTemelBilgiler.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxTemelBilgiler.Size = new System.Drawing.Size(840, 220);
            this.groupBoxTemelBilgiler.TabIndex = 0;
            this.groupBoxTemelBilgiler.TabStop = false;
            this.groupBoxTemelBilgiler.Text = "Temel Bilgiler";

            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriNo.ForeColor = System.Drawing.Color.Black;
            this.lblMusteriNo.Location = new System.Drawing.Point(20, 30);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(71, 15);
            this.lblMusteriNo.TabIndex = 0;
            this.lblMusteriNo.Text = "Müşteri No:*";

            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(20, 50);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(250, 23);
            this.txtMusteriNo.TabIndex = 1;

            // 
            // btnMusteriNoOlustur
            // 
            this.btnMusteriNoOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnMusteriNoOlustur.FlatAppearance.BorderSize = 0;
            this.btnMusteriNoOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriNoOlustur.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriNoOlustur.ForeColor = System.Drawing.Color.White;
            this.btnMusteriNoOlustur.Location = new System.Drawing.Point(280, 50);
            this.btnMusteriNoOlustur.Name = "btnMusteriNoOlustur";
            this.btnMusteriNoOlustur.Size = new System.Drawing.Size(90, 23);
            this.btnMusteriNoOlustur.TabIndex = 2;
            this.btnMusteriNoOlustur.Text = "Yeni Oluştur";
            this.btnMusteriNoOlustur.UseVisualStyleBackColor = false;
            this.btnMusteriNoOlustur.Click += new System.EventHandler(this.btnMusteriNoOlustur_Click);

            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 85);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(79, 15);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:*";

            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(20, 105);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(250, 23);
            this.txtKullaniciAdi.TabIndex = 4;

            // 
            // panelSifre
            // 
            this.panelSifre.Controls.Add(this.lblSifre);
            this.panelSifre.Controls.Add(this.txtSifre);
            this.panelSifre.Location = new System.Drawing.Point(300, 85);
            this.panelSifre.Name = "panelSifre";
            this.panelSifre.Size = new System.Drawing.Size(250, 50);
            this.panelSifre.TabIndex = 5;

            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(0, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(36, 15);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre:*";

            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(0, 20);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(250, 23);
            this.txtSifre.TabIndex = 1;

            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(20, 140);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(28, 15);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Ad:*";

            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(20, 160);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 23);
            this.txtAd.TabIndex = 7;

            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(300, 140);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(45, 15);
            this.lblSoyad.TabIndex = 8;
            this.lblSoyad.Text = "Soyad:*";

            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(300, 160);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 23);
            this.txtSoyad.TabIndex = 9;

            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKN.ForeColor = System.Drawing.Color.Black;
            this.lblTCKN.Location = new System.Drawing.Point(580, 140);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(38, 15);
            this.lblTCKN.TabIndex = 10;
            this.lblTCKN.Text = "TCKN:";

            // 
            // txtTCKN
            // 
            this.txtTCKN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCKN.Location = new System.Drawing.Point(580, 160);
            this.txtTCKN.MaxLength = 11;
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(200, 23);
            this.txtTCKN.TabIndex = 11;

            // 
            // groupBoxIletisimBilgileri
            // 
            this.groupBoxIletisimBilgileri.Controls.Add(this.txtAdres);
            this.groupBoxIletisimBilgileri.Controls.Add(this.lblAdres);
            this.groupBoxIletisimBilgileri.Controls.Add(this.txtTelefon);
            this.groupBoxIletisimBilgileri.Controls.Add(this.lblTelefon);
            this.groupBoxIletisimBilgileri.Controls.Add(this.txtEmail);
            this.groupBoxIletisimBilgileri.Controls.Add(this.lblEmail);
            this.groupBoxIletisimBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIletisimBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.groupBoxIletisimBilgileri.Location = new System.Drawing.Point(20, 260);
            this.groupBoxIletisimBilgileri.Name = "groupBoxIletisimBilgileri";
            this.groupBoxIletisimBilgileri.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxIletisimBilgileri.Size = new System.Drawing.Size(840, 120);
            this.groupBoxIletisimBilgileri.TabIndex = 1;
            this.groupBoxIletisimBilgileri.TabStop = false;
            this.groupBoxIletisimBilgileri.Text = "İletişim Bilgileri";

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(20, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(20, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 1;

            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.Black;
            this.lblTelefon.Location = new System.Drawing.Point(340, 30);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(48, 15);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";

            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(340, 50);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 23);
            this.txtTelefon.TabIndex = 3;

            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.Black;
            this.lblAdres.Location = new System.Drawing.Point(560, 30);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(40, 15);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";

            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(560, 50);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(250, 50);
            this.txtAdres.TabIndex = 5;

            // 
            // groupBoxEkBilgiler
            // 
            this.groupBoxEkBilgiler.Controls.Add(this.chkAktif);
            this.groupBoxEkBilgiler.Controls.Add(this.txtKayitKanali);
            this.groupBoxEkBilgiler.Controls.Add(this.lblKayitKanali);
            this.groupBoxEkBilgiler.Controls.Add(this.numIndirimOrani);
            this.groupBoxEkBilgiler.Controls.Add(this.lblIndirimOrani);
            this.groupBoxEkBilgiler.Controls.Add(this.cmbUyruk);
            this.groupBoxEkBilgiler.Controls.Add(this.lblUyruk);
            this.groupBoxEkBilgiler.Controls.Add(this.chkDogumTarihiVar);
            this.groupBoxEkBilgiler.Controls.Add(this.dtpDogumTarihi);
            this.groupBoxEkBilgiler.Controls.Add(this.lblDogumTarihi);
            this.groupBoxEkBilgiler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxEkBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.groupBoxEkBilgiler.Location = new System.Drawing.Point(20, 400);
            this.groupBoxEkBilgiler.Name = "groupBoxEkBilgiler";
            this.groupBoxEkBilgiler.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxEkBilgiler.Size = new System.Drawing.Size(840, 130);
            this.groupBoxEkBilgiler.TabIndex = 2;
            this.groupBoxEkBilgiler.TabStop = false;
            this.groupBoxEkBilgiler.Text = "Ek Bilgiler";

            // 
            // chkDogumTarihiVar
            // 
            this.chkDogumTarihiVar.AutoSize = true;
            this.chkDogumTarihiVar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDogumTarihiVar.ForeColor = System.Drawing.Color.Black;
            this.chkDogumTarihiVar.Location = new System.Drawing.Point(20, 30);
            this.chkDogumTarihiVar.Name = "chkDogumTarihiVar";
            this.chkDogumTarihiVar.Size = new System.Drawing.Size(119, 19);
            this.chkDogumTarihiVar.TabIndex = 0;
            this.chkDogumTarihiVar.Text = "Doğum tarihi var";
            this.chkDogumTarihiVar.UseVisualStyleBackColor = true;
            this.chkDogumTarihiVar.CheckedChanged += new System.EventHandler(this.chkDogumTarihiVar_CheckedChanged);

            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblDogumTarihi.Location = new System.Drawing.Point(20, 55);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(81, 15);
            this.lblDogumTarihi.TabIndex = 1;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";

            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Enabled = false;
            this.dtpDogumTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(20, 75);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(120, 23);
            this.dtpDogumTarihi.TabIndex = 2;

            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyruk.ForeColor = System.Drawing.Color.Black;
            this.lblUyruk.Location = new System.Drawing.Point(180, 55);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(43, 15);
            this.lblUyruk.TabIndex = 3;
            this.lblUyruk.Text = "Uyruk:";

            // 
            // cmbUyruk
            // 
            this.cmbUyruk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyruk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Location = new System.Drawing.Point(180, 75);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(150, 23);
            this.cmbUyruk.TabIndex = 4;

            // 
            // lblIndirimOrani
            // 
            this.lblIndirimOrani.AutoSize = true;
            this.lblIndirimOrani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimOrani.ForeColor = System.Drawing.Color.Black;
            this.lblIndirimOrani.Location = new System.Drawing.Point(360, 55);
            this.lblIndirimOrani.Name = "lblIndirimOrani";
            this.lblIndirimOrani.Size = new System.Drawing.Size(88, 15);
            this.lblIndirimOrani.TabIndex = 5;
            this.lblIndirimOrani.Text = "İndirim Oranı %:";

            // 
            // numIndirimOrani
            // 
            this.numIndirimOrani.DecimalPlaces = 2;
            this.numIndirimOrani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numIndirimOrani.Location = new System.Drawing.Point(360, 75);
            this.numIndirimOrani.Name = "numIndirimOrani";
            this.numIndirimOrani.Size = new System.Drawing.Size(100, 23);
            this.numIndirimOrani.TabIndex = 6;

            // 
            // lblKayitKanali
            // 
            this.lblKayitKanali.AutoSize = true;
            this.lblKayitKanali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitKanali.ForeColor = System.Drawing.Color.Black;
            this.lblKayitKanali.Location = new System.Drawing.Point(490, 55);
            this.lblKayitKanali.Name = "lblKayitKanali";
            this.lblKayitKanali.Size = new System.Drawing.Size(74, 15);
            this.lblKayitKanali.TabIndex = 7;
            this.lblKayitKanali.Text = "Kayıt Kanalı:";

            // 
            // txtKayitKanali
            // 
            this.txtKayitKanali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitKanali.Location = new System.Drawing.Point(490, 75);
            this.txtKayitKanali.Name = "txtKayitKanali";
            this.txtKayitKanali.Size = new System.Drawing.Size(200, 23);
            this.txtKayitKanali.TabIndex = 8;

            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.ForeColor = System.Drawing.Color.Black;
            this.chkAktif.Location = new System.Drawing.Point(720, 79);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(51, 19);
            this.chkAktif.TabIndex = 9;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;

            // 
            // groupBoxIstatistikler
            // 
            this.groupBoxIstatistikler.Controls.Add(this.txtSadakatPuani);
            this.groupBoxIstatistikler.Controls.Add(this.lblSadakatPuani);
            this.groupBoxIstatistikler.Controls.Add(this.txtToplamHarcama);
            this.groupBoxIstatistikler.Controls.Add(this.lblToplamHarcama);
            this.groupBoxIstatistikler.Controls.Add(this.txtToplamSeyahat);
            this.groupBoxIstatistikler.Controls.Add(this.lblToplamSeyahat);
            this.groupBoxIstatistikler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIstatistikler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.groupBoxIstatistikler.Location = new System.Drawing.Point(20, 550);
            this.groupBoxIstatistikler.Name = "groupBoxIstatistikler";
            this.groupBoxIstatistikler.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxIstatistikler.Size = new System.Drawing.Size(840, 90);
            this.groupBoxIstatistikler.TabIndex = 3;
            this.groupBoxIstatistikler.TabStop = false;
            this.groupBoxIstatistikler.Text = "Müşteri İstatistikleri (Sadece Okunabilir)";

            // 
            // lblToplamSeyahat
            // 
            this.lblToplamSeyahat.AutoSize = true;
            this.lblToplamSeyahat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSeyahat.ForeColor = System.Drawing.Color.Black;
            this.lblToplamSeyahat.Location = new System.Drawing.Point(20, 30);
            this.lblToplamSeyahat.Name = "lblToplamSeyahat";
            this.lblToplamSeyahat.Size = new System.Drawing.Size(93, 15);
            this.lblToplamSeyahat.TabIndex = 0;
            this.lblToplamSeyahat.Text = "Toplam Seyahat:";

            // 
            // txtToplamSeyahat
            // 
            this.txtToplamSeyahat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamSeyahat.Location = new System.Drawing.Point(20, 50);
            this.txtToplamSeyahat.Name = "txtToplamSeyahat";
            this.txtToplamSeyahat.ReadOnly = true;
            this.txtToplamSeyahat.Size = new System.Drawing.Size(100, 23);
            this.txtToplamSeyahat.TabIndex = 1;
            this.txtToplamSeyahat.Text = "0";

            // 
            // lblToplamHarcama
            // 
            this.lblToplamHarcama.AutoSize = true;
            this.lblToplamHarcama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHarcama.ForeColor = System.Drawing.Color.Black;
            this.lblToplamHarcama.Location = new System.Drawing.Point(140, 30);
            this.lblToplamHarcama.Name = "lblToplamHarcama";
            this.lblToplamHarcama.Size = new System.Drawing.Size(98, 15);
            this.lblToplamHarcama.TabIndex = 2;
            this.lblToplamHarcama.Text = "Toplam Harcama:";

            // 
            // txtToplamHarcama
            // 
            this.txtToplamHarcama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamHarcama.Location = new System.Drawing.Point(140, 50);
            this.txtToplamHarcama.Name = "txtToplamHarcama";
            this.txtToplamHarcama.ReadOnly = true;
            this.txtToplamHarcama.Size = new System.Drawing.Size(120, 23);
            this.txtToplamHarcama.TabIndex = 3;
            this.txtToplamHarcama.Text = "0,00";

            // 
            // lblSadakatPuani
            // 
            this.lblSadakatPuani.AutoSize = true;
            this.lblSadakatPuani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSadakatPuani.ForeColor = System.Drawing.Color.Black;
            this.lblSadakatPuani.Location = new System.Drawing.Point(280, 30);
            this.lblSadakatPuani.Name = "lblSadakatPuani";
            this.lblSadakatPuani.Size = new System.Drawing.Size(81, 15);
            this.lblSadakatPuani.TabIndex = 4;
            this.lblSadakatPuani.Text = "Sadakat Puanı:";

            // 
            // txtSadakatPuani
            // 
            this.txtSadakatPuani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSadakatPuani.Location = new System.Drawing.Point(280, 50);
            this.txtSadakatPuani.Name = "txtSadakatPuani";
            this.txtSadakatPuani.ReadOnly = true;
            this.txtSadakatPuani.Size = new System.Drawing.Size(100, 23);
            this.txtSadakatPuani.TabIndex = 5;
            this.txtSadakatPuani.Text = "0";

            // 
            // MusteriEkleDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriEkleDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Ekle/Düzenle";
            this.Load += new System.EventHandler(this.MusteriEkleDuzenleForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.panelIcerik.ResumeLayout(false);
            this.groupBoxIstatistikler.ResumeLayout(false);
            this.groupBoxIstatistikler.PerformLayout();
            this.groupBoxEkBilgiler.ResumeLayout(false);
            this.groupBoxEkBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndirimOrani)).EndInit();
            this.groupBoxIletisimBilgileri.ResumeLayout(false);
            this.groupBoxIletisimBilgileri.PerformLayout();
            this.groupBoxTemelBilgiler.ResumeLayout(false);
            this.groupBoxTemelBilgiler.PerformLayout();
            this.panelSifre.ResumeLayout(false);
            this.panelSifre.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.GroupBox groupBoxTemelBilgiler;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Panel panelSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox groupBoxIletisimBilgileri;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBoxEkBilgiler;
        private System.Windows.Forms.CheckBox chkDogumTarihiVar;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.NumericUpDown numIndirimOrani;
        private System.Windows.Forms.Label lblIndirimOrani;
        private System.Windows.Forms.TextBox txtKayitKanali;
        private System.Windows.Forms.Label lblKayitKanali;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.GroupBox groupBoxIstatistikler;
        private System.Windows.Forms.TextBox txtSadakatPuani;
        private System.Windows.Forms.Label lblSadakatPuani;
        private System.Windows.Forms.TextBox txtToplamHarcama;
        private System.Windows.Forms.Label lblToplamHarcama;
        private System.Windows.Forms.TextBox txtToplamSeyahat;
        private System.Windows.Forms.Label lblToplamSeyahat;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Button btnMusteriNoOlustur;
    }
}