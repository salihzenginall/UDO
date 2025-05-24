using System;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class DenizOtobusuEkleDuzenleForm : Form
    {
        private readonly DenizOtobusuManager denizOtobusuManager;
        private DenizOtobusu denizOtobusu;
        private bool duzenleModu;

        // Yeni deniz otobüsü ekleme için constructor
        public DenizOtobusuEkleDuzenleForm()
        {
            InitializeComponent();
            denizOtobusuManager = new DenizOtobusuManager();
            denizOtobusu = new DenizOtobusu();
            duzenleModu = false;

            // Deniz otobüsü için varsayılan değerler
            denizOtobusu.Aktif = true;
            denizOtobusu.UretimYili = DateTime.Now.Year;
            denizOtobusu.KayitTarihi = DateTime.Now;
        }

        // Mevcut deniz otobüsünü düzenlemek için constructor
        public DenizOtobusuEkleDuzenleForm(DenizOtobusu mevcutDenizOtobusu)
        {
            InitializeComponent();
            denizOtobusuManager = new DenizOtobusuManager();
            denizOtobusu = mevcutDenizOtobusu;
            duzenleModu = true;
        }

        private void DenizOtobusuEkleDuzenleForm_Load(object sender, EventArgs e)
        {
            if (duzenleModu)
            {
                // Düzenleme modu için form ayarları
                lblBaslik.Text = "DENİZ OTOBÜSÜ DÜZENLE";
                Text = "Deniz Otobüsü Düzenle";

                // Deniz otobüsü bilgilerini form kontrollerine doldur
                DenizOtobusuBilgileriniDoldur();
            }
            else
            {
                // Ekleme modu için form ayarları
                lblBaslik.Text = "YENİ DENİZ OTOBÜSÜ EKLE";
                Text = "Deniz Otobüsü Ekle";

                // Varsayılan değerleri ayarla
                chkAktif.Checked = true;
                numUretimYili.Value = DateTime.Now.Year;
            }

            // Üretim yılı için minimum ve maksimum değerleri ayarla
            numUretimYili.Minimum = 1990;
            numUretimYili.Maximum = DateTime.Now.Year + 2;
        }

        private void DenizOtobusuBilgileriniDoldur()
        {
            if (denizOtobusu != null)
            {
                txtDenizOtobusuAdi.Text = denizOtobusu.DenizOtobusuAdi;
                txtModel.Text = denizOtobusu.Model;
                txtMarka.Text = denizOtobusu.Marka;
                txtSeriNumarasi.Text = denizOtobusu.SeriNumarasi;
                numKapasite.Value = denizOtobusu.Kapasite;
                numUretimYili.Value = denizOtobusu.UretimYili;
                numYakitKapasitesi.Value = denizOtobusu.YakitKapasitesi;
                txtMotorTipi.Text = denizOtobusu.MotorTipi;
                numMaxHiz.Value = denizOtobusu.MaxHiz;
                chkAktif.Checked = denizOtobusu.Aktif;

                if (denizOtobusu.SonBakimTarihi.HasValue)
                {
                    dtpSonBakimTarihi.Value = denizOtobusu.SonBakimTarihi.Value;
                    chkBakimTarihiVar.Checked = true;
                }
                else
                {
                    chkBakimTarihiVar.Checked = false;
                    dtpSonBakimTarihi.Enabled = false;
                }

                if (denizOtobusu.SonMuayeneTarihi.HasValue)
                {
                    dtpSonMuayeneTarihi.Value = denizOtobusu.SonMuayeneTarihi.Value;
                    chkMuayeneTarihiVar.Checked = true;
                }
                else
                {
                    chkMuayeneTarihiVar.Checked = false;
                    dtpSonMuayeneTarihi.Enabled = false;
                }

                txtAciklama.Text = denizOtobusu.Aciklama;
                txtDurumNotu.Text = denizOtobusu.DurumNotu;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Form verilerini kontrol et
            if (!FormVerileriniKontrolEt())
                return;

            // Deniz otobüsü nesnesini form verilerine göre güncelle
            denizOtobusu.DenizOtobusuAdi = txtDenizOtobusuAdi.Text.Trim();
            denizOtobusu.Model = txtModel.Text.Trim();
            denizOtobusu.Marka = txtMarka.Text.Trim();
            denizOtobusu.SeriNumarasi = txtSeriNumarasi.Text.Trim();
            denizOtobusu.Kapasite = (int)numKapasite.Value;
            denizOtobusu.UretimYili = (int)numUretimYili.Value;
            denizOtobusu.YakitKapasitesi = numYakitKapasitesi.Value;
            denizOtobusu.MotorTipi = txtMotorTipi.Text.Trim();
            denizOtobusu.MaxHiz = (int)numMaxHiz.Value;
            denizOtobusu.Aktif = chkAktif.Checked;
            denizOtobusu.SonBakimTarihi = chkBakimTarihiVar.Checked ? dtpSonBakimTarihi.Value : (DateTime?)null;
            denizOtobusu.SonMuayeneTarihi = chkMuayeneTarihiVar.Checked ? dtpSonMuayeneTarihi.Value : (DateTime?)null;
            denizOtobusu.Aciklama = txtAciklama.Text.Trim();
            denizOtobusu.DurumNotu = txtDurumNotu.Text.Trim();

            try
            {
                bool islemBasarili = false;

                if (duzenleModu)
                {
                    // Deniz otobüsünü güncelle
                    islemBasarili = denizOtobusuManager.DenizOtobusuGuncelle(denizOtobusu);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Deniz otobüsü bilgileri başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Deniz otobüsü güncellenirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Yeni deniz otobüsü ekle
                    islemBasarili = denizOtobusuManager.DenizOtobusuEkle(denizOtobusu);

                    if (islemBasarili)
                    {
                        MessageBox.Show("Yeni deniz otobüsü başarıyla eklendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Deniz otobüsü eklenirken bir hata oluştu.", "Hata",
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
            // Deniz otobüsü adı kontrolü
            if (string.IsNullOrEmpty(txtDenizOtobusuAdi.Text.Trim()))
            {
                MessageBox.Show("Deniz otobüsü adı alanı boş olamaz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDenizOtobusuAdi.Focus();
                return false;
            }

            // Kapasite kontrolü
            if (numKapasite.Value <= 0)
            {
                MessageBox.Show("Kapasite 0'dan büyük olmalıdır.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKapasite.Focus();
                return false;
            }

            // Üretim yılı kontrolü
            if (numUretimYili.Value > DateTime.Now.Year + 2)
            {
                MessageBox.Show("Üretim yılı gelecek yıldan fazla olamaz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                numUretimYili.Focus();
                return false;
            }

            // Seri numarası benzersizlik kontrolü (opsiyonel)
            if (!string.IsNullOrEmpty(txtSeriNumarasi.Text.Trim()))
            {
                // Bu kontrolü veritabanı seviyesinde yapmak daha iyi olabilir
                // Şimdilik basit uzunluk kontrolü yapıyoruz
                if (txtSeriNumarasi.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Seri numarası en az 3 karakter olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSeriNumarasi.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkBakimTarihiVar_CheckedChanged(object sender, EventArgs e)
        {
            dtpSonBakimTarihi.Enabled = chkBakimTarihiVar.Checked;
            if (chkBakimTarihiVar.Checked)
                dtpSonBakimTarihi.Value = DateTime.Now;
        }

        private void chkMuayeneTarihiVar_CheckedChanged(object sender, EventArgs e)
        {
            dtpSonMuayeneTarihi.Enabled = chkMuayeneTarihiVar.Checked;
            if (chkMuayeneTarihiVar.Checked)
                dtpSonMuayeneTarihi.Value = DateTime.Now;
        }
    }

    // Bu formun Designer.cs dosyası da gerekli
    // Aşağıdaki kontrolleri içermeli:
    // - Panel yapıları (üst, alt, içerik)
    // - TextBox'lar (ad, model, marka, seri no, motor tipi, açıklama, durum notu)
    // - NumericUpDown'lar (kapasite, üretim yılı, yakıt kapasitesi, max hız)
    // - DateTimePicker'lar (bakım ve muayene tarihleri)
    // - CheckBox'lar (aktif, bakım tarihi var, muayene tarihi var)
    // - Butonlar (kaydet, iptal)
}