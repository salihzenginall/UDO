using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class DenizOtobusuYonetimForm : Form
    {
        private readonly DenizOtobusuManager denizOtobusuManager;
        private DenizOtobusu seciliDenizOtobusu;

        public DenizOtobusuYonetimForm()
        {
            InitializeComponent();
            denizOtobusuManager = new DenizOtobusuManager();
            seciliDenizOtobusu = null;
        }

        private void DenizOtobusuYonetimForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde deniz otobüsü listesini getir
            DenizOtobusuListesiniYukle();
            // Butonların başlangıç durumlarını ayarla
            ButonDurumlariniAyarla(false);
        }

        private void DenizOtobusuListesiniYukle()
        {
            try
            {
                DataTable denizOtobusleriTablosu = denizOtobusuManager.TumDenizOtobusleriniGetir();

                // DataGridView'a verileri yükle
                dataGridViewDenizOtobusleri.AutoGenerateColumns = false;
                dataGridViewDenizOtobusleri.DataSource = denizOtobusleriTablosu;

                // Yaş ve Bakım Durumu sütunlarını hesapla
                foreach (DataGridViewRow row in dataGridViewDenizOtobusleri.Rows)
                {
                    int index = row.Index;
                    if (index < denizOtobusleriTablosu.Rows.Count)
                    {
                        DataRow dataRow = denizOtobusleriTablosu.Rows[index];

                        // Yaş hesaplama
                        int uretimYili = Convert.ToInt32(dataRow["UretimYili"]);
                        int yas = DateTime.Now.Year - uretimYili;
                        row.Cells["Yas"].Value = yas;

                        // Bakım durumu hesaplama
                        DateTime? sonBakimTarihi = dataRow["SonBakimTarihi"] != DBNull.Value ?
                            Convert.ToDateTime(dataRow["SonBakimTarihi"]) : (DateTime?)null;

                        string bakimDurumu = BakimDurumuHesapla(sonBakimTarihi);
                        row.Cells["BakimDurumu"].Value = bakimDurumu;
                    }
                }

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Toplam deniz otobüsü sayısı: {denizOtobusleriTablosu.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deniz otobüsü listesi yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BakimDurumuHesapla(DateTime? sonBakimTarihi)
        {
            if (sonBakimTarihi == null)
                return "Bakım Gerekli";

            int gecenAylar = (DateTime.Now.Year - sonBakimTarihi.Value.Year) * 12 +
                            DateTime.Now.Month - sonBakimTarihi.Value.Month;

            if (gecenAylar >= 6)
                return "Bakım Zamanı";
            else if (gecenAylar >= 5)
                return "Yaklaşıyor";
            else
                return "Güncel";
        }

        // Butonların durumlarını ayarla
        private void ButonDurumlariniAyarla(bool aktifMi)
        {
            btnDuzenle.Enabled = aktifMi;
            btnSil.Enabled = aktifMi;
            btnDurumDegistir.Enabled = aktifMi;
            btnBakimYap.Enabled = aktifMi;
        }

        // Arama işlemi
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                DenizOtobusuListesiniYukle();
                return;
            }

            try
            {
                DataTable sonucTablosu = denizOtobusuManager.DenizOtobusuAra(aramaMetni);

                // DataGridView'a verileri yükle
                dataGridViewDenizOtobusleri.AutoGenerateColumns = false;
                dataGridViewDenizOtobusleri.DataSource = sonucTablosu;

                // Yaş ve Bakım Durumu sütunlarını hesapla
                HesaplanmisSutunlariDoldur(sonucTablosu);

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Arama sonucu: {sonucTablosu.Rows.Count} deniz otobüsü bulundu.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HesaplanmisSutunlariDoldur(DataTable tablosu)
        {
            foreach (DataGridViewRow row in dataGridViewDenizOtobusleri.Rows)
            {
                int index = row.Index;
                if (index < tablosu.Rows.Count)
                {
                    DataRow dataRow = tablosu.Rows[index];

                    // Yaş hesaplama
                    int uretimYili = Convert.ToInt32(dataRow["UretimYili"]);
                    int yas = DateTime.Now.Year - uretimYili;
                    row.Cells["Yas"].Value = yas;

                    // Bakım durumu hesaplama
                    DateTime? sonBakimTarihi = dataRow["SonBakimTarihi"] != DBNull.Value ?
                        Convert.ToDateTime(dataRow["SonBakimTarihi"]) : (DateTime?)null;

                    string bakimDurumu = BakimDurumuHesapla(sonBakimTarihi);
                    row.Cells["BakimDurumu"].Value = bakimDurumu;
                }
            }
        }

        // Tüm deniz otobüslerini göster
        private void rdTumDenizOtobusleri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTumDenizOtobusleri.Checked)
            {
                DenizOtobusuListesiniYukle();
            }
        }

        // Aktif deniz otobüslerini göster
        private void rdAktifDenizOtobusleri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAktifDenizOtobusleri.Checked)
            {
                try
                {
                    DataTable aktifDenizOtobusleri = denizOtobusuManager.DenizOtobusleriniDurumaGoreFiltrele(true);

                    dataGridViewDenizOtobusleri.AutoGenerateColumns = false;
                    dataGridViewDenizOtobusleri.DataSource = aktifDenizOtobusleri;

                    HesaplanmisSutunlariDoldur(aktifDenizOtobusleri);

                    lblBilgi.Text = $"Aktif deniz otobüsü sayısı: {aktifDenizOtobusleri.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aktif deniz otobüsleri listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Pasif deniz otobüslerini göster
        private void rdPasifDenizOtobusleri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPasifDenizOtobusleri.Checked)
            {
                try
                {
                    DataTable pasifDenizOtobusleri = denizOtobusuManager.DenizOtobusleriniDurumaGoreFiltrele(false);

                    dataGridViewDenizOtobusleri.AutoGenerateColumns = false;
                    dataGridViewDenizOtobusleri.DataSource = pasifDenizOtobusleri;

                    HesaplanmisSutunlariDoldur(pasifDenizOtobusleri);

                    lblBilgi.Text = $"Pasif deniz otobüsü sayısı: {pasifDenizOtobusleri.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pasif deniz otobüsleri listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Bakım zamanı gelenleri göster
        private void rdBakimZamani_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBakimZamani.Checked)
            {
                try
                {
                    DataTable bakimZamaniGelenler = denizOtobusuManager.BakimZamaniGelenler();

                    dataGridViewDenizOtobusleri.AutoGenerateColumns = false;
                    dataGridViewDenizOtobusleri.DataSource = bakimZamaniGelenler;

                    HesaplanmisSutunlariDoldur(bakimZamaniGelenler);

                    lblBilgi.Text = $"Bakım zamanı gelen deniz otobüsü sayısı: {bakimZamaniGelenler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bakım zamanı gelenler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Yenile butonu
        private void btnYenile_Click(object sender, EventArgs e)
        {
            DenizOtobusuListesiniYukle();
            txtArama.Clear();
            rdTumDenizOtobusleri.Checked = true;
        }

        // DataGridView'da satır seçildiğinde
        private void dataGridViewDenizOtobusleri_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDenizOtobusleri.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewDenizOtobusleri.SelectedRows[0];
                int denizOtobusuId = Convert.ToInt32(selectedRow.Cells["DenizOtobusuID"].Value);

                // Seçili deniz otobüsünü yükle
                seciliDenizOtobusu = denizOtobusuManager.DenizOtobusuGetirById(denizOtobusuId);

                // Butonları aktifleştir
                ButonDurumlariniAyarla(true);

                // Durum değiştir butonunun metnini güncelle
                GuncelleButonDurumMetni();
            }
            else
            {
                seciliDenizOtobusu = null;
                ButonDurumlariniAyarla(false);
            }
        }

        // Durum değiştir butonunun metnini güncelle
        private void GuncelleButonDurumMetni()
        {
            if (seciliDenizOtobusu != null)
            {
                btnDurumDegistir.Text = seciliDenizOtobusu.Aktif ? "Pasif Yap" : "Aktif Yap";
            }
        }

        // DataGridView hücre formatlanırken
        private void dataGridViewDenizOtobusleri_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Durum sütunu için renklendirme
            if (e.ColumnIndex == dataGridViewDenizOtobusleri.Columns["Durum"].Index && e.Value != null)
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

            // Bakım durumu sütunu için renklendirme
            if (e.ColumnIndex == dataGridViewDenizOtobusleri.Columns["BakimDurumu"].Index && e.Value != null)
            {
                string durum = e.Value.ToString();

                switch (durum)
                {
                    case "Güncel":
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.SelectionForeColor = Color.Green;
                        break;
                    case "Yaklaşıyor":
                        e.CellStyle.ForeColor = Color.Orange;
                        e.CellStyle.SelectionForeColor = Color.Orange;
                        break;
                    case "Bakım Zamanı":
                    case "Bakım Gerekli":
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                        break;
                }
            }

            // Yaş sütunu için renklendirme
            if (e.ColumnIndex == dataGridViewDenizOtobusleri.Columns["Yas"].Index && e.Value != null)
            {
                int yas = Convert.ToInt32(e.Value);

                if (yas <= 5)
                {
                    e.CellStyle.ForeColor = Color.Green; // Yeni
                }
                else if (yas <= 15)
                {
                    e.CellStyle.ForeColor = Color.Orange; // Orta
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red; // Eski
                }
            }

            // Tarih formatı
            if ((e.ColumnIndex == dataGridViewDenizOtobusleri.Columns["SonBakimTarihi"].Index ||
                e.ColumnIndex == dataGridViewDenizOtobusleri.Columns["SonMuayeneTarihi"].Index) &&
                e.Value != null && e.Value != DBNull.Value)
            {
                DateTime tarih = Convert.ToDateTime(e.Value);
                e.Value = tarih.ToString("dd.MM.yyyy");
                e.FormattingApplied = true;
            }
        }

        // Deniz otobüsü ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (DenizOtobusuEkleDuzenleForm denizOtobusuEkleForm = new DenizOtobusuEkleDuzenleForm())
            {
                DialogResult sonuc = denizOtobusuEkleForm.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    DenizOtobusuListesiniYukle(); // Listeyi yenile
                }
            }
        }

        // Deniz otobüsü düzenle
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliDenizOtobusu == null)
            {
                MessageBox.Show("Lütfen düzenlemek için bir deniz otobüsü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (DenizOtobusuEkleDuzenleForm denizOtobusuDuzenleForm = new DenizOtobusuEkleDuzenleForm(seciliDenizOtobusu))
            {
                DialogResult sonuc = denizOtobusuDuzenleForm.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    DenizOtobusuListesiniYukle(); // Listeyi yenile
                }
            }
        }

        // Deniz otobüsü sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliDenizOtobusu == null)
            {
                MessageBox.Show("Lütfen silmek için bir deniz otobüsü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                $"{seciliDenizOtobusu.DenizOtobusuAdi} adlı deniz otobüsünü silmek istediğinize emin misiniz?",
                "Deniz Otobüsü Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    // Deniz otobüsünü pasif yap (tamamen silmek yerine)
                    bool basarili = denizOtobusuManager.DenizOtobusuDurumDegistir(seciliDenizOtobusu.DenizOtobusuID, false);

                    if (basarili)
                    {
                        MessageBox.Show("Deniz otobüsü başarıyla pasif duruma alındı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DenizOtobusuListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Deniz otobüsü pasif duruma alınırken bir hata oluştu.", "Hata",
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

        // Deniz otobüsü durumunu değiştir
        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (seciliDenizOtobusu == null)
            {
                MessageBox.Show("Lütfen durumunu değiştirmek için bir deniz otobüsü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string durumMetni = seciliDenizOtobusu.Aktif ? "pasif" : "aktif";

            DialogResult sonuc = MessageBox.Show(
                $"{seciliDenizOtobusu.DenizOtobusuAdi} adlı deniz otobüsünü {durumMetni} duruma almak istediğinize emin misiniz?",
                "Durum Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    bool yeniDurum = !seciliDenizOtobusu.Aktif; // Durumu tersine çevir
                    bool basarili = denizOtobusuManager.DenizOtobusuDurumDegistir(seciliDenizOtobusu.DenizOtobusuID, yeniDurum);

                    if (basarili)
                    {
                        MessageBox.Show($"Deniz otobüsü başarıyla {durumMetni} duruma alındı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DenizOtobusuListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Deniz otobüsü durumu değiştirilirken bir hata oluştu.", "Hata",
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

        // Bakım yap
        private void btnBakimYap_Click(object sender, EventArgs e)
        {
            if (seciliDenizOtobusu == null)
            {
                MessageBox.Show("Lütfen bakım yapılacak deniz otobüsünü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                $"{seciliDenizOtobusu.DenizOtobusuAdi} için bakım tarihini bugün olarak güncellemek istediğinize emin misiniz?",
                "Bakım Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    bool basarili = denizOtobusuManager.BakimTarihiGuncelle(seciliDenizOtobusu.DenizOtobusuID, DateTime.Now);

                    if (basarili)
                    {
                        MessageBox.Show("Bakım tarihi başarıyla güncellendi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DenizOtobusuListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Bakım tarihi güncellenirken bir hata oluştu.", "Hata",
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
    }
}