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
            panelLeft = new Panel();
            pictureBoxLogo = new PictureBox();
            lblCompanySlogan = new Label();
            lblWelcomeBack = new Label();
            panelRight = new Panel();
            lblSignUp = new LinkLabel();
            lblNoAccount = new Label();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            lblKullaniciAdi = new Label();
            lblDescription = new Label();
            lblLoginTitle = new Label();
            btnIptal = new Button();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(0, 122, 204);
            panelLeft.Controls.Add(pictureBoxLogo);
            panelLeft.Controls.Add(lblCompanySlogan);
            panelLeft.Controls.Add(lblWelcomeBack);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(408, 577);
            panelLeft.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(134, 115);
            pictureBoxLogo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(140, 138);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // lblCompanySlogan
            // 
            lblCompanySlogan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCompanySlogan.ForeColor = Color.WhiteSmoke;
            lblCompanySlogan.Location = new Point(47, 335);
            lblCompanySlogan.Margin = new Padding(4, 0, 4, 0);
            lblCompanySlogan.Name = "lblCompanySlogan";
            lblCompanySlogan.Size = new Size(315, 69);
            lblCompanySlogan.TabIndex = 1;
            lblCompanySlogan.Text = "Deniz Yolculuğunda Güvenilir Tercihiniz";
            // 
            // lblWelcomeBack
            // 
            lblWelcomeBack.AutoSize = true;
            lblWelcomeBack.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWelcomeBack.ForeColor = Color.White;
            lblWelcomeBack.Location = new Point(42, 254);
            lblWelcomeBack.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeBack.Name = "lblWelcomeBack";
            lblWelcomeBack.Size = new Size(301, 62);
            lblWelcomeBack.TabIndex = 0;
            lblWelcomeBack.Text = "Hoşgeldiniz!";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblSignUp);
            panelRight.Controls.Add(lblNoAccount);
            panelRight.Controls.Add(btnGirisYap);
            panelRight.Controls.Add(txtSifre);
            panelRight.Controls.Add(lblSifre);
            panelRight.Controls.Add(txtKullaniciAdi);
            panelRight.Controls.Add(lblKullaniciAdi);
            panelRight.Controls.Add(lblDescription);
            panelRight.Controls.Add(lblLoginTitle);
            panelRight.Controls.Add(btnIptal);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(408, 0);
            panelRight.Margin = new Padding(4, 3, 4, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(409, 577);
            panelRight.TabIndex = 1;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSignUp.LinkColor = Color.FromArgb(0, 122, 204);
            lblSignUp.Location = new Point(209, 410);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(53, 17);
            lblSignUp.TabIndex = 11;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "Kayıt Ol";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNoAccount.ForeColor = Color.DimGray;
            lblNoAccount.Location = new Point(117, 410);
            lblNoAccount.Margin = new Padding(4, 0, 4, 0);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(85, 17);
            lblNoAccount.TabIndex = 10;
            lblNoAccount.Text = "Hesabın yok?";
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
            btnGirisYap.Click += btnGirisYap_Click;
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
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(47, 127);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(315, 46);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Uludağ Deniz Otobüsleri sistemine giriş yapmak için bilgilerinizi giriniz.";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLoginTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblLoginTitle.Location = new Point(43, 69);
            lblLoginTitle.Margin = new Padding(4, 0, 4, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(88, 45);
            lblLoginTitle.TabIndex = 3;
            lblLoginTitle.Text = "Giriş";
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
            btnIptal.Click += btnIptal_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 577);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDO - Uludağ Deniz Otobüsleri";
            Load += LoginForm_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblCompanySlogan;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lblSignUp;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnIptal;
    }
}