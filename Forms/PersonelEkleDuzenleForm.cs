using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class PersonelEkleDuzenleForm : Form
    {
        private readonly PersonelManager personelManager;
        private User personel;
        private bool duzenleModu;

        // Yeni personel ekleme için constructor
        public PersonelEkleDuzenleForm()
        {
            InitializeComponent();
            personelManager = new PersonelManager();
            personel = new User();
            duzenleModu = false;

            // Personel modeli için varsayılan değerler
            personel.RolID = 2; // Personel rol ID'si (Veritabanında Roller tablosunda kontrol edilmeli)
            personel.RolAdi = "Personel";
            personel.KayitTarihi = DateTime.Now;
            personel.Aktif = true;
        }

        // Mevcut personeli düzenlemek için constructor
        public PersonelEkleDuzenleForm(User mevcutPersonel)
        {
            InitializeComponent();
            personelManager = new PersonelManager();
            personel = mevcutPersonel;
            duzenleModu = true;
        }

        // Form yüklenirken 
        private void PersonelEkleDuzenleForm_Load(object sender, EventArgs e)
        {
            if (duzenleModu)
            {
                // Düzenleme modu için form ayarları
                lblBaslik.Text = "PERSONEL DÜZENLE";
                Text = "Personel Düzenle";
                panelSifre.Visible = false; // Düzenleme modunda şifre gizlenir

                // Personel bilgilerini form kontrollerine doldur
                txtKullaniciAdi.Text = personel.KullaniciAdi;
                txtAd.Text = personel.Ad;
                txtSoyad.Text = personel.Soyad;
                txtTCKN.Text = personel.TCKN;
                txtEmail.Text = personel.Email;
                txtTelefon.Text = personel.TelefonNumarasi;
                txtAdres.Text = personel.Adres;
                chkAktif.Checked = personel.Aktif;
            }
            else
            {
                // Ekleme modu için form ayarları
                lblBaslik.Text = "YENİ PERSONEL EKLE";
                Text = "Personel Ekle";
                panelSifre.Visible = true; // Ekleme modunda şifre gösterilir
            }
        }

        // Kaydet butonu tıklandığında
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Form verilerini kontrol et
            if (!FormVerileriniKontrolEt())
                return;

            // Personel nesnesini form verilerine göre güncelle
            personel.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            personel.Ad = txtAd.Text.Trim();
            personel.Soyad = txtSoyad.Text.Trim();
            personel.TCKN = txtTCKN.Text.Trim();
            personel.Email = txtEmail.Text.Trim();
            personel.TelefonNumarasi = txtTelefon.Text.Trim();
            personel.Adres = txtAdres.Text.Trim();
            personel.Aktif = chkAktif.Checked;

            try
            {
                bool islemBasarili = false;

                if (duzenleModu)
                {
                    // Personeli güncelle
                    islemBasarili = personelManager.PersonelGuncelle(personel);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Personel bilgileri başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Personel güncellenirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Şifre kontrolü
                    string sifre = txtSifre.Text.Trim();
                    if (string.IsNullOrEmpty(sifre) || sifre.Length < 6)
                    {
                        MessageBox.Show("Şifre en az 6 karakter olmalıdır.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSifre.Focus();
                        return;
                    }

                    // Yeni personel ekle
                    islemBasarili = personelManager.PersonelEkle(personel, sifre);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Yeni personel başarıyla eklendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Personel eklenirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form verilerini kontrol et
        private bool FormVerileriniKontrolEt()
        {
            // Kullanıcı adı kontrolü
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text.Trim()))
            {
                MessageBox.Show("Kullanıcı adı alanı boş olamaz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAdi.Focus();
                return false;
            }

            // Ad kontrolü
            if (string.IsNullOrEmpty(txtAd.Text.Trim()))
            {
                MessageBox.Show("Ad alanı boş olamaz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAd.Focus();
                return false;
            }

            // Soyad kontrolü
            if (string.IsNullOrEmpty(txtSoyad.Text.Trim()))
            {
                MessageBox.Show("Soyad alanı boş olamaz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoyad.Focus();
                return false;
            }

            // TCKN kontrolü (11 karakter ve sayısal olmalı)
            if (!string.IsNullOrEmpty(txtTCKN.Text.Trim()))
            {
                if (txtTCKN.Text.Trim().Length != 11 || !TumKarakterlerSayisalMi(txtTCKN.Text.Trim()))
                {
                    MessageBox.Show("TCKN 11 karakter uzunluğunda ve sayısal olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTCKN.Focus();
                    return false;
                }
            }

            // Email formatı kontrolü
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (!EmailGecerliMi(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return false;
                }
            }

            // Telefon numarası formatı kontrolü
            if (!string.IsNullOrEmpty(txtTelefon.Text.Trim()))
            {
                if (!TelefonGecerliMi(txtTelefon.Text.Trim()))
                {
                    MessageBox.Show("Geçerli bir telefon numarası giriniz. Örnek: 5XX XXX XXXX", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefon.Focus();
                    return false;
                }
            }

            return true;
        }

        // Tüm karakterlerin sayısal olup olmadığını kontrol eden yardımcı metot
        private bool TumKarakterlerSayisalMi(string metin)
        {
            foreach (char c in metin)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        // Email formatının geçerli olup olmadığını kontrol eden yardımcı metot
        private bool EmailGecerliMi(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Telefon numarası formatının geçerli olup olmadığını kontrol eden yardımcı metot
        private bool TelefonGecerliMi(string telefon)
        {
            // Boşlukları kaldır
            telefon = telefon.Replace(" ", "");

            // Sadece rakamları al
            string sadeceSayilar = Regex.Replace(telefon, @"[^\d]", "");

            // 10 veya 11 basamak olmalı (başında 0 veya ülke kodu olabilir)
            return sadeceSayilar.Length >= 10 && sadeceSayilar.Length <= 11;
        }

        // İptal butonu tıklandığında
        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}