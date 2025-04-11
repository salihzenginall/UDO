using System;
using System.Drawing;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserManager userManager;

        public LoginForm()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiðinde yapýlacak iþlemler
            this.AcceptButton = btnGirisYap; // Enter tuþu ile giriþ yapýlabilmesi için

            // TextBox placeholder efekti
            txtKullaniciAdi.GotFocus += RemoveText;
            txtKullaniciAdi.LostFocus += AddText;
            txtSifre.GotFocus += RemoveTextPassword;
            txtSifre.LostFocus += AddTextPassword;
        }

        // Placeholder efektleri için yardýmcý metotlar
        private void RemoveText(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanýcý adýnýzý giriniz")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                txtKullaniciAdi.Text = "Kullanýcý adýnýzý giriniz";
            }
        }

        private void RemoveTextPassword(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '•';
            if (txtSifre.Text == "Þifrenizi giriniz")
            {
                txtSifre.Text = "";
            }
        }

        private void AddTextPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                txtSifre.PasswordChar = '\0';
                txtSifre.Text = "Þifrenizi giriniz";
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            // Placeholder deðerleriyse iþlem yapma
            if (kullaniciAdi == "Kullanýcý adýnýzý giriniz" || sifre == "Þifrenizi giriniz")
            {
                MessageBox.Show("Lütfen kullanýcý adý ve þifre giriniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanýcý adý ve þifre boþ býrakýlamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User user = userManager.Login(kullaniciAdi, sifre);

                if (user != null)
                {
                    // Kullanýcý tipine bakýlmaksýzýn yönetici formunu aç
                    YoneticiForm yoneticiForm = new YoneticiForm(user);
                    this.Hide();
                    yoneticiForm.FormClosed += (s, args) => this.Close();
                    yoneticiForm.Show();
                }
                else
                {
                    // Kullanýcý bulunamadý veya bilgiler yanlýþ
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giriþ sýrasýnda bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Uygulamayý kapat
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayýt olma özelliði henüz uygulanmadý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}