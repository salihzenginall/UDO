using System;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;
using UDO.Forms; // PersonelForm'u kullanmak için ekleyin

namespace UDO.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void GirisForm_Yukleme(object sender, EventArgs e)
        {
            // Logo ve görsel ayarlar
            try
            {
                // Logo resmini proje kaynaklarýndan yükle
                // resimKutusuLogo.Image = Properties.Resources.udoLogo;

                // Þifre alanýný gizle
                txtSifre.PasswordChar = '*';

                // Form kontrollerini ilk durumuna getir
                txtKullaniciAdi.Text = string.Empty;
                txtSifre.Text = string.Empty;
                txtKullaniciAdi.Focus();

                // TextBox'lara odaklanma ve odak kaybetme olaylarýný ekle
                txtKullaniciAdi.GotFocus += TextBox_GotFocus;
                txtKullaniciAdi.LostFocus += TextBox_LostFocus;
                txtSifre.GotFocus += TextBox_GotFocus;
                txtSifre.LostFocus += TextBox_LostFocus;

                // Baþlangýç ipucu metinlerini ayarla
                TextBox_LostFocus(txtKullaniciAdi, EventArgs.Empty);
                TextBox_LostFocus(txtSifre, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken bir hata oluþtu: " + ex.Message);
            }
        }

        private void btnGirisYap_Tiklama(object sender, EventArgs e)
        {
            // Kullanýcý giriþ bilgilerini kontrol et
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || txtKullaniciAdi.Text == "Kullanýcý adýnýzý giriniz")
            {
                MessageBox.Show("Kullanýcý adý boþ býrakýlamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == "Þifrenizi giriniz")
            {
                MessageBox.Show("Þifre boþ býrakýlamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Focus();
                return;
            }

            try
            {
                // Kullanýcý bilgilerini veritabanýnda kontrol et
                UserManager kullaniciYoneticisi = new UserManager();
                User kullanici = kullaniciYoneticisi.Login(txtKullaniciAdi.Text, txtSifre.Text);

                if (kullanici != null)
                {
                    // Baþarýlý giriþ
                    MessageBox.Show("Giriþ baþarýlý! Hoþ geldiniz, " + kullanici.TamAd(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kullanýcý tipine göre uygun formu aç
                    if (kullanici.IsYonetici())
                    {
                        // Yönetici formunu aç
                        YoneticiForm yoneticiForm = new YoneticiForm(kullanici);
                        this.Hide();
                        yoneticiForm.ShowDialog();
                        this.Close();
                    }
                    else if (kullanici.IsPersonel())
                    {
                        // Personel formunu aç
                        PersonelForm personelForm = new PersonelForm(kullanici);
                        this.Hide();
                        personelForm.ShowDialog();
                        this.Close();
                    }
                    else if (kullanici.IsMusteri())
                    {
                        // Müþteri formunu aç (henüz uygulanmadý)
                        MessageBox.Show("Müþteri paneli yakýnda eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // MusteriForm musteriForm = new MusteriForm(kullanici);
                        // this.Hide();
                        // musteriForm.ShowDialog();
                        // this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý rolü tanýmlý deðil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Baþarýsýz giriþ
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriþ yapýlýrken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Tiklama(object sender, EventArgs e)
        {
            // Formu kapat
            DialogResult result = MessageBox.Show("Uygulamadan çýkmak istediðinize emin misiniz?", "Çýkýþ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblKayitOl_Tiklama(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kayýt formunu aç (henüz uygulanmadý)
            MessageBox.Show("Kayýt formu yakýnda eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // KayitForm kayitForm = new KayitForm();
            // kayitForm.ShowDialog();
        }

        // TextBox'lardaki ipucu metinlerini yönetmek için yardýmcý metotlar
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox == txtKullaniciAdi && textBox.Text == "Kullanýcý adýnýzý giriniz")
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
                else if (textBox == txtSifre && textBox.Text == "Þifrenizi giriniz")
                {
                    textBox.Text = string.Empty;
                    textBox.PasswordChar = '*';
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox == txtKullaniciAdi && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "Kullanýcý adýnýzý giriniz";
                    textBox.ForeColor = System.Drawing.Color.DimGray;
                }
                else if (textBox == txtSifre && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.PasswordChar = '\0'; // Karakteri görünür yap
                    textBox.Text = "Þifrenizi giriniz";
                    textBox.ForeColor = System.Drawing.Color.DimGray;
                }
            }
        }
    }
}
