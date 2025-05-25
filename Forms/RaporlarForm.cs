// UDO/Forms/RaporlarForm.cs
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UDO.Managers; // Manager sınıflarını kullanmak için ekleyin

namespace UDO.Forms
{
    public partial class RaporlarForm : Form
    {
        private readonly SeferManager seferManager;
        private readonly MusteriManager musteriManager;
        private readonly PersonelManager personelManager;
        private readonly DenizOtobusuManager denizOtobusuManager;

        public RaporlarForm()
        {
            InitializeComponent();
            seferManager = new SeferManager();
            musteriManager = new MusteriManager();
            personelManager = new PersonelManager();
            denizOtobusuManager = new DenizOtobusuManager();
            this.Text = "Raporlar"; // Formun başlığını ayarla
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde varsayılan olarak "Tüm Seferler" raporunu göster
            cmbRaporTuru.SelectedIndex = 0; // İlk öğeyi seç
            LoadReport(cmbRaporTuru.SelectedItem.ToString());
        }

        private void cmbRaporTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Rapor türü değiştiğinde DataGridView'i temizle
            dataGridViewRapor.DataSource = null;
            lblBilgi.Text = "Toplam kayıt: 0";
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
            if (cmbRaporTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir rapor türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenRapor = cmbRaporTuru.SelectedItem.ToString();
            LoadReport(secilenRapor);
        }

