namespace UDO.Forms
{
    partial class DenizOtobusuYonetimForm
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
            this.rdTumDenizOtobusleri = new System.Windows.Forms.RadioButton();
            this.rdPasifDenizOtobusleri = new System.Windows.Forms.RadioButton();
            this.rdAktifDenizOtobusleri = new System.Windows.Forms.RadioButton();
            this.rdBakimZamani = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnBakimYap = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewDenizOtobusleri = new System.Windows.Forms.DataGridView();
            this.DenizOtobusuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenizOtobusuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UretimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonBakimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonMuayeneTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BakimDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelArama.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDenizOtobusleri)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(254, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DENİZ OTOBÜSÜ YÖNETİMİ";
            // 
            // panelArama
            // 
            this.panelArama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelArama.Controls.Add(this.rdTumDenizOtobusleri);
            this.panelArama.Controls.Add(this.rdPasifDenizOtobusleri);
            this.panelArama.Controls.Add(this.rdAktifDenizOtobusleri);
            this.panelArama.Controls.Add(this.rdBakimZamani);
            this.panelArama.Controls.Add(this.btnAra);
            this.panelArama.Controls.Add(this.txtArama);
            this.panelArama.Controls.Add(this.lblArama);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Location = new System.Drawing.Point(0, 50);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(950, 60);
            this.panelArama.TabIndex = 1;
            // 
            // rdTumDenizOtobusleri
            // 
            this.rdTumDenizOtobusleri.AutoSize = true;
            this.rdTumDenizOtobusleri.Checked = true;
            this.rdTumDenizOtobusleri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumDenizOtobusleri.Location = new System.Drawing.Point(500, 21);
            this.rdTumDenizOtobusleri.Name = "rdTumDenizOtobusleri";
            this.rdTumDenizOtobusleri.Size = new System.Drawing.Size(131, 19);
            this.rdTumDenizOtobusleri.TabIndex = 6;
            this.rdTumDenizOtobusleri.TabStop = true;
            this.rdTumDenizOtobusleri.Text = "Tüm Deniz Otobüsleri";
            this.rdTumDenizOtobusleri.UseVisualStyleBackColor = true;
            this.rdTumDenizOtobusleri.CheckedChanged += new System.EventHandler(this.rdTumDenizOtobusleri_CheckedChanged);
            // 
            // rdPasifDenizOtobusleri
            // 
            this.rdPasifDenizOtobusleri.AutoSize = true;
            this.rdPasifDenizOtobusleri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdPasifDenizOtobusleri.Location = new System.Drawing.Point(750, 21);
            this.rdPasifDenizOtobusleri.Name = "rdPasifDenizOtobusleri";
            this.rdPasifDenizOtobusleri.Size = new System.Drawing.Size(133, 19);
            this.rdPasifDenizOtobusleri.TabIndex = 5;
            this.rdPasifDenizOtobusleri.Text = "Pasif Deniz Otobüsleri";
            this.rdPasifDenizOtobusleri.UseVisualStyleBackColor = true;
            this.rdPasifDenizOtobusleri.CheckedChanged += new System.EventHandler(this.rdPasifDenizOtobusleri_CheckedChanged);
            // 
            // rdAktifDenizOtobusleri
            // 
            this.rdAktifDenizOtobusleri.AutoSize = true;
            this.rdAktifDenizOtobusleri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktifDenizOtobusleri.Location = new System.Drawing.Point(630, 21);
            this.rdAktifDenizOtobusleri.Name = "rdAktifDenizOtobusleri";
            this.rdAktifDenizOtobusleri.Size = new System.Drawing.Size(132, 19);
            this.rdAktifDenizOtobusleri.TabIndex = 4;
            this.rdAktifDenizOtobusleri.Text = "Aktif Deniz Otobüsleri";
            this.rdAktifDenizOtobusleri.UseVisualStyleBackColor = true;
            this.rdAktifDenizOtobusleri.CheckedChanged += new System.EventHandler(this.rdAktifDenizOtobusleri_CheckedChanged);
            // 
            // rdBakimZamani
            // 
            this.rdBakimZamani.AutoSize = true;
            this.rdBakimZamani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBakimZamani.Location = new System.Drawing.Point(500, 40);
            this.rdBakimZamani.Name = "rdBakimZamani";
            this.rdBakimZamani.Size = new System.Drawing.Size(121, 19);
            this.rdBakimZamani.TabIndex = 7;
            this.rdBakimZamani.Text = "Bakım Zamanı Gelen";
            this.rdBakimZamani.UseVisualStyleBackColor = true;
            this.rdBakimZamani.CheckedChanged += new System.EventHandler(this.rdBakimZamani_CheckedChanged);
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
            this.lblArama.Text = "Araç/Model:";
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnYenile);
            this.panelIslemler.Controls.Add(this.btnBakimYap);
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
            // btnBakimYap
            // 
            this.btnBakimYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnBakimYap.Enabled = false;
            this.btnBakimYap.FlatAppearance.BorderSize = 0;
            this.btnBakimYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakimYap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakimYap.ForeColor = System.Drawing.Color.White;
            this.btnBakimYap.Location = new System.Drawing.Point(531, 18);
            this.btnBakimYap.Name = "btnBakimYap";
            this.btnBakimYap.Size = new System.Drawing.Size(95, 30);
            this.btnBakimYap.TabIndex = 4;
            this.btnBakimYap.Text = "Bakım Yap";
            this.btnBakimYap.UseVisualStyleBackColor = false;
            this.btnBakimYap.Click += new System.EventHandler(this.btnBakimYap_Click);
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
            this.panelGrid.Controls.Add(this.dataGridViewDenizOtobusleri);
            this.panelGrid.Controls.Add(this.lblBilgi);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 110);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(950, 435);
            this.panelGrid.TabIndex = 3;
            // 
            // dataGridViewDenizOtobusleri
            // 
            this.dataGridViewDenizOtobusleri.AllowUserToAddRows = false;
            this.dataGridViewDenizOtobusleri.AllowUserToDeleteRows = false;
            this.dataGridViewDenizOtobusleri.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDenizOtobusleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDenizOtobusleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DenizOtobusuID,
            this.DenizOtobusuAdi,
            this.Model,
            this.Marka,
            this.Kapasite,
            this.UretimYili,
            this.Yas,
            this.SonBakimTarihi,
            this.SonMuayeneTarihi,
            this.BakimDurumu,
            this.Durum});
            this.dataGridViewDenizOtobusleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDenizOtobusleri.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDenizOtobusleri.MultiSelect = false;
            this.dataGridViewDenizOtobusleri.Name = "dataGridViewDenizOtobusleri";
            this.dataGridViewDenizOtobusleri.ReadOnly = true;
            this.dataGridViewDenizOtobusleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDenizOtobusleri.Size = new System.Drawing.Size(950, 415);
            this.dataGridViewDenizOtobusleri.TabIndex = 0;
            this.dataGridViewDenizOtobusleri.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDenizOtobusleri_CellFormatting);
            this.dataGridViewDenizOtobusleri.SelectionChanged += new System.EventHandler(this.dataGridViewDenizOtobusleri_SelectionChanged);
            // 
            // DenizOtobusuID
            // 
            this.DenizOtobusuID.DataPropertyName = "DenizOtobusuID";
            this.DenizOtobusuID.HeaderText = "ID";
            this.DenizOtobusuID.Name = "DenizOtobusuID";
            this.DenizOtobusuID.ReadOnly = true;
            this.DenizOtobusuID.Width = 50;
            // 
            // DenizOtobusuAdi
            // 
            this.DenizOtobusuAdi.DataPropertyName = "DenizOtobusuAdi";
            this.DenizOtobusuAdi.HeaderText = "Deniz Otobüsü Adı";
            this.DenizOtobusuAdi.Name = "DenizOtobusuAdi";
            this.DenizOtobusuAdi.ReadOnly = true;
            this.DenizOtobusuAdi.Width = 150;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 120;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            this.Marka.Width = 100;
            // 
            // Kapasite
            // 
            this.Kapasite.DataPropertyName = "Kapasite";
            this.Kapasite.HeaderText = "Kapasite";
            this.Kapasite.Name = "Kapasite";
            this.Kapasite.ReadOnly = true;
            this.Kapasite.Width = 80;
            // 
            // UretimYili
            // 
            this.UretimYili.DataPropertyName = "UretimYili";
            this.UretimYili.HeaderText = "Üretim Yılı";
            this.UretimYili.Name = "UretimYili";
            this.UretimYili.ReadOnly = true;
            this.UretimYili.Width = 90;
            // 
            // Yas
            // 
            this.Yas.HeaderText = "Yaş";
            this.Yas.Name = "Yas";
            this.Yas.ReadOnly = true;
            this.Yas.Width = 60;
            // 
            // SonBakimTarihi
            // 
            this.SonBakimTarihi.DataPropertyName = "SonBakimTarihi";
            this.SonBakimTarihi.HeaderText = "Son Bakım";
            this.SonBakimTarihi.Name = "SonBakimTarihi";
            this.SonBakimTarihi.ReadOnly = true;
            this.SonBakimTarihi.Width = 100;
            // 
            // SonMuayeneTarihi
            // 
            this.SonMuayeneTarihi.DataPropertyName = "SonMuayeneTarihi";
            this.SonMuayeneTarihi.HeaderText = "Son Muayene";
            this.SonMuayeneTarihi.Name = "SonMuayeneTarihi";
            this.SonMuayeneTarihi.ReadOnly = true;
            this.SonMuayeneTarihi.Width = 100;
            // 
            // BakimDurumu
            // 
            this.BakimDurumu.HeaderText = "Bakım Durumu";
            this.BakimDurumu.Name = "BakimDurumu";
            this.BakimDurumu.ReadOnly = true;
            this.BakimDurumu.Width = 110;
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
            this.lblBilgi.Text = "Toplam deniz otobüsü sayısı: 0";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DenizOtobusuYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelArama);
            this.Controls.Add(this.panelUst);
            this.Name = "DenizOtobusuYonetimForm";
            this.Text = "Deniz Otobüsü Yönetimi";
            this.Load += new System.EventHandler(this.DenizOtobusuYonetimForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDenizOtobusleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewDenizOtobusleri;
        private System.Windows.Forms.RadioButton rdPasifDenizOtobusleri;
        private System.Windows.Forms.RadioButton rdAktifDenizOtobusleri;
        private System.Windows.Forms.RadioButton rdTumDenizOtobusleri;
        private System.Windows.Forms.RadioButton rdBakimZamani;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnBakimYap;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenizOtobusuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenizOtobusuAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasite;
        private System.Windows.Forms.DataGridViewTextBoxColumn UretimYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonBakimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonMuayeneTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BakimDurumu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
    }
}