namespace UDO.Forms
{
    partial class DenizOtobusuEkleDuzenleForm
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
            this.groupBoxBilgiler = new System.Windows.Forms.GroupBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtDurumNotu = new System.Windows.Forms.TextBox();
            this.lblDurumNotu = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.numMaxHiz = new System.Windows.Forms.NumericUpDown();
            this.lblMaxHiz = new System.Windows.Forms.Label();
            this.txtMotorTipi = new System.Windows.Forms.TextBox();
            this.lblMotorTipi = new System.Windows.Forms.Label();
            this.numYakitKapasitesi = new System.Windows.Forms.NumericUpDown();
            this.lblYakitKapasitesi = new System.Windows.Forms.Label();
            this.numUretimYili = new System.Windows.Forms.NumericUpDown();
            this.lblUretimYili = new System.Windows.Forms.Label();
            this.numKapasite = new System.Windows.Forms.NumericUpDown();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.txtSeriNumarasi = new System.Windows.Forms.TextBox();
            this.lblSeriNumarasi = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtDenizOtobusuAdi = new System.Windows.Forms.TextBox();
            this.lblDenizOtobusuAdi = new System.Windows.Forms.Label();
            this.groupBoxBakimBilgileri = new System.Windows.Forms.GroupBox();
            this.chkMuayeneTarihiVar = new System.Windows.Forms.CheckBox();
            this.dtpSonMuayeneTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSonMuayeneTarihi = new System.Windows.Forms.Label();
            this.chkBakimTarihiVar = new System.Windows.Forms.CheckBox();
            this.dtpSonBakimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSonBakimTarihi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.panelIcerik.SuspendLayout();
            this.groupBoxBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYakitKapasitesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUretimYili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).BeginInit();
            this.groupBoxBakimBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(684, 50);
            this.panelUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 14);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(220, 21);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ DENİZ OTOBÜSÜ EKLE";
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAlt.Controls.Add(this.btnIptal);
            this.panelAlt.Controls.Add(this.btnKaydet);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 511);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(684, 50);
            this.panelAlt.TabIndex = 1;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(577, 10);
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
            this.btnKaydet.Location = new System.Drawing.Point(476, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 30);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panelIcerik
            // 
            this.panelIcerik.Controls.Add(this.groupBoxBakimBilgileri);
            this.panelIcerik.Controls.Add(this.groupBoxBilgiler);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 50);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Padding = new System.Windows.Forms.Padding(10);
            this.panelIcerik.Size = new System.Drawing.Size(684, 461);
            this.panelIcerik.TabIndex = 2;
            // 
            // groupBoxBilgiler
            // 
            this.groupBoxBilgiler.Controls.Add(this.chkAktif);
            this.groupBoxBilgiler.Controls.Add(this.txtDurumNotu);
            this.groupBoxBilgiler.Controls.Add(this.lblDurumNotu);
            this.groupBoxBilgiler.Controls.Add(this.txtAciklama);
            this.groupBoxBilgiler.Controls.Add(this.lblAciklama);
            this.groupBoxBilgiler.Controls.Add(this.numMaxHiz);
            this.groupBoxBilgiler.Controls.Add(this.lblMaxHiz);
            this.groupBoxBilgiler.Controls.Add(this.txtMotorTipi);
            this.groupBoxBilgiler.Controls.Add(this.lblMotorTipi);
            this.groupBoxBilgiler.Controls.Add(this.numYakitKapasitesi);
            this.groupBoxBilgiler.Controls.Add(this.lblYakitKapasitesi);
            this.groupBoxBilgiler.Controls.Add(this.numUretimYili);
            this.groupBoxBilgiler.Controls.Add(this.lblUretimYili);
            this.groupBoxBilgiler.Controls.Add(this.numKapasite);
            this.groupBoxBilgiler.Controls.Add(this.lblKapasite);
            this.groupBoxBilgiler.Controls.Add(this.txtSeriNumarasi);
            this.groupBoxBilgiler.Controls.Add(this.lblSeriNumarasi);
            this.groupBoxBilgiler.Controls.Add(this.txtMarka);
            this.groupBoxBilgiler.Controls.Add(this.lblMarka);
            this.groupBoxBilgiler.Controls.Add(this.txtModel);
            this.groupBoxBilgiler.Controls.Add(this.lblModel);
            this.groupBoxBilgiler.Controls.Add(this.txtDenizOtobusuAdi);
            this.groupBoxBilgiler.Controls.Add(this.lblDenizOtobusuAdi);
            this.groupBoxBilgiler.Location = new System.Drawing.Point(13, 13);
            this.groupBoxBilgiler.Name = "groupBoxBilgiler";
            this.groupBoxBilgiler.Size = new System.Drawing.Size(658, 320);
            this.groupBoxBilgiler.TabIndex = 0;
            this.groupBoxBilgiler.TabStop = false;
            this.groupBoxBilgiler.Text = "Deniz Otobüsü Bilgileri";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(580, 30);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(51, 19);
            this.chkAktif.TabIndex = 22;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtDurumNotu
            // 
            this.txtDurumNotu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurumNotu.Location = new System.Drawing.Point(420, 250);
            this.txtDurumNotu.Multiline = true;
            this.txtDurumNotu.Name = "txtDurumNotu";
            this.txtDurumNotu.Size = new System.Drawing.Size(220, 60);
            this.txtDurumNotu.TabIndex = 21;
            // 
            // lblDurumNotu
            // 
            this.lblDurumNotu.AutoSize = true;
            this.lblDurumNotu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurumNotu.Location = new System.Drawing.Point(420, 232);
            this.lblDurumNotu.Name = "lblDurumNotu";
            this.lblDurumNotu.Size = new System.Drawing.Size(73, 15);
            this.lblDurumNotu.TabIndex = 20;
            this.lblDurumNotu.Text = "Durum Notu:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(15, 250);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(380, 60);
            this.txtAciklama.TabIndex = 19;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(15, 232);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 15);
            this.lblAciklama.TabIndex = 18;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // numMaxHiz
            // 
            this.numMaxHiz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numMaxHiz.Location = new System.Drawing.Point(540, 190);
            this.numMaxHiz.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMaxHiz.Name = "numMaxHiz";
            this.numMaxHiz.Size = new System.Drawing.Size(100, 23);
            this.numMaxHiz.TabIndex = 17;
            // 
            // lblMaxHiz
            // 
            this.lblMaxHiz.AutoSize = true;
            this.lblMaxHiz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxHiz.Location = new System.Drawing.Point(540, 172);
            this.lblMaxHiz.Name = "lblMaxHiz";
            this.lblMaxHiz.Size = new System.Drawing.Size(87, 15);
            this.lblMaxHiz.TabIndex = 16;
            this.lblMaxHiz.Text = "Max Hız (Knot):";
            // 
            // txtMotorTipi
            // 
            this.txtMotorTipi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMotorTipi.Location = new System.Drawing.Point(15, 190);
            this.txtMotorTipi.Name = "txtMotorTipi";
            this.txtMotorTipi.Size = new System.Drawing.Size(200, 23);
            this.txtMotorTipi.TabIndex = 15;
            // 
            // lblMotorTipi
            // 
            this.lblMotorTipi.AutoSize = true;
            this.lblMotorTipi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMotorTipi.Location = new System.Drawing.Point(15, 172);
            this.lblMotorTipi.Name = "lblMotorTipi";
            this.lblMotorTipi.Size = new System.Drawing.Size(66, 15);
            this.lblMotorTipi.TabIndex = 14;
            this.lblMotorTipi.Text = "Motor Tipi:";
            // 
            // numYakitKapasitesi
            // 
            this.numYakitKapasitesi.DecimalPlaces = 2;
            this.numYakitKapasitesi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numYakitKapasitesi.Location = new System.Drawing.Point(240, 190);
            this.numYakitKapasitesi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numYakitKapasitesi.Name = "numYakitKapasitesi";
            this.numYakitKapasitesi.Size = new System.Drawing.Size(120, 23);
            this.numYakitKapasitesi.TabIndex = 13;
            // 
            // lblYakitKapasitesi
            // 
            this.lblYakitKapasitesi.AutoSize = true;
            this.lblYakitKapasitesi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakitKapasitesi.Location = new System.Drawing.Point(240, 172);
            this.lblYakitKapasitesi.Name = "lblYakitKapasitesi";
            this.lblYakitKapasitesi.Size = new System.Drawing.Size(115, 15);
            this.lblYakitKapasitesi.TabIndex = 12;
            this.lblYakitKapasitesi.Text = "Yakıt Kapasitesi (Lt):";
            // 
            // numUretimYili
            // 
            this.numUretimYili.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUretimYili.Location = new System.Drawing.Point(420, 130);
            this.numUretimYili.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numUretimYili.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numUretimYili.Name = "numUretimYili";
            this.numUretimYili.Size = new System.Drawing.Size(100, 23);
            this.numUretimYili.TabIndex = 11;
            this.numUretimYili.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUretimYili.Location = new System.Drawing.Point(420, 112);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(69, 15);
            this.lblUretimYili.TabIndex = 10;
            this.lblUretimYili.Text = "Üretim Yılı:";
            // 
            // numKapasite
            // 
            this.numKapasite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numKapasite.Location = new System.Drawing.Point(540, 130);
            this.numKapasite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKapasite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKapasite.Name = "numKapasite";
            this.numKapasite.Size = new System.Drawing.Size(100, 23);
            this.numKapasite.TabIndex = 9;
            this.numKapasite.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(540, 112);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(56, 15);
            this.lblKapasite.TabIndex = 8;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // txtSeriNumarasi
            // 
            this.txtSeriNumarasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriNumarasi.Location = new System.Drawing.Point(15, 130);
            this.txtSeriNumarasi.Name = "txtSeriNumarasi";
            this.txtSeriNumarasi.Size = new System.Drawing.Size(380, 23);
            this.txtSeriNumarasi.TabIndex = 7;
            // 
            // lblSeriNumarasi
            // 
            this.lblSeriNumarasi.AutoSize = true;
            this.lblSeriNumarasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeriNumarasi.Location = new System.Drawing.Point(15, 112);
            this.lblSeriNumarasi.Name = "lblSeriNumarasi";
            this.lblSeriNumarasi.Size = new System.Drawing.Size(84, 15);
            this.lblSeriNumarasi.TabIndex = 6;
            this.lblSeriNumarasi.Text = "Seri Numarası:";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(420, 70);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(150, 23);
            this.txtMarka.TabIndex = 5;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(420, 52);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(43, 15);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Marka:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(15, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(380, 23);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(15, 52);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtDenizOtobusuAdi
            // 
            this.txtDenizOtobusuAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDenizOtobusuAdi.Location = new System.Drawing.Point(15, 30);
            this.txtDenizOtobusuAdi.Name = "txtDenizOtobusuAdi";
            this.txtDenizOtobusuAdi.Size = new System.Drawing.Size(540, 23);
            this.txtDenizOtobusuAdi.TabIndex = 1;
            // 
            // lblDenizOtobusuAdi
            // 
            this.lblDenizOtobusuAdi.AutoSize = true;
            this.lblDenizOtobusuAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDenizOtobusuAdi.Location = new System.Drawing.Point(15, 12);
            this.lblDenizOtobusuAdi.Name = "lblDenizOtobusuAdi";
            this.lblDenizOtobusuAdi.Size = new System.Drawing.Size(117, 15);
            this.lblDenizOtobusuAdi.TabIndex = 0;
            this.lblDenizOtobusuAdi.Text = "Deniz Otobüsü Adı:*";
            // 
            // groupBoxBakimBilgileri
            // 
            this.groupBoxBakimBilgileri.Controls.Add(this.chkMuayeneTarihiVar);
            this.groupBoxBakimBilgileri.Controls.Add(this.dtpSonMuayeneTarihi);
            this.groupBoxBakimBilgileri.Controls.Add(this.lblSonMuayeneTarihi);
            this.groupBoxBakimBilgileri.Controls.Add(this.chkBakimTarihiVar);
            this.groupBoxBakimBilgileri.Controls.Add(this.dtpSonBakimTarihi);
            this.groupBoxBakimBilgileri.Controls.Add(this.lblSonBakimTarihi);
            this.groupBoxBakimBilgileri.Location = new System.Drawing.Point(13, 340);
            this.groupBoxBakimBilgileri.Name = "groupBoxBakimBilgileri";
            this.groupBoxBakimBilgileri.Size = new System.Drawing.Size(658, 100);
            this.groupBoxBakimBilgileri.TabIndex = 1;
            this.groupBoxBakimBilgileri.TabStop = false;
            this.groupBoxBakimBilgileri.Text = "Bakım ve Muayene Bilgileri";
            // 
            // chkMuayeneTarihiVar
            // 
            this.chkMuayeneTarihiVar.AutoSize = true;
            this.chkMuayeneTarihiVar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMuayeneTarihiVar.Location = new System.Drawing.Point(340, 25);
            this.chkMuayeneTarihiVar.Name = "chkMuayeneTarihiVar";
            this.chkMuayeneTarihiVar.Size = new System.Drawing.Size(139, 19);
            this.chkMuayeneTarihiVar.TabIndex = 5;
            this.chkMuayeneTarihiVar.Text = "Son muayene tarihi var";
            this.chkMuayeneTarihiVar.UseVisualStyleBackColor = true;
            this.chkMuayeneTarihiVar.CheckedChanged += new System.EventHandler(this.chkMuayeneTarihiVar_CheckedChanged);
            // 
            // dtpSonMuayeneTarihi
            // 
            this.dtpSonMuayeneTarihi.Enabled = false;
            this.dtpSonMuayeneTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSonMuayeneTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonMuayeneTarihi.Location = new System.Drawing.Point(340, 65);
            this.dtpSonMuayeneTarihi.Name = "dtpSonMuayeneTarihi";
            this.dtpSonMuayeneTarihi.Size = new System.Drawing.Size(150, 23);
            this.dtpSonMuayeneTarihi.TabIndex = 4;
            // 
            // lblSonMuayeneTarihi
            // 
            this.lblSonMuayeneTarihi.AutoSize = true;
            this.lblSonMuayeneTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonMuayeneTarihi.Location = new System.Drawing.Point(340, 47);
            this.lblSonMuayeneTarihi.Name = "lblSonMuayeneTarihi";
            this.lblSonMuayeneTarihi.Size = new System.Drawing.Size(107, 15);
            this.lblSonMuayeneTarihi.TabIndex = 3;
            this.lblSonMuayeneTarihi.Text = "Son Muayene Tarihi:";
            // 
            // chkBakimTarihiVar
            // 
            this.chkBakimTarihiVar.AutoSize = true;
            this.chkBakimTarihiVar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBakimTarihiVar.Location = new System.Drawing.Point(15, 25);
            this.chkBakimTarihiVar.Name = "chkBakimTarihiVar";
            this.chkBakimTarihiVar.Size = new System.Drawing.Size(123, 19);
            this.chkBakimTarihiVar.TabIndex = 2;
            this.chkBakimTarihiVar.Text = "Son bakım tarihi var";
            this.chkBakimTarihiVar.UseVisualStyleBackColor = true;
            this.chkBakimTarihiVar.CheckedChanged += new System.EventHandler(this.chkBakimTarihiVar_CheckedChanged);
            // 
            // dtpSonBakimTarihi
            // 
            this.dtpSonBakimTarihi.Enabled = false;
            this.dtpSonBakimTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSonBakimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonBakimTarihi.Location = new System.Drawing.Point(15, 65);
            this.dtpSonBakimTarihi.Name = "dtpSonBakimTarihi";
            this.dtpSonBakimTarihi.Size = new System.Drawing.Size(150, 23);
            this.dtpSonBakimTarihi.TabIndex = 1;
            // 
            // lblSonBakimTarihi
            // 
            this.lblSonBakimTarihi.AutoSize = true;
            this.lblSonBakimTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonBakimTarihi.Location = new System.Drawing.Point(15, 47);
            this.lblSonBakimTarihi.Name = "lblSonBakimTarihi";
            this.lblSonBakimTarihi.Size = new System.Drawing.Size(91, 15);
            this.lblSonBakimTarihi.TabIndex = 0;
            this.lblSonBakimTarihi.Text = "Son Bakım Tarihi:";
            // 
            // DenizOtobusuEkleDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DenizOtobusuEkleDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deniz Otobüsü Ekle/Düzenle";
            this.Load += new System.EventHandler(this.DenizOtobusuEkleDuzenleForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.panelIcerik.ResumeLayout(false);
            this.groupBoxBilgiler.ResumeLayout(false);
            this.groupBoxBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYakitKapasitesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUretimYili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).EndInit();
            this.groupBoxBakimBilgileri.ResumeLayout(false);
            this.groupBoxBakimBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.GroupBox groupBoxBilgiler;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.TextBox txtDurumNotu;
        private System.Windows.Forms.Label lblDurumNotu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.NumericUpDown numMaxHiz;
        private System.Windows.Forms.Label lblMaxHiz;
        private System.Windows.Forms.TextBox txtMotorTipi;
        private System.Windows.Forms.Label lblMotorTipi;
        private System.Windows.Forms.NumericUpDown numYakitKapasitesi;
        private System.Windows.Forms.Label lblYakitKapasitesi;
        private System.Windows.Forms.NumericUpDown numUretimYili;
        private System.Windows.Forms.Label lblUretimYili;
        private System.Windows.Forms.NumericUpDown numKapasite;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.TextBox txtSeriNumarasi;
        private System.Windows.Forms.Label lblSeriNumarasi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtDenizOtobusuAdi;
        private System.Windows.Forms.Label lblDenizOtobusuAdi;
        private System.Windows.Forms.GroupBox groupBoxBakimBilgileri;
        private System.Windows.Forms.CheckBox chkMuayeneTarihiVar;
        private System.Windows.Forms.DateTimePicker dtpSonMuayeneTarihi;
        private System.Windows.Forms.Label lblSonMuayeneTarihi;
        private System.Windows.Forms.CheckBox chkBakimTarihiVar;
        private System.Windows.Forms.DateTimePicker dtpSonBakimTarihi;
        private System.Windows.Forms.Label lblSonBakimTarihi;
    }
}