        private void LoadReport(string reportType)
        {
            DataTable dataTable = null;
            string infoMessage = "";

            try
            {
                switch (reportType)
                {
                    case "Tüm Seferler":
                        dataTable = seferManager.TumSeferleriGetir();
                        infoMessage = $"Toplam sefer sayısı: {dataTable.Rows.Count}";
                        FormatSeferReport(dataTable);
                        break;
                    case "Aktif Seferler":
                        dataTable = seferManager.SeferleriDurumaGoreFiltrele("Planlandi"); // 'Planlandi' durumu aktif kabul edildi
                        infoMessage = $"Aktif sefer sayısı: {dataTable.Rows.Count}";
                        FormatSeferReport(dataTable);
                        break;
                    case "İptal Edilen Seferler":
                        dataTable = seferManager.SeferleriDurumaGoreFiltrele("IptalEdildi");
                        infoMessage = $"İptal edilen sefer sayısı: {dataTable.Rows.Count}";
                        FormatSeferReport(dataTable);
                        break;
                    case "Tamamlanan Seferler":
                        dataTable = seferManager.SeferleriDurumaGoreFiltrele("Tamamlandi");
                        infoMessage = $"Tamamlanan sefer sayısı: {dataTable.Rows.Count}";
                        FormatSeferReport(dataTable);
                        break;
                    case "Tüm Müşteriler":
                        dataTable = musteriManager.TumMusterileriGetir();
                        infoMessage = $"Toplam müşteri sayısı: {dataTable.Rows.Count}";
                        FormatMusteriReport(dataTable);
                        break;
                    case "Aktif Müşteriler":
                        dataTable = musteriManager.MusterileriDurumaGoreFiltrele(true);
                        infoMessage = $"Aktif müşteri sayısı: {dataTable.Rows.Count}";
                        FormatMusteriReport(dataTable);
                        break;
                    case "VIP Müşteriler":
                        dataTable = musteriManager.VipMusterileriGetir();
                        infoMessage = $"VIP müşteri sayısı: {dataTable.Rows.Count}";
                        FormatMusteriReport(dataTable);
                        break;
                    case "Tüm Personel":
                        dataTable = personelManager.TumPersoneliGetir();
                        infoMessage = $"Toplam personel sayısı: {dataTable.Rows.Count}";
                        FormatPersonelReport(dataTable);
                        break;
                    case "Aktif Personel":
                        dataTable = personelManager.PersoneliDurumaGoreFiltrele(true);
                        infoMessage = $"Aktif personel sayısı: {dataTable.Rows.Count}";
                        FormatPersonelReport(dataTable);
                        break;
                    case "Pasif Personel":
                        dataTable = personelManager.PersoneliDurumaGoreFiltrele(false);
                        infoMessage = $"Pasif personel sayısı: {dataTable.Rows.Count}";
                        FormatPersonelReport(dataTable);
                        break;
                    case "Tüm Deniz Otobüsleri":
                        dataTable = denizOtobusuManager.TumDenizOtobusleriniGetir();
                        infoMessage = $"Toplam deniz otobüsü sayısı: {dataTable.Rows.Count}";
                        FormatDenizOtobusuReport(dataTable);
                        break;
                    case "Bakım Zamanı Gelen Deniz Otobüsleri":
                        dataTable = denizOtobusuManager.BakimZamaniGelenler();
                        infoMessage = $"Bakım zamanı gelen deniz otobüsü sayısı: {dataTable.Rows.Count}";
                        FormatDenizOtobusuReport(dataTable);
                        break;
                    default:
                        MessageBox.Show("Geçersiz rapor türü seçimi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                if (dataTable != null)
                {
                    dataGridViewRapor.DataSource = dataTable;
                    lblBilgi.Text = infoMessage;
                }
                else
                {
                    dataGridViewRapor.DataSource = null;
                    lblBilgi.Text = "Veri bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewRapor.DataSource = null;
                lblBilgi.Text = "Hata oluştu.";
            }
        }

        // --- Rapor Formatlama Metotları ---
        // Her rapor türü için DataGridView sütunlarını ve formatlamayı ayarlar
        // Bu metotlar, ilgili yönetim formlarındaki CellFormatting mantığına benzerdir.

        private void FormatSeferReport(DataTable dataTable)
        {
            dataGridViewRapor.Columns.Clear(); // Önceki sütunları temizle
            dataGridViewRapor.AutoGenerateColumns = false;

            // Sütunları manuel olarak ekle
            // DataPropertyName, DataTable'daki sütun adıdır. Name ise DataGridView sütununa verdiğimiz isimdir.
            // Bu şekilde, DataGridView'in otomatik bağlama mekanizmasını atlayarak,
            // değer atamalarını CellFormatting veya foreach döngüsü içinde daha kontrollü yapabiliriz.
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("SeferID", "Sefer ID", 70));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KalkisLimaniAdi", "Kalkış Limanı", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("VarisLimaniAdi", "Varış Limanı", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KalkisTarihi", "Kalkış Tarihi", 100));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KalkisSaati", "Kalkış Saati", 90));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("DenizOtobusuAdi", "Deniz Otobüsü", 120));

            // Doluluk Oranı ve Bilet Fiyatı için DataPropertyName boş bırakılır,
            // değerler manuel olarak atanacağı için. Sadece bir Name veriyoruz.
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("DolulukOraniDisplay", "Doluluk", 90));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("BiletFiyatiDisplay", "Bilet Fiyatı", 90));

            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("SeferDurumu", "Durum", 100));

            dataGridViewRapor.DataSource = dataTable;

            foreach (DataGridViewRow row in dataGridViewRapor.Rows)
            {
                int index = row.Index;
                if (index < dataTable.Rows.Count)
                {
                    DataRow dataRow = dataTable.Rows[index];

                    // Doluluk oranı hesaplama ve atama
                    int doluKoltuk = Convert.ToInt32(dataRow["DoluKoltukSayisi"]);
                    int kapasite = Convert.ToInt32(dataRow["KapasiteYolcu"]);
                    string doluluk = $"{doluKoltuk}/{kapasite} (%{(int)((double)doluKoltuk / kapasite * 100)})";
                    row.Cells["DolulukOraniDisplay"].Value = doluluk; // "DolulukOraniDisplay" isimli sütuna atama

                    // Bilet Fiyatı formatlama ve atama
                    decimal biletFiyati = Convert.ToDecimal(dataRow["BiletFiyati"]);
                    row.Cells["BiletFiyatiDisplay"].Value = biletFiyati.ToString("N2", System.Globalization.CultureInfo.CurrentCulture) + " ₺"; // "BiletFiyatiDisplay" isimli sütuna atama

                    // Sefer Durumu renklendirme
                    string durum = dataRow["SeferDurumu"].ToString();
                    switch (durum)
                    {
                        case "Planlandi":
                            row.Cells["SeferDurumu"].Style.ForeColor = Color.Green;
                            break;
                        case "Yolda":
                            row.Cells["SeferDurumu"].Style.ForeColor = Color.Blue;
                            break;
                        case "Tamamlandi":
                            row.Cells["SeferDurumu"].Style.ForeColor = Color.DarkGray;
                            break;
                        case "IptalEdildi":
                            row.Cells["SeferDurumu"].Style.ForeColor = Color.Red;
                            break;
                    }
                }

                // Tarih ve saat formatı
                // DataPropertyName ile bağlanan sütunların değerleri burada yeniden formatlanabilir.
                if (row.Cells["KalkisTarihi"].Value != null && row.Cells["KalkisTarihi"].Value != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(row.Cells["KalkisTarihi"].Value);
                    row.Cells["KalkisTarihi"].Value = tarih.ToString("dd.MM.yyyy");
                }
                if (row.Cells["KalkisSaati"].Value != null && row.Cells["KalkisSaati"].Value != DBNull.Value)
                {
                    TimeSpan saat = (TimeSpan)row.Cells["KalkisSaati"].Value;
                    row.Cells["KalkisSaati"].Value = saat.ToString(@"hh\:mm");
                }
            }
        }

        private void FormatMusteriReport(DataTable dataTable)
        {
            dataGridViewRapor.Columns.Clear();
            dataGridViewRapor.AutoGenerateColumns = false;

            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("MusteriID", "ID", 50));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("TamAd", "Ad Soyad", 150)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("MusteriNo", "Müşteri No", 100));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("TCKN", "TCKN", 110));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("Email", "E-posta", 150));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("TelefonNumarasi", "Telefon", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("Yas", "Yaş", 60)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("UyrukAdi", "Uyruk", 80));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("ToplamSeyahat", "Seyahat", 70));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("ToplamHarcama", "Harcama", 100));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("SadakatPuani", "Puan", 70));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("SadakatSeviyesi", "Seviye", 80)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("VipDurum", "VIP", 60)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KayitTarihi", "Kayıt Tarihi", 100));
            dataGridViewRapor.Columns.Add(CreateCheckBoxColumn("Aktif", "Durum", 70)); // Aktif sütun adını "Aktif" olarak kullanıyoruz

            dataGridViewRapor.DataSource = dataTable;

            foreach (DataGridViewRow row in dataGridViewRapor.Rows)
            {
                if (row.IsNewRow) continue;

                int index = row.Index;
                if (index < dataTable.Rows.Count)
                {
                    DataRow dataRow = dataTable.Rows[index];

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

                    // Durum sütunu için renklendirme
                    bool aktifMi = Convert.ToBoolean(dataRow["Aktif"]);
                    row.Cells["Aktif"].Style.ForeColor = aktifMi ? Color.Green : Color.Red; // "Aktif" isimli sütun

                    // VIP durum renklendirmesi
                    if (vipMi)
                    {
                        row.Cells["VipDurum"].Style.ForeColor = Color.Gold;
                        row.Cells["VipDurum"].Style.Font = new Font(row.Cells["VipDurum"].Style.Font, FontStyle.Bold);
                    }

                    // Sadakat seviyesi renklendirmesi
                    switch (seviye)
                    {
                        case "Altın":
                            row.Cells["SadakatSeviyesi"].Style.ForeColor = Color.Gold;
                            break;
                        case "Gümüş":
                            row.Cells["SadakatSeviyesi"].Style.ForeColor = Color.Silver;
                            break;
                        case "Bronz":
                            row.Cells["SadakatSeviyesi"].Style.ForeColor = Color.Peru;
                            break;
                        default:
                            row.Cells["SadakatSeviyesi"].Style.ForeColor = Color.Gray;
                            break;
                    }

                    // Tarih formatı
                    if (row.Cells["KayitTarihi"].Value != null && row.Cells["KayitTarihi"].Value != DBNull.Value)
                    {
                        DateTime tarih = Convert.ToDateTime(row.Cells["KayitTarihi"].Value);
                        row.Cells["KayitTarihi"].Value = tarih.ToString("dd.MM.yyyy");
                    }
                    // Para formatı
                    if (row.Cells["ToplamHarcama"].Value != null && row.Cells["ToplamHarcama"].Value != DBNull.Value)
                    {
                        decimal tutar = Convert.ToDecimal(row.Cells["ToplamHarcama"].Value);
                        row.Cells["ToplamHarcama"].Value = string.Format("{0:N2} ₺", tutar);
                    }
                }
            }
        }

        private void FormatPersonelReport(DataTable dataTable)
        {
            dataGridViewRapor.Columns.Clear();
            dataGridViewRapor.AutoGenerateColumns = false;

            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KullaniciID", "ID", 50));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KullaniciAdi", "Kullanıcı Adı", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("AdSoyad", "Ad Soyad", 150)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("TCKN", "TCKN", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("Email", "E-posta", 150));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("TelefonNumarasi", "Telefon", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("KayitTarihi", "Kayıt Tarihi", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("SonGirisTarihi", "Son Giriş", 120));
            dataGridViewRapor.Columns.Add(CreateCheckBoxColumn("Aktif", "Durum", 70)); // Aktif sütun adını "Aktif" olarak kullanıyoruz

            dataGridViewRapor.DataSource = dataTable;

            foreach (DataGridViewRow row in dataGridViewRapor.Rows)
            {
                int index = row.Index;
                if (index < dataTable.Rows.Count)
                {
                    DataRow dataRow = dataTable.Rows[index];

                    // AdSoyad Sütununu doldur
                    string ad = dataRow["Ad"] != DBNull.Value ? dataRow["Ad"].ToString() : "";
                    string soyad = dataRow["Soyad"] != DBNull.Value ? dataRow["Soyad"].ToString() : "";
                    row.Cells["AdSoyad"].Value = ad + " " + soyad;

                    // Durum sütunu için renklendirme
                    bool aktifMi = Convert.ToBoolean(dataRow["Aktif"]);
                    row.Cells["Aktif"].Style.ForeColor = aktifMi ? Color.Green : Color.Red;
                }

                // Tarih formatı
                if (row.Cells["KayitTarihi"].Value != null && row.Cells["KayitTarihi"].Value != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(row.Cells["KayitTarihi"].Value);
                    row.Cells["KayitTarihi"].Value = tarih.ToString("dd.MM.yyyy HH:mm");
                }
                if (row.Cells["SonGirisTarihi"].Value != null && row.Cells["SonGirisTarihi"].Value != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(row.Cells["SonGirisTarihi"].Value);
                    row.Cells["SonGirisTarihi"].Value = tarih.ToString("dd.MM.yyyy HH:mm");
                }
            }
        }

        private void FormatDenizOtobusuReport(DataTable dataTable)
        {
            dataGridViewRapor.Columns.Clear();
            dataGridViewRapor.AutoGenerateColumns = false;

            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("DenizOtobusuID", "ID", 50));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("DenizOtobusuAdi", "Deniz Otobüsü Adı", 150));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("Model", "Model", 120));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("Marka", "Marka", 100));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("Kapasite", "Kapasite", 80));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("UretimYili", "Üretim Yılı", 90));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("Yas", "Yaş", 60)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("SonBakimTarihi", "Son Bakım", 100));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumnWithDataProperty("SonMuayeneTarihi", "Son Muayene", 100));
            dataGridViewRapor.Columns.Add(CreateTextBoxColumn("BakimDurumuDisplay", "Bakım Durumu", 110)); // Manuel doldurulacak
            dataGridViewRapor.Columns.Add(CreateCheckBoxColumn("Aktif", "Durum", 70)); // Aktif sütun adını "Aktif" olarak kullanıyoruz

            dataGridViewRapor.DataSource = dataTable;

            foreach (DataGridViewRow row in dataGridViewRapor.Rows)
            {
                int index = row.Index;
                if (index < dataTable.Rows.Count)
                {
                    DataRow dataRow = dataTable.Rows[index];

                    // Yaş hesaplama
                    int uretimYili = Convert.ToInt32(dataRow["UretimYili"]);
                    int yas = DateTime.Now.Year - uretimYili;
                    row.Cells["Yas"].Value = yas;

                    // Bakım durumu hesaplama
                    DateTime? sonBakimTarihi = dataRow["SonBakimTarihi"] != DBNull.Value ?
                        Convert.ToDateTime(dataRow["SonBakimTarihi"]) : (DateTime?)null;

                    string bakimDurumu = BakimDurumuHesapla(sonBakimTarihi);
                    row.Cells["BakimDurumuDisplay"].Value = bakimDurumu; // "BakimDurumuDisplay" isimli sütuna atama

                    // Durum sütunu için renklendirme
                    bool aktifMi = Convert.ToBoolean(dataRow["Aktif"]);
                    row.Cells["Aktif"].Style.ForeColor = aktifMi ? Color.Green : Color.Red;

                    // Bakım durumu sütunu için renklendirme
                    switch (bakimDurumu)
                    {
                        case "Güncel":
                            row.Cells["BakimDurumuDisplay"].Style.ForeColor = Color.Green;
                            break;
                        case "Yaklaşıyor":
                            row.Cells["BakimDurumuDisplay"].Style.ForeColor = Color.Orange;
                            break;
                        case "Bakım Zamanı":
                        case "Bakım Gerekli":
                            row.Cells["BakimDurumuDisplay"].Style.ForeColor = Color.Red;
                            break;
                    }

                    // Yaş sütunu için renklendirme
                    if (yas <= 5)
                    {
                        row.Cells["Yas"].Style.ForeColor = Color.Green;
                    }
                    else if (yas <= 15)
                    {
                        row.Cells["Yas"].Style.ForeColor = Color.Orange;
                    }
                    else
                    {
                        row.Cells["Yas"].Style.ForeColor = Color.Red;
                    }
                }

                // Tarih formatı
                if (row.Cells["SonBakimTarihi"].Value != null && row.Cells["SonBakimTarihi"].Value != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(row.Cells["SonBakimTarihi"].Value);
                    row.Cells["SonBakimTarihi"].Value = tarih.ToString("dd.MM.yyyy");
                }
                if (row.Cells["SonMuayeneTarihi"].Value != null && row.Cells["SonMuayeneTarihi"].Value != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(row.Cells["SonMuayeneTarihi"].Value);
                    row.Cells["SonMuayeneTarihi"].Value = tarih.ToString("dd.MM.yyyy");
                }
            }
        }


        // Yardımcı Metot: DataGridViewTextBoxColumn oluşturur (DataPropertyName olmadan)
        private DataGridViewTextBoxColumn CreateTextBoxColumn(string name, string headerText, int width)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = name, // Sütunun benzersiz adı
                HeaderText = headerText,
                ReadOnly = true,
                Width = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None // Boyutunu manuel ayarlamak için
            };
        }

        // Yardımcı Metot: DataGridViewTextBoxColumn oluşturur (DataPropertyName ile)
        private DataGridViewTextBoxColumn CreateTextBoxColumnWithDataProperty(string dataPropertyName, string headerText, int width)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = dataPropertyName, // DataPropertyName'i aynı zamanda Name olarak kullanıyoruz
                ReadOnly = true,
                Width = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
        }

        // Yardımcı Metot: DataGridViewCheckBoxColumn oluşturur
        private DataGridViewCheckBoxColumn CreateCheckBoxColumn(string dataPropertyName, string headerText, int width)
        {
            return new DataGridViewCheckBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = dataPropertyName,
                ReadOnly = true,
                Width = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
        }

        // Deniz Otobüsü Bakım Durumu Hesaplama (DenizOtobusuYonetimForm'dan kopyalandı)
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
    }
}