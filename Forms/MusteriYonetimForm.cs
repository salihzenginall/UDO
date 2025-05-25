using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class MusteriYonetimForm : Form
    {
        private readonly MusteriManager musteriManager;
        private Musteri seciliMusteri;

        public MusteriYonetimForm()
        {
            InitializeComponent();
            musteriManager = new MusteriManager();
            seciliMusteri = null;
        }

        private void MusteriYonetimForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Form yüklendiğinde müşteri listesini getir
                MusteriListesiniYukle();

                // Butonların başlangıç durumlarını ayarla
                ButonDurumlariniAyarla(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusteriListesiniYukle()
        {
            try
            {
                DataTable musterilerTablosu = musteriManager.TumMusterileriGetir();

                // DataGridView'a verileri yükle
                dataGridViewMusteriler.AutoGenerateColumns = false;
                dataGridViewMusteriler.DataSource = musterilerTablosu;

                // Hesaplanmış sütunları doldur
                HesaplanmisSutunlariDoldur(musterilerTablosu);

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Toplam müşteri sayısı: {musterilerTablosu.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri listesi yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HesaplanmisSutunlariDoldur(DataTable tablosu)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewMusteriler.Rows)
                {
                    if (row.IsNewRow) continue;

                    int index = row.Index;
                    if (index < tablosu.Rows.Count)
                    {
                        DataRow dataRow = tablosu.Rows[index];

                        // Tam ad
                        string ad = dataRow["Ad"] != DBNull.Value ? dataRow["Ad"].ToString() : "";
                        string soyad = dataRow["Soyad"] != DBNull.Value ? dataRow["Soyad"].ToString() : "";
                        row.Cells["TamAd"].Value = ad + " " + soyad;

                        // Yaş hesaplama
                        if (dataRow["DogumTarihi"] != DBNull.Value)
                        {
                            DateTime dogumTarihi = Convert.ToDateTime(dataRow["DogumTarihi"]);
                            int yas = DateTime.Now.Year - dogumTarihi.Year;
                            if (DateTime.Now.DayOfYear < dogumTarihi.DayOfYear) yas--;
                            row.Cells["Yas"].Value = yas;
                        }
                        else
                        {
                            row.Cells["Yas"].Value = "-";
                        }

                        // Sadakat seviyesi
                        int sadakatPuani = dataRow["SadakatPuani"] != DBNull.Value ? Convert.ToInt32(dataRow["SadakatPuani"]) : 0;
                        string seviye = "";
                        if (sadakatPuani >= 1000) seviye = "Altın";
                        else if (sadakatPuani >= 500) seviye = "Gümüş";
                        else if (sadakatPuani >= 100) seviye = "Bronz";
                        else seviye = "Standart";
                        row.Cells["SadakatSeviyesi"].Value = seviye;

                        // VIP durum
                        int toplamSeyahat = dataRow["ToplamSeyahat"] != DBNull.Value ? Convert.ToInt32(dataRow["ToplamSeyahat"]) : 0;
                        decimal toplamHarcama = dataRow["ToplamHarcama"] != DBNull.Value ? Convert.ToDecimal(dataRow["ToplamHarcama"]) : 0;
                        bool vipMi = toplamSeyahat >= 10 || toplamHarcama >= 1000;
                        row.Cells["VipDurum"].Value = vipMi ? "VIP" : "Normal";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplanmış sütunlar doldurulurken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Arama işlemi
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                MusteriListesiniYukle();
                return;
            }

            try
            {
                DataTable sonucTablosu = musteriManager.MusteriAra(aramaMetni);

                // DataGridView'a verileri yükle ve hesaplanmış sütunları doldur
                dataGridViewMusteriler.AutoGenerateColumns = false;
                dataGridViewMusteriler.DataSource = sonucTablosu;
                HesaplanmisSutunlariDoldur(sonucTablosu);

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Arama sonucu: {sonucTablosu.Rows.Count} müşteri bulundu.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tüm müşterileri göster
        private void rdTumMusteriler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTumMusteriler.Checked)
            {
                MusteriListesiniYukle();
            }
        }

        // Aktif müşterileri göster
        private void rdAktifMusteriler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAktifMusteriler.Checked)
            {
                try
                {
                    DataTable aktifMusteriler = musteriManager.MusterileriDurumaGoreFiltrele(true);
                    dataGridViewMusteriler.AutoGenerateColumns = false;
                    dataGridViewMusteriler.DataSource = aktifMusteriler;
                    HesaplanmisSutunlariDoldur(aktifMusteriler);
                    lblBilgi.Text = $"Aktif müşteri sayısı: {aktifMusteriler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aktif müşteriler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Pasif müşterileri göster
        private void rdPasifMusteriler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPasifMusteriler.Checked)
            {
                try
                {
                    DataTable pasifMusteriler = musteriManager.MusterileriDurumaGoreFiltrele(false);
                    dataGridViewMusteriler.AutoGenerateColumns = false;
                    dataGridViewMusteriler.DataSource = pasifMusteriler;
                    HesaplanmisSutunlariDoldur(pasifMusteriler);
                    lblBilgi.Text = $"Pasif müşteri sayısı: {pasifMusteriler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pasif müşteriler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // VIP müşterileri göster
        private void rdVipMusteriler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdVipMusteriler.Checked)
            {
                try
                {
                    DataTable vipMusteriler = musteriManager.VipMusterileriGetir();
                    dataGridViewMusteriler.AutoGenerateColumns = false;
                    dataGridViewMusteriler.DataSource = vipMusteriler;
                    HesaplanmisSutunlariDoldur(vipMusteriler);
                    lblBilgi.Text = $"VIP müşteri sayısı: {vipMusteriler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("VIP müşteriler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Yenile butonu
        private void btnYenile_Click(object sender, EventArgs e)
        {
            MusteriListesiniYukle();
            txtArama.Clear();
            rdTumMusteriler.Checked = true;
        }

        // DataGridView'da satır seçildiğinde
        private void dataGridViewMusteriler_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMusteriler.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewMusteriler.SelectedRows[0];
                    if (selectedRow.Cells["MusteriID"].Value != null)
                    {
                        int musteriId = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);

                        // Seçili müşteriyi yükle
                        seciliMusteri = musteriManager.MusteriGetirById(musteriId);

                        // Butonları aktifleştir
                        ButonDurumlariniAyarla(true);

                        // Durum değiştir butonunun metnini güncelle
                        GuncelleButonDurumMetni();
                    }
                }
                else
                {
                    seciliMusteri = null;
                    ButonDurumlariniAyarla(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satır seçimi sırasında hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DataGridView hücre formatlanırken
        private void dataGridViewMusteriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Durum sütunu için renklendirme
                if (e.ColumnIndex == dataGridViewMusteriler.Columns["Durum"].Index && e.Value != null)
                {
                    bool aktifMi = Convert.ToBoolean(e.Value);

                    if (aktifMi)
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.SelectionForeColor = Color.Green;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                }

                // VIP durum renklendirmesi
                if (e.ColumnIndex == dataGridViewMusteriler.Columns["VipDurum"].Index && e.Value != null)
                {
                    string vipDurum = e.Value.ToString();
                    if (vipDurum == "VIP")
                    {
                        e.CellStyle.ForeColor = Color.Gold;
                        e.CellStyle.SelectionForeColor = Color.Gold;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }

                // Sadakat seviyesi renklendirmesi
                if (e.ColumnIndex == dataGridViewMusteriler.Columns["SadakatSeviyesi"].Index && e.Value != null)
                {
                    string seviye = e.Value.ToString();
                    switch (seviye)
                    {
                        case "Altın":
                            e.CellStyle.ForeColor = Color.Gold;
                            break;
                        case "Gümüş":
                            e.CellStyle.ForeColor = Color.Silver;
                            break;
                        case "Bronz":
                            e.CellStyle.ForeColor = Color.Peru;
                            break;
                        default:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                    }
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }

                // Tarih formatı
                if ((e.ColumnIndex == dataGridViewMusteriler.Columns["KayitTarihi"].Index) &&
                    e.Value != null && e.Value != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(e.Value);
                    e.Value = tarih.ToString("dd.MM.yyyy");
                    e.FormattingApplied = true;
                }

                // Para formatı
                if (e.ColumnIndex == dataGridViewMusteriler.Columns["ToplamHarcama"].Index && e.Value != null)
                {
                    decimal tutar = Convert.ToDecimal(e.Value);
                    e.Value = string.Format("{0:N2} ₺", tutar);
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda sadece log tutabiliriz, kullanıcıya göstermeyiz
                System.Diagnostics.Debug.WriteLine("Formatla hatası: " + ex.Message);
            }
        }

        // Butonların durumlarını ayarla
        private void ButonDurumlariniAyarla(bool aktifMi)
        {
            btnDuzenle.Enabled = aktifMi;
            btnSil.Enabled = aktifMi;
            btnDurumDegistir.Enabled = aktifMi;
            btnDetay.Enabled = aktifMi;
        }

        // Durum değiştir butonunun metnini güncelle
        private void GuncelleButonDurumMetni()
        {
            if (seciliMusteri != null)
            {
                btnDurumDegistir.Text = seciliMusteri.Aktif ? "Pasif Yap" : "Aktif Yap";
            }
        }

        // Müşteri ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (MusteriEkleDuzenleForm musteriEkleForm = new MusteriEkleDuzenleForm())
                {
                    DialogResult sonuc = musteriEkleForm.ShowDialog(this);

                    if (sonuc == DialogResult.OK)
                    {
                        MusteriListesiniYukle(); // Listeyi yenile
                        MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri ekleme formu açılırken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Müşteri düzenle
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Lütfen düzenlemek için bir müşteri seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MusteriEkleDuzenleForm musteriDuzenleForm = new MusteriEkleDuzenleForm(seciliMusteri))
                {
                    DialogResult sonuc = musteriDuzenleForm.ShowDialog(this);

                    if (sonuc == DialogResult.OK)
                    {
                        MusteriListesiniYukle(); // Listeyi yenile
                        MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri düzenleme formu açılırken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Müşteri sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                $"{seciliMusteri.Ad} {seciliMusteri.Soyad} adlı müşteriyi silmek istediğinize emin misiniz?\n\n" +
                "Not: Müşteri tamamen silinmeyecek, pasif duruma alınacaktır.",
                "Müşteri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    // Müşteriyi pasif yap (tamamen silmek yerine)
                    bool basarili = musteriManager.MusteriDurumDegistir(seciliMusteri.KullaniciID, false);

                    if (basarili)
                    {
                        MessageBox.Show("Müşteri başarıyla pasif duruma alındı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusteriListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Müşteri pasif duruma alınırken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Müşteri durumunu değiştir
        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Lütfen durumunu değiştirmek için bir müşteri seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string durumMetni = seciliMusteri.Aktif ? "pasif" : "aktif";

            DialogResult sonuc = MessageBox.Show(
                $"{seciliMusteri.Ad} {seciliMusteri.Soyad} adlı müşteriyi {durumMetni} duruma almak istediğinize emin misiniz?",
                "Durum Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    bool yeniDurum = !seciliMusteri.Aktif;
                    bool basarili = musteriManager.MusteriDurumDegistir(seciliMusteri.KullaniciID, yeniDurum);

                    if (basarili)
                    {
                        MessageBox.Show($"Müşteri başarıyla {durumMetni} duruma alındı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusteriListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Müşteri durumu değiştirilirken bir hata oluştu.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Müşteri detay
        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Lütfen detaylarını görmek için bir müşteri seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Müşteri detay bilgilerini göster
                string detayMesaj = $"Müşteri Detayları:\n\n" +
                                  $"Müşteri No: {seciliMusteri.MusteriNo}\n" +
                                  $"Ad Soyad: {seciliMusteri.TamAd()}\n" +
                                  $"TCKN: {seciliMusteri.TCKN ?? "Belirtilmemiş"}\n" +
                                  $"Email: {seciliMusteri.Email ?? "Belirtilmemiş"}\n" +
                                  $"Telefon: {seciliMusteri.TelefonNumarasi ?? "Belirtilmemiş"}\n" +
                                  $"Yaş: {seciliMusteri.Yas()}\n" +
                                  $"Uyruk: {seciliMusteri.UyrukAdi ?? "Belirtilmemiş"}\n" +
                                  $"Toplam Seyahat: {seciliMusteri.ToplamSeyahat}\n" +
                                  $"Toplam Harcama: {seciliMusteri.ToplamHarcama:N2} ₺\n" +
                                  $"Sadakat Puanı: {seciliMusteri.SadakatPuani}\n" +
                                  $"Sadakat Seviyesi: {seciliMusteri.SadakatSeviyesi()}\n" +
                                  $"İndirim Oranı: %{seciliMusteri.IndirimOrani}\n" +
                                  $"Kayıt Kanalı: {seciliMusteri.KayitKanali ?? "Belirtilmemiş"}\n" +
                                  $"Kayıt Tarihi: {seciliMusteri.KayitTarihi:dd.MM.yyyy}\n" +
                                  $"VIP Müşteri: {(seciliMusteri.VipMusteriMi() ? "Evet" : "Hayır")}\n" +
                                  $"Durum: {seciliMusteri.MusteriDurum()}";

                MessageBox.Show(detayMesaj, "Müşteri Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri detayları gösterilirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}