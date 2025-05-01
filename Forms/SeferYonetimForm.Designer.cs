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
            this.panelArama = new System.Windows.Forms.Panel();
            this.rdTamamlananSeferler = new System.Windows.Forms.RadioButton();
            this.rdIptalEdilenSeferler = new System.Windows.Forms.RadioButton();
            this.rdAktifSeferler = new System.Windows.Forms.RadioButton();
            this.rdTumSeferler = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewSeferler = new System.Windows.Forms.DataGridView();
            this.SeferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisLimani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarisLimani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalkisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenizOtobusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolulukOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeferDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelArama.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(158, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "SEFER YÖNETİMİ";
            // 
            // panelArama
            // 
            this.panelArama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelArama.Controls.Add(this.rdTamamlananSeferler);
            this.panelArama.Controls.Add(this.rdIptalEdilenSeferler);
            this.panelArama.Controls.Add(this.rdAktifSeferler);
            this.panelArama.Controls.Add(this.rdTumSeferler);
            this.panelArama.Controls.Add(this.btnAra);
            this.panelArama.Controls.Add(this.txtArama);
            this.panelArama.Controls.Add(this.lblArama);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Location = new System.Drawing.Point(0, 50);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(950, 60);
            this.panelArama.TabIndex = 1;
            // 
            // rdTamamlananSeferler
            // 
            this.rdTamamlananSeferler.AutoSize = true;
            this.rdTamamlananSeferler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTamamlananSeferler.Location = new System.Drawing.Point(810, 21);
            this.rdTamamlananSeferler.Name = "rdTamamlananSeferler";
            this.rdTamamlananSeferler.Size = new System.Drawing.Size(134, 19);
            this.rdTamamlananSeferler.TabIndex = 6;
            this.rdTamamlananSeferler.Text = "Tamamlanan Seferler";
            this.rdTamamlananSeferler.UseVisualStyleBackColor = true;
            this.rdTamamlananSeferler.CheckedChanged += new System.EventHandler(this.rdTamamlananSeferler_CheckedChanged);
            // 
            // rdIptalEdilenSeferler
            // 
            this.rdIptalEdilenSeferler.AutoSize = true;
            this.rdIptalEdilenSeferler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdIptalEdilenSeferler.Location = new System.Drawing.Point(690, 21);
            this.rdIptalEdilenSeferler.Name = "rdIptalEdilenSeferler";
            this.rdIptalEdilenSeferler.Size = new System.Drawing.Size(120, 19);
            this.rdIptalEdilenSeferler.TabIndex = 5;
            this.rdIptalEdilenSeferler.Text = "İptal Edilen Seferler";
            this.rdIptalEdilenSeferler.UseVisualStyleBackColor = true;
            this.rdIptalEdilenSeferler.CheckedChanged += new System.EventHandler(this.rdIptalEdilenSeferler_CheckedChanged);
            // 
            // rdAktifSeferler
            // 
            this.rdAktifSeferler.AutoSize = true;
            this.rdAktifSeferler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktifSeferler.Location = new System.Drawing.Point(597, 21);
            this.rdAktifSeferler.Name = "rdAktifSeferler";
            this.rdAktifSeferler.Size = new System.Drawing.Size(91, 19);
            this.rdAktifSeferler.TabIndex = 4;
            this.rdAktifSeferler.Text = "Aktif Seferler";
            this.rdAktifSeferler.UseVisualStyleBackColor = true;
            this.rdAktifSeferler.CheckedChanged += new System.EventHandler(this.rdAktifSeferler_CheckedChanged);
            // 
            // rdTumSeferler
            // 
            this.rdTumSeferler.AutoSize = true;
            this.rdTumSeferler.Checked = true;
            this.rdTumSeferler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumSeferler.Location = new System.Drawing.Point(504, 21);
            this.rdTumSeferler.Name = "rdTumSeferler";
            this.rdTumSeferler.Size = new System.Drawing.Size(91, 19);
            this.rdTumSeferler.TabIndex = 3;
            this.rdTumSeferler.TabStop = true;
            this.rdTumSeferler.Text = "Tüm Seferler";
            this.rdTumSeferler.UseVisualStyleBackColor = true;
            this.rdTumSeferler.CheckedChanged += new System.EventHandler(this.rdTumSeferler_CheckedChanged);
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
            this.lblArama.Size = new System.Drawing.Size(61, 15);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Sefer Ara:";
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnYenile);
            this.panelIslemler.Controls.Add(this.btnDetay);
            this.panelIslemler.Controls.Add(this.btnIptal);
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
            this.btnYenile.TabIndex = 4;
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
            this.btnDetay.Location = new System.Drawing.Point(418, 18);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(95, 30);
            this.btnDetay.TabIndex = 3;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIptal.Enabled = false;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(305, 18);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 30);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
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
            this.panelGrid.Controls.Add(this.dataGridViewSeferler);
            this.panelGrid.Controls.Add(this.lblBilgi);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 110);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(950, 435);
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
            this.KalkisLimani,
            this.VarisLimani,
            this.KalkisTarihi,
            this.KalkisSaati,
            this.DenizOtobusu,
            this.DolulukOrani,
            this.BiletFiyati,
            this.SeferDurumu});
            this.dataGridViewSeferler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeferler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSeferler.MultiSelect = false;
            this.dataGridViewSeferler.Name = "dataGridViewSeferler";
            this.dataGridViewSeferler.ReadOnly = true;
            this.dataGridViewSeferler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeferler.Size = new System.Drawing.Size(950, 415);
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
            // KalkisLimani
            // 
            this.KalkisLimani.DataPropertyName = "KalkisLimaniAdi";
            this.KalkisLimani.HeaderText = "Kalkış Limanı";
            this.KalkisLimani.Name = "KalkisLimani";
            this.KalkisLimani.ReadOnly = true;
            this.KalkisLimani.Width = 120;
            // 
            // VarisLimani
            // 
            this.VarisLimani.DataPropertyName = "VarisLimaniAdi";
            this.VarisLimani.HeaderText = "Varış Limanı";
            this.VarisLimani.Name = "VarisLimani";
            this.VarisLimani.ReadOnly = true;
            this.VarisLimani.Width = 120;
            // 
            // KalkisTarihi
            // 
            this.KalkisTarihi.DataPropertyName = "KalkisTarihi";
            this.KalkisTarihi.HeaderText = "Kalkış Tarihi";
            this.KalkisTarihi.Name = "KalkisTarihi";
            this.KalkisTarihi.ReadOnly = true;
            this.KalkisTarihi.Width = 100;
            // 
            // KalkisSaati
            // 
            this.KalkisSaati.DataPropertyName = "KalkisSaati";
            this.KalkisSaati.HeaderText = "Kalkış Saati";
            this.KalkisSaati.Name = "KalkisSaati";
            this.KalkisSaati.ReadOnly = true;
            this.KalkisSaati.Width = 90;
            // 
            // DenizOtobusu
            // 
            this.DenizOtobusu.DataPropertyName = "DenizOtobusuAdi";
            this.DenizOtobusu.HeaderText = "Deniz Otobüsü";
            this.DenizOtobusu.Name = "DenizOtobusu";
            this.DenizOtobusu.ReadOnly = true;
            this.DenizOtobusu.Width = 120;
            // 
            // DolulukOrani
            // 
            this.DolulukOrani.HeaderText = "Doluluk";
            this.DolulukOrani.Name = "DolulukOrani";
            this.DolulukOrani.ReadOnly = true;
            this.DolulukOrani.Width = 90;
            // 
            // BiletFiyati
            // 
            this.BiletFiyati.DataPropertyName = "BiletFiyati";
            this.BiletFiyati.HeaderText = "Bilet Fiyatı";
            this.BiletFiyati.Name = "BiletFiyati";
            this.BiletFiyati.ReadOnly = true;
            this.BiletFiyati.Width = 90;
            // 
            // SeferDurumu
            // 
            this.SeferDurumu.DataPropertyName = "SeferDurumu";
            this.SeferDurumu.HeaderText = "Durum";
            this.SeferDurumu.Name = "SeferDurumu";
            this.SeferDurumu.ReadOnly = true;
            this.SeferDurumu.Width = 100;
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
            this.Controls.Add(this.panelArama);
            this.Controls.Add(this.panelUst);
            this.Name = "SeferYonetimForm";
            this.Text = "Sefer Yönetimi";
            this.Load += new System.EventHandler(this.SeferYonetimForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.RadioButton rdTamamlananSeferler;
        private System.Windows.Forms.RadioButton rdIptalEdilenSeferler;
        private System.Windows.Forms.RadioButton rdAktifSeferler;
        private System.Windows.Forms.RadioButton rdTumSeferler;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewSeferler;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisLimani;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarisLimani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalkisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenizOtobusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolulukOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiletFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeferDurumu;
        private System.Windows.Forms.Label lblBilgi;
    }
}