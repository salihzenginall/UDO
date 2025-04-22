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
        private Sefer seciliSefer;
        private readonly User mevcutKullanici;

        public SeferYonetimForm(User kullanici = null)
        {
            InitializeComponent();
            seferManager = new SeferManager();
            seciliSefer = null;
            mevcutKullanici = kullanici;
        }

        // Form yüklenirken
        private void SeferYonetimForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde sefer listesini getir
            SeferListesiniYukle();

            // Tarih filtresi için bugünün tarihini ayarla
            dtpTarih.Value = DateTime.Today;

            // Durum filtresini doldur
            cmbDurumFiltre.Items.Add("Tümü");
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.Programlandi);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.Beklemede);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.KapilariKapatti);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.HareketEtti);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.Yolda);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.YaklastiVarisa);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.Tamamlandi);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.GecikmeBekleniyor);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.Gecikti);
            cmbDurumFiltre.Items.Add(Sefer.Durumlar.IptalEdildi);
            cmbDurumFiltre.SelectedIndex = 0; // Varsayılan olarak "Tümü" seçili

            // Butonların başlangıç durumlarını ayarla
            ButonDurumlariniAyarla(false);
        }

        // Tüm seferleri listeleyen metot
        private void SeferListesiniYukle()
        {
            try
            {
                DataTable seferTablosu = seferManager.TumSeferleriGetir();

                // DataGridView'a verileri yükle
                dataGridViewSeferler.AutoGenerateColumns = false;
                dataGridViewSeferler.DataSource = seferTablosu;

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"Toplam sefer sayısı: {seferTablosu.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sefer listesi yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tarih filtresine göre seferleri listeleyen metot
        private void TariheGoreSeferleriListele()
        {
            try
            {
                DateTime secilenTarih = dtpTarih.Value.Date;
                DataTable seferTablosu = seferManager.SeferleriTariheGoreGetir(secilenTarih);

                // DataGridView'a verileri yükle
                dataGridViewSeferler.AutoGenerateColumns = false;
                dataGridViewSeferler.DataSource = seferTablosu;

                // Bilgi etiketini güncelle
                lblBilgi.Text = $"{secilenTarih.ToShortDateString()} tarihinde toplam {seferTablosu.Rows.Count} sefer bulundu.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seferler tarih filtresine göre listelenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Duruma göre seferleri listeleyen metot
        private void DurumaGoreSeferleriListele(string durum)
        {
            try
            {
                DataTable seferTablosu;

                if (durum == "Tümü")
                {
                    seferTablosu = seferManager.TumSeferleriGetir();
                }
                else
                {
                    seferTablosu = seferManager.SeferleriDurumaGoreGetir(durum);
                }

                // DataGridView'a verileri yükle
                dataGridViewSeferler.AutoGenerateColumns = false;
                dataGridViewSeferler.DataSource = seferTablosu;

                // Bilgi etiketini güncelle
                if (durum == "Tümü")
                {
                    lblBilgi.Text = $"Toplam sefer sayısı: {seferTablosu.Rows.Count}";
                }
                else
                {
                    lblBilgi.Text = $"'{durum}' durumunda toplam {seferTablosu.Rows.Count} sefer bulundu.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seferler durum filtresine göre listelenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Butonların durumlarını ayarla
        private void ButonDurumlariniAyarla(bool aktifMi)
        {
            btnDuzenle.Enabled = aktifMi;
            btnIptal.Enabled = aktifMi;
            btnDurumGuncelle.Enabled = aktifMi;
            btnDetay.Enabled = aktifMi;
        }

        // DataGridView'da satır seçildiğinde
        private void dataGridViewSeferler_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSeferler.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSeferler.SelectedRows[0];
                int seferID = Convert.ToInt32(selectedRow.Cells["SeferID"].Value);

                // Seçili seferi yükle
                seciliSefer = seferManager.SeferGetirById(seferID);

                // Butonları aktifleştir
                ButonDurumlariniAyarla(true);

                // Sefer iptal edilmiş veya tamamlanmışsa bazı butonları devre dışı bırak
                if (seciliSefer.SeferDurumu == Sefer.Durumlar.IptalEdildi ||
                    seciliSefer.SeferDurumu == Sefer.Durumlar.Tamamlandi)
                {
                    btnDuzenle.Enabled = false;
                    btnIptal.Enabled = false;
                    btnDurumGuncelle.Enabled = false;
                }
                else
                {
                    btnDuzenle.Enabled = true;
                    btnIptal.Enabled = true;
                    btnDurumGuncelle.Enabled = true;
                }
            }
            else
            {
                seciliSefer = null;
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
                    case "Programlandı":
                        e.CellStyle.ForeColor = Color.Blue;
                        break;
                    case "Beklemede":
                        e.CellStyle.ForeColor = Color.DarkBlue;
                        break;
                    case "Kapılar Kapandı":
                        e.CellStyle.ForeColor = Color.DarkCyan;
                        break;
                    case "Hareket Etti":
                    case "Yolda":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "Varışa Yaklaşıldı":
                        e.CellStyle.ForeColor = Color.DarkGreen;
                        break;
                    case "Tamamlandı":
                        e.CellStyle.ForeColor = Color.Purple;
                        break;
                    case "Gecikme Bekleniyor":
                    case "Gecikti":
                        e.CellStyle.ForeColor = Color.Orange;
                        break;
                    case "İptal Edildi":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                }

                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }

            // Doluluk oranı sütunu için renklendirme
            if (e.ColumnIndex == dataGridViewSeferler.Columns["DolulukOrani"].Index && e.Value != null)
            {
                int doluluk = Convert.ToInt32(e.Value);

                if (doluluk < 50)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (doluluk < 85)
                {
                    e.CellStyle.ForeColor = Color.Orange;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }

                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }

            // Tarih formatı
            if ((e.ColumnIndex == dataGridViewSeferler.Columns["KalkisTarihi"].Index ||
                e.ColumnIndex == dataGridViewSeferler.Columns["TahminiVarisTarihi"].Index ||
                e.ColumnIndex == dataGridViewSeferler.Columns["GercekVarisTarihi"].Index) &&
                e.Value != null && e.Value != DBNull.Value)
            {
                DateTime tarih = Convert.ToDateTime(e.Value);
                e.Value = tarih.ToString("dd.MM.yyyy HH:mm");
                e.FormattingApplied = true;
            }
        }

        // Yeni Sefer Ekle butonu
        

        // Sefer Düzenle butonu
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliSefer == null)
            {
                MessageBox.Show("Lütfen düzenlemek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Geçmiş seferleri düzenlemeye izin verme
            if (seciliSefer.SeferBasladiMi())
            {
                MessageBox.Show("Başlamış bir seferi düzenleyemezsiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
        }

        // Sefer İptal Et butonu
        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (seciliSefer == null)
            {
                MessageBox.Show("Lütfen iptal etmek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tamamlanmış seferi iptal etmeye izin verme
            if (seciliSefer.SeferTamamlandiMi())
            {
                MessageBox.Show("Tamamlanmış bir seferi iptal edemezsiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // İptal nedeni için input formu göster
            string iptalNedeni = "";
            using (var form = new Form())
            {
                form.Text = "İptal Nedeni";
                form.Size = new Size(400, 200);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                Label label = new Label();
                label.Text = "İptal Nedeni:";
                label.Location = new Point(20, 20);
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Location = new Point(20, 50);
                textBox.Size = new Size(340, 80);
                textBox.Multiline = true;

                Button okButton = new Button();
                okButton.Text = "Tamam";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new Point(180, 130);

                Button cancelButton = new Button();
                cancelButton.Text = "İptal";
                cancelButton.DialogResult = DialogResult.Cancel;
                cancelButton.Location = new Point(280, 130);

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(okButton);
                form.Controls.Add(cancelButton);

                form.AcceptButton = okButton;
                form.CancelButton = cancelButton;

                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    iptalNedeni = textBox.Text.Trim();
                    if (string.IsNullOrEmpty(iptalNedeni))
                    {
                        MessageBox.Show("İptal nedeni boş bırakılamaz.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            DialogResult onay = MessageBox.Show(
                $"{seciliSefer.GuzergahAdi} seferini iptal etmek istediğinize emin misiniz?",
                "Sefer İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    bool basarili = seferManager.SeferIptalEt(seciliSefer.SeferID, iptalNedeni);

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

        // Sefer Durumu Güncelle butonu
        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliSefer == null)
            {
                MessageBox.Show("Lütfen durumunu güncellemek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sefer durum değiştirme formu göster
            using (var form = new Form())
            {
                form.Text = "Sefer Durumu Güncelle";
                form.Size = new Size(400, 250);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                Label labelSefer = new Label();
                labelSefer.Text = $"Sefer: {seciliSefer.GuzergahAdi}";
                labelSefer.Location = new Point(20, 20);
                labelSefer.AutoSize = true;
                labelSefer.Font = new Font(labelSefer.Font, FontStyle.Bold);

                Label labelMevcutDurum = new Label();
                labelMevcutDurum.Text = $"Mevcut Durum: {seciliSefer.SeferDurumu}";
                labelMevcutDurum.Location = new Point(20, 50);
                labelMevcutDurum.AutoSize = true;

                Label labelYeniDurum = new Label();
                labelYeniDurum.Text = "Yeni Durum:";
                labelYeniDurum.Location = new Point(20, 80);
                labelYeniDurum.AutoSize = true;

                ComboBox cmbYeniDurum = new ComboBox();
                cmbYeniDurum.Location = new Point(120, 80);
                cmbYeniDurum.Size = new Size(240, 25);
                cmbYeniDurum.DropDownStyle = ComboBoxStyle.DropDownList;

                // Mevcut duruma göre sonraki olası durumları doldur
                switch (seciliSefer.SeferDurumu)
                {
                    case Sefer.Durumlar.Programlandi:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Beklemede);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.GecikmeBekleniyor);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.IptalEdildi);
                        break;
                    case Sefer.Durumlar.Beklemede:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.KapilariKapatti);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.GecikmeBekleniyor);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.IptalEdildi);
                        break;
                    case Sefer.Durumlar.KapilariKapatti:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.HareketEtti);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.GecikmeBekleniyor);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.IptalEdildi);
                        break;
                    case Sefer.Durumlar.HareketEtti:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Yolda);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Gecikti);
                        break;
                    case Sefer.Durumlar.Yolda:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.YaklastiVarisa);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Gecikti);
                        break;
                    case Sefer.Durumlar.YaklastiVarisa:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Tamamlandi);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Gecikti);
                        break;
                    case Sefer.Durumlar.GecikmeBekleniyor:
                    case Sefer.Durumlar.Gecikti:
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Beklemede);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.KapilariKapatti);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.HareketEtti);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Yolda);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.YaklastiVarisa);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.Tamamlandi);
                        cmbYeniDurum.Items.Add(Sefer.Durumlar.IptalEdildi);
                        break;
                    case Sefer.Durumlar.Tamamlandi:
                    case Sefer.Durumlar.IptalEdildi:
                        // Bu durumlardan sonra geçiş yok, form gösterilmemeli
                        MessageBox.Show($"{seciliSefer.SeferDurumu} durumundaki bir seferin durumu değiştirilemez.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                if (cmbYeniDurum.Items.Count > 0)
                {
                    cmbYeniDurum.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Bu durumdan sonra geçiş yapılabilecek durum bulunamadı.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Label labelAciklama = new Label();
                labelAciklama.Text = "Açıklama:";
                labelAciklama.Location = new Point(20, 120);
                labelAciklama.AutoSize = true;

                TextBox txtAciklama = new TextBox();
                txtAciklama.Location = new Point(120, 120);
                txtAciklama.Size = new Size(240, 60);
                txtAciklama.Multiline = true;

                Button okButton = new Button();
                okButton.Text = "Tamam";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new Point(180, 190);

                Button cancelButton = new Button();
                cancelButton.Text = "İptal";
                cancelButton.DialogResult = DialogResult.Cancel;
                cancelButton.Location = new Point(280, 190);

                form.Controls.Add(labelSefer);
                form.Controls.Add(labelMevcutDurum);
                form.Controls.Add(labelYeniDurum);
                form.Controls.Add(cmbYeniDurum);
                form.Controls.Add(labelAciklama);
                form.Controls.Add(txtAciklama);
                form.Controls.Add(okButton);
                form.Controls.Add(cancelButton);

                form.AcceptButton = okButton;
                form.CancelButton = cancelButton;

                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string yeniDurum = cmbYeniDurum.SelectedItem.ToString();
                    string aciklama = txtAciklama.Text.Trim();

                    try
                    {
                        bool basarili;

                        // Eğer yeni durum "Tamamlandı" ise gerçek varış tarihini de ayarla
                        if (yeniDurum == Sefer.Durumlar.Tamamlandi)
                        {
                            basarili = seferManager.SeferTamamlandi(seciliSefer.SeferID, DateTime.Now, aciklama);
                        }
                        else
                        {
                            basarili = seferManager.SeferDurumuGuncelle(seciliSefer.SeferID, yeniDurum, aciklama);
                        }

                        if (basarili)
                        {
                            MessageBox.Show("Sefer durumu başarıyla güncellendi.", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SeferListesiniYukle(); // Listeyi yenile
                        }
                        else
                        {
                            MessageBox.Show("Sefer durumu güncellenirken bir hata oluştu.", "Hata",
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

        // Sefer Detay butonu
        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (seciliSefer == null)
            {
                MessageBox.Show("Lütfen detayını görmek için bir sefer seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sefer detay formunu göster
            MessageBox.Show($"Sefer Detay formu henüz tamamlanmadı. Sefer ID: {seciliSefer.SeferID}", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: SeferDetayForm formunu hazırlandığında bu kısmı güncelle
            // using (SeferDetayForm detayForm = new SeferDetayForm(seciliSefer))
            // {
            //     detayForm.ShowDialog();
            // }
        }

        // Bugünün Seferleri radyo butonu
        private void rdBugun_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBugun.Checked)
            {
                dtpTarih.Value = DateTime.Today;
                TariheGoreSeferleriListele();
            }
        }

        // Yarının Seferleri radyo butonu
        private void rdYarin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdYarin.Checked)
            {
                dtpTarih.Value = DateTime.Today.AddDays(1);
                TariheGoreSeferleriListele();
            }
        }

        // Seçili Tarihteki Seferleri radyo butonu
        private void rdTarihSec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTarihSec.Checked)
            {
                dtpTarih.Enabled = true;
                TariheGoreSeferleriListele();
            }
            else
            {
                dtpTarih.Enabled = false;
            }
        }

        // DateTimePicker değeri değiştiğinde
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (rdTarihSec.Checked)
            {
                TariheGoreSeferleriListele();
            }
        }

        // Durum filtresi değiştiğinde
        private void cmbDurumFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDurumFiltre.SelectedIndex >= 0)
            {
                string secilenDurum = cmbDurumFiltre.SelectedItem.ToString();
                DurumaGoreSeferleriListele(secilenDurum);
            }
        }

        // Yenile butonu
        private void btnYenile_Click(object sender, EventArgs e)
        {
            // Radio butonları ve durum filtresini sıfırla
            rdTumSeferler.Checked = true;
            cmbDurumFiltre.SelectedIndex = 0;

            // Sefer listesini yenile
            SeferListesiniYukle();
        }

        // Tüm Seferleri radyo butonu
        private void rdTumSeferler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTumSeferler.Checked)
            {
                SeferListesiniYukle();
            }
        }

        // Yaklaşan Seferleri radyo butonu
        private void rdYaklasan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdYaklasan.Checked)
            {
                try
                {
                    DataTable seferTablosu = seferManager.YaklasanSeferleriGetir(24); // Önümüzdeki 24 saat

                    // DataGridView'a verileri yükle
                    dataGridViewSeferler.AutoGenerateColumns = false;
                    dataGridViewSeferler.DataSource = seferTablosu;

                    // Bilgi etiketini güncelle
                    lblBilgi.Text = $"Yaklaşan sefer sayısı: {seferTablosu.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yaklaşan seferler listelenirken hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}