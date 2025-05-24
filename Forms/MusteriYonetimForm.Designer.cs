namespace UDO.Forms
{
    partial class MusteriYonetimForm
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
            this.panelArama = new System.Windows.Forms.Panel();
            this.rdVipMusteriler = new System.Windows.Forms.RadioButton();
            this.rdTumMusteriler = new System.Windows.Forms.RadioButton();
            this.rdPasifMusteriler = new System.Windows.Forms.RadioButton();
            this.rdAktifMusteriler = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            this.MusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCKN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyrukAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamSeyahat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamHarcama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SadakatPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SadakatSeviyesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VipDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelArama.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(950, 50);
            this.panelUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 11);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(181, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "MÜŞTERİ YÖNETİMİ";
            // 
            // panelArama
            // 
            this.panelArama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelArama.Controls.Add(this.rdVipMusteriler);
            this.panelArama.Controls.Add(this.rdTumMusteriler);
            this.panelArama.Controls.Add(this.rdPasifMusteriler);
            this.panelArama.Controls.Add(this.rdAktifMusteriler);
            this.panelArama.Controls.Add(this.btnAra);
            this.panelArama.Controls.Add(this.txtArama);
            this.panelArama.Controls.Add(this.lblArama);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Location = new System.Drawing.Point(0, 50);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(950, 60);
            this.panelArama.TabIndex = 1;
            // 
            // rdVipMusteriler
            // 
            this.rdVipMusteriler.AutoSize = true;
            this.rdVipMusteriler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdVipMusteriler.Location = new System.Drawing.Point(850, 21);
            this.rdVipMusteriler.Name = "rdVipMusteriler";
            this.rdVipMusteriler.Size = new System.Drawing.Size(95, 19);
            this.rdVipMusteriler.TabIndex = 6;
            this.rdVipMusteriler.Text = "VIP Müşteriler";
            this.rdVipMusteriler.UseVisualStyleBackColor = true;
            this.rdVipMusteriler.CheckedChanged += new System.EventHandler(this.rdVipMusteriler_CheckedChanged);
            // 
            // rdTumMusteriler
            // 
            this.rdTumMusteriler.AutoSize = true;
            this.rdTumMusteriler.Checked = true;
            this.rdTumMusteriler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumMusteriler.Location = new System.Drawing.Point(550, 21);
            this.rdTumMusteriler.Name = "rdTumMusteriler";
            this.rdTumMusteriler.Size = new System.Drawing.Size(100, 19);
            this.rdTumMusteriler.TabIndex = 5;
            this.rdTumMusteriler.TabStop = true;
            this.rdTumMusteriler.Text = "Tüm Müşteriler";
            this.rdTumMusteriler.UseVisualStyleBackColor = true;
            this.rdTumMusteriler.CheckedChanged += new System.EventHandler(this.rdTumMusteriler_CheckedChanged);
            // 
            // rdPasifMusteriler
            // 
            this.rdPasifMusteriler.AutoSize = true;
            this.rdPasifMusteriler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdPasifMusteriler.Location = new System.Drawing.Point(750, 21);
            this.rdPasifMusteriler.Name = "rdPasifMusteriler";
            this.rdPasifMusteriler.Size = new System.Drawing.Size(102, 19);
            this.rdPasifMusteriler.TabIndex = 4;
            this.rdPasifMusteriler.Text = "Pasif Müşteriler";
            this.rdPasifMusteriler.UseVisualStyleBackColor = true;
            this.rdPasifMusteriler.CheckedChanged += new System.EventHandler(this.rdPasifMusteriler_CheckedChanged);
            // 
            // rdAktifMusteriler
            // 
            this.rdAktifMusteriler.AutoSize = true;
            this.rdAktifMusteriler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktifMusteriler.Location = new System.Drawing.Point(650, 21);
            this.rdAktifMusteriler.Name = "rdAktifMusteriler";
            this.rdAktifMusteriler.Size = new System.Drawing.Size(101, 19);
            this.rdAktifMusteriler.TabIndex = 3;
            this.rdAktifMusteriler.Text = "Aktif Müşteriler";
            this.rdAktifMusteriler.UseVisualStyleBackColor = true;
            this.rdAktifMusteriler.CheckedChanged += new System.EventHandler(this.rdAktifMusteriler_CheckedChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(371, 17);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 25);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(92, 18);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(273, 23);
            this.txtArama.TabIndex = 1;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Location = new System.Drawing.Point(15, 22);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(71, 15);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Müşteri Ara:";
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnYenile);
            this.panelIslemler.Controls.Add(this.btnDetay);
            this.panelIslemler.Controls.Add(this.btnDurumDegistir);
            this.panelIslemler.Controls.Add(this.btnSil);
            this.panelIslemler.Controls.Add(this.btnDuzenle);
            this.panelIslemler.Controls.Add(this.btnEkle);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 545);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(950, 60);
            this.panelIslemler.TabIndex = 2;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(843, 18);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(95, 30);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnDetay.Enabled = false;
            this.btnDetay.FlatAppearance.BorderSize = 0;
            this.btnDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetay.ForeColor = System.Drawing.Color.White;
            this.btnDetay.Location = new System.Drawing.Point(531, 18);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(95, 30);
            this.btnDetay.TabIndex = 4;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnDurumDegistir.Enabled = false;
            this.btnDurumDegistir.FlatAppearance.BorderSize = 0;
            this.btnDurumDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumDegistir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDurumDegistir.Location = new System.Drawing.Point(418, 18);
            this.btnDurumDegistir.Name = "btnDurumDegistir";
            this.btnDurumDegistir.Size = new System.Drawing.Size(95, 30);
            this.btnDurumDegistir.TabIndex = 3;
            this.btnDurumDegistir.Text = "Durum Değiştir";
            this.btnDurumDegistir.UseVisualStyleBackColor = false;
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.Enabled = false;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(305, 18);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 30);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnDuzenle.Enabled = false;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDuzenle.Location = new System.Drawing.Point(192, 18);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(95, 30);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(76, 18);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 30);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewMusteriler);
            this.panelGrid.Controls.Add(this.lblBilgi);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 110);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(950, 435);
            this.panelGrid.TabIndex = 3;
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AllowUserToAddRows = false;
            this.dataGridViewMusteriler.AllowUserToDeleteRows = false;
            this.dataGridViewMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusteriID,
            this.MusteriNo,
            this.TamAd,
            this.TCKN,
            this.Email,
            this.TelefonNumarasi,
            this.Yas,
            this.UyrukAdi,
            this.ToplamSeyahat,
            this.ToplamHarcama,
            this.SadakatPuani,
            this.SadakatSeviyesi,
            this.VipDurum,
            this.KayitTarihi,
            this.Durum});
            this.dataGridViewMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMusteriler.MultiSelect = false;
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.ReadOnly = true;
            this.dataGridViewMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(950, 415);
            this.dataGridViewMusteriler.TabIndex = 0;
            this.dataGridViewMusteriler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMusteriler_CellFormatting);
            this.dataGridViewMusteriler.SelectionChanged += new System.EventHandler(this.dataGridViewMusteriler_SelectionChanged);
            // 
            // MusteriID
            // 
            this.MusteriID.DataPropertyName = "MusteriID";
            this.MusteriID.HeaderText = "ID";
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.ReadOnly = true;
            this.MusteriID.Width = 50;
            // 
            // MusteriNo
            // 
            this.MusteriNo.DataPropertyName = "MusteriNo";
            this.MusteriNo.HeaderText = "Müşteri No";
            this.MusteriNo.Name = "MusteriNo";
            this.MusteriNo.ReadOnly = true;
            this.MusteriNo.Width = 100;
            // 
            // TamAd
            // 
            this.TamAd.HeaderText = "Ad Soyad";
            this.TamAd.Name = "TamAd";
            this.TamAd.ReadOnly = true;
            this.TamAd.Width = 150;
            // 
            // TCKN
            // 
            this.TCKN.DataPropertyName = "TCKN";
            this.TCKN.HeaderText = "TCKN";
            this.TCKN.Name = "TCKN";
            this.TCKN.ReadOnly = true;
            this.TCKN.Width = 110;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-posta";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // TelefonNumarasi
            // 
            this.TelefonNumarasi.DataPropertyName = "TelefonNumarasi";
            this.TelefonNumarasi.HeaderText = "Telefon";
            this.TelefonNumarasi.Name = "TelefonNumarasi";
            this.TelefonNumarasi.ReadOnly = true;
            this.TelefonNumarasi.Width = 120;
            // 
            // Yas
            // 
            this.Yas.HeaderText = "Yaş";
            this.Yas.Name = "Yas";
            this.Yas.ReadOnly = true;
            this.Yas.Width = 60;
            // 
            // UyrukAdi
            // 
            this.UyrukAdi.DataPropertyName = "UyrukAdi";
            this.UyrukAdi.HeaderText = "Uyruk";
            this.UyrukAdi.Name = "UyrukAdi";
            this.UyrukAdi.ReadOnly = true;
            this.UyrukAdi.Width = 80;
            // 
            // ToplamSeyahat
            // 
            this.ToplamSeyahat.DataPropertyName = "ToplamSeyahat";
            this.ToplamSeyahat.HeaderText = "Seyahat";
            this.ToplamSeyahat.Name = "ToplamSeyahat";
            this.ToplamSeyahat.ReadOnly = true;
            this.ToplamSeyahat.Width = 70;
            // 
            // ToplamHarcama
            // 
            this.ToplamHarcama.DataPropertyName = "ToplamHarcama";
            this.ToplamHarcama.HeaderText = "Harcama";
            this.ToplamHarcama.Name = "ToplamHarcama";
            this.ToplamHarcama.ReadOnly = true;
            this.ToplamHarcama.Width = 100;
            // 
            // SadakatPuani
            // 
            this.SadakatPuani.DataPropertyName = "SadakatPuani";
            this.SadakatPuani.HeaderText = "Puan";
            this.SadakatPuani.Name = "SadakatPuani";
            this.SadakatPuani.ReadOnly = true;
            this.SadakatPuani.Width = 70;
            // 
            // SadakatSeviyesi
            // 
            this.SadakatSeviyesi.HeaderText = "Seviye";
            this.SadakatSeviyesi.Name = "SadakatSeviyesi";
            this.SadakatSeviyesi.ReadOnly = true;
            this.SadakatSeviyesi.Width = 80;
            // 
            // VipDurum
            // 
            this.VipDurum.HeaderText = "VIP";
            this.VipDurum.Name = "VipDurum";
            this.VipDurum.ReadOnly = true;
            this.VipDurum.Width = 60;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.DataPropertyName = "KayitTarihi";
            this.KayitTarihi.HeaderText = "Kayıt Tarihi";
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.ReadOnly = true;
            this.KayitTarihi.Width = 100;
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Aktif";
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Durum.Width = 70;
            // 
            // lblBilgi
            // 
            this.lblBilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Gray;
            this.lblBilgi.Location = new System.Drawing.Point(0, 415);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(950, 20);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "Toplam müşteri sayısı: 0";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MusteriYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelArama);
            this.Controls.Add(this.panelUst);
            this.Name = "MusteriYonetimForm";
            this.Text = "Müşteri Yönetimi";
            this.Load += new System.EventHandler(this.MusteriYonetimForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.RadioButton rdVipMusteriler;
        private System.Windows.Forms.RadioButton rdTumMusteriler;
        private System.Windows.Forms.RadioButton rdPasifMusteriler;
        private System.Windows.Forms.RadioButton rdAktifMusteriler;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyrukAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamSeyahat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamHarcama;
        private System.Windows.Forms.DataGridViewTextBoxColumn SadakatPuani;
        private System.Windows.Forms.DataGridViewTextBoxColumn SadakatSeviyesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VipDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
        private System.Windows.Forms.Label lblBilgi;
    }
}