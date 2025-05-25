using System;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;
using UDO.Forms; // PersonelForm'u kullanmak i�in ekleyin

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
            // Logo ve g�rsel ayarlar
            try
            {
                // Logo resmini proje kaynaklar�ndan y�kle
                // resimKutusuLogo.Image = Properties.Resources.udoLogo;

                // �ifre alan�n� gizle
                txtSifre.PasswordChar = '*';

                // Form kontrollerini ilk durumuna getir
                txtKullaniciAdi.Text = string.Empty;
                txtSifre.Text = string.Empty;
                txtKullaniciAdi.Focus();

                // TextBox'lara odaklanma ve odak kaybetme olaylar�n� ekle
                txtKullaniciAdi.GotFocus += TextBox_GotFocus;
                txtKullaniciAdi.LostFocus += TextBox_LostFocus;
                txtSifre.GotFocus += TextBox_GotFocus;
                txtSifre.LostFocus += TextBox_LostFocus;

                // Ba�lang�� ipucu metinlerini ayarla
                TextBox_LostFocus(txtKullaniciAdi, EventArgs.Empty);
                TextBox_LostFocus(txtSifre, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form y�klenirken bir hata olu�tu: " + ex.Message);
            }
        }

        private void btnGirisYap_Tiklama(object sender, EventArgs e)
        {
            // Kullan�c� giri� bilgilerini kontrol et
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || txtKullaniciAdi.Text == "Kullan�c� ad�n�z� giriniz")
            {
                MessageBox.Show("Kullan�c� ad� bo� b�rak�lamaz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == "�ifrenizi giriniz")
            {
                MessageBox.Show("�ifre bo� b�rak�lamaz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Focus();
                return;
            }

            try
            {
                // Kullan�c� bilgilerini veritaban�nda kontrol et
                UserManager kullaniciYoneticisi = new UserManager();
                User kullanici = kullaniciYoneticisi.Login(txtKullaniciAdi.Text, txtSifre.Text);

                if (kullanici != null)
                {
                    // Ba�ar�l� giri�
                    MessageBox.Show("Giri� ba�ar�l�! Ho� geldiniz, " + kullanici.TamAd(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kullan�c� tipine g�re uygun formu a�
                    if (kullanici.IsYonetici())
                    {
                        // Y�netici formunu a�
                        YoneticiForm yoneticiForm = new YoneticiForm(kullanici);
                        this.Hide();
                        yoneticiForm.ShowDialog();
                        this.Close();
                    }
                    else if (kullanici.IsPersonel())
                    {
                        // Personel formunu a�
                        PersonelForm personelForm = new PersonelForm(kullanici);
                        this.Hide();
                        personelForm.ShowDialog();
                        this.Close();
                    }
                    else if (kullanici.IsMusteri())
                    {
                        // M��teri formunu a� (hen�z uygulanmad�)
                        MessageBox.Show("M��teri paneli yak�nda eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // MusteriForm musteriForm = new MusteriForm(kullanici);
                        // this.Hide();
                        // musteriForm.ShowDialog();
                        // this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� rol� tan�ml� de�il!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Ba�ar�s�z giri�
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giri� yap�l�rken bir hata olu�tu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Tiklama(object sender, EventArgs e)
        {
            // Formu kapat
            DialogResult result = MessageBox.Show("Uygulamadan ��kmak istedi�inize emin misiniz?", "��k��",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblKayitOl_Tiklama(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kay�t formunu a� (hen�z uygulanmad�)
            MessageBox.Show("Kay�t formu yak�nda eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // KayitForm kayitForm = new KayitForm();
            // kayitForm.ShowDialog();
        }

        // TextBox'lardaki ipucu metinlerini y�netmek i�in yard�mc� metotlar
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox == txtKullaniciAdi && textBox.Text == "Kullan�c� ad�n�z� giriniz")
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
                else if (textBox == txtSifre && textBox.Text == "�ifrenizi giriniz")
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
                    textBox.Text = "Kullan�c� ad�n�z� giriniz";
                    textBox.ForeColor = System.Drawing.Color.DimGray;
                }
                else if (textBox == txtSifre && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.PasswordChar = '\0'; // Karakteri g�r�n�r yap
                    textBox.Text = "�ifrenizi giriniz";
                    textBox.ForeColor = System.Drawing.Color.DimGray;
                }
            }
        }
    }
}
