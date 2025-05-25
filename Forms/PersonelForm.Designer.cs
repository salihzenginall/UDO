namespace UDO.Forms
{
    partial class PersonelForm
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnBiletSatis = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.resimKutusuLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelBaslikCubugu = new System.Windows.Forms.Panel();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.lblKullaniciBilgisi = new System.Windows.Forms.Label();
            this.btnSimgeDurumu = new System.Windows.Forms.Button();
            this.btnEkraniKapla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelMasaustuAlani = new System.Windows.Forms.Panel();
            this.durumCubugu = new System.Windows.Forms.StatusStrip();
            this.aracCubuguDurumEtiketi = new System.Windows.Forms.ToolStripStatusLabel();
            this.zamanlayici1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimKutusuLogo)).BeginInit();
            this.panelBaslikCubugu.SuspendLayout();
            this.durumCubugu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btnAyarlar);
            this.panelMenu.Controls.Add(this.btnBiletSatis);
            this.panelMenu.Controls.Add(this.btnMusteriYonetimi);
            this.panelMenu.Controls.Add(this.btnAnasayfa);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(0, 295); // Moved up from 350
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCikis.Size = new System.Drawing.Size(250, 55);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "  Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 240); // Moved up from 295
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAyarlar.Size = new System.Drawing.Size(250, 55);
            this.btnAyarlar.TabIndex = 7;
            this.btnAyarlar.Text = "  Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnBiletSatis
            // 
            this.btnBiletSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiletSatis.FlatAppearance.BorderSize = 0;
            this.btnBiletSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletSatis.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletSatis.ForeColor = System.Drawing.Color.White;
            this.btnBiletSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiletSatis.Location = new System.Drawing.Point(0, 185);
            this.btnBiletSatis.Name = "btnBiletSatis";
            this.btnBiletSatis.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBiletSatis.Size = new System.Drawing.Size(250, 55);
            this.btnBiletSatis.TabIndex = 4;
            this.btnBiletSatis.Text = "  Bilet Satış";
            this.btnBiletSatis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiletSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiletSatis.UseVisualStyleBackColor = true;
            this.btnBiletSatis.Click += new System.EventHandler(this.btnBiletSatis_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteriYonetimi.FlatAppearance.BorderSize = 0;
            this.btnMusteriYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriYonetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnMusteriYonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(0, 130);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(250, 55);
            this.btnMusteriYonetimi.TabIndex = 3;
            this.btnMusteriYonetimi.Text = "  Müşteri Yönetimi";
            this.btnMusteriYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriYonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 75);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAnasayfa.Size = new System.Drawing.Size(250, 55);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "  Ana Sayfa";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.panelLogo.Controls.Add(this.resimKutusuLogo);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // resimKutusuLogo
            // 
            this.resimKutusuLogo.Location = new System.Drawing.Point(12, 12);
            this.resimKutusuLogo.Name = "resimKutusuLogo";
            this.resimKutusuLogo.Size = new System.Drawing.Size(50, 50);
            this.resimKutusuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resimKutusuLogo.TabIndex = 1;
            this.resimKutusuLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(67, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(62, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "UDO";
            // 
            // panelBaslikCubugu
            // 
            this.panelBaslikCubugu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelBaslikCubugu.Controls.Add(this.lblTarihSaat);
            this.panelBaslikCubugu.Controls.Add(this.lblKullaniciBilgisi);
            this.panelBaslikCubugu.Controls.Add(this.btnSimgeDurumu);
            this.panelBaslikCubugu.Controls.Add(this.btnEkraniKapla);
            this.panelBaslikCubugu.Controls.Add(this.btnKapat);
            this.panelBaslikCubugu.Controls.Add(this.lblBaslik);
            this.panelBaslikCubugu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslikCubugu.Location = new System.Drawing.Point(250, 0);
            this.panelBaslikCubugu.Name = "panelBaslikCubugu";
            this.panelBaslikCubugu.Size = new System.Drawing.Size(950, 75);
            this.panelBaslikCubugu.TabIndex = 1;
            this.panelBaslikCubugu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBaslikCubugu_MouseDown);
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSaat.ForeColor = System.Drawing.Color.White;
            this.lblTarihSaat.Location = new System.Drawing.Point(700, 40);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(200, 17);
            this.lblTarihSaat.TabIndex = 5;
            this.lblTarihSaat.Text = "15.04.2025 14:30";
            this.lblTarihSaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKullaniciBilgisi
            // 
            this.lblKullaniciBilgisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKullaniciBilgisi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciBilgisi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciBilgisi.Location = new System.Drawing.Point(700, 15);
            this.lblKullaniciBilgisi.Name = "lblKullaniciBilgisi";
            this.lblKullaniciBilgisi.Size = new System.Drawing.Size(200, 25);
            this.lblKullaniciBilgisi.TabIndex = 4;
            this.lblKullaniciBilgisi.Text = "Kullanıcı: Personel";
            this.lblKullaniciBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSimgeDurumu
            // 
            this.btnSimgeDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimgeDurumu.FlatAppearance.BorderSize = 0;
            this.btnSimgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimgeDurumu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSimgeDurumu.ForeColor = System.Drawing.Color.White;
            this.btnSimgeDurumu.Location = new System.Drawing.Point(865, 3);
            this.btnSimgeDurumu.Name = "btnSimgeDurumu";
            this.btnSimgeDurumu.Size = new System.Drawing.Size(25, 25);
            this.btnSimgeDurumu.TabIndex = 3;
            this.btnSimgeDurumu.UseVisualStyleBackColor = true;
            this.btnSimgeDurumu.Click += new System.EventHandler(this.btnSimgeDurumu_Click);
            // 
            // btnEkraniKapla
            // 
            this.btnEkraniKapla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkraniKapla.FlatAppearance.BorderSize = 0;
            this.btnEkraniKapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkraniKapla.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkraniKapla.ForeColor = System.Drawing.Color.White;
            this.btnEkraniKapla.Location = new System.Drawing.Point(895, 3);
            this.btnEkraniKapla.Name = "btnEkraniKapla";
            this.btnEkraniKapla.Size = new System.Drawing.Size(25, 25);
            this.btnEkraniKapla.TabIndex = 2;
            this.btnEkraniKapla.UseVisualStyleBackColor = true;
            this.btnEkraniKapla.Click += new System.EventHandler(this.btnEkraniKapla_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(925, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(25, 25);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(20, 22);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(145, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ANA SAYFA";
            // 
            // panelMasaustuAlani
            // 
            this.panelMasaustuAlani.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMasaustuAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMasaustuAlani.Location = new System.Drawing.Point(250, 75);
            this.panelMasaustuAlani.Name = "panelMasaustuAlani";
            this.panelMasaustuAlani.Size = new System.Drawing.Size(950, 625);
            this.panelMasaustuAlani.TabIndex = 2;
            // 
            // durumCubugu
            // 
            this.durumCubugu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.durumCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aracCubuguDurumEtiketi});
            this.durumCubugu.Location = new System.Drawing.Point(250, 678);
            this.durumCubugu.Name = "durumCubugu";
            this.durumCubugu.Size = new System.Drawing.Size(950, 22);
            this.durumCubugu.TabIndex = 3;
            this.durumCubugu.Text = "statusStrip1";
            // 
            // aracCubuguDurumEtiketi
            // 
            this.aracCubuguDurumEtiketi.Name = "aracCubuguDurumEtiketi";
            this.aracCubuguDurumEtiketi.Size = new System.Drawing.Size(50, 17);
            this.aracCubuguDurumEtiketi.Text = "Durum: ";
            // 
            // zamanlayici1
            // 
            this.zamanlayici1.Enabled = true;
            this.zamanlayici1.Interval = 1000;
            this.zamanlayici1.Tick += new System.EventHandler(this.zamanlayici1_Tick);
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.durumCubugu);
            this.Controls.Add(this.panelMasaustuAlani);
            this.Controls.Add(this.panelBaslikCubugu);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDO - Personel Paneli";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimKutusuLogo)).EndInit();
            this.panelBaslikCubugu.ResumeLayout(false);
            this.panelBaslikCubugu.PerformLayout();
            this.durumCubugu.ResumeLayout(false);
            this.durumCubugu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnBiletSatis;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelBaslikCubugu;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSimgeDurumu;
        private System.Windows.Forms.Button btnEkraniKapla;
        private System.Windows.Forms.Panel panelMasaustuAlani;
        private System.Windows.Forms.StatusStrip durumCubugu;
        private System.Windows.Forms.ToolStripStatusLabel aracCubuguDurumEtiketi;
        private System.Windows.Forms.Label lblKullaniciBilgisi;
        private System.Windows.Forms.PictureBox resimKutusuLogo;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Timer zamanlayici1;
    }
}
