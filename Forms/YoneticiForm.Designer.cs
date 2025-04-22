namespace UDO.Forms
{
    partial class YoneticiForm
    {
        // Gerekli tasarımcı değişkeni
        private System.ComponentModel.IContainer components = null;

        // Kullanılan kaynakları temizleyin
        // param: disposing - yönetilen kaynaklar dispose edilecekse true; aksi halde false
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Tasarımcı desteği için gerekli metod - bu metodun 
        // içeriğini kod düzenleyici ile değiştirmeyin
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnCikis = new Button();
            btnAyarlar = new Button();
            btnRaporlar = new Button();
            btnMusteriYonetimi = new Button();
            btnAracYonetimi = new Button();
            btnSeferYonetimi = new Button();
            btnPersonelYonetimi = new Button();
            btnAnasayfa = new Button();
            panelLogo = new Panel();
            resimKutusuLogo = new PictureBox();
            lblLogo = new Label();
            panelBaslikCubugu = new Panel();
            lblTarihSaat = new Label();
            lblKullaniciBilgisi = new Label();
            btnSimgeDurumu = new Button();
            btnEkraniKapla = new Button();
            btnKapat = new Button();
            lblBaslik = new Label();
            panelMasaustuAlani = new Panel();
            durumCubugu = new StatusStrip();
            aracCubuguDurumEtiketi = new ToolStripStatusLabel();
            zamanlayici1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resimKutusuLogo).BeginInit();
            panelBaslikCubugu.SuspendLayout();
            durumCubugu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 71, 118);
            panelMenu.Controls.Add(btnCikis);
            panelMenu.Controls.Add(btnAyarlar);
            panelMenu.Controls.Add(btnRaporlar);
            panelMenu.Controls.Add(btnMusteriYonetimi);
            panelMenu.Controls.Add(btnAracYonetimi);
            panelMenu.Controls.Add(btnSeferYonetimi);
            panelMenu.Controls.Add(btnPersonelYonetimi);
            panelMenu.Controls.Add(btnAnasayfa);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 700);
            panelMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.Dock = DockStyle.Top;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.Location = new Point(0, 460);
            btnCikis.Name = "btnCikis";
            btnCikis.Padding = new Padding(12, 0, 0, 0);
            btnCikis.Size = new Size(250, 55);
            btnCikis.TabIndex = 8;
            btnCikis.Text = "  Çıkış";
            btnCikis.TextAlign = ContentAlignment.MiddleLeft;
            btnCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Tiklama;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Dock = DockStyle.Top;
            btnAyarlar.FlatAppearance.BorderSize = 0;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyarlar.Location = new Point(0, 405);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Padding = new Padding(12, 0, 0, 0);
            btnAyarlar.Size = new Size(250, 55);
            btnAyarlar.TabIndex = 7;
            btnAyarlar.Text = "  Ayarlar";
            btnAyarlar.TextAlign = ContentAlignment.MiddleLeft;
            btnAyarlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAyarlar.UseVisualStyleBackColor = true;
            btnAyarlar.Click += btnAyarlar_Tiklama;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Dock = DockStyle.Top;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.Location = new Point(0, 350);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Padding = new Padding(12, 0, 0, 0);
            btnRaporlar.Size = new Size(250, 55);
            btnRaporlar.TabIndex = 6;
            btnRaporlar.Text = "  Raporlar";
            btnRaporlar.TextAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Tiklama;
            // 
            // btnMusteriYonetimi
            // 
            btnMusteriYonetimi.Dock = DockStyle.Top;
            btnMusteriYonetimi.FlatAppearance.BorderSize = 0;
            btnMusteriYonetimi.FlatStyle = FlatStyle.Flat;
            btnMusteriYonetimi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriYonetimi.ForeColor = Color.White;
            btnMusteriYonetimi.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusteriYonetimi.Location = new Point(0, 295);
            btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            btnMusteriYonetimi.Padding = new Padding(12, 0, 0, 0);
            btnMusteriYonetimi.Size = new Size(250, 55);
            btnMusteriYonetimi.TabIndex = 5;
            btnMusteriYonetimi.Text = "  Müşteri Yönetimi";
            btnMusteriYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnMusteriYonetimi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMusteriYonetimi.UseVisualStyleBackColor = true;
            btnMusteriYonetimi.Click += btnMusteriYonetimi_Tiklama;
            // 
            // btnAracYonetimi
            // 
            btnAracYonetimi.Dock = DockStyle.Top;
            btnAracYonetimi.FlatAppearance.BorderSize = 0;
            btnAracYonetimi.FlatStyle = FlatStyle.Flat;
            btnAracYonetimi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAracYonetimi.ForeColor = Color.White;
            btnAracYonetimi.ImageAlign = ContentAlignment.MiddleLeft;
            btnAracYonetimi.Location = new Point(0, 240);
            btnAracYonetimi.Name = "btnAracYonetimi";
            btnAracYonetimi.Padding = new Padding(12, 0, 0, 0);
            btnAracYonetimi.Size = new Size(250, 55);
            btnAracYonetimi.TabIndex = 4;
            btnAracYonetimi.Text = "  Deniz Otobüsü Yönetimi";
            btnAracYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnAracYonetimi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAracYonetimi.UseVisualStyleBackColor = true;
            btnAracYonetimi.Click += btnAracYonetimi_Tiklama;
            // 
            // btnSeferYonetimi
            // 
            btnSeferYonetimi.Dock = DockStyle.Top;
            btnSeferYonetimi.FlatAppearance.BorderSize = 0;
            btnSeferYonetimi.FlatStyle = FlatStyle.Flat;
            btnSeferYonetimi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSeferYonetimi.ForeColor = Color.White;
            btnSeferYonetimi.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeferYonetimi.Location = new Point(0, 185);
            btnSeferYonetimi.Name = "btnSeferYonetimi";
            btnSeferYonetimi.Padding = new Padding(12, 0, 0, 0);
            btnSeferYonetimi.Size = new Size(250, 55);
            btnSeferYonetimi.TabIndex = 3;
            btnSeferYonetimi.Text = "  Sefer Yönetimi";
            btnSeferYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnSeferYonetimi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeferYonetimi.UseVisualStyleBackColor = true;
            btnSeferYonetimi.Click += btnSeferYonetimi_Click;
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.Dock = DockStyle.Top;
            btnPersonelYonetimi.FlatAppearance.BorderSize = 0;
            btnPersonelYonetimi.FlatStyle = FlatStyle.Flat;
            btnPersonelYonetimi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonelYonetimi.ForeColor = Color.White;
            btnPersonelYonetimi.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonelYonetimi.Location = new Point(0, 130);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Padding = new Padding(12, 0, 0, 0);
            btnPersonelYonetimi.Size = new Size(250, 55);
            btnPersonelYonetimi.TabIndex = 2;
            btnPersonelYonetimi.Text = "  Personel Yönetimi";
            btnPersonelYonetimi.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonelYonetimi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersonelYonetimi.UseVisualStyleBackColor = true;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Tiklama;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.Dock = DockStyle.Top;
            btnAnasayfa.FlatAppearance.BorderSize = 0;
            btnAnasayfa.FlatStyle = FlatStyle.Flat;
            btnAnasayfa.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAnasayfa.ForeColor = Color.White;
            btnAnasayfa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnasayfa.Location = new Point(0, 75);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Padding = new Padding(12, 0, 0, 0);
            btnAnasayfa.Size = new Size(250, 55);
            btnAnasayfa.TabIndex = 1;
            btnAnasayfa.Text = "  Ana Sayfa";
            btnAnasayfa.TextAlign = ContentAlignment.MiddleLeft;
            btnAnasayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnasayfa.UseVisualStyleBackColor = true;
            btnAnasayfa.Click += btnAnasayfa_Tiklama;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 60, 105);
            panelLogo.Controls.Add(resimKutusuLogo);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 75);
            panelLogo.TabIndex = 0;
            // 
            // resimKutusuLogo
            // 
            resimKutusuLogo.Location = new Point(12, 12);
            resimKutusuLogo.Name = "resimKutusuLogo";
            resimKutusuLogo.Size = new Size(50, 50);
            resimKutusuLogo.SizeMode = PictureBoxSizeMode.Zoom;
            resimKutusuLogo.TabIndex = 1;
            resimKutusuLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(67, 22);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(62, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "UDO";
            // 
            // panelBaslikCubugu
            // 
            panelBaslikCubugu.BackColor = Color.FromArgb(0, 127, 180);
            panelBaslikCubugu.Controls.Add(lblTarihSaat);
            panelBaslikCubugu.Controls.Add(lblKullaniciBilgisi);
            panelBaslikCubugu.Controls.Add(btnSimgeDurumu);
            panelBaslikCubugu.Controls.Add(btnEkraniKapla);
            panelBaslikCubugu.Controls.Add(btnKapat);
            panelBaslikCubugu.Controls.Add(lblBaslik);
            panelBaslikCubugu.Dock = DockStyle.Top;
            panelBaslikCubugu.Location = new Point(250, 0);
            panelBaslikCubugu.Name = "panelBaslikCubugu";
            panelBaslikCubugu.Size = new Size(950, 75);
            panelBaslikCubugu.TabIndex = 1;
            panelBaslikCubugu.MouseDown += panelBaslikCubugu_FareBasildi;
            // 
            // lblTarihSaat
            // 
            lblTarihSaat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTarihSaat.ForeColor = Color.White;
            lblTarihSaat.Location = new Point(700, 40);
            lblTarihSaat.Name = "lblTarihSaat";
            lblTarihSaat.Size = new Size(200, 17);
            lblTarihSaat.TabIndex = 5;
            lblTarihSaat.Text = "15.04.2025 14:30";
            lblTarihSaat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKullaniciBilgisi
            // 
            lblKullaniciBilgisi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKullaniciBilgisi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKullaniciBilgisi.ForeColor = Color.White;
            lblKullaniciBilgisi.Location = new Point(700, 15);
            lblKullaniciBilgisi.Name = "lblKullaniciBilgisi";
            lblKullaniciBilgisi.Size = new Size(200, 25);
            lblKullaniciBilgisi.TabIndex = 4;
            lblKullaniciBilgisi.Text = "Kullanıcı: Admin";
            lblKullaniciBilgisi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSimgeDurumu
            // 
            btnSimgeDurumu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSimgeDurumu.FlatAppearance.BorderSize = 0;
            btnSimgeDurumu.FlatStyle = FlatStyle.Flat;
            btnSimgeDurumu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSimgeDurumu.ForeColor = Color.White;
            btnSimgeDurumu.Location = new Point(865, 3);
            btnSimgeDurumu.Name = "btnSimgeDurumu";
            btnSimgeDurumu.Size = new Size(25, 25);
            btnSimgeDurumu.TabIndex = 3;
            btnSimgeDurumu.UseVisualStyleBackColor = true;
            btnSimgeDurumu.Click += btnSimgeDurumu_Tiklama;
            // 
            // btnEkraniKapla
            // 
            btnEkraniKapla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEkraniKapla.FlatAppearance.BorderSize = 0;
            btnEkraniKapla.FlatStyle = FlatStyle.Flat;
            btnEkraniKapla.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkraniKapla.ForeColor = Color.White;
            btnEkraniKapla.Location = new Point(895, 3);
            btnEkraniKapla.Name = "btnEkraniKapla";
            btnEkraniKapla.Size = new Size(25, 25);
            btnEkraniKapla.TabIndex = 2;
            btnEkraniKapla.UseVisualStyleBackColor = true;
            btnEkraniKapla.Click += btnEkraniKapla_Tiklama;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(925, 3);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 1;
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Tiklama;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(20, 22);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(145, 32);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "ANA SAYFA";
            // 
            // panelMasaustuAlani
            // 
            panelMasaustuAlani.BackColor = Color.WhiteSmoke;
            panelMasaustuAlani.Dock = DockStyle.Fill;
            panelMasaustuAlani.Location = new Point(250, 75);
            panelMasaustuAlani.Name = "panelMasaustuAlani";
            panelMasaustuAlani.Size = new Size(950, 625);
            panelMasaustuAlani.TabIndex = 2;
            // 
            // durumCubugu
            // 
            durumCubugu.BackColor = Color.FromArgb(225, 240, 250);
            durumCubugu.Items.AddRange(new ToolStripItem[] { aracCubuguDurumEtiketi });
            durumCubugu.Location = new Point(250, 678);
            durumCubugu.Name = "durumCubugu";
            durumCubugu.Size = new Size(950, 22);
            durumCubugu.TabIndex = 3;
            durumCubugu.Text = "statusStrip1";
            // 
            // aracCubuguDurumEtiketi
            // 
            aracCubuguDurumEtiketi.Name = "aracCubuguDurumEtiketi";
            aracCubuguDurumEtiketi.Size = new Size(50, 17);
            aracCubuguDurumEtiketi.Text = "Durum: ";
            // 
            // zamanlayici1
            // 
            zamanlayici1.Enabled = true;
            zamanlayici1.Interval = 1000;
            zamanlayici1.Tick += zamanlayici1_Tik;
            // 
            // YoneticiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(durumCubugu);
            Controls.Add(panelMasaustuAlani);
            Controls.Add(panelBaslikCubugu);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YoneticiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDO - Yönetici Paneli";
            Load += YoneticiForm_Yukleme;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resimKutusuLogo).EndInit();
            panelBaslikCubugu.ResumeLayout(false);
            panelBaslikCubugu.PerformLayout();
            durumCubugu.ResumeLayout(false);
            durumCubugu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnAracYonetimi;
        private System.Windows.Forms.Button btnSeferYonetimi;
        private System.Windows.Forms.Button btnPersonelYonetimi;
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