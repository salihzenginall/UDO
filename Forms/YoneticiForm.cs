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
        // Fields
        private Button currentButton;
        private Form activeForm;
        private readonly User currentUser;

        // Constructor
        public YoneticiForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            // Form border olmadığı için custom control sağlamak için gerekli ayarlar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // DLL Import, formu taşımak için gerekli
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Methods
        private Color SelectThemeColor()
        {
            // UDO mavi teması için sabit bir renk
            return Color.FromArgb(0, 122, 204);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 90, 170);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = Color.FromArgb(0, 80, 150);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 122, 204);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

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

            lblTitle.Text = childForm.Text;
        }

        // Dashboard/Ana sayfaefefsef
        private void LoadDashboard()
        {
            // Gelecekte bu kısım veritabanından güncel verileri çekecek
            // Şimdilik sadece placeholder metin
            lblTitle.Text = "ANA SAYFA";
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

            // Durum çubuğunu güncelle
            toolStripStatusLabel.Text = "Durum: Hazır | Son giriş: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Menü Butonları Event Handlers
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(sender);
            LoadDashboard();
        }

        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            // Personel Yönetimi formunu açmak için
            // OpenChildForm(new PersonelYonetimForm(), sender);
            MessageBox.Show("Personel Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "PERSONEL YÖNETİMİ";
            ActivateButton(sender);
        }

        private void btnSeferYonetimi_Click(object sender, EventArgs e)
        {
            // Sefer Yönetimi formunu açmak için
            // OpenChildForm(new SeferYonetimForm(), sender);
            MessageBox.Show("Sefer Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "SEFER YÖNETİMİ";
            ActivateButton(sender);
        }

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            // Araç Yönetimi formunu açmak için
            // OpenChildForm(new AracYonetimForm(), sender);
            MessageBox.Show("Araç Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "ARAÇ YÖNETİMİ";
            ActivateButton(sender);
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            // Müşteri Yönetimi formunu açmak için
            // OpenChildForm(new MusteriYonetimForm(), sender);
            MessageBox.Show("Müşteri Yönetimi modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "MÜŞTERİ YÖNETİMİ";
            ActivateButton(sender);
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            // Raporlar formunu açmak için
            // OpenChildForm(new RaporlarForm(), sender);
            MessageBox.Show("Raporlar modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "RAPORLAR";
            ActivateButton(sender);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            // Ayarlar formunu açmak için
            // OpenChildForm(new AyarlarForm(), sender);
            MessageBox.Show("Ayarlar modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTitle.Text = "AYARLAR";
            ActivateButton(sender);
        }

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