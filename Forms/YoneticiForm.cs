using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            // Ana sayfa içeriğini göster
            lblTitle.Text = "ANA SAYFA";

            // Burada ana sayfa içeriği yüklenecek
            // Örneğin günlük sefer sayısı, yolcu sayısı, aktif deniz otobüsü sayısı gibi metrikler

            toolStripStatusLabel.Text = "Durum: Ana Sayfa yüklendi. Tarih: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        // Form Events
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            // Form başlığını kullanıcı adıyla güncelle
            this.Text = $"UDO - Hoş Geldiniz, {currentUser.TamAd()}";

            // Kullanıcı bilgilerini göster
            lblUserInfo.Text = $"Kullanıcı: {currentUser.TamAd()}";
            lblTitle.Text = "ANA SAYFA";

            // Tarih saat bilgisini güncelle
            UpdateDateTime();

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