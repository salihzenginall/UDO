using System;
using System.Data;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class SeferEkleDuzenleForm : Form
    {
        private readonly SeferManager seferManager;
        private readonly LimanManager limanManager;
        private readonly DenizOtobusuManager denizOtobusuManager;
        private Sefer sefer;
        private User mevcutKullanici;
        private bool duzenleModu;

        // Yeni sefer ekleme için constructor
        public SeferEkleDuzenleForm(User kullanici)
        {
            InitializeComponent();
            seferManager = new SeferManager();
            limanManager = new LimanManager();
            denizOtobusuManager = new DenizOtobusuManager();
            mevcutKullanici = kullanici;
            duzenleModu = false;

            // Sefer modeli için varsayılan değerler
            sefer = new Sefer
            {
                KalkisTarihi = DateTime.Today,
                TahminiVarisTarihi = DateTime.Today,
                KalkisSaati = new TimeSpan(8, 0, 0),
                TahminiVarisSaati = new TimeSpan(10, 0, 0),
                DoluKoltukSayisi = 0,
                SeferDurumu = "Planlandi",
                OlusturanKullaniciID = mevcutKullanici.KullaniciID,
                OlusturmaTarihi = DateTime.Now
            };
        }

        // Mevcut seferi düzenlemek için constructor
        public SeferEkleDuzenleForm(User kullanici, int seferID)
        {
            InitializeComponent();
            seferManager = new SeferManager();
            limanManager = new LimanManager();
            denizOtobusuManager = new DenizOtobusuManager();
            mevcutKullanici = kullanici;
            duzenleModu = true;

            // Mevcut seferi getir
            sefer = seferManager.SeferDetayGetirById(seferID);
        }

        private void SeferEkleDuzenleForm_Load(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'ları doldur
                LimanlariYukle();
                DenizOtobusleriniYukle();

                // Başlık ve buton metinlerini ayarla
                if (duzenleModu)
                {
                    lblBaslik.Text = "SEFER DÜZENLE";
                    btnKaydet.Text = "Güncelle";
                    // Mevcut sefer bilgilerini form kontrollerine doldur
                    SeferBilgileriniDoldur();
                }
                else
                {
                    lblBaslik.Text = "YENİ SEFER EKLE";
                    btnKaydet.Text = "Kaydet";
                    // Varsayılan değerleri ayarla
                    dtpKalkisTarihi.Value = DateTime.Today;
                    dtpTahminiVarisTarihi.Value = DateTime.Today;
                    dtpKalkisSaati.Value = DateTime.Today.AddHours(8);
                    dtpTahminiVarisSaati.Value = DateTime.Today.AddHours(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken bir hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimanlariYukle()
        {
            // Kalkış limanları için ComboBox'ı doldur
            DataTable kalkisLimanlari = limanManager.LimanlariComboBoxIcinGetir();
            cmbKalkisLimani.ValueMember = "LimanID";
            cmbKalkisLimani.DisplayMember = "LimanAdi";
            cmbKalkisLimani.DataSource = kalkisLimanlari;
            cmbKalkisLimani.SelectedIndex = -1;

            // Varış limanları için ComboBox'ı doldur
            DataTable varisLimanlari = limanManager.LimanlariComboBoxIcinGetir();
            cmbVarisLimani.ValueMember = "LimanID";
            cmbVarisLimani.DisplayMember = "LimanAdi";
            cmbVarisLimani.DataSource = varisLimanlari;
            cmbVarisLimani.SelectedIndex = -1;
        }

        private void DenizOtobusleriniYukle()
        {
            // Deniz otobüsleri için ComboBox'ı doldur
            DataTable denizOtobusleri = denizOtobusuManager.DenizOtobusleriComboBoxIcinGetir();
            cmbDenizOtobusu.ValueMember = "DenizOtobusuID";
            cmbDenizOtobusu.DisplayMember = "DenizOtobusuAdi";
            cmbDenizOtobusu.DataSource = denizOtobusleri;
            cmbDenizOtobusu.SelectedIndex = -1;
        }

        private void SeferBilgileriniDoldur()
        {
            if (sefer != null)
            {
                cmbKalkisLimani.SelectedValue = sefer.KalkisLimaniID;
                cmbVarisLimani.SelectedValue = sefer.VarisLimaniID;
                cmbDenizOtobusu.SelectedValue = sefer.DenizOtobusuID;
                dtpKalkisTarihi.Value = sefer.KalkisTarihi;
                dtpTahminiVarisTarihi.Value = sefer.TahminiVarisTarihi;
                dtpKalkisSaati.Value = DateTime.Today.Add(sefer.KalkisSaati);
                dtpTahminiVarisSaati.Value = DateTime.Today.Add(sefer.TahminiVarisSaati);
                txtBiletFiyati.Text = sefer.BiletFiyati.ToString("N2");
                txtIndirimliBiletFiyati.Text = sefer.IndirimliBiletFiyati > 0 ? sefer.IndirimliBiletFiyati.ToString("N2") : "";
                txtAciklama.Text = sefer.Aciklama;
            }
        }

        private void cmbDenizOtobusu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen deniz otobüsünün kapasitesini göster
            if (cmbDenizOtobusu.SelectedIndex > -1)
            {
                DataRowView selectedRow = (DataRowView)cmbDenizOtobusu.SelectedItem;
                int kapasite = Convert.ToInt32(selectedRow["Kapasite"]);
                txtKapasite.Text = kapasite.ToString();
            }
            else
            {
                txtKapasite.Text = "";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Form verilerini doğrula
                if (!FormVerileriniDogrula())
                    return;

                // Sefer nesnesini form değerleriyle doldur
                SeferNesnesiniFormVerileriyleDoldur();

                bool islemBasarili = false;

                if (duzenleModu)
                {
                    // Sefer güncelleme
                    islemBasarili = seferManager.SeferGuncelle(sefer);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Sefer bilgileri başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Sefer güncellenirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Yeni sefer ekleme
                    islemBasarili = seferManager.SeferEkle(sefer);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Yeni sefer başarıyla eklendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Sefer eklenirken bir hata oluştu.", "Hata",
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

        private bool FormVerileriniDogrula()
        {
            // Tüm alanları kontrol et
            if (cmbKalkisLimani.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kalkış limanını seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbKalkisLimani.Focus();
                return false;
            }

            if (cmbVarisLimani.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen varış limanını seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbVarisLimani.Focus();
                return false;
            }

            if (cmbKalkisLimani.SelectedValue.Equals(cmbVarisLimani.SelectedValue))
            {
                MessageBox.Show("Kalkış ve varış limanları aynı olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbVarisLimani.Focus();
                return false;
            }

            if (cmbDenizOtobusu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen deniz otobüsünü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDenizOtobusu.Focus();
                return false;
            }

            // Tarih ve saat kontrolleri
            DateTime kalkisTarihi = dtpKalkisTarihi.Value.Date;
            DateTime varisTarihi = dtpTahminiVarisTarihi.Value.Date;
            TimeSpan kalkisSaati = dtpKalkisSaati.Value.TimeOfDay;
            TimeSpan varisSaati = dtpTahminiVarisSaati.Value.TimeOfDay;

            // Sefer tarihi bugünden önce olamaz (düzenleme modu hariç)
            if (!duzenleModu && kalkisTarihi.Date < DateTime.Today)
            {
                MessageBox.Show("Sefer tarihi bugünden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpKalkisTarihi.Focus();
                return false;
            }

            // Bilet fiyatı kontrolü
            decimal biletFiyati;
            if (!decimal.TryParse(txtBiletFiyati.Text, out biletFiyati) || biletFiyati <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir bilet fiyatı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBiletFiyati.Focus();
                return false;
            }

            // İndirimli bilet fiyatı kontrolü (eğer doldurulmuşsa)
            if (!string.IsNullOrEmpty(txtIndirimliBiletFiyati.Text))
            {
                decimal indirimliBiletFiyati;
                if (!decimal.TryParse(txtIndirimliBiletFiyati.Text, out indirimliBiletFiyati) || indirimliBiletFiyati <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir indirimli bilet fiyatı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIndirimliBiletFiyati.Focus();
                    return false;
                }

                if (indirimliBiletFiyati >= biletFiyati)
                {
                    MessageBox.Show("İndirimli bilet fiyatı, normal bilet fiyatından düşük olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIndirimliBiletFiyati.Focus();
                    return false;
                }
            }

            return true;
        }

        private void SeferNesnesiniFormVerileriyleDoldur()
        {
            // Form verilerini sefer nesnesine aktar
            sefer.KalkisLimaniID = Convert.ToInt32(cmbKalkisLimani.SelectedValue);
            sefer.KalkisLimaniAdi = cmbKalkisLimani.Text;
            sefer.VarisLimaniID = Convert.ToInt32(cmbVarisLimani.SelectedValue);
            sefer.VarisLimaniAdi = cmbVarisLimani.Text;
            sefer.DenizOtobusuID = Convert.ToInt32(cmbDenizOtobusu.SelectedValue);
            sefer.DenizOtobusuAdi = cmbDenizOtobusu.Text;
            sefer.KalkisTarihi = dtpKalkisTarihi.Value.Date;
            sefer.KalkisSaati = dtpKalkisSaati.Value.TimeOfDay;
            sefer.TahminiVarisTarihi = dtpTahminiVarisTarihi.Value.Date;
            sefer.TahminiVarisSaati = dtpTahminiVarisSaati.Value.TimeOfDay;
            sefer.KapasiteYolcu = Convert.ToInt32(txtKapasite.Text);
            sefer.BiletFiyati = Convert.ToDecimal(txtBiletFiyati.Text);
            sefer.IndirimliBiletFiyati = string.IsNullOrEmpty(txtIndirimliBiletFiyati.Text) ? 0 : Convert.ToDecimal(txtIndirimliBiletFiyati.Text);
            sefer.Aciklama = txtAciklama.Text;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}