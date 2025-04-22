namespace UDO.Forms
{
    partial class GuzergahYonetimForm
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
            this.rdTumGuzergahlar = new System.Windows.Forms.RadioButton();
            this.rdAktifGuzergahlar = new System.Windows.Forms.RadioButton();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewGuzergahlar = new System.Windows.Forms.DataGridView();
            this.GuzergahID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuzergahAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicIskeleAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarisIskeleAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesafeDenizMili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahminiSureDakika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlusturmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelUst.SuspendLayout();
            this.panelArama.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuzergahlar)).BeginInit();
            this.panelIslemler.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(198, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "GÜZERGAH YÖNETİMİ";
            // 
            // panelArama
            // 
            this.panelArama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelArama.Controls.Add(this.rdTumGuzergahlar);
            this.panelArama.Controls.Add(this.rdAktifGuzergahlar);
            this.panelArama.Controls.Add(this.btnYenile);
            this.panelArama.Controls.Add(this.btnAra);
            this.panelArama.Controls.Add(this.txtArama);
            this.panelArama.Controls.Add(this.lblArama);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Location = new System.Drawing.Point(0, 50);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(950, 60);
            this.panelArama.TabIndex = 1;
            // 
            // rdTumGuzergahlar
            // 
            this.rdTumGuzergahlar.AutoSize = true;
            this.rdTumGuzergahlar.Checked = true;
            this.rdTumGuzergahlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumGuzergahlar.Location = new System.Drawing.Point(681, 22);
            this.rdTumGuzergahlar.Name = "rdTumGuzergahlar";
            this.rdTumGuzergahlar.Size = new System.Drawing.Size(113, 19);
            this.rdTumGuzergahlar.TabIndex = 3;
            this.rdTumGuzergahlar.TabStop = true;
            this.rdTumGuzergahlar.Text = "Tüm Güzergahlar";
            this.rdTumGuzergahlar.UseVisualStyleBackColor = true;
            // 
            // rdAktifGuzergahlar
            // 
            this.rdAktifGuzergahlar.AutoSize = true;
            this.rdAktifGuzergahlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktifGuzergahlar.Location = new System.Drawing.Point(551, 22);
            this.rdAktifGuzergahlar.Name = "rdAktifGuzergahlar";
            this.rdAktifGuzergahlar.Size = new System.Drawing.Size(114, 19);
            this.rdAktifGuzergahlar.TabIndex = 2;
            this.rdAktifGuzergahlar.Text = "Aktif Güzergahlar";
            this.rdAktifGuzergahlar.UseVisualStyleBackColor = true;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(850, 16);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(88, 30);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(421, 16);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 30);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(142, 20);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(273, 23);
            this.txtArama.TabIndex = 0;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Location = new System.Drawing.Point(15, 24);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(121, 15);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Güzergah Adı/İskele Ara:";
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewGuzergahlar);
            this.panelGrid.Controls.Add(this.lblBilgi);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 110);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(950, 435);
            this.panelGrid.TabIndex = 2;
            // 
            // dataGridViewGuzergahlar
            // 
            this.dataGridViewGuzergahlar.AllowUserToAddRows = false;
            this.dataGridViewGuzergahlar.AllowUserToDeleteRows = false;
            this.dataGridViewGuzergahlar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGuzergahlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuzergahlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuzergahID,
            this.GuzergahAdi,
            this.BaslangicIskeleAdi,
            this.VarisIskeleAdi,
            this.MesafeDenizMili,
            this.TahminiSureDakika,
            this.OlusturmaTarihi,
            this.Aktif});
            this.dataGridViewGuzergahlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGuzergahlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGuzergahlar.MultiSelect = false;
            this.dataGridViewGuzergahlar.Name = "dataGridViewGuzergahlar";
            this.dataGridViewGuzergahlar.ReadOnly = true;
            this.dataGridViewGuzergahlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuzergahlar.Size = new System.Drawing.Size(950, 415);
            this.dataGridViewGuzergahlar.TabIndex = 0;
            // 
            // GuzergahID
            // 
            this.GuzergahID.DataPropertyName = "GuzergahID";
            this.GuzergahID.HeaderText = "ID";
            this.GuzergahID.Name = "GuzergahID";
            this.GuzergahID.ReadOnly = true;
            this.GuzergahID.Width = 50;
            // 
            // GuzergahAdi
            // 
            this.GuzergahAdi.DataPropertyName = "GuzergahAdi";
            this.GuzergahAdi.HeaderText = "Güzergah Adı";
            this.GuzergahAdi.Name = "GuzergahAdi";
            this.GuzergahAdi.ReadOnly = true;
            this.GuzergahAdi.Width = 150;
            // 
            // BaslangicIskeleAdi
            // 
            this.BaslangicIskeleAdi.DataPropertyName = "BaslangicIskeleAdi";
            this.BaslangicIskeleAdi.HeaderText = "Başlangıç İskelesi";
            this.BaslangicIskeleAdi.Name = "BaslangicIskeleAdi";
            this.BaslangicIskeleAdi.ReadOnly = true;
            this.BaslangicIskeleAdi.Width = 150;
            // 
            // VarisIskeleAdi
            // 
            this.VarisIskeleAdi.DataPropertyName = "VarisIskeleAdi";
            this.VarisIskeleAdi.HeaderText = "Varış İskelesi";
            this.VarisIskeleAdi.Name = "VarisIskeleAdi";
            this.VarisIskeleAdi.ReadOnly = true;
            this.VarisIskeleAdi.Width = 150;
            // 
            // MesafeDenizMili
            // 
            this.MesafeDenizMili.DataPropertyName = "MesafeDenizMili";
            this.MesafeDenizMili.HeaderText = "Mesafe (Deniz Mili)";
            this.MesafeDenizMili.Name = "MesafeDenizMili";
            this.MesafeDenizMili.ReadOnly = true;
            this.MesafeDenizMili.Width = 120;
            // 
            // TahminiSureDakika
            // 
            this.TahminiSureDakika.DataPropertyName = "TahminiSureDakika";
            this.TahminiSureDakika.HeaderText = "Tahmini Süre (dk)";
            this.TahminiSureDakika.Name = "TahminiSureDakika";
            this.TahminiSureDakika.ReadOnly = true;
            this.TahminiSureDakika.Width = 120;
            // 
            // OlusturmaTarihi
            // 
            this.OlusturmaTarihi.DataPropertyName = "OlusturmaTarihi";
            this.OlusturmaTarihi.HeaderText = "Oluşturma Tarihi";
            this.OlusturmaTarihi.Name = "OlusturmaTarihi";
            this.OlusturmaTarihi.ReadOnly = true;
            this.OlusturmaTarihi.Width = 120;
            // 
            // Aktif
            // 
            this.Aktif.DataPropertyName = "Aktif";
            this.Aktif.HeaderText = "Durum";
            this.Aktif.Name = "Aktif";
            this.Aktif.ReadOnly = true;
            this.Aktif.Width = 80;
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
            this.lblBilgi.Text = "Toplam güzergah sayısı: 0";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnDetay);
            this.panelIslemler.Controls.Add(this.btnDurumDegistir);
            this.panelIslemler.Controls.Add(this.btnSil);
            this.panelIslemler.Controls.Add(this.btnDuzenle);
            this.panelIslemler.Controls.Add(this.btnEkle);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 545);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(950, 60);
            this.panelIslemler.TabIndex = 3;
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
            this.btnDetay.Text = "Detaylar";
            this.btnDetay.UseVisualStyleBackColor = false;
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
            this.btnEkle.Text = "Yeni Güzergah";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // GuzergahYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelArama);
            this.Controls.Add(this.panelUst);
            this.Name = "GuzergahYonetimForm";
            this.Text = "Güzergah Yönetimi";
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuzergahlar)).EndInit();
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewGuzergahlar;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rdTumGuzergahlar;
        private System.Windows.Forms.RadioButton rdAktifGuzergahlar;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuzergahID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuzergahAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicIskeleAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarisIskeleAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesafeDenizMili;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahminiSureDakika;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlusturmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;
    }
}