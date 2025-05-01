using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class SeferYonetimForm : Form
    {
        private readonly SeferManager seferManager;
        private User mevcutKullanici;
        private int seciliSeferID;

        public SeferYonetimForm(User kullanici)
        {
            InitializeComponent();
            seferManager = new SeferManager();
            mevcutKullanici = kullanici;
            seciliSeferID = 0;
        }

        private void SeferYonetimForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde sefer listesini getir
            SeferListesiniYukle();
            // Butonların başlangıç durumlarını ayarla
            ButonDurumlariniAyarla(false);
        }

        private void SeferListesiniYukle()
        {
            try
            {
                DataTable seferlerTablosu = seferManager.TumSeferleriGetir();

                // DataGridView'a verileri yükle
                dataGridViewSeferler.AutoGenerateColumns = false;
                dataGridViewSeferler.DataSource = seferlerTablosu;

                // Doluluk oranı sütununu hesapla
                foreach (DataGridViewRow row in dataGridViewSeferler.Rows)
                {
                    int index = row.Index;
                    if (index < seferlerTablosu.Rows.Count)
                    {
                        DataRow dataRow = seferlerTablosu.Rows[index];
                        int doluKoltuk = Convert.ToInt32(dataRow["DoluKoltukSayisi"]);
                        int kapasite = Convert.ToInt32(dataRow["KapasiteYolcu"]);

                        string doluluk = $"{doluKoltuk}/{kapasite} (%{(int)((double)doluKoltuk / kapasite * 100)})";
                        row.Cells["DolulukOrani"].Value = doluluk;
                    }
                }

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Toplam sefer sayısı: {seferlerTablosu.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sefer listesi yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Butonların durumlarını ayarla
        private void ButonDurumlariniAyarla(bool aktifMi)
        {
            btnDuzenle.Enabled = aktifMi;
            btnIptal.Enabled = aktifMi;
            btnDetay.Enabled = aktifMi;
        }

        // Arama işlemi
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                SeferListesiniYukle();
                return;
            }

            try
            {
                DataTable sonucTablosu = seferManager.SeferAra(aramaMetni);

                // DataGridView'a verileri yükle
                dataGridViewSeferler.AutoGenerateColumns = false;
                dataGridViewSeferler.DataSource = sonucTablosu;

                // Doluluk oranı sütununu hesapla
                foreach (DataGridViewRow row in dataGridViewSeferler.Rows)
                {
                    int index = row.Index;
                    if (index < sonucTablosu.Rows.Count)
                    {
                        DataRow dataRow = sonucTablosu.Rows[index];
                        int doluKoltuk = Convert.ToInt32(dataRow["DoluKoltukSayisi"]);
                        int kapasite = Convert.ToInt32(dataRow["KapasiteYolcu"]);

                        string doluluk = $"{doluKoltuk}/{kapasite} (%{(int)((double)doluKoltuk / kapasite * 100)})";
                        row.Cells["DolulukOrani"].Value = doluluk;
                    }
                }

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Arama sonucu: {sonucTablosu.Rows.Count} sefer bulundu.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tüm seferleri göster
        private void rdTumSeferler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTumSeferler.Checked)
            {
                SeferListesiniYukle();
            }
        }

        // Aktif seferleri göster
        private void rdAktifSeferler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAktifSeferler.Checked)
            {
                try
                {
                    DataTable aktifSeferler = seferManager.SeferleriDurumaGoreFiltrele("Planlandi");

                    // DataGridView'a verileri yükle
                    dataGridViewSeferler.AutoGenerateColumns = false;
                    dataGridViewSeferler.DataSource = aktifSeferler;

                    // Doluluk oranı sütununu hesapla
                    foreach (DataGridViewRow row in dataGridViewSeferler.Rows)
                    {
                        int index = row.Index;
                        if (index < aktifSeferler.Rows.Count)
                        {
                            DataRow dataRow = aktifSeferler.Rows[index];
                            int doluKoltuk = Convert.ToInt32(dataRow["DoluKoltukSayisi"]);
                            int kapasite = Convert.ToInt32(dataRow["KapasiteYolcu"]);

                            string doluluk = $"{doluKoltuk}/{kapasite} (%{(int)((double)doluKoltuk / kapasite * 100)})";
                            row.Cells["DolulukOrani"].Value = doluluk;
                        }
                    }

                    // Bilgi etiketini güncelle
                    lblBilgi.Text = $"Aktif sefer sayısı: {aktifSeferler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aktif seferler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // İptal edilen seferleri göster
        private void rdIptalEdilenSeferler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdIptalEdilenSeferler.Checked)
            {
                try
                {
                    DataTable iptalSeferler = seferManager.SeferleriDurumaGoreFiltrele("IptalEdildi");

                    // DataGridView'a verileri yükle
                    dataGridViewSeferler.AutoGenerateColumns = false;
                    dataGridViewSeferler.DataSource = iptalSeferler;

                    // Doluluk oranı sütununu hesapla
                    foreach (DataGridViewRow row in dataGridViewSeferler.Rows)
                    {
                        int index = row.Index;
                        if (index < iptalSeferler.Rows.Count)
                        {
                            DataRow dataRow = iptalSeferler.Rows[index];
                            int doluKoltuk = Convert.ToInt32(dataRow["DoluKoltukSayisi"]);
                            int kapasite = Convert.ToInt32(dataRow["KapasiteYolcu"]);

                            string doluluk = $"{doluKoltuk}/{kapasite} (%{(int)((double)doluKoltuk / kapasite * 100)})";
                            row.Cells["DolulukOrani"].Value = doluluk;
                        }
                    }

                    // Bilgi etiketini güncelle
                    lblBilgi.Text = $"İptal edilen sefer sayısı: {iptalSeferler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İptal edilen seferler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Tamamlanan seferleri göster
        private void rdTamamlananSeferler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTamamlananSeferler.Checked)
            {
                try
                {
                    DataTable tamamlananSeferler = seferManager.SeferleriDurumaGoreFiltrele("Tamamlandi");

                    // DataGridView'a verileri yükle
                    dataGridViewSeferler.AutoGenerateColumns = false;
                    dataGridViewSeferler.DataSource = tamamlananSeferler;

                    // Doluluk oranı sütununu hesapla
                    foreach (DataGridViewRow row in dataGridViewSeferler.Rows)
                    {
                        int index = row.Index;
                        if (index < tamamlananSeferler.Rows.Count)
                        {
                            DataRow dataRow = tamamlananSeferler.Rows[index];
                            int doluKoltuk = Convert.ToInt32(dataRow["DoluKoltukSayisi"]);
                            int kapasite = Convert.ToInt32(dataRow["KapasiteYolcu"]);

                            string doluluk = $"{doluKoltuk}/{kapasite} (%{(int)((double)doluKoltuk / kapasite * 100)})";
                            row.Cells["DolulukOrani"].Value = doluluk;
                        }
                    }

                    // Bilgi etiketini güncelle
                    lblBilgi.Text = $"Tamamlanan sefer sayısı: {tamamlananSeferler.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tamamlanan seferler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Yenile butonu
        private void btnYenile_Click(object sender, EventArgs e)
        {
            SeferListesiniYukle();
            txtArama.Clear();
            rdTumSeferler.Checked = true;
        }

        // DataGridView'da satır seçildiğinde
        private void dataGridViewSeferler_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSeferler.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSeferler.SelectedRows[0];
                seciliSeferID = Convert.ToInt32(selectedRow.Cells["SeferID"].Value);

                // Butonları aktifleştir
                ButonDurumlariniAyarla(true);
            }
            else
            {
                seciliSeferID = 0;
                ButonDurumlariniAyarla(false);
            }
        }

        // DataGridView hücre formatlanırken
        private void dataGridViewSeferler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Durum sütunu için renklendirme
            if (e.ColumnIndex == dataGridViewSeferler.Columns["SeferDurumu"].Index && e.Value != null)
            {
                string durum = e.Value.ToString();

                switch (durum)
                {
                    case "Planlandi":
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.SelectionForeColor = Color.Green;
                        break;
                    case "Yolda":
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.SelectionForeColor = Color.Blue;
                        break;
                    case "Tamamlandi":
                        e.CellStyle.ForeColor = Color.DarkGray;
                        e.CellStyle.SelectionForeColor = Color.DarkGray;
                        break;
                    case "IptalEdildi":
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                        break;
                    default:
                        break;
                }
            }

            // Tarih formatı
            if (e.ColumnIndex == dataGridViewSeferler.Columns["KalkisTarihi"].Index && e.Value != null && e.Value != DBNull.Value)
            {
                DateTime tarih = Convert.ToDateTime(e.Value);
                e.Value = tarih.ToString("dd.MM.yyyy");
                e.FormattingApplied = true;
            }

            // Saat formatı
            if (e.ColumnIndex == dataGridViewSeferler.Columns["KalkisSaati"].Index && e.Value != null && e.Value != DBNull.Value)
            {
                TimeSpan saat = (TimeSpan)e.Value;
                e.Value = saat.ToString(@"hh\:mm");
                e.FormattingApplied = true;
            }

            // Bilet fiyatı formatı
            if (e.ColumnIndex == dataGridViewSeferler.Columns["BiletFiyati"].Index && e.Value != null && e.Value != DBNull.Value)
            {
                decimal fiyat = Convert.ToDecimal(e.Value);
                e.Value = string.Format("{0:N2} ₺", fiyat);
                e.FormattingApplied = true;
            }
        }

        // Sefer ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SeferEkleDuzenleForm seferEkleForm = new SeferEkleDuzenleForm(mevcutKullanici))
            {
                if (seferEkleForm.ShowDialog() == DialogResult.OK)
                {
                    SeferListesiniYukle(); // Listeyi yenile
                }
            }
        }

        // Sefer düzenle
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliSeferID <= 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SeferEkleDuzenleForm seferDuzenleForm = new SeferEkleDuzenleForm(mevcutKullanici, seciliSeferID))
            {
                if (seferDuzenleForm.ShowDialog() == DialogResult.OK)
                {
                    SeferListesiniYukle(); // Listeyi yenile
                }
            }
        }

        // Sefer iptal et
        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (seciliSeferID <= 0)
            {
                MessageBox.Show("Lütfen iptal etmek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili seferin durumunu kontrol et (sadece Planlandi durumundaki seferler iptal edilebilir)
            var selectedRow = dataGridViewSeferler.SelectedRows[0];
            string durumStr = selectedRow.Cells["SeferDurumu"].Value.ToString();

            if (durumStr != "Planlandi")
            {
                MessageBox.Show("Sadece planlanmış seferler iptal edilebilir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                $"{selectedRow.Cells["KalkisLimani"].Value} - {selectedRow.Cells["VarisLimani"].Value} seferini iptal etmek istediğinize emin misiniz?",
                "Sefer İptal Etme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    bool basarili = seferManager.SeferDurumunuGuncelle(seciliSeferID, "IptalEdildi");

                    if (basarili)
                    {
                        MessageBox.Show("Sefer başarıyla iptal edildi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SeferListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Sefer iptal edilirken bir hata oluştu.", "Hata",
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

        // Sefer detay
        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (seciliSeferID <= 0)
            {
                MessageBox.Show("Lütfen detaylarını görmek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sefer detay formunu göster - Bu formu daha sonra oluşturacağız
            MessageBox.Show("Sefer detay gösterme özelliği sonraki aşamada eklenecek.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}