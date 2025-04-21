namespace UDO.Forms
{
    partial class PersonelYonetimForm
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
            this.rdTumPersonel = new System.Windows.Forms.RadioButton();
            this.rdPasifPersonel = new System.Windows.Forms.RadioButton();
            this.rdAktifPersonel = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCKN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonGirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            this.panelArama.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(196, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "PERSONEL YÖNETİMİ";
            // 
            // panelArama
            // 
            this.panelArama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelArama.Controls.Add(this.rdTumPersonel);
            this.panelArama.Controls.Add(this.rdPasifPersonel);
            this.panelArama.Controls.Add(this.rdAktifPersonel);
            this.panelArama.Controls.Add(this.btnAra);
            this.panelArama.Controls.Add(this.txtArama);
            this.panelArama.Controls.Add(this.lblArama);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Location = new System.Drawing.Point(0, 50);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(950, 60);
            this.panelArama.TabIndex = 1;
            // 
            // rdTumPersonel
            // 
            this.rdTumPersonel.AutoSize = true;
            this.rdTumPersonel.Checked = true;
            this.rdTumPersonel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumPersonel.Location = new System.Drawing.Point(675, 21);
            this.rdTumPersonel.Name = "rdTumPersonel";
            this.rdTumPersonel.Size = new System.Drawing.Size(95, 19);
            this.rdTumPersonel.TabIndex = 5;
            this.rdTumPersonel.TabStop = true;
            this.rdTumPersonel.Text = "Tüm Personel";
            this.rdTumPersonel.UseVisualStyleBackColor = true;
            this.rdTumPersonel.CheckedChanged += new System.EventHandler(this.rdTumPersonel_CheckedChanged);
            // 
            // rdPasifPersonel
            // 
            this.rdPasifPersonel.AutoSize = true;
            this.rdPasifPersonel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdPasifPersonel.Location = new System.Drawing.Point(850, 21);
            this.rdPasifPersonel.Name = "rdPasifPersonel";
            this.rdPasifPersonel.Size = new System.Drawing.Size(97, 19);
            this.rdPasifPersonel.TabIndex = 4;
            this.rdPasifPersonel.Text = "Pasif Personel";
            this.rdPasifPersonel.UseVisualStyleBackColor = true;
            this.rdPasifPersonel.CheckedChanged += new System.EventHandler(this.rdPasifPersonel_CheckedChanged);
            // 
            // rdAktifPersonel
            // 
            this.rdAktifPersonel.AutoSize = true;
            this.rdAktifPersonel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktifPersonel.Location = new System.Drawing.Point(765, 21);
            this.rdAktifPersonel.Name = "rdAktifPersonel";
            this.rdAktifPersonel.Size = new System.Drawing.Size(96, 19);
            this.rdAktifPersonel.TabIndex = 3;
            this.rdAktifPersonel.Text = "Aktif Personel";
            this.rdAktifPersonel.UseVisualStyleBackColor = true;
            this.rdAktifPersonel.CheckedChanged += new System.EventHandler(this.rdAktifPersonel_CheckedChanged);
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
            this.lblArama.Text = "Personel Ara:";
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnYenile);
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
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
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
            this.panelGrid.Controls.Add(this.dataGridViewPersonel);
            this.panelGrid.Controls.Add(this.lblBilgi);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 110);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(950, 435);
            this.panelGrid.TabIndex = 3;
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AllowUserToAddRows = false;
            this.dataGridViewPersonel.AllowUserToDeleteRows = false;
            this.dataGridViewPersonel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciID,
            this.KullaniciAdi,
            this.AdSoyad,
            this.TCKN,
            this.Email,
            this.Telefon,
            this.KayitTarihi,
            this.SonGirisTarihi,
            this.Durum});
            this.dataGridViewPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonel.MultiSelect = false;
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.ReadOnly = true;
            this.dataGridViewPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(950, 415);
            this.dataGridViewPersonel.TabIndex = 0;
            this.dataGridViewPersonel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPersonel_CellFormatting);
            this.dataGridViewPersonel.SelectionChanged += new System.EventHandler(this.dataGridViewPersonel_SelectionChanged);
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "KullaniciID";
            this.KullaniciID.HeaderText = "ID";
            this.KullaniciID.Name = "KullaniciID";
            this.KullaniciID.ReadOnly = true;
            this.KullaniciID.Width = 50;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.DataPropertyName = "KullaniciAdi";
            this.KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.ReadOnly = true;
            this.KullaniciAdi.Width = 120;
            // 
            // AdSoyad
            // 
            this.AdSoyad.HeaderText = "Ad Soyad";
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.ReadOnly = true;
            this.AdSoyad.Width = 150;
            // 
            // TCKN
            // 
            this.TCKN.DataPropertyName = "TCKN";
            this.TCKN.HeaderText = "TCKN";
            this.TCKN.Name = "TCKN";
            this.TCKN.ReadOnly = true;
            this.TCKN.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-posta";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "TelefonNumarasi";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 120;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.DataPropertyName = "KayitTarihi";
            this.KayitTarihi.HeaderText = "Kayıt Tarihi";
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.ReadOnly = true;
            this.KayitTarihi.Width = 120;
            // 
            // SonGirisTarihi
            // 
            this.SonGirisTarihi.DataPropertyName = "SonGirisTarihi";
            this.SonGirisTarihi.HeaderText = "Son Giriş";
            this.SonGirisTarihi.Name = "SonGirisTarihi";
            this.SonGirisTarihi.ReadOnly = true;
            this.SonGirisTarihi.Width = 120;
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
            this.lblBilgi.Text = "Toplam personel sayısı: 0";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PersonelYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelArama);
            this.Controls.Add(this.panelUst);
            this.Name = "PersonelYonetimForm";
            this.Text = "Personel Yönetimi";
            this.Load += new System.EventHandler(this.PersonelYonetimForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.RadioButton rdPasifPersonel;
        private System.Windows.Forms.RadioButton rdAktifPersonel;
        private System.Windows.Forms.RadioButton rdTumPersonel;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonGirisTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
    }
}