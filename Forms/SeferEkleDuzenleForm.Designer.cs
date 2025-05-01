namespace UDO.Forms
{
    partial class SeferEkleDuzenleForm
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
            this.panelButonlar = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.groupBoxSeferDetaylari = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtIndirimliBiletFiyati = new System.Windows.Forms.TextBox();
            this.lblIndirimliBiletFiyati = new System.Windows.Forms.Label();
            this.txtBiletFiyati = new System.Windows.Forms.TextBox();
            this.lblBiletFiyati = new System.Windows.Forms.Label();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.cmbDenizOtobusu = new System.Windows.Forms.ComboBox();
            this.lblDenizOtobusu = new System.Windows.Forms.Label();
            this.groupBoxZamanBilgileri = new System.Windows.Forms.GroupBox();
            this.dtpTahminiVarisSaati = new System.Windows.Forms.DateTimePicker();
            this.lblTahminiVarisSaati = new System.Windows.Forms.Label();
            this.dtpTahminiVarisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTahminiVarisTarihi = new System.Windows.Forms.Label();
            this.dtpKalkisSaati = new System.Windows.Forms.DateTimePicker();
            this.lblKalkisSaati = new System.Windows.Forms.Label();
            this.dtpKalkisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblKalkisTarihi = new System.Windows.Forms.Label();
            this.groupBoxSeferBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbVarisLimani = new System.Windows.Forms.ComboBox();
            this.lblVarisLimani = new System.Windows.Forms.Label();
            this.cmbKalkisLimani = new System.Windows.Forms.ComboBox();
            this.lblKalkisLimani = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelButonlar.SuspendLayout();
            this.panelIcerik.SuspendLayout();
            this.groupBoxSeferDetaylari.SuspendLayout();
            this.groupBoxZamanBilgileri.SuspendLayout();
            this.groupBoxSeferBilgileri.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(156, 21);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ SEFER EKLE";
            // 
            // panelButonlar
            // 
            this.panelButonlar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButonlar.Controls.Add(this.btnIptal);
            this.panelButonlar.Controls.Add(this.btnKaydet);
            this.panelButonlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButonlar.Location = new System.Drawing.Point(0, 511);
            this.panelButonlar.Name = "panelButonlar";
            this.panelButonlar.Size = new System.Drawing.Size(684, 50);
            this.panelButonlar.TabIndex = 1;
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
            this.panelIcerik.Controls.Add(this.groupBoxSeferDetaylari);
            this.panelIcerik.Controls.Add(this.groupBoxZamanBilgileri);
            this.panelIcerik.Controls.Add(this.groupBoxSeferBilgileri);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 50);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Padding = new System.Windows.Forms.Padding(10);
            this.panelIcerik.Size = new System.Drawing.Size(684, 461);
            this.panelIcerik.TabIndex = 2;
            // 
            // groupBoxSeferBilgileri
            // 
            this.groupBoxSeferBilgileri.Controls.Add(this.cmbVarisLimani);
            this.groupBoxSeferBilgileri.Controls.Add(this.lblVarisLimani);
            this.groupBoxSeferBilgileri.Controls.Add(this.cmbKalkisLimani);
            this.groupBoxSeferBilgileri.Controls.Add(this.lblKalkisLimani);
            this.groupBoxSeferBilgileri.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSeferBilgileri.Name = "groupBoxSeferBilgileri";
            this.groupBoxSeferBilgileri.Size = new System.Drawing.Size(658, 100);
            this.groupBoxSeferBilgileri.TabIndex = 0;
            this.groupBoxSeferBilgileri.TabStop = false;
            this.groupBoxSeferBilgileri.Text = "Sefer Bilgileri";
            // 
            // lblKalkisLimani
            // 
            this.lblKalkisLimani.AutoSize = true;
            this.lblKalkisLimani.Location = new System.Drawing.Point(15, 30);
            this.lblKalkisLimani.Name = "lblKalkisLimani";
            this.lblKalkisLimani.Size = new System.Drawing.Size(77, 13);
            this.lblKalkisLimani.TabIndex = 0;
            this.lblKalkisLimani.Text = "Kalkış Limanı:";
            // 
            // cmbKalkisLimani
            // 
            this.cmbKalkisLimani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKalkisLimani.FormattingEnabled = true;
            this.cmbKalkisLimani.Location = new System.Drawing.Point(98, 27);
            this.cmbKalkisLimani.Name = "cmbKalkisLimani";
            this.cmbKalkisLimani.Size = new System.Drawing.Size(250, 21);
            this.cmbKalkisLimani.TabIndex = 1;
            // 
            // lblVarisLimani
            // 
            this.lblVarisLimani.AutoSize = true;
            this.lblVarisLimani.Location = new System.Drawing.Point(15, 65);
            this.lblVarisLimani.Name = "lblVarisLimani";
            this.lblVarisLimani.Size = new System.Drawing.Size(70, 13);
            this.lblVarisLimani.TabIndex = 2;
            this.lblVarisLimani.Text = "Varış Limanı:";
            // 
            // cmbVarisLimani
            // 
            this.cmbVarisLimani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVarisLimani.FormattingEnabled = true;
            this.cmbVarisLimani.Location = new System.Drawing.Point(98, 62);
            this.cmbVarisLimani.Name = "cmbVarisLimani";
            this.cmbVarisLimani.Size = new System.Drawing.Size(250, 21);
            this.cmbVarisLimani.TabIndex = 3;
            // 
            // groupBoxZamanBilgileri
            // 
            this.groupBoxZamanBilgileri.Controls.Add(this.dtpTahminiVarisSaati);
            this.groupBoxZamanBilgileri.Controls.Add(this.lblTahminiVarisSaati);
            this.groupBoxZamanBilgileri.Controls.Add(this.dtpTahminiVarisTarihi);
            this.groupBoxZamanBilgileri.Controls.Add(this.lblTahminiVarisTarihi);
            this.groupBoxZamanBilgileri.Controls.Add(this.dtpKalkisSaati);
            this.groupBoxZamanBilgileri.Controls.Add(this.lblKalkisSaati);
            this.groupBoxZamanBilgileri.Controls.Add(this.dtpKalkisTarihi);
            this.groupBoxZamanBilgileri.Controls.Add(this.lblKalkisTarihi);
            this.groupBoxZamanBilgileri.Location = new System.Drawing.Point(13, 119);
            this.groupBoxZamanBilgileri.Name = "groupBoxZamanBilgileri";
            this.groupBoxZamanBilgileri.Size = new System.Drawing.Size(658, 100);
            this.groupBoxZamanBilgileri.TabIndex = 1;
            this.groupBoxZamanBilgileri.TabStop = false;
            this.groupBoxZamanBilgileri.Text = "Zaman Bilgileri";
            // 
            // lblKalkisTarihi
            // 
            this.lblKalkisTarihi.AutoSize = true;
            this.lblKalkisTarihi.Location = new System.Drawing.Point(15, 30);
            this.lblKalkisTarihi.Name = "lblKalkisTarihi";
            this.lblKalkisTarihi.Size = new System.Drawing.Size(71, 13);
            this.lblKalkisTarihi.TabIndex = 0;
            this.lblKalkisTarihi.Text = "Kalkış Tarihi:";
            // 
            // dtpKalkisTarihi
            // 
            this.dtpKalkisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKalkisTarihi.Location = new System.Drawing.Point(92, 27);
            this.dtpKalkisTarihi.Name = "dtpKalkisTarihi";
            this.dtpKalkisTarihi.Size = new System.Drawing.Size(150, 20);
            this.dtpKalkisTarihi.TabIndex = 1;
            // 
            // lblKalkisSaati
            // 
            this.lblKalkisSaati.AutoSize = true;
            this.lblKalkisSaati.Location = new System.Drawing.Point(250, 30);
            this.lblKalkisSaati.Name = "lblKalkisSaati";
            this.lblKalkisSaati.Size = new System.Drawing.Size(64, 13);
            this.lblKalkisSaati.TabIndex = 2;
            this.lblKalkisSaati.Text = "Kalkış Saati:";
            // 
            // dtpKalkisSaati
            // 
            this.dtpKalkisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKalkisSaati.Location = new System.Drawing.Point(320, 27);
            this.dtpKalkisSaati.Name = "dtpKalkisSaati";
            this.dtpKalkisSaati.ShowUpDown = true;
            this.dtpKalkisSaati.Size = new System.Drawing.Size(100, 20);
            this.dtpKalkisSaati.TabIndex = 3;
            // 
            // lblTahminiVarisTarihi
            // 
            this.lblTahminiVarisTarihi.AutoSize = true;
            this.lblTahminiVarisTarihi.Location = new System.Drawing.Point(15, 65);
            this.lblTahminiVarisTarihi.Name = "lblTahminiVarisTarihi";
            this.lblTahminiVarisTarihi.Size = new System.Drawing.Size(110, 13);
            this.lblTahminiVarisTarihi.TabIndex = 4;
            this.lblTahminiVarisTarihi.Text = "Tahmini Varış Tarihi:";
            // 
            // dtpTahminiVarisTarihi
            // 
            this.dtpTahminiVarisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTahminiVarisTarihi.Location = new System.Drawing.Point(131, 62);
            this.dtpTahminiVarisTarihi.Name = "dtpTahminiVarisTarihi";
            this.dtpTahminiVarisTarihi.Size = new System.Drawing.Size(150, 20);
            this.dtpTahminiVarisTarihi.TabIndex = 5;
            // 
            // lblTahminiVarisSaati
            // 
            this.lblTahminiVarisSaati.AutoSize = true;
            this.lblTahminiVarisSaati.Location = new System.Drawing.Point(294, 65);
            this.lblTahminiVarisSaati.Name = "lblTahminiVarisSaati";
            this.lblTahminiVarisSaati.Size = new System.Drawing.Size(103, 13);
            this.lblTahminiVarisSaati.TabIndex = 6;
            this.lblTahminiVarisSaati.Text = "Tahmini Varış Saati:";
            // 
            // dtpTahminiVarisSaati
            // 
            this.dtpTahminiVarisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTahminiVarisSaati.Location = new System.Drawing.Point(403, 62);
            this.dtpTahminiVarisSaati.Name = "dtpTahminiVarisSaati";
            this.dtpTahminiVarisSaati.ShowUpDown = true;
            this.dtpTahminiVarisSaati.Size = new System.Drawing.Size(100, 20);
            this.dtpTahminiVarisSaati.TabIndex = 7;
            // 
            // groupBoxSeferDetaylari
            // 
            this.groupBoxSeferDetaylari.Controls.Add(this.txtAciklama);
            this.groupBoxSeferDetaylari.Controls.Add(this.lblAciklama);
            this.groupBoxSeferDetaylari.Controls.Add(this.txtIndirimliBiletFiyati);
            this.groupBoxSeferDetaylari.Controls.Add(this.lblIndirimliBiletFiyati);
            this.groupBoxSeferDetaylari.Controls.Add(this.txtBiletFiyati);
            this.groupBoxSeferDetaylari.Controls.Add(this.lblBiletFiyati);
            this.groupBoxSeferDetaylari.Controls.Add(this.txtKapasite);
            this.groupBoxSeferDetaylari.Controls.Add(this.lblKapasite);
            this.groupBoxSeferDetaylari.Controls.Add(this.cmbDenizOtobusu);
            this.groupBoxSeferDetaylari.Controls.Add(this.lblDenizOtobusu);
            this.groupBoxSeferDetaylari.Location = new System.Drawing.Point(13, 225);
            this.groupBoxSeferDetaylari.Name = "groupBoxSeferDetaylari";
            this.groupBoxSeferDetaylari.Size = new System.Drawing.Size(658, 223);
            this.groupBoxSeferDetaylari.TabIndex = 2;
            this.groupBoxSeferDetaylari.TabStop = false;
            this.groupBoxSeferDetaylari.Text = "Sefer Detayları";
            // 
            // lblDenizOtobusu
            // 
            this.lblDenizOtobusu.AutoSize = true;
            this.lblDenizOtobusu.Location = new System.Drawing.Point(15, 30);
            this.lblDenizOtobusu.Name = "lblDenizOtobusu";
            this.lblDenizOtobusu.Size = new System.Drawing.Size(82, 13);
            this.lblDenizOtobusu.TabIndex = 0;
            this.lblDenizOtobusu.Text = "Deniz Otobüsü:";
            // 
            // cmbDenizOtobusu
            // 
            this.cmbDenizOtobusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDenizOtobusu.FormattingEnabled = true;
            this.cmbDenizOtobusu.Location = new System.Drawing.Point(103, 27);
            this.cmbDenizOtobusu.Name = "cmbDenizOtobusu";
            this.cmbDenizOtobusu.Size = new System.Drawing.Size(250, 21);
            this.cmbDenizOtobusu.TabIndex = 1;
            this.cmbDenizOtobusu.SelectedIndexChanged += new System.EventHandler(this.cmbDenizOtobusu_SelectedIndexChanged);
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(371, 30);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(53, 13);
            this.lblKapasite.TabIndex = 2;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(430, 27);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.ReadOnly = true;
            this.txtKapasite.Size = new System.Drawing.Size(100, 20);
            this.txtKapasite.TabIndex = 3;
            // 
            // lblBiletFiyati
            // 
            this.lblBiletFiyati.AutoSize = true;
            this.lblBiletFiyati.Location = new System.Drawing.Point(15, 65);
            this.lblBiletFiyati.Name = "lblBiletFiyati";
            this.lblBiletFiyati.Size = new System.Drawing.Size(74, 13);
            this.lblBiletFiyati.TabIndex = 4;
            this.lblBiletFiyati.Text = "Bilet Fiyatı (₺):";
            // 
            // txtBiletFiyati
            // 
            this.txtBiletFiyati.Location = new System.Drawing.Point(103, 62);
            this.txtBiletFiyati.Name = "txtBiletFiyati";
            this.txtBiletFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtBiletFiyati.TabIndex = 5;
            // 
            // lblIndirimliBiletFiyati
            // 
            this.lblIndirimliBiletFiyati.AutoSize = true;
            this.lblIndirimliBiletFiyati.Location = new System.Drawing.Point(223, 65);
            this.lblIndirimliBiletFiyati.Name = "lblIndirimliBiletFiyati";
            this.lblIndirimliBiletFiyati.Size = new System.Drawing.Size(111, 13);
            this.lblIndirimliBiletFiyati.TabIndex = 6;
            this.lblIndirimliBiletFiyati.Text = "İndirimli Bilet Fiyatı (₺):";
            // 
            // txtIndirimliBiletFiyati
            // 
            this.txtIndirimliBiletFiyati.Location = new System.Drawing.Point(340, 62);
            this.txtIndirimliBiletFiyati.Name = "txtIndirimliBiletFiyati";
            this.txtIndirimliBiletFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtIndirimliBiletFiyati.TabIndex = 7;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(15, 100);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(53, 13);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(103, 97);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(400, 110);
            this.txtAciklama.TabIndex = 9;
            // 
            // SeferEkleDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panelButonlar);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SeferEkleDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sefer Ekle/Düzenle";
            this.Load += new System.EventHandler(this.SeferEkleDuzenleForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelButonlar.ResumeLayout(false);
            this.panelIcerik.ResumeLayout(false);
            this.groupBoxSeferDetaylari.ResumeLayout(false);
            this.groupBoxSeferDetaylari.PerformLayout();
            this.groupBoxZamanBilgileri.ResumeLayout(false);
            this.groupBoxZamanBilgileri.PerformLayout();
            this.groupBoxSeferBilgileri.ResumeLayout(false);
            this.groupBoxSeferBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelButonlar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.GroupBox groupBoxSeferDetaylari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtIndirimliBiletFiyati;
        private System.Windows.Forms.Label lblIndirimliBiletFiyati;
        private System.Windows.Forms.TextBox txtBiletFiyati;
        private System.Windows.Forms.Label lblBiletFiyati;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.ComboBox cmbDenizOtobusu;
        private System.Windows.Forms.Label lblDenizOtobusu;
        private System.Windows.Forms.GroupBox groupBoxZamanBilgileri;
        private System.Windows.Forms.DateTimePicker dtpTahminiVarisSaati;
        private System.Windows.Forms.Label lblTahminiVarisSaati;
        private System.Windows.Forms.DateTimePicker dtpTahminiVarisTarihi;
        private System.Windows.Forms.Label lblTahminiVarisTarihi;
        private System.Windows.Forms.DateTimePicker dtpKalkisSaati;
        private System.Windows.Forms.Label lblKalkisSaati;
        private System.Windows.Forms.DateTimePicker dtpKalkisTarihi;
        private System.Windows.Forms.Label lblKalkisTarihi;
        private System.Windows.Forms.GroupBox groupBoxSeferBilgileri;
        private System.Windows.Forms.ComboBox cmbVarisLimani;
        private System.Windows.Forms.Label lblVarisLimani;
        private System.Windows.Forms.ComboBox cmbKalkisLimani;
        private System.Windows.Forms.Label lblKalkisLimani;
    }
}