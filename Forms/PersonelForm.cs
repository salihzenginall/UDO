using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UDO.Models; // User modelini kullanmak için
using UDO.Forms; // Diğer formları açmak için

namespace UDO.Forms
{
    public partial class PersonelForm : Form
    {
        // Alanlar
        private Button mevcutButon;
        private Form aktifForm;
        private readonly User mevcutKullanici;

        // Yapıcı metot
        public PersonelForm(User user)
        {
            InitializeComponent();
            mevcutKullanici = user;

            // Form border olmadığı için custom control sağlamak için gerekli ayarlar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Varsayılan aktif buton olarak ana sayfa butonunu işaretle
            ButonuAktifEt(btnAnasayfa);

            // Butonların simgelerini ayarlama
            ButonSimgeleriniAyarla();
        }

        // Butonların simgelerini ve konumlarını ayarlayan metot
        private void ButonSimgeleriniAyarla()
        {
            // Windows Forms uygulamasında butonların simgelerini ayarla
            // Not: Gerçek uygulamada bu simgeler proje kaynaklarından yüklenir
            try
            {
                // Minimize, Maximize ve Close butonları için simgeler
                btnSimgeDurumu.Text = "−";
                btnSimgeDurumu.Font = new Font("Arial", 12, FontStyle.Bold);
                btnSimgeDurumu.ForeColor = Color.White;

                btnEkraniKapla.Text = "□";
                btnEkraniKapla.Font = new Font("Arial", 12, FontStyle.Bold);
                btnEkraniKapla.ForeColor = Color.White;

                btnKapat.Text = "×";
                btnKapat.Font = new Font("Arial", 12, FontStyle.Bold);
                btnKapat.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Buton simgeleri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        // Kontrollerin konumlarını ayarlayan metot
        private void KontrolPozisyonlariniAyarla()
        {
            // Butonların konumlarını panelin en sağına ayarla
            int panelGenislik = panelBaslikCubugu.Width;

            // Butonlar için daha solda yer ayarla (Kullanıcı bilgisinin solunda)
            btnKapat.Location = new Point(panelGenislik - 30, 3);
            btnEkraniKapla.Location = new Point(panelGenislik - 60, 3);
            btnSimgeDurumu.Location = new Point(panelGenislik - 90, 3);

            // Kullanıcı bilgisini daha kısa tut ve konumunu ayarla
            lblKullaniciBilgisi.MaximumSize = new Size(300, 25);
            lblKullaniciBilgisi.Location = new Point(panelGenislik - 400, 15);
            lblKullaniciBilgisi.TextAlign = ContentAlignment.MiddleRight;

            // Tarih saat bilgisinin konumunu ayarla
            lblTarihSaat.Location = new Point(panelGenislik - 400, 40);
            lblTarihSaat.TextAlign = ContentAlignment.MiddleRight;
        }

        // DLL Import, formu taşımak için gerekli
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void FareKaptureSerbestBirak();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void MesajGonder(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Tema rengini seçen metot
        private Color TemaRenginiSec()
        {
            // UDO deniz teması için sabit bir renk
            return Color.FromArgb(0, 127, 180);
        }

        // Butonları aktifleştiren metot
        private void ButonuAktifEt(object btnGonderen)
        {
            if (btnGonderen != null)
            {
                if (mevcutButon != (Button)btnGonderen)
                {
                    ButonuPasifEt();
                    Color renk = TemaRenginiSec();
                    mevcutButon = (Button)btnGonderen;
                    mevcutButon.BackColor = Color.FromArgb(0, 60, 105);
                    mevcutButon.ForeColor = Color.White;
                    mevcutButon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                    panelBaslikCubugu.BackColor = renk;
                    panelLogo.BackColor = Color.FromArgb(0, 60, 105);
                }
            }
        }

        // Butonları pasifleştiren metot
        private void ButonuPasifEt()
        {
            foreach (Control oncekiBtn in panelMenu.Controls)
            {
                if (oncekiBtn.GetType() == typeof(Button))
                {
                    oncekiBtn.BackColor = Color.FromArgb(0, 71, 118);
                    oncekiBtn.ForeColor = Color.White;
                    oncekiBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        // Alt formları açan metot
        private void AltFormuAc(Form altForm, object btnGonderen)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }

            ButonuAktifEt(btnGonderen);

            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;

            this.panelMasaustuAlani.Controls.Add(altForm);
            this.panelMasaustuAlani.Tag = altForm;

            altForm.BringToFront();
            altForm.Show();

            lblBaslik.Text = altForm.Text.ToUpper();
        }

        // Dashboard/Ana sayfa
        private void PanoyuYukle()
        {
            // Önce tüm kontrolleri temizle
            panelMasaustuAlani.Controls.Clear();

            // İstatistik kartlarını oluştur (Örnek verilerle)
            IstatistikKartlariniOlustur();

            // Haftalık yolcu istatistiklerini oluştur (Örnek verilerle)
            HaftalikIstatistikleriOlustur();

            // Yaklaşan seferleri oluştur (Örnek verilerle)
            YaklasanSeferleriOlustur();

            aracCubuguDurumEtiketi.Text = "Durum: Hazır | Son giriş: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        // İstatistik kartlarını oluşturan metot (YöneticiForm'dan kopyalanmıştır)
        private void IstatistikKartlariniOlustur()
        {
            // Günlük Satışlar Kartı
            Panel pnlGunlukSatislar = PanelOlustur(20, 20, 300, 150, Color.FromArgb(230, 242, 247));

            Label lblGunlukSatislarBaslik = EtiketOlustur("Günlük Bilet Satışları", 10, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlGunlukSatislar.Controls.Add(lblGunlukSatislarBaslik);

            Label lblGunlukSatislarDeger = EtiketOlustur("₺ 1.500", 90, 50, new Font("Segoe UI", 36, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlGunlukSatislar.Controls.Add(lblGunlukSatislarDeger);

            Label lblGunlukSatislarAltYazi = EtiketOlustur("Bugünkü Toplam Ciro", 75, 110, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
            pnlGunlukSatislar.Controls.Add(lblGunlukSatislarAltYazi);

            panelMasaustuAlani.Controls.Add(pnlGunlukSatislar);

            // Bugün Satılan Bilet Sayısı Kartı
            Panel pnlBugunSatilanBilet = PanelOlustur(330, 20, 300, 150, Color.FromArgb(230, 242, 247));

            Label lblBugunSatilanBiletBaslik = EtiketOlustur("Bugün Satılan Bilet Sayısı", 10, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlBugunSatilanBilet.Controls.Add(lblBugunSatilanBiletBaslik);

            Label lblBugunSatilanBiletDeger = EtiketOlustur("50", 125, 50, new Font("Segoe UI", 36, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlBugunSatilanBilet.Controls.Add(lblBugunSatilanBiletDeger);

            Label lblBugunSatilanBiletAltYazi = EtiketOlustur("Toplam Bilet Adedi", 100, 110, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
            pnlBugunSatilanBilet.Controls.Add(lblBugunSatilanBiletAltYazi);

            panelMasaustuAlani.Controls.Add(pnlBugunSatilanBilet);

            // Yeni Kayıt Olan Müşteri Kartı
            Panel pnlYeniMusteri = PanelOlustur(640, 20, 300, 150, Color.FromArgb(230, 242, 247));

            Label lblYeniMusteriBaslik = EtiketOlustur("Yeni Kayıt Olan Müşteri", 10, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlYeniMusteri.Controls.Add(lblYeniMusteriBaslik);

            Label lblYeniMusteriDeger = EtiketOlustur("5", 125, 50, new Font("Segoe UI", 36, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlYeniMusteri.Controls.Add(lblYeniMusteriDeger);

            Label lblYeniMusteriAltYazi = EtiketOlustur("Bugün Kayıt Olan", 100, 110, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
            pnlYeniMusteri.Controls.Add(lblYeniMusteriAltYazi);

            panelMasaustuAlani.Controls.Add(pnlYeniMusteri);
        }

        // Haftalık istatistikleri oluşturan metot (YöneticiForm'dan kopyalanmıştır)
        private void HaftalikIstatistikleriOlustur()
        {
            // Haftalık istatistikler panel
            Panel pnlHaftalikIstatistikler = PanelOlustur(20, 190, 920, 180, Color.FromArgb(230, 242, 247));

            // Başlık
            Label lblHaftalikIstatistiklerBaslik = EtiketOlustur("Haftalık Bilet Satış İstatistikleri", 20, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlHaftalikIstatistikler.Controls.Add(lblHaftalikIstatistiklerBaslik);

            // Grafik için çubuklarını temsil eden paneller
            CubukGrafiginiOlustur(pnlHaftalikIstatistikler);

            panelMasaustuAlani.Controls.Add(pnlHaftalikIstatistikler);
        }

        // Grafik çubuklarını oluşturan metot (YöneticiForm'dan kopyalanmıştır)
        private void CubukGrafiginiOlustur(Panel ebeveynPanel)
        {
            string[] gunler = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };
            int[] degerler = { 150, 120, 180, 160, 200, 100, 170 }; // Örnek satış değerleri

            int baslangicX = 70;
            int cubukGenislik = 70;
            int aralik = 30;
            int maksYukseklik = 120;
            int tabanY = 160;

            for (int i = 0; i < gunler.Length; i++)
            {
                // Çubuk yüksekliği (değere göre ölçeklendirme)
                int cubukYukseklik = (int)(((double)degerler[i] / 200) * maksYukseklik); // Max satış 200 olarak varsayıldı

                // Çubuk panel
                Panel pnlCubuk = PanelOlustur(baslangicX + i * (cubukGenislik + aralik), tabanY - cubukYukseklik, cubukGenislik, cubukYukseklik, Color.FromArgb(52, 152, 219));
                ebeveynPanel.Controls.Add(pnlCubuk);

                // Gün etiketi
                Label lblGun = EtiketOlustur(gunler[i], baslangicX + i * (cubukGenislik + aralik) + cubukGenislik / 2 - 10, tabanY + 5, new Font("Segoe UI", 9, FontStyle.Regular), Color.DimGray);
                ebeveynPanel.Controls.Add(lblGun);
            }
        }

        // Yaklaşan seferleri oluşturan metot (YöneticiForm'dan kopyalanmıştır)
        private void YaklasanSeferleriOlustur()
        {
            // Ana panel
            Panel pnlYaklasanSeferler = PanelOlustur(20, 390, 920, 180, Color.FromArgb(230, 242, 247));

            // Başlık
            Label lblYaklasanSeferlerBaslik = EtiketOlustur("Yaklaşan Seferler", 20, 10, new Font("Segoe UI", 12, FontStyle.Bold), Color.FromArgb(0, 127, 180));
            pnlYaklasanSeferler.Controls.Add(lblYaklasanSeferlerBaslik);

            // Tablo başlıkları
            string[] basliklar = { "Saat", "Güzergah", "Deniz Otobüsü", "Doluluk", "İşlem" };
            int[] baslikGenislikleri = { 80, 200, 200, 100, 100 };
            int baslikY = 45;
            int baslangicX = 20;

            for (int i = 0; i < basliklar.Length; i++)
            {
                Label lblBaslik = EtiketOlustur(basliklar[i], baslangicX, baslikY, new Font("Segoe UI", 10, FontStyle.Bold), Color.FromArgb(0, 71, 118));
                pnlYaklasanSeferler.Controls.Add(lblBaslik);
                baslangicX += baslikGenislikleri[i] + 10;
            }

            // Tablo verileri (Örnek veriler)
            string[,] seferVerileri = {
                { "09:30", "İstanbul - Bursa", "Deniz Otobüsü 3", "92/120 Yolcu" },
                { "10:15", "Bursa - Yalova", "Deniz Otobüsü 7", "45/80 Yolcu" }
            };

            for (int satir = 0; satir < 2; satir++)
            {
                baslangicX = 20;

                for (int sutun = 0; sutun < 4; sutun++)
                {
                    Label lblHucre = EtiketOlustur(seferVerileri[satir, sutun], baslangicX, baslikY + 35 + (satir * 35), new Font("Segoe UI", 9, FontStyle.Regular), Color.Black);
                    pnlYaklasanSeferler.Controls.Add(lblHucre);
                    baslangicX += baslikGenislikleri[sutun] + 10;
                }

                // Bilet Satış butonu (Personel için önemli)
                Button btnBiletSat = new Button();
                btnBiletSat.Text = "Bilet Sat";
                btnBiletSat.Size = new Size(80, 25);
                btnBiletSat.Location = new Point(baslangicX, baslikY + 30 + (satir * 35));
                btnBiletSat.BackColor = Color.FromArgb(0, 192, 0); // Yeşil renk
                btnBiletSat.ForeColor = Color.White;
                btnBiletSat.FlatStyle = FlatStyle.Flat;
                btnBiletSat.Tag = satir; // Sefer ID'si yerine şimdilik satır indeksi
                btnBiletSat.Click += (s, e) =>
                {
                    // Bilet satış formunu açacak kod buraya gelecek
                    MessageBox.Show($"'{seferVerileri[(int)((Button)s).Tag, 1]}' seferi için bilet satış ekranı açılacak.", "Bilet Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                pnlYaklasanSeferler.Controls.Add(btnBiletSat);
            }

            panelMasaustuAlani.Controls.Add(pnlYaklasanSeferler);
        }


        // Panel oluşturan yardımcı metot
        private Panel PanelOlustur(int x, int y, int genislik, int yukseklik, Color arkaRenk)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(genislik, yukseklik);
            panel.BackColor = arkaRenk;
            panel.BorderStyle = BorderStyle.FixedSingle;
            return panel;
        }

        // Etiket oluşturan yardımcı metot
        private Label EtiketOlustur(string metin, int x, int y, Font yazi, Color onRenk)
        {
            Label etiket = new Label();
            etiket.Text = metin;
            etiket.AutoSize = true;
            etiket.Location = new Point(x, y);
            etiket.Font = yazi;
            etiket.ForeColor = onRenk;
            return etiket;
        }

        // Form Events
        private void PersonelForm_Load(object sender, EventArgs e)
        {
            // Form başlığını kullanıcı adıyla güncelle
            this.Text = $"UDO - Hoş Geldiniz, {mevcutKullanici.TamAd()}";

            // Kullanıcı bilgilerini göster - Kullanıcı adını ve rolü ekleyerek güncelle
            lblKullaniciBilgisi.Text = $"Kullanıcı: {mevcutKullanici.TamAd()} Personel";
            lblBaslik.Text = "ANA SAYFA";

            // Tarih saat bilgisini güncelle
            TarihZamaniGuncelle();

            // Kontrollerin konumlarını ayarla (üst üste binmeyi önlemek için)
            KontrolPozisyonlariniAyarla();

            // Durum çubuğunu güncelle
            aracCubuguDurumEtiketi.Text = "Durum: Hazır | Son giriş: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            // Dashboard'u yükle
            PanoyuYukle();
        }

        // Timer event - tarih ve saati güncellemek için
        private void zamanlayici1_Tick(object sender, EventArgs e)
        {
            TarihZamaniGuncelle();
        }

        // Tarih ve saat bilgisini güncelleyen metot
        private void TarihZamaniGuncelle()
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        // Form başlık çubuğunu taşıma işlevi
        private void panelBaslikCubugu_MouseDown(object sender, MouseEventArgs e)
        {
            FareKaptureSerbestBirak();
            MesajGonder(this.Handle, 0x112, 0xf012, 0);
        }

        // Kapat butonunun tıklama olayı
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ekranı kapla butonunun tıklama olayı
        private void btnEkraniKapla_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Simge durumuna küçült butonunun tıklama olayı
        private void btnSimgeDurumu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Ana Sayfa butonunun tıklama olayı
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            if (aktifForm != null)
                aktifForm.Close();

            ButonuAktifEt(sender);
            lblBaslik.Text = "ANA SAYFA";
            PanoyuYukle();
        }

        // Müşteri Yönetimi butonunun tıklama olayı
        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            // Müşteri Yönetimi formunu açmak için
            AltFormuAc(new MusteriYonetimForm(), sender);
            lblBaslik.Text = "MÜŞTERİ YÖNETİMİ";
        }

        // Bilet Satış butonunun tıklama olayı
        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            // Bilet Satış formunu açmak için (Henüz oluşturulmadı)
            // AltFormuAc(new BiletSatisForm(mevcutKullanici), sender);
            MessageBox.Show("Bilet Satış modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblBaslik.Text = "BİLET SATIŞ";
            ButonuAktifEt(sender);
        }

        // Raporlar butonunun tıklama olayı
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            // Raporlar formunu açmak için
            AltFormuAc(new RaporlarForm(), sender);
            lblBaslik.Text = "RAPORLAR";
        }

        // Ayarlar butonunun tıklama olayı
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            // Ayarlar formunu açmak için
            // AltFormuAc(new AyarlarForm(), sender);
            MessageBox.Show("Ayarlar modülü yakında eklenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblBaslik.Text = "AYARLAR";
            ButonuAktifEt(sender);
        }

        // Çıkış butonunun tıklama olayı
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
