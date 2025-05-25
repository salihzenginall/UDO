using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class MusteriEkleDuzenleForm : Form
    {
        private readonly MusteriManager musteriManager;
        private Musteri musteri;
        private bool duzenleModu;

        // Yeni müşteri ekleme için constructor
        public MusteriEkleDuzenleForm()
        {
            InitializeComponent();
            musteriManager = new MusteriManager();
            musteri = new Musteri();
            duzenleModu = false;

            // Müşteri modeli için varsayılan değerler
            musteri.Aktif = true;
            musteri.KayitTarihi = DateTime.Now;
            musteri.ToplamSeyahat = 0;
            musteri.ToplamHarcama = 0;
            musteri.SadakatPuani = 0;
            musteri.IndirimOrani = 0;

            // Müşteri numarası otomatik oluştur
            musteri.MusteriNo = "MST" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        // Mevcut müşteriyi düzenlemek için constructor
        public MusteriEkleDuzenleForm(Musteri mevcutMusteri)
        {
            InitializeComponent();
            musteriManager = new MusteriManager();
            musteri = mevcutMusteri;
            duzenleModu = true;
        }

        private void MusteriEkleDuzenleForm_Load(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'ları doldur
                UlkeleriYukle();

                // Başlık ve buton metinlerini ayarla
                if (duzenleModu)
                {
                    lblBaslik.Text = "MÜŞTERİ DÜZENLE";
                    Text = "Müşteri Düzenle";
                    panelSifre.Visible = false; // Düzenleme modunda şifre gizlenir

                    // Mevcut müşteri bilgilerini form kontrollerine doldur
                    MusteriBilgileriniDoldur();
                }
                else
                {
                    lblBaslik.Text = "YENİ MÜŞTERİ EKLE";
                    Text = "Müşteri Ekle";
                    panelSifre.Visible = true; // Ekleme modunda şifre gösterilir

                    // Varsayılan değerleri ayarla
                    chkAktif.Checked = true;
                    txtMusteriNo.Text = musteri.MusteriNo;
                    dtpDogumTarihi.Value = DateTime.Today.AddYears(-25); // 25 yaş varsayılan
                }

                // Müşteri numarası her zaman readonly
                txtMusteriNo.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken bir hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UlkeleriYukle()
        {
            try
            {
                DataTable ulkeler = musteriManager.UlkeleriGetir();

                cmbUyruk.ValueMember = "UlkeID";
                cmbUyruk.DisplayMember = "UlkeAdi";
                cmbUyruk.DataSource = ulkeler;
                cmbUyruk.SelectedIndex = -1;

                // Türkiye'yi varsayılan olarak seç (varsa)
                for (int i = 0; i < cmbUyruk.Items.Count; i++)
                {
                    DataRowView row = (DataRowView)cmbUyruk.Items[i];
                    if (row["UlkeAdi"].ToString().ToLower().Contains("türkiye"))
                    {
                        cmbUyruk.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ülke listesi yüklenirken hata: " + ex.Message);
            }
        }

        private void MusteriBilgileriniDoldur()
        {
            if (musteri != null)
            {
                txtMusteriNo.Text = musteri.MusteriNo;
                txtKullaniciAdi.Text = musteri.KullaniciAdi;
                txtAd.Text = musteri.Ad;
                txtSoyad.Text = musteri.Soyad;
                txtTCKN.Text = musteri.TCKN;
                txtEmail.Text = musteri.Email;
                txtTelefon.Text = musteri.TelefonNumarasi;
                txtAdres.Text = musteri.Adres;
                chkAktif.Checked = musteri.Aktif;

                if (musteri.DogumTarihi.HasValue)
                {
                    dtpDogumTarihi.Value = musteri.DogumTarihi.Value;
                    chkDogumTarihiVar.Checked = true;
                }
                else
                {
                    chkDogumTarihiVar.Checked = false;
                    dtpDogumTarihi.Enabled = false;
                }

                if (musteri.UyrukID.HasValue)
                {
                    cmbUyruk.SelectedValue = musteri.UyrukID.Value;
                }

                numIndirimOrani.Value = musteri.IndirimOrani;
                txtKayitKanali.Text = musteri.KayitKanali;

                // Sadece okunabilir alanlar
                txtToplamSeyahat.Text = musteri.ToplamSeyahat.ToString();
                txtToplamHarcama.Text = musteri.ToplamHarcama.ToString("N2");
                txtSadakatPuani.Text = musteri.SadakatPuani.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Form verilerini kontrol et
            if (!FormVerileriniKontrolEt())
                return;

            // Müşteri nesnesini form verilerine göre güncelle
            musteri.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            musteri.Ad = txtAd.Text.Trim();
            musteri.Soyad = txtSoyad.Text.Trim();
            musteri.TCKN = txtTCKN.Text.Trim();
            musteri.Email = txtEmail.Text.Trim();
            musteri.TelefonNumarasi = txtTelefon.Text.Trim();
            musteri.Adres = txtAdres.Text.Trim();
            musteri.Aktif = chkAktif.Checked;
            musteri.DogumTarihi = chkDogumTarihiVar.Checked ? dtpDogumTarihi.Value : (DateTime?)null;
            musteri.UyrukID = cmbUyruk.SelectedIndex > -1 ? (int?)cmbUyruk.SelectedValue : null;
            musteri.IndirimOrani = numIndirimOrani.Value;
            musteri.KayitKanali = txtKayitKanali.Text.Trim();

            try
            {
                bool islemBasarili = false;

                if (duzenleModu)
                {
                    // Müşteriyi güncelle
                    islemBasarili = musteriManager.MusteriGuncelle(musteri);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri güncellenirken bir hata oluştu.", "Hata",
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

                    // Yeni müşteri ekle
                    islemBasarili = musteriManager.MusteriEkle(musteri, sifre);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Yeni müşteri başarıyla eklendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri eklenirken bir hata oluştu.", "Hata",
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

            // TCKN kontrolü (eğer doldurulmuşsa)
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

            // Doğum tarihi kontrolü
            if (chkDogumTarihiVar.Checked)
            {
                if (dtpDogumTarihi.Value.Date >= DateTime.Today)
                {
                    MessageBox.Show("Doğum tarihi bugünden önce olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDogumTarihi.Focus();
                    return false;
                }

                // Çok yaşlı veya çok genç kontrolü
                int yas = DateTime.Today.Year - dtpDogumTarihi.Value.Year;
                if (yas < 16 || yas > 120)
                {
                    MessageBox.Show("Geçerli bir doğum tarihi giriniz. (16-120 yaş arası)", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDogumTarihi.Focus();
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkDogumTarihiVar_CheckedChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Enabled = chkDogumTarihiVar.Checked;
            if (chkDogumTarihiVar.Checked && dtpDogumTarihi.Value >= DateTime.Today)
            {
                dtpDogumTarihi.Value = DateTime.Today.AddYears(-25);
            }
        }

        private void btnMusteriNoOlustur_Click(object sender, EventArgs e)
        {
            // Yeni müşteri numarası oluştur
            txtMusteriNo.Text = "MST" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}