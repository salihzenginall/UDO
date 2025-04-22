namespace UDO.Forms
{
    partial class SeferYonetimForm
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
            this.panelFiltre = new System.Windows.Forms.Panel();
            this.groupBoxTarih = new System.Windows.Forms.GroupBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.rdTarihSec = new System.Windows.Forms.RadioButton();
            this.rdYarin = new System.Windows.Forms.RadioButton();
            this.rdBugun = new System.Windows.Forms.RadioButton();
            this.rdTumSeferler = new System.Windows.Forms.RadioButton();
            this.rdYaklasan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDurumFiltre = new System.Windows.Forms.ComboBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewSeferler = new System.Windows.Forms.DataGridView();
            this.SeferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuzergahID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuzergahAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenizOtobusuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenizOtobusuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahminiVarisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GercekVarisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeferDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoluKoltukSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BosKoltukSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolulukOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelFiltre.SuspendLayout();
            this.groupBoxTarih.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferler)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(162, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "SEFER YÖNETİMİ";
            // 
            // panelFiltre
            // 
            this.panelFiltre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFiltre.Controls.Add(this.groupBoxTarih);
            this.panelFiltre.Controls.Add(this.label2);
            this.panelFiltre.Controls.Add(this.cmbDurumFiltre);
            this.panelFiltre.Controls.Add(this.btnYenile);
            this.panelFiltre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltre.Location = new System.Drawing.Point(0, 50);
            this.panelFiltre.Name = "panelFiltre";
            this.panelFiltre.Size = new System.Drawing.Size(950, 100);
            this.panelFiltre.TabIndex = 1;
            // 
            // groupBoxTarih
            // 
            this.groupBoxTarih.Controls.Add(this.dtpTarih);
            this.groupBoxTarih.Controls.Add(this.rdTarihSec);
            this.groupBoxTarih.Controls.Add(this.rdYarin);
            this.groupBoxTarih.Controls.Add(this.rdBugun);
            this.groupBoxTarih.Controls.Add(this.rdTumSeferler);
            this.groupBoxTarih.Controls.Add(this.rdYaklasan);
            this.groupBoxTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxTarih.Location = new System.Drawing.Point(12, 10);
            this.groupBoxTarih.Name = "groupBoxTarih";
            this.groupBoxTarih.Size = new System.Drawing.Size(600, 80);
            this.groupBoxTarih.TabIndex = 1;
            this.groupBoxTarih.TabStop = false;
            this.groupBoxTarih.Text = "Tarih Filtresi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Enabled = false;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(483, 26);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(100, 23);
            this.dtpTarih.TabIndex = 5;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // rdTarihSec
            // 
            this.rdTarihSec.AutoSize = true;
            this.rdTarihSec.Location = new System.Drawing.Point(370, 28);
            this.rdTarihSec.Name = "rdTarihSec";
            this.rdTarihSec.Size = new System.Drawing.Size(107, 19);
            this.rdTarihSec.TabIndex = 4;
            this.rdTarihSec.Text = "Seçili Tarihtekiler";
            this.rdTarihSec.UseVisualStyleBackColor = true;
            this.rdTarihSec.CheckedChanged += new System.EventHandler(this.rdTarihSec_CheckedChanged);
            // 
            // rdYarin
            // 
            this.rdYarin.AutoSize = true;
            this.rdYarin.Location = new System.Drawing.Point(300, 28);
            this.rdYarin.Name = "rdYarin";
            this.rdYarin.Size = new System.Drawing.Size(53, 19);
            this.rdYarin.TabIndex = 3;
            this.rdYarin.Text = "Yarın";
            this.rdYarin.UseVisualStyleBackColor = true;
            this.rdYarin.CheckedChanged += new System.EventHandler(this.rdYarin_CheckedChanged);
            // 
            // rdBugun
            // 
            this.rdBugun.AutoSize = true;
            this.rdBugun.Location = new System.Drawing.Point(218, 28);
            this.rdBugun.Name = "rdBugun";
            this.rdBugun.Size = new System.Drawing.Size(60, 19);
            this.rdBugun.TabIndex = 2;
            this.rdBugun.Text = "Bugün";
            this.rdBugun.UseVisualStyleBackColor = true;
            this.rdBugun.CheckedChanged += new System.EventHandler(this.rdBugun_CheckedChanged);
            // 
            // rdTumSeferler
            // 
            this.rdTumSeferler.AutoSize = true;
            this.rdTumSeferler.Checked = true;
            this.rdTumSeferler.Location = new System.Drawing.Point(124, 28);
            this.rdTumSeferler.Name = "rdTumSeferler";
            this.rdTumSeferler.Size = new System.Drawing.Size(72, 19);
            this.rdTumSeferler.TabIndex = 1;
            this.rdTumSeferler.TabStop = true;
            this.rdTumSeferler.Text = "Tüm Seferler";
            this.rdTumSeferler.UseVisualStyleBackColor = true;
            this.rdTumSeferler.CheckedChanged += new System.EventHandler(this.rdTumSeferler_CheckedChanged);
            // 
            // rdYaklasan
            // 
            this.rdYaklasan.AutoSize = true;
            this.rdYaklasan.Location = new System.Drawing.Point(17, 28);
            this.rdYaklasan.Name = "rdYaklasan";
            this.rdYaklasan.Size = new System.Drawing.Size(81, 19);
            this.rdYaklasan.TabIndex = 0;
            this.rdYaklasan.Text = "Yaklaşanlar";
            this.rdYaklasan.UseVisualStyleBackColor = true;
            this.rdYaklasan.CheckedChanged += new System.EventHandler(this.rdYaklasan_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(630, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Durum:";
            // 
            // cmbDurumFiltre
            // 
            this.cmbDurumFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumFiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurumFiltre.FormattingEnabled = true;
            this.cmbDurumFiltre.Location = new System.Drawing.Point(681, 25);
            this.cmbDurumFiltre.Name = "cmbDurumFiltre";
            this.cmbDurumFiltre.Size = new System.Drawing.Size(160, 23);
            this.cmbDurumFiltre.TabIndex = 3;
            this.cmbDurumFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbDurumFiltre_SelectedIndexChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(850, 22);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(88, 30);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnDetay);
            this.panelIslemler.Controls.Add(this.btnDurumGuncelle);
            this.panelIslemler.Controls.Add(this.btnIptal);
            this.panelIslemler.Controls.Add(this.btnDuzenle);
            this.panelIslemler.Controls.Add(this.btnEkle);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 545);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(950, 60);
            this.panelIslemler.TabIndex = 2;
            // 
            // btnDetay
            // 
            this.btnDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnDetay.FlatAppearance.BorderSize = 0;
            this.btnDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetay.ForeColor = System.Drawing.Color.White;
            this.btnDetay.Location = new System.Drawing.Point(531, 18);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(95, 30);
            this.btnDetay.TabIndex = 4;
            this.btnDetay.Text = "Sefer Detayı";
            this.btnDetay.UseVisualStyleBackColor = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnDurumGuncelle.FlatAppearance.BorderSize = 0;
            this.btnDurumGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDurumGuncelle.Location = new System.Drawing.Point(418, 18);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(95, 30);
            this.btnDurumGuncelle.TabIndex = 3;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(305, 18);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 30);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "Sefer İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
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
            this.btnEkle.Text = "Yeni Sefer";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewSeferler);
            this.panelGrid.Controls.Add(this.lblBilgi);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 150);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(950, 395);
            this.panelGrid.TabIndex = 3;
            // 
            // dataGridViewSeferler
            // 
            this.dataGridViewSeferler.AllowUserToAddRows = false;
            this.dataGridViewSeferler.AllowUserToDeleteRows = false;
            this.dataGridViewSeferler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeferler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeferID,
            this.GuzergahID,
            this.GuzergahAdi,
            this.DenizOtobusuID,
            this.DenizOtobusuAdi,
            this.KalkisTarihi,
            this.TahminiVarisTarihi,
            this.GercekVarisTarihi,
            this.SeferDurumu,
            this.Kapasite,
            this.DoluKoltukSayisi,
            this.BosKoltukSayisi,
            this.DolulukOrani,
            this.BiletFiyati});
            this.dataGridViewSeferler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeferler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSeferler.MultiSelect = false;
            this.dataGridViewSeferler.Name = "dataGridViewSeferler";
            this.dataGridViewSeferler.ReadOnly = true;
            this.dataGridViewSeferler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeferler.Size = new System.Drawing.Size(950, 375);
            this.dataGridViewSeferler.TabIndex = 0;
            this.dataGridViewSeferler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSeferler_CellFormatting);
            this.dataGridViewSeferler.SelectionChanged += new System.EventHandler(this.dataGridViewSeferler_SelectionChanged);
            // 
            // SeferID
            // 
            this.SeferID.DataPropertyName = "SeferID";
            this.SeferID.HeaderText = "Sefer ID";
            this.SeferID.Name = "SeferID";
            this.SeferID.ReadOnly = true;
            this.SeferID.Width = 70;
            // 
            // GuzergahID
            // 
            this.GuzergahID.DataPropertyName = "GuzergahID";
            this.GuzergahID.HeaderText = "Güzergah ID";
            this.GuzergahID.Name = "GuzergahID";
            this.GuzergahID.ReadOnly = true;
            this.GuzergahID.Visible = false;
            // 
            // GuzergahAdi
            // 
            this.GuzergahAdi.DataPropertyName = "GuzergahAdi";
            this.GuzergahAdi.HeaderText = "Güzergah";
            this.GuzergahAdi.Name = "GuzergahAdi";
            this.GuzergahAdi.ReadOnly = true;
            this.GuzergahAdi.Width = 150;
            // 
            // DenizOtobusuID
            // 
            this.DenizOtobusuID.DataPropertyName = "DenizOtobusuID";
            this.DenizOtobusuID.HeaderText = "Otobüs ID";
            this.DenizOtobusuID.Name = "DenizOtobusuID";
            this.DenizOtobusuID.ReadOnly = true;
            this.DenizOtobusuID.Visible = false;
            // 
            // DenizOtobusuAdi
            // 
            this.DenizOtobusuAdi.DataPropertyName = "DenizOtobusuAdi";
            this.DenizOtobusuAdi.HeaderText = "Deniz Otobüsü";
            this.DenizOtobusuAdi.Name = "DenizOtobusuAdi";
            this.DenizOtobusuAdi.ReadOnly = true;
            this.DenizOtobusuAdi.Width = 130;
            // 
            // KalkisTarihi
            // 
            this.KalkisTarihi.DataPropertyName = "KalkisTarihi";
            this.KalkisTarihi.HeaderText = "Kalkış Tarihi";
            this.KalkisTarihi.Name = "KalkisTarihi";
            this.KalkisTarihi.ReadOnly = true;
            this.KalkisTarihi.Width = 130;
            // 
            // TahminiVarisTarihi
            // 
            this.TahminiVarisTarihi.DataPropertyName = "TahminiVarisTarihi";
            this.TahminiVarisTarihi.HeaderText = "Tahmini Varış";
            this.TahminiVarisTarihi.Name = "TahminiVarisTarihi";
            this.TahminiVarisTarihi.ReadOnly = true;
            this.TahminiVarisTarihi.Width = 130;
            // 
            // GercekVarisTarihi
            // 
            this.GercekVarisTarihi.DataPropertyName = "GercekVarisTarihi";
            this.GercekVarisTarihi.HeaderText = "Gerçek Varış";
            this.GercekVarisTarihi.Name = "GercekVarisTarihi";
            this.GercekVarisTarihi.ReadOnly = true;
            this.GercekVarisTarihi.Width = 130;
            // 
            // SeferDurumu
            // 
            this.SeferDurumu.DataPropertyName = "SeferDurumu";
            this.SeferDurumu.HeaderText = "Durum";
            this.SeferDurumu.Name = "SeferDurumu";
            this.SeferDurumu.ReadOnly = true;
            this.SeferDurumu.Width = 120;
            // 
            // Kapasite
            // 
            this.Kapasite.DataPropertyName = "Kapasite";
            this.Kapasite.HeaderText = "Kapasite";
            this.Kapasite.Name = "Kapasite";
            this.Kapasite.ReadOnly = true;
            this.Kapasite.Width = 70;
            // 
            // DoluKoltukSayisi
            // 
            this.DoluKoltukSayisi.DataPropertyName = "DoluKoltukSayisi";
            this.DoluKoltukSayisi.HeaderText = "Dolu";
            this.DoluKoltukSayisi.Name = "DoluKoltukSayisi";
            this.DoluKoltukSayisi.ReadOnly = true;
            this.DoluKoltukSayisi.Width = 60;
            // 
            // BosKoltukSayisi
            // 
            this.BosKoltukSayisi.DataPropertyName = "BosKoltukSayisi";
            this.BosKoltukSayisi.HeaderText = "Boş";
            this.BosKoltukSayisi.Name = "BosKoltukSayisi";
            this.BosKoltukSayisi.ReadOnly = true;
            this.BosKoltukSayisi.Width = 60;
            // 
            // DolulukOrani
            // 
            this.DolulukOrani.HeaderText = "Doluluk %";
            this.DolulukOrani.Name = "DolulukOrani";
            this.DolulukOrani.ReadOnly = true;
            this.DolulukOrani.Width = 80;
            // 
            // BiletFiyati
            // 
            this.BiletFiyati.DataPropertyName = "BiletFiyati";
            this.BiletFiyati.HeaderText = "Bilet Fiyatı";
            this.BiletFiyati.Name = "BiletFiyati";
            this.BiletFiyati.ReadOnly = true;
            this.BiletFiyati.Width = 80;
            // 
            // lblBilgi
            // 
            this.lblBilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Gray;
            this.lblBilgi.Location = new System.Drawing.Point(0, 375);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(950, 20);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "Toplam sefer sayısı: 0";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeferYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelFiltre);
            this.Controls.Add(this.panelUst);
            this.Name = "SeferYonetimForm";
            this.Text = "Sefer Yönetimi";
            this.Load += new System.EventHandler(this.SeferYonetimForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelFiltre.ResumeLayout(false);
            this.panelFiltre.PerformLayout();
            this.groupBoxTarih.ResumeLayout(false);
            this.groupBoxTarih.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelFiltre;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ComboBox cmbDurumFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTarih;
        private System.Windows.Forms.RadioButton rdTarihSec;
        private System.Windows.Forms.RadioButton rdYarin;
        private System.Windows.Forms.RadioButton rdBugun;
        private System.Windows.Forms.RadioButton rdTumSeferler;
        private System.Windows.Forms.RadioButton rdYaklasan;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewSeferler;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuzergahID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuzergahAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenizOtobusuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenizOtobusuAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahminiVarisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GercekVarisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeferDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasite;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoluKoltukSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BosKoltukSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolulukOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiletFiyati;
    }
}