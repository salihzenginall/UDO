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
            this.lblGuzergah = new System.Windows.Forms.Label();
            this.cmbGuzergah = new System.Windows.Forms.ComboBox();
            this.lblDenizOtobusu = new System.Windows.Forms.Label();
            this.cmbDenizOtobusu = new System.Windows.Forms.ComboBox();
            this.lblKalkisTarihi = new System.Windows.Forms.Label();
            this.dtpKalkisTarih = new System.Windows.Forms.DateTimePicker();
            this.lblKalkisSaati = new System.Windows.Forms.Label();
            this.dtpKalkisSaat = new System.Windows.Forms.DateTimePicker();
            this.lblVarisTarihi = new System.Windows.Forms.Label();
            this.dtpVarisTarih = new System.Windows.Forms.DateTimePicker();
            this.lblVarisSaati = new System.Windows.Forms.Label();
            this.dtpVarisSaat = new System.Windows.Forms.DateTimePicker();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.nudKapasite = new System.Windows.Forms.NumericUpDown();
            this.lblBiletFiyati = new System.Windows.Forms.Label();
            this.nudBiletFiyati = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblGuzergahBilgi = new System.Windows.Forms.Label();
            this.lblMesafeSure = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiletFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(484, 50);
            this.panelUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 14);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(124, 21);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ SEFER EKLE";
            // 
            // lblGuzergah
            // 
            this.lblGuzergah.AutoSize = true;
            this.lblGuzergah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuzergah.Location = new System.Drawing.Point(33, 66);
            this.lblGuzergah.Name = "lblGuzergah";
            this.lblGuzergah.Size = new System.Drawing.Size(61, 15);
            this.lblGuzergah.TabIndex = 1;
            this.lblGuzergah.Text = "Güzergah:";
            // 
            // cmbGuzergah
            // 
            this.cmbGuzergah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuzergah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGuzergah.FormattingEnabled = true;
            this.cmbGuzergah.Location = new System.Drawing.Point(130, 63);
            this.cmbGuzergah.Name = "cmbGuzergah";
            this.cmbGuzergah.Size = new System.Drawing.Size(322, 23);
            this.cmbGuzergah.TabIndex = 0;
            // 
            // lblDenizOtobusu
            // 
            this.lblDenizOtobusu.AutoSize = true;
            this.lblDenizOtobusu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDenizOtobusu.Location = new System.Drawing.Point(33, 126);
            this.lblDenizOtobusu.Name = "lblDenizOtobusu";
            this.lblDenizOtobusu.Size = new System.Drawing.Size(86, 15);
            this.lblDenizOtobusu.TabIndex = 3;
            this.lblDenizOtobusu.Text = "Deniz Otobüsü:";
            // 
            // cmbDenizOtobusu
            // 
            this.cmbDenizOtobusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDenizOtobusu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDenizOtobusu.FormattingEnabled = true;
            this.cmbDenizOtobusu.Location = new System.Drawing.Point(130, 123);
            this.cmbDenizOtobusu.Name = "cmbDenizOtobusu";
            this.cmbDenizOtobusu.Size = new System.Drawing.Size(322, 23);
            this.cmbDenizOtobusu.TabIndex = 1;
            // 
            // lblKalkisTarihi
            // 
            this.lblKalkisTarihi.AutoSize = true;
            this.lblKalkisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkisTarihi.Location = new System.Drawing.Point(33, 158);
            this.lblKalkisTarihi.Name = "lblKalkisTarihi";
            this.lblKalkisTarihi.Size = new System.Drawing.Size(71, 15);
            this.lblKalkisTarihi.TabIndex = 5;
            this.lblKalkisTarihi.Text = "Kalkış Tarihi:";
            // 
            // dtpKalkisTarih
            // 
            this.dtpKalkisTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKalkisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKalkisTarih.Location = new System.Drawing.Point(130, 155);
            this.dtpKalkisTarih.Name = "dtpKalkisTarih";
            this.dtpKalkisTarih.Size = new System.Drawing.Size(140, 23);
            this.dtpKalkisTarih.TabIndex = 2;
            // 
            // lblKalkisSaati
            // 
            this.lblKalkisSaati.AutoSize = true;
            this.lblKalkisSaati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkisSaati.Location = new System.Drawing.Point(276, 158);
            this.lblKalkisSaati.Name = "lblKalkisSaati";
            this.lblKalkisSaati.Size = new System.Drawing.Size(69, 15);
            this.lblKalkisSaati.TabIndex = 7;
            this.lblKalkisSaati.Text = "Kalkış Saati:";
            // 
            // dtpKalkisSaat
            // 
            this.dtpKalkisSaat.CustomFormat = "HH:mm";
            this.dtpKalkisSaat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKalkisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKalkisSaat.Location = new System.Drawing.Point(351, 155);
            this.dtpKalkisSaat.Name = "dtpKalkisSaat";
            this.dtpKalkisSaat.ShowUpDown = true;
            this.dtpKalkisSaat.Size = new System.Drawing.Size(101, 23);
            this.dtpKalkisSaat.TabIndex = 3;
            // 
            // lblVarisTarihi
            // 
            this.lblVarisTarihi.AutoSize = true;
            this.lblVarisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVarisTarihi.Location = new System.Drawing.Point(33, 187);
            this.lblVarisTarihi.Name = "lblVarisTarihi";
            this.lblVarisTarihi.Size = new System.Drawing.Size(67, 15);
            this.lblVarisTarihi.TabIndex = 9;
            this.lblVarisTarihi.Text = "Varış Tarihi:";
            // 
            // dtpVarisTarih
            // 
            this.dtpVarisTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpVarisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarisTarih.Location = new System.Drawing.Point(130, 184);
            this.dtpVarisTarih.Name = "dtpVarisTarih";
            this.dtpVarisTarih.Size = new System.Drawing.Size(140, 23);
            this.dtpVarisTarih.TabIndex = 4;
            // 
            // lblVarisSaati
            // 
            this.lblVarisSaati.AutoSize = true;
            this.lblVarisSaati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVarisSaati.Location = new System.Drawing.Point(276, 187);
            this.lblVarisSaati.Name = "lblVarisSaati";
            this.lblVarisSaati.Size = new System.Drawing.Size(65, 15);
            this.lblVarisSaati.TabIndex = 11;
            this.lblVarisSaati.Text = "Varış Saati:";
            // 
            // dtpVarisSaat
            // 
            this.dtpVarisSaat.CustomFormat = "HH:mm";
            this.dtpVarisSaat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpVarisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarisSaat.Location = new System.Drawing.Point(351, 184);
            this.dtpVarisSaat.Name = "dtpVarisSaat";
            this.dtpVarisSaat.ShowUpDown = true;
            this.dtpVarisSaat.Size = new System.Drawing.Size(101, 23);
            this.dtpVarisSaat.TabIndex = 5;
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(33, 221);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(55, 15);
            this.lblKapasite.TabIndex = 13;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // nudKapasite
            // 
            this.nudKapasite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKapasite.Location = new System.Drawing.Point(130, 219);
            this.nudKapasite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKapasite.Name = "nudKapasite";
            this.nudKapasite.Size = new System.Drawing.Size(140, 23);
            this.nudKapasite.TabIndex = 6;
            this.nudKapasite.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // lblBiletFiyati
            // 
            this.lblBiletFiyati.AutoSize = true;
            this.lblBiletFiyati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBiletFiyati.Location = new System.Drawing.Point(276, 221);
            this.lblBiletFiyati.Name = "lblBiletFiyati";
            this.lblBiletFiyati.Size = new System.Drawing.Size(63, 15);
            this.lblBiletFiyati.TabIndex = 15;
            this.lblBiletFiyati.Text = "Bilet Fiyatı:";
            // 
            // nudBiletFiyati
            // 
            this.nudBiletFiyati.DecimalPlaces = 2;
            this.nudBiletFiyati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudBiletFiyati.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBiletFiyati.Location = new System.Drawing.Point(351, 219);
            this.nudBiletFiyati.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBiletFiyati.Name = "nudBiletFiyati";
            this.nudBiletFiyati.Size = new System.Drawing.Size(101, 23);
            this.nudBiletFiyati.TabIndex = 7;
            this.nudBiletFiyati.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(33, 250);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 15);
            this.lblAciklama.TabIndex = 17;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(130, 248);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(322, 60);
            this.txtAciklama.TabIndex = 8;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(130, 314);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(50, 19);
            this.chkAktif.TabIndex = 9;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(257, 350);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(357, 350);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 30);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // lblGuzergahBilgi
            // 
            this.lblGuzergahBilgi.AutoSize = true;
            this.lblGuzergahBilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuzergahBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGuzergahBilgi.Location = new System.Drawing.Point(130, 89);
            this.lblGuzergahBilgi.Name = "lblGuzergahBilgi";
            this.lblGuzergahBilgi.Size = new System.Drawing.Size(119, 15);
            this.lblGuzergahBilgi.TabIndex = 22;
            this.lblGuzergahBilgi.Text = "Lütfen güzergah seçin";
            // 
            // lblMesafeSure
            // 
            this.lblMesafeSure.AutoSize = true;
            this.lblMesafeSure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesafeSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMesafeSure.Location = new System.Drawing.Point(130, 104);
            this.lblMesafeSure.Name = "lblMesafeSure";
            this.lblMesafeSure.Size = new System.Drawing.Size(0, 15);
            this.lblMesafeSure.TabIndex = 23;
            // 
            // SeferEkleDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 401);
            this.Controls.Add(this.lblMesafeSure);
            this.Controls.Add(this.lblGuzergahBilgi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.nudBiletFiyati);
            this.Controls.Add(this.lblBiletFiyati);
            this.Controls.Add(this.nudKapasite);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.dtpVarisSaat);
            this.Controls.Add(this.lblVarisSaati);
            this.Controls.Add(this.dtpVarisTarih);
            this.Controls.Add(this.lblVarisTarihi);
            this.Controls.Add(this.dtpKalkisSaat);
            this.Controls.Add(this.lblKalkisSaati);
            this.Controls.Add(this.dtpKalkisTarih);
            this.Controls.Add(this.lblKalkisTarihi);
            this.Controls.Add(this.cmbDenizOtobusu);
            this.Controls.Add(this.lblDenizOtobusu);
            this.Controls.Add(this.cmbGuzergah);
            this.Controls.Add(this.lblGuzergah);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeferEkleDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sefer Ekle/Düzenle";
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiletFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblGuzergah;
        private System.Windows.Forms.ComboBox cmbGuzergah;
        private System.Windows.Forms.Label lblDenizOtobusu;
        private System.Windows.Forms.ComboBox cmbDenizOtobusu;
        private System.Windows.Forms.Label lblKalkisTarihi;
        private System.Windows.Forms.DateTimePicker dtpKalkisTarih;
        private System.Windows.Forms.Label lblKalkisSaati;
        private System.Windows.Forms.DateTimePicker dtpKalkisSaat;
        private System.Windows.Forms.Label lblVarisTarihi;
        private System.Windows.Forms.DateTimePicker dtpVarisTarih;
        private System.Windows.Forms.Label lblVarisSaati;
        private System.Windows.Forms.DateTimePicker dtpVarisSaat;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.NumericUpDown nudKapasite;
        private System.Windows.Forms.Label lblBiletFiyati;
        private System.Windows.Forms.NumericUpDown nudBiletFiyati;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblGuzergahBilgi;
        private System.Windows.Forms.Label lblMesafeSure;
    }
}