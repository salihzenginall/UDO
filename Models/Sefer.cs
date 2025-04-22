using System;

namespace UDO.Models
{
    public class Sefer
    {
        public int SeferID { get; set; }
        public int GuzergahID { get; set; }
        public string GuzergahAdi { get; set; }
        public int DenizOtobusuID { get; set; }
        public string DenizOtobusuAdi { get; set; }
        public DateTime KalkisTarihi { get; set; }
        public DateTime TahminiVarisTarihi { get; set; }
        public DateTime? GercekVarisTarihi { get; set; }
        public string SeferDurumu { get; set; }
        public int Kapasite { get; set; }
        public int DoluKoltukSayisi { get; set; }
        public int BosKoltukSayisi => Kapasite - DoluKoltukSayisi;
        public decimal BiletFiyati { get; set; }
        public string Aciklama { get; set; }
        public int SeferSorumlusuID { get; set; }
        public string SeferSorumlusuAdSoyad { get; set; }
        public bool Aktif { get; set; }

        // Doluluk oranını hesapla
        public double DolulukOrani()
        {
            if (Kapasite == 0) return 0;
            return (double)DoluKoltukSayisi / Kapasite * 100;
        }

        // Seferin başlayıp başlamadığını kontrol et
        public bool SeferBasladiMi()
        {
            return DateTime.Now > KalkisTarihi;
        }

        // Seferin tamamlanıp tamamlanmadığını kontrol et
        public bool SeferTamamlandiMi()
        {
            return GercekVarisTarihi.HasValue;
        }

        // Gecikme süresi hesapla (dakika cinsinden)
        public int GecikmeHesapla()
        {
            if (!GercekVarisTarihi.HasValue) return 0;

            TimeSpan gecikme = GercekVarisTarihi.Value - TahminiVarisTarihi;
            return (int)gecikme.TotalMinutes;
        }

        // Sefer durumlarını tanımlayan sabitler
        public static class Durumlar
        {
            public const string Programlandi = "Programlandı";
            public const string Beklemede = "Beklemede";
            public const string KapilariKapatti = "Kapılar Kapandı";
            public const string HareketEtti = "Hareket Etti";
            public const string Yolda = "Yolda";
            public const string YaklastiVarisa = "Varışa Yaklaşıldı";
            public const string Tamamlandi = "Tamamlandı";
            public const string GecikmeBekleniyor = "Gecikme Bekleniyor";
            public const string Gecikti = "Gecikti";
            public const string IptalEdildi = "İptal Edildi";
        }
    }
}