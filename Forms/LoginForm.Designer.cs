namespace UDO.Forms
{
    partial class LoginForm
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
            panelSol = new Panel();
            resimKutusuLogo = new PictureBox();
            lblSirketSlogani = new Label();
            lblHosgeldiniz = new Label();
            panelSag = new Panel();
            lblKayitOl = new LinkLabel();
            lblHesapYok = new Label();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            lblKullaniciAdi = new Label();
            lblAciklama = new Label();
            lblGirisBaslik = new Label();
            btnIptal = new Button();
            panelSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resimKutusuLogo).BeginInit();
            panelSag.SuspendLayout();
            SuspendLayout();
            // 
            // panelSol
            // 
            panelSol.BackColor = Color.FromArgb(0, 122, 204);
            panelSol.Controls.Add(resimKutusuLogo);
            panelSol.Controls.Add(lblSirketSlogani);
            panelSol.Controls.Add(lblHosgeldiniz);
            panelSol.Dock = DockStyle.Left;
            panelSol.Location = new Point(0, 0);
            panelSol.Margin = new Padding(4, 3, 4, 3);
            panelSol.Name = "panelSol";
            panelSol.Size = new Size(408, 577);
            panelSol.TabIndex = 0;
            // 
            // resimKutusuLogo
            // 
            resimKutusuLogo.Location = new Point(134, 115);
            resimKutusuLogo.Margin = new Padding(4, 3, 4, 3);
            resimKutusuLogo.Name = "resimKutusuLogo";
            resimKutusuLogo.Size = new Size(140, 138);
            resimKutusuLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            resimKutusuLogo.TabIndex = 2;
            resimKutusuLogo.TabStop = false;
            // 
            // lblSirketSlogani
            // 
            lblSirketSlogani.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSirketSlogani.ForeColor = Color.WhiteSmoke;
            lblSirketSlogani.Location = new Point(47, 335);
            lblSirketSlogani.Margin = new Padding(4, 0, 4, 0);
            lblSirketSlogani.Name = "lblSirketSlogani";
            lblSirketSlogani.Size = new Size(315, 69);
            lblSirketSlogani.TabIndex = 1;
            lblSirketSlogani.Text = "Deniz Yolculuğunda Güvenilir Tercihiniz";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHosgeldiniz.ForeColor = Color.White;
            lblHosgeldiniz.Location = new Point(42, 254);
            lblHosgeldiniz.Margin = new Padding(4, 0, 4, 0);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(301, 62);
            lblHosgeldiniz.TabIndex = 0;
            lblHosgeldiniz.Text = "Hoşgeldiniz!";
            // 
            // panelSag
            // 
            panelSag.BackColor = Color.White;
            panelSag.Controls.Add(lblKayitOl);
            panelSag.Controls.Add(lblHesapYok);
            panelSag.Controls.Add(btnGirisYap);
            panelSag.Controls.Add(txtSifre);
            panelSag.Controls.Add(lblSifre);
            panelSag.Controls.Add(txtKullaniciAdi);
            panelSag.Controls.Add(lblKullaniciAdi);
            panelSag.Controls.Add(lblAciklama);
            panelSag.Controls.Add(lblGirisBaslik);
            panelSag.Controls.Add(btnIptal);
            panelSag.Dock = DockStyle.Fill;
            panelSag.Location = new Point(408, 0);
            panelSag.Margin = new Padding(4, 3, 4, 3);
            panelSag.Name = "panelSag";
            panelSag.Size = new Size(409, 577);
            panelSag.TabIndex = 1;
            // 
            
            // lblHesapYok
            // 
            lblHesapYok.AutoSize = true;
            lblHesapYok.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHesapYok.ForeColor = Color.DimGray;
            lblHesapYok.Location = new Point(117, 410);
            lblHesapYok.Margin = new Padding(4, 0, 4, 0);
            lblHesapYok.Name = "lblHesapYok";
            lblHesapYok.Size = new Size(85, 17);
            lblHesapYok.TabIndex = 10;
            lblHesapYok.Text = "Hesabın yok?";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(0, 122, 204);
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(47, 346);
            btnGirisYap.Margin = new Padding(4, 3, 4, 3);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(315, 52);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Tiklama;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.DimGray;
            txtSifre.Location = new Point(47, 277);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(315, 29);
            txtSifre.TabIndex = 1;
            txtSifre.Text = "Şifrenizi giriniz";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.DimGray;
            lblSifre.Location = new Point(47, 254);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(37, 17);
            lblSifre.TabIndex = 7;
            lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.ForeColor = Color.DimGray;
            txtKullaniciAdi.Location = new Point(47, 208);
            txtKullaniciAdi.Margin = new Padding(4, 3, 4, 3);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(315, 29);
            txtKullaniciAdi.TabIndex = 0;
            txtKullaniciAdi.Text = "Kullanıcı adınızı giriniz";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.DimGray;
            lblKullaniciAdi.Location = new Point(47, 185);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(81, 17);
            lblKullaniciAdi.TabIndex = 5;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAciklama
            // 
            lblAciklama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.DimGray;
            lblAciklama.Location = new Point(47, 127);
            lblAciklama.Margin = new Padding(4, 0, 4, 0);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(315, 46);
            lblAciklama.TabIndex = 4;
            lblAciklama.Text = "Uludağ Deniz Otobüsleri sistemine giriş yapmak için bilgilerinizi giriniz.";
            // 
            // lblGirisBaslik
            // 
            lblGirisBaslik.AutoSize = true;
            lblGirisBaslik.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGirisBaslik.ForeColor = Color.FromArgb(0, 122, 204);
            lblGirisBaslik.Location = new Point(43, 69);
            lblGirisBaslik.Margin = new Padding(4, 0, 4, 0);
            lblGirisBaslik.Name = "lblGirisBaslik";
            lblGirisBaslik.Size = new Size(88, 45);
            lblGirisBaslik.TabIndex = 3;
            lblGirisBaslik.Text = "Giriş";
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Gray;
            btnIptal.FlatAppearance.BorderSize = 0;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(148, 527);
            btnIptal.Margin = new Padding(5, 5, 5, 5);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(111, 35);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Visible = false;
            btnIptal.Click += btnIptal_Tiklama;
            // 
            // LoginForm
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 577);
            Controls.Add(panelSag);
            Controls.Add(panelSol);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDO - Uludağ Deniz Otobüsleri";
            Load += GirisForm_Yukleme;
            panelSol.ResumeLayout(false);
            panelSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resimKutusuLogo).EndInit();
            panelSag.ResumeLayout(false);
            panelSag.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Panel panelSag;
        private System.Windows.Forms.Label lblSirketSlogani;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblHesapYok;
        private System.Windows.Forms.LinkLabel lblKayitOl;
        private System.Windows.Forms.PictureBox resimKutusuLogo;
        private System.Windows.Forms.Button btnIptal;
    }
}