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
            // Form y�klendi�inde yap�lacak i�lemler
            this.AcceptButton = btnGirisYap; // Enter tu�u ile giri� yap�labilmesi i�in

            // TextBox placeholder efekti
            txtKullaniciAdi.GotFocus += RemoveText;
            txtKullaniciAdi.LostFocus += AddText;
            txtSifre.GotFocus += RemoveTextPassword;
            txtSifre.LostFocus += AddTextPassword;
        }

        // Placeholder efektleri i�in yard�mc� metotlar
        private void RemoveText(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullan�c� ad�n�z� giriniz")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                txtKullaniciAdi.Text = "Kullan�c� ad�n�z� giriniz";
            }
        }

        private void RemoveTextPassword(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '�';
            if (txtSifre.Text == "�ifrenizi giriniz")
            {
                txtSifre.Text = "";
            }
        }

        private void AddTextPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                txtSifre.PasswordChar = '\0';
                txtSifre.Text = "�ifrenizi giriniz";
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            // Placeholder de�erleriyse i�lem yapma
            if (kullaniciAdi == "Kullan�c� ad�n�z� giriniz" || sifre == "�ifrenizi giriniz")
            {
                MessageBox.Show("L�tfen kullan�c� ad� ve �ifre giriniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User user = userManager.Login(kullaniciAdi, sifre);

                if (user != null)
                {
                    // Kullan�c� tipine bak�lmaks�z�n y�netici formunu a�
                    YoneticiForm yoneticiForm = new YoneticiForm(user);
                    this.Hide();
                    yoneticiForm.FormClosed += (s, args) => this.Close();
                    yoneticiForm.Show();
                }
                else
                {
                    // Kullan�c� bulunamad� veya bilgiler yanl��
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Giri� Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giri� s�ras�nda bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Uygulamay� kapat
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kay�t olma �zelli�i hen�z uygulanmad�.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}