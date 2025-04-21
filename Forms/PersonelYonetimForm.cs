using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UDO.Managers;
using UDO.Models;

namespace UDO.Forms
{
    public partial class PersonelYonetimForm : Form
    {
        private readonly PersonelManager personelManager;
        private User seciliPersonel;

        public PersonelYonetimForm()
        {
            InitializeComponent();
            personelManager = new PersonelManager();
            seciliPersonel = null;
        }

       
        private void PersonelListesiniYukle()
        {
            try
            {
                DataTable personelTablosu = personelManager.TumPersoneliGetir();

                // DataGridView'a verileri yükle
                dataGridViewPersonel.AutoGenerateColumns = false;
                dataGridViewPersonel.DataSource = personelTablosu;

                // AdSoyad Sütununu doldur - Düzeltilmiş kod
                foreach (DataGridViewRow row in dataGridViewPersonel.Rows)
                {
                    int index = row.Index;
                    if (index < personelTablosu.Rows.Count)
                    {
                        DataRow dataRow = personelTablosu.Rows[index];
                        string ad = dataRow["Ad"] != DBNull.Value ? dataRow["Ad"].ToString() : "";
                        string soyad = dataRow["Soyad"] != DBNull.Value ? dataRow["Soyad"].ToString() : "";
                        row.Cells["AdSoyad"].Value = ad + " " + soyad;
                    }
                }

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Toplam personel sayısı: {personelTablosu.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel listesi yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Arama işlemi
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                PersonelListesiniYukle();
                return;
            }

            try
            {
                DataTable sonucTablosu = personelManager.PersonelAra(aramaMetni);

                // DataGridView'a verileri yükle
                dataGridViewPersonel.AutoGenerateColumns = false;
                dataGridViewPersonel.DataSource = sonucTablosu;

                // AdSoyad Sütununu doldur - Düzeltilmiş kod
                foreach (DataGridViewRow row in dataGridViewPersonel.Rows)
                {
                    int index = row.Index;
                    if (index < sonucTablosu.Rows.Count)
                    {
                        DataRow dataRow = sonucTablosu.Rows[index];
                        string ad = dataRow["Ad"] != DBNull.Value ? dataRow["Ad"].ToString() : "";
                        string soyad = dataRow["Soyad"] != DBNull.Value ? dataRow["Soyad"].ToString() : "";
                        row.Cells["AdSoyad"].Value = ad + " " + soyad;
                    }
                }

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Arama sonucu: {sonucTablosu.Rows.Count} personel bulundu.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tüm personeli göster
        private void rdTumPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTumPersonel.Checked)
            {
                PersonelListesiniYukle();
            }
        }

        // Aktif personeli göster
        private void rdAktifPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAktifPersonel.Checked)
            {
                try
                {
                    DataTable aktifPersonel = personelManager.PersoneliDurumaGoreFiltrele(true);

                    // DataGridView'a verileri yükle
                    dataGridViewPersonel.AutoGenerateColumns = false;
                    dataGridViewPersonel.DataSource = aktifPersonel;

                    // AdSoyad Sütununu doldur - Düzeltilmiş kod
                    foreach (DataGridViewRow row in dataGridViewPersonel.Rows)
                    {
                        int index = row.Index;
                        if (index < aktifPersonel.Rows.Count)
                        {
                            DataRow dataRow = aktifPersonel.Rows[index];
                            string ad = dataRow["Ad"] != DBNull.Value ? dataRow["Ad"].ToString() : "";
                            string soyad = dataRow["Soyad"] != DBNull.Value ? dataRow["Soyad"].ToString() : "";
                            row.Cells["AdSoyad"].Value = ad + " " + soyad;
                        }
                    }

                    // Bilgi etiketini güncelle
                    lblBilgi.Text = $"Aktif personel sayısı: {aktifPersonel.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aktif personel listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Pasif personeli göster
        private void rdPasifPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPasifPersonel.Checked)
            {
                try
                {
                    DataTable pasifPersonel = personelManager.PersoneliDurumaGoreFiltrele(false);

                    // DataGridView'a verileri yükle
                    dataGridViewPersonel.AutoGenerateColumns = false;
                    dataGridViewPersonel.DataSource = pasifPersonel;

                    // AdSoyad Sütununu doldur - Düzeltilmiş kod
                    foreach (DataGridViewRow row in dataGridViewPersonel.Rows)
                    {
                        int index = row.Index;
                        if (index < pasifPersonel.Rows.Count)
                        {
                            DataRow dataRow = pasifPersonel.Rows[index];
                            string ad = dataRow["Ad"] != DBNull.Value ? dataRow["Ad"].ToString() : "";
                            string soyad = dataRow["Soyad"] != DBNull.Value ? dataRow["Soyad"].ToString() : "";
                            row.Cells["AdSoyad"].Value = ad + " " + soyad;
                        }
                    }

                    // Bilgi etiketini güncelle
                    lblBilgi.Text = $"Pasif personel sayısı: {pasifPersonel.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pasif personel listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Yenile butonu
        private void btnYenile_Click(object sender, EventArgs e)
        {
            PersonelListesiniYukle();
            txtArama.Clear();
            rdTumPersonel.Checked = true;
        }

        // DataGridView'da satır seçildiğinde
        private void dataGridViewPersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPersonel.SelectedRows[0];
                int personelId = Convert.ToInt32(selectedRow.Cells["KullaniciID"].Value);

                // Seçili personeli yükle
                seciliPersonel = personelManager.PersonelGetirById(personelId);

                // Butonları aktifleştir
                ButonDurumlariniAyarla(true);

                // Durum değiştir butonunun metnini güncelle
                GuncelleButonDurumMetni();
            }
            else
            {
                seciliPersonel = null;
                ButonDurumlariniAyarla(false);
            }
        }

        // DataGridView hücre formatlanırken
        private void dataGridViewPersonel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Durum sütunu için renklendirme
            if (e.ColumnIndex == dataGridViewPersonel.Columns["Durum"].Index && e.Value != null)
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

            // Tarih formatı
            if ((e.ColumnIndex == dataGridViewPersonel.Columns["KayitTarihi"].Index ||
                e.ColumnIndex == dataGridViewPersonel.Columns["SonGirisTarihi"].Index) &&
                e.Value != null && e.Value != DBNull.Value)
            {
                DateTime tarih = Convert.ToDateTime(e.Value);
                e.Value = tarih.ToString("dd.MM.yyyy HH:mm");
                e.FormattingApplied = true;
            }
        }

        // Butonların durumlarını ayarla
        private void ButonDurumlariniAyarla(bool aktifMi)
        {
            btnDuzenle.Enabled = aktifMi;
            btnSil.Enabled = aktifMi;
            btnDurumDegistir.Enabled = aktifMi;
        }

        // Durum değiştir butonunun metnini güncelle
        private void GuncelleButonDurumMetni()
        {
            if (seciliPersonel != null)
            {
                btnDurumDegistir.Text = seciliPersonel.Aktif ? "Pasif Yap" : "Aktif Yap";
            }
        }

        private void PersonelYonetimForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde personel listesini getir
            PersonelListesiniYukle();
            // Butonların başlangıç durumlarını ayarla
            ButonDurumlariniAyarla(false);
        }

        // Personel ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Personel ekle formunu göster
            using (PersonelEkleDuzenleForm personelEkleForm = new PersonelEkleDuzenleForm())
            {
                DialogResult sonuc = personelEkleForm.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    PersonelListesiniYukle(); // Listeyi yenile
                }
            }
        }

        // Personel düzenle
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliPersonel == null)
            {
                MessageBox.Show("Lütfen düzenlemek için bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Personel düzenleme formunu göster
            using (PersonelEkleDuzenleForm personelDuzenleForm = new PersonelEkleDuzenleForm(seciliPersonel))
            {
                DialogResult sonuc = personelDuzenleForm.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    PersonelListesiniYukle(); // Listeyi yenile
                }
            }
        }

        // Personel sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliPersonel == null)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                $"{seciliPersonel.Ad} {seciliPersonel.Soyad} adlı personeli silmek istediğinize emin misiniz?",
                "Personel Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    // Personeli pasif yap (tamamen silmek yerine)
                    bool basarili = personelManager.PersonelDurumDegistir(seciliPersonel.KullaniciID, false);

                    if (basarili)
                    {
                        MessageBox.Show("Personel başarıyla pasif duruma alındı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PersonelListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Personel pasif duruma alınırken bir hata oluştu.", "Hata",
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

        // Personel durumunu değiştir
        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (seciliPersonel == null)
            {
                MessageBox.Show("Lütfen durumunu değiştirmek için bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string durumMetni = seciliPersonel.Aktif ? "pasif" : "aktif";

            DialogResult sonuc = MessageBox.Show(
                $"{seciliPersonel.Ad} {seciliPersonel.Soyad} adlı personeli {durumMetni} duruma almak istediğinize emin misiniz?",
                "Durum Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    bool yeniDurum = !seciliPersonel.Aktif; // Durumu tersine çevir
                    bool basarili = personelManager.PersonelDurumDegistir(seciliPersonel.KullaniciID, yeniDurum);

                    if (basarili)
                    {
                        MessageBox.Show($"Personel başarıyla {durumMetni} duruma alındı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PersonelListesiniYukle(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Personel durumu değiştirilirken bir hata oluştu.", "Hata",
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

        // Şifre sıfırlama butonu - kullanılmıyor
        private void btnSifreSifirla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu özellik şu anda kullanılmamaktadır.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}