using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UDO.Models;

namespace UDO.Forms
{
    public partial class YoneticiForm : Form
    {
        // Alanlar
        private Button currentButton;
        private Form activeForm;
        private readonly User currentUser;

        // Yapıcı metot
        public YoneticiForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            // Form border olmadığı için custom control sağlamak için gerekli ayarlar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Varsayılan aktif buton olarak ana sayfa butonunu işaretle
            ActivateButton(btnAnasayfa);

            // Butonların simgelerini ayarlama
            SetButtonIcons();
        }

        // Butonların simgelerini ve konumlarını ayarlayan metod
        private void SetButtonIcons()
        {
            // Windows Forms uygulamasında butonların simgelerini ayarla
            // Not: Gerçek uygulamada bu simgeler proje kaynaklarından yüklenir
            try
            {
                // Minimize, Maximize ve Close butonları için simgeler
                btnMinimize.Text = "−";
                btnMinimize.Font = new Font("Arial", 12, FontStyle.Bold);
                btnMinimize.ForeColor = Color.White;

                btnMaximize.Text = "□";
                btnMaximize.Font = new Font("Arial", 12, FontStyle.Bold);
                btnMaximize.ForeColor = Color.White;

                btnClose.Text = "×";
                btnClose.Font = new Font("Arial", 12, FontStyle.Bold);
                btnClose.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Buton simgeleri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        // Kontrollerin konumlarını ayarlayan metod
        private void AdjustControlPositions()
        {
            // Butonların konumlarını panelin en sağına ayarla
            int panelWidth = panelTitleBar.Width;

            // Butonlar için daha solda yer ayarla (Kullanıcı bilgisinin solunda)
            btnClose.Location = new Point(panelWidth - 30, 3);
            btnMaximize.Location = new Point(panelWidth - 60, 3);
            btnMinimize.Location = new Point(panelWidth - 90, 3);

            // Kullanıcı bilgisini daha kısa tut ve konumunu ayarla
            lblUserInfo.MaximumSize = new Size(300, 25);
            lblUserInfo.Location = new Point(panelWidth - 400, 15);
            lblUserInfo.TextAlign = ContentAlignment.MiddleRight;

            // Tarih saat bilgisinin konumunu ayarla
            lblDateTime.Location = new Point(panelWidth - 400, 40);
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
        }

        // DLL Import, formu taşımak için gerekli
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Tema rengini seçen metot
        private Color SelectThemeColor()
        {
            // UDO deniz teması için sabit bir renk
            return Color.FromArgb(0, 127, 180);
        }

        // Butonları aktifleştiren metot
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 60, 105);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = Color.FromArgb(0, 60, 105);
                }
            }
        }

        // Butonları pasifleştiren metot
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 71, 118);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        // Alt formları açan metot
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text.ToUpper();
        }

        // Dashboard/Ana sayfa
        private void LoadDashboard()
        {
            // Önce tüm kontrolleri temizle
            panelDesktopPane.Controls.Clear();

            // İstatistik kartlarını oluştur
            CreateStatCards();

            // Haftalık yolcu istatistiklerini oluştur
            CreateWeeklyStats();

            // Yaklaşan seferleri oluştur
            CreateUpcomingTrips();

            toolStripStatusLabel.Text = "Durum: Hazır | Son giriş: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        // İstatistik kartlarını oluşturan metot
        private void CreateStatCards()
        {
            // Günlük Seferler Kartı
            Panel pnlDailyTrips = CreatePanel(20, 20, 300, 150, Color.FromArgb(230, 242, 247));

            Label lblDailyTripsTitle = CreateLabel("Günlük Seferler", 10, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlDailyTrips.Controls.Add(lblDailyTripsTitle);

            Label lblDailyTripsValue = CreateLabel("24", 125, 50, new Font("Segoe UI", 36, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlDailyTrips.Controls.Add(lblDailyTripsValue);

            Label lblDailyTripsSubtitle = CreateLabel("Bugünkü Toplam Sefer", 75, 110, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
            pnlDailyTrips.Controls.Add(lblDailyTripsSubtitle);

            panelDesktopPane.Controls.Add(pnlDailyTrips);

            // Bugünkü Yolcu Sayısı Kartı
            Panel pnlDailyPassengers = CreatePanel(330, 20, 300, 150, Color.FromArgb(230, 242, 247));

            Label lblDailyPassengersTitle = CreateLabel("Bugünkü Yolcu Sayısı", 10, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlDailyPassengers.Controls.Add(lblDailyPassengersTitle);

            Label lblDailyPassengersValue = CreateLabel("867", 110, 50, new Font("Segoe UI", 36, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlDailyPassengers.Controls.Add(lblDailyPassengersValue);

            Label lblDailyPassengersSubtitle = CreateLabel("Toplam Yolcu", 110, 110, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
            pnlDailyPassengers.Controls.Add(lblDailyPassengersSubtitle);

            panelDesktopPane.Controls.Add(pnlDailyPassengers);

            // Aktif Deniz Otobüsleri Kartı
            Panel pnlActiveShips = CreatePanel(640, 20, 300, 150, Color.FromArgb(230, 242, 247));

            Label lblActiveShipsTitle = CreateLabel("Aktif Deniz Otobüsleri", 10, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlActiveShips.Controls.Add(lblActiveShipsTitle);

            Label lblActiveShipsValue = CreateLabel("12", 125, 50, new Font("Segoe UI", 36, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlActiveShips.Controls.Add(lblActiveShipsValue);

            Label lblActiveShipsSubtitle = CreateLabel("Toplam 15 Araçtan", 100, 110, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
            pnlActiveShips.Controls.Add(lblActiveShipsSubtitle);

            panelDesktopPane.Controls.Add(pnlActiveShips);
        }

        // Haftalık istatistikleri oluşturan metot
        private void CreateWeeklyStats()
        {
            // Haftalık istatistikler panel
            Panel pnlWeeklyStats = CreatePanel(20, 190, 920, 180, Color.FromArgb(230, 242, 247));

            // Başlık
            Label lblWeeklyStatsTitle = CreateLabel("Haftalık Yolcu İstatistikleri", 20, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlWeeklyStats.Controls.Add(lblWeeklyStatsTitle);

            // Grafik için çubuklarını temsil eden paneller
            CreateBarChart(pnlWeeklyStats);

            panelDesktopPane.Controls.Add(pnlWeeklyStats);
        }

        // Grafik çubuklarını oluşturan metot
        private void CreateBarChart(Panel parentPanel)
        {
            string[] days = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };
            int[] values = { 250, 180, 270, 220, 290, 160, 240 }; // Örnek değerler

            int startX = 70;
            int barWidth = 70;
            int spacing = 30;
            int maxHeight = 120;
            int baseY = 160;

            for (int i = 0; i < days.Length; i++)
            {
                // Çubuk yüksekliği (değere göre ölçeklendirme)
                int barHeight = (int)(((double)values[i] / 300) * maxHeight);

                // Çubuk panel
                Panel pnlBar = CreatePanel(startX + i * (barWidth + spacing), baseY - barHeight, barWidth, barHeight, Color.FromArgb(52, 152, 219));
                parentPanel.Controls.Add(pnlBar);

                // Gün etiketi
                Label lblDay = CreateLabel(days[i], startX + i * (barWidth + spacing) + barWidth / 2 - 10, baseY + 5, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
                parentPanel.Controls.Add(lblDay);
            }
        }

        // Yaklaşan seferleri oluşturan metot
        private void CreateUpcomingTrips()
        {
            // Ana panel
            Panel pnlUpcomingTrips = CreatePanel(20, 390, 920, 180, Color.FromArgb(230, 242, 247));

            // Başlık
            Label lblUpcomingTripsTitle = CreateLabel("Yaklaşan Seferler", 20, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlUpcomingTrips.Controls.Add(lblUpcomingTripsTitle);

            // Tablo başlıkları
            string[] headers = { "Saat", "Güzergah", "Deniz Otobüsü", "Yolcu", "İşlem" };
            int[] headerWidths = { 80, 200, 200, 100, 100 };
            int headerY = 45;
            int startX = 20;

            for (int i = 0; i < headers.Length; i++)
            {
                Label lblHeader = CreateLabel(headers[i], startX, headerY, new Font("Segoe UI", 10, FontStyle.Bold), Color.FromArgb(0, 71, 118));
                pnlUpcomingTrips.Controls.Add(lblHeader);
                startX += headerWidths[i] + 10;
            }

            // Tablo verileri
            string[,] tripData = {
                { "09:30", "İstanbul - Bursa", "Deniz Otobüsü 3", "92/120 Yolcu" },
                { "10:15", "Bursa - Yalova", "Deniz Otobüsü 7", "45/80 Yolcu" }
            };

            for (int row = 0; row < 2; row++)
            {
                startX = 20;

                for (int col = 0; col < 4; col++)
                {
                    Label lblCell = CreateLabel(tripData[row, col], startX, headerY + 35 + (row * 35), new Font("Segoe UI", 9, FontStyle.Regular), Color.Black);
                    pnlUpcomingTrips.Controls.Add(lblCell);
                    startX += headerWidths[col] + 10;
                }

                // Detay butonu
                Button btnDetail = new Button();
                btnDetail.Text = "Detaylar";
                btnDetail.Size = new Size(80, 25);
                btnDetail.Location = new Point(startX, headerY + 30 + (row * 35));
                btnDetail.BackColor = Color.FromArgb(0, 127, 180);
                btnDetail.ForeColor = Color.White;
                btnDetail.FlatStyle = FlatStyle.Flat;
                btnDetail.Tag = row;
                btnDetail.Click += (s, e) => {
                    MessageBox.Show($"Sefer detayları: {tripData[(int)((Button)s).Tag, 0]} - {tripData[(int)((Button)s).Tag, 1]}", "Sefer Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                pnlUpcomingTrips.Controls.Add(btnDetail);
            }

            panelDesktopPane.Controls.Add(pnlUpcomingTrips);
        }

        // Panel oluşturan yardımcı metot
        private Panel CreatePanel(int x, int y, int width, int height, Color backColor)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(width, height);
            panel.BackColor = backColor;
            panel.BorderStyle = BorderStyle.FixedSingle;
            return panel;
        }

        // Etiket oluşturan yardımcı metot
        private Label CreateLabel(string text, int x, int y, Font font, Color foreColor)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.Location = new Point(x, y);
            label.Font = font;
            label.ForeColor = foreColor;
            return label;
        }

        // Form Events
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            // Form başlığını kullanıcı adıyla güncelle
            this.Text = $"UDO - Hoş Geldiniz, {currentUser.TamAd()}";

            // Kullanıcı bilgilerini göster - Kullanıcı adını ve rolü ekleyerek güncelle
            lblUserInfo.Text = $"Kullanıcı: {currentUser.TamAd()} Yönetici";
            lblTitle.Text = "ANA SAYFA";

            // Tarih saat bilgisini güncelle
            UpdateDateTime();

            // Kontrollerin konumlarını ayarla (üst üste binmeyi önlemek için)
            AdjustControlPositions();

            // Durum çubuğunu güncelle
            toolStripStatusLabel.Text = "Durum: Hazır | Son giriş: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            // Dashboard'u yükle
            LoadDashboard();
        }

        // Timer event - tarih ve saati güncellemek için
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        // Tarih ve saat bilgisini güncelleyen metot
        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        // Form başlık çubuğunu taşıma işlevi
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Kapat butonunun tıklama olayı
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ekranı kapla butonunun tıklama olayı
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Simge durumuna küçült butonunun tıklama olayı
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Ana Sayfa butonunun tıklama olayı
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(sender);
            lblTitle.Text = "ANA SAYFA";
            LoadDashboard();
        }

        // Personel Yönetimi butonunun tıklama olayı
        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            // Personel Yönetimi formunu açmak için
            // OpenChildForm(new PersonelYonetimForm(), sender);
            MessageBox.Show("Personel Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "PERSONEL YÖNETİMİ";
            ActivateButton(sender);
        }

        // Sefer Yönetimi butonunun tıklama olayı
        private void btnSeferYonetimi_Click(object sender, EventArgs e)
        {
            // Sefer Yönetimi formunu açmak için
            // OpenChildForm(new SeferYonetimForm(), sender);
            MessageBox.Show("Sefer Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "SEFER YÖNETİMİ";
            ActivateButton(sender);
        }

        // Deniz Otobüsü Yönetimi butonunun tıklama olayı
        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            // Deniz Otobüsü Yönetimi formunu açmak için
            // OpenChildForm(new DenizOtobusuYonetimForm(), sender);
            MessageBox.Show("Deniz Otobüsü Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "DENİZ OTOBÜSÜ YÖNETİMİ";
            ActivateButton(sender);
        }

        // Müşteri Yönetimi butonunun tıklama olayı
        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            // Müşteri Yönetimi formunu açmak için
            // OpenChildForm(new MusteriYonetimForm(), sender);
            MessageBox.Show("Müşteri Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "MÜŞTERİ YÖNETİMİ";
            ActivateButton(sender);
        }

        // Raporlar butonunun tıklama olayı
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            // Raporlar formunu açmak için
            // OpenChildForm(new RaporlarForm(), sender);
            MessageBox.Show("Raporlar modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "RAPORLAR";
            ActivateButton(sender);
        }

        // Ayarlar butonunun tıklama olayı
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            // Ayarlar formunu açmak için
            // OpenChildForm(new AyarlarForm(), sender);
            MessageBox.Show("Ayarlar modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "AYARLAR";
            ActivateButton(sender);
        }

        // Çıkış butonunun tıklama olayı
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}