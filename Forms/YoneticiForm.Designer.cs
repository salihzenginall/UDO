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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnAracYonetimi = new System.Windows.Forms.Button();
            this.btnSeferYonetimi = new System.Windows.Forms.Button();
            this.btnPersonelYonetimi = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btnAyarlar);
            this.panelMenu.Controls.Add(this.btnRaporlar);
            this.panelMenu.Controls.Add(this.btnMusteriYonetimi);
            this.panelMenu.Controls.Add(this.btnAracYonetimi);
            this.panelMenu.Controls.Add(this.btnSeferYonetimi);
            this.panelMenu.Controls.Add(this.btnPersonelYonetimi);
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
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(0, 460);
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
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 405);
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
            // btnRaporlar
            // 
            this.btnRaporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaporlar.FlatAppearance.BorderSize = 0;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ForeColor = System.Drawing.Color.White;
            this.btnRaporlar.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.Image")));
            this.btnRaporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporlar.Location = new System.Drawing.Point(0, 350);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRaporlar.Size = new System.Drawing.Size(250, 55);
            this.btnRaporlar.TabIndex = 6;
            this.btnRaporlar.Text = "  Raporlar";
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteriYonetimi.FlatAppearance.BorderSize = 0;
            this.btnMusteriYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriYonetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnMusteriYonetimi.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriYonetimi.Image")));
            this.btnMusteriYonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(0, 295);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(250, 55);
            this.btnMusteriYonetimi.TabIndex = 5;
            this.btnMusteriYonetimi.Text = "  Müşteri Yönetimi";
            this.btnMusteriYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriYonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnAracYonetimi
            // 
            this.btnAracYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAracYonetimi.FlatAppearance.BorderSize = 0;
            this.btnAracYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracYonetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnAracYonetimi.Image = ((System.Drawing.Image)(resources.GetObject("btnAracYonetimi.Image")));
            this.btnAracYonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracYonetimi.Location = new System.Drawing.Point(0, 240);
            this.btnAracYonetimi.Name = "btnAracYonetimi";
            this.btnAracYonetimi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAracYonetimi.Size = new System.Drawing.Size(250, 55);
            this.btnAracYonetimi.TabIndex = 4;
            this.btnAracYonetimi.Text = "  Deniz Otobüsü Yönetimi";
            this.btnAracYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracYonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAracYonetimi.UseVisualStyleBackColor = true;
            this.btnAracYonetimi.Click += new System.EventHandler(this.btnAracYonetimi_Click);
            // 
            // btnSeferYonetimi
            // 
            this.btnSeferYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeferYonetimi.FlatAppearance.BorderSize = 0;
            this.btnSeferYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeferYonetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeferYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnSeferYonetimi.Image = ((System.Drawing.Image)(resources.GetObject("btnSeferYonetimi.Image")));
            this.btnSeferYonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeferYonetimi.Location = new System.Drawing.Point(0, 185);
            this.btnSeferYonetimi.Name = "btnSeferYonetimi";
            this.btnSeferYonetimi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSeferYonetimi.Size = new System.Drawing.Size(250, 55);
            this.btnSeferYonetimi.TabIndex = 3;
            this.btnSeferYonetimi.Text = "  Sefer Yönetimi";
            this.btnSeferYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeferYonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeferYonetimi.UseVisualStyleBackColor = true;
            this.btnSeferYonetimi.Click += new System.EventHandler(this.btnSeferYonetimi_Click);
            // 
            // btnPersonelYonetimi
            // 
            this.btnPersonelYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonelYonetimi.FlatAppearance.BorderSize = 0;
            this.btnPersonelYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelYonetimi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnPersonelYonetimi.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelYonetimi.Image")));
            this.btnPersonelYonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelYonetimi.Location = new System.Drawing.Point(0, 130);
            this.btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            this.btnPersonelYonetimi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPersonelYonetimi.Size = new System.Drawing.Size(250, 55);
            this.btnPersonelYonetimi.TabIndex = 2;
            this.btnPersonelYonetimi.Text = "  Personel Yönetimi";
            this.btnPersonelYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelYonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelYonetimi.UseVisualStyleBackColor = true;
            this.btnPersonelYonetimi.Click += new System.EventHandler(this.btnPersonelYonetimi_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
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
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(67, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(56, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "UDO";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(180)))));
            this.panelTitleBar.Controls.Add(this.lblDateTime);
            this.panelTitleBar.Controls.Add(this.lblUserInfo);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(950, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(700, 40);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(200, 17);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "15.04.2025 14:30";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(700, 15);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(200, 25);
            this.lblUserInfo.TabIndex = 4;
            this.lblUserInfo.Text = "Kullanıcı: Admin";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(865, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(895, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(925, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ANA SAYFA";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(250, 75);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(950, 603);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(250, 678);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(950, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel.Text = "Durum: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoneticiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDO - Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}