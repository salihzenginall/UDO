using System;

namespace UDO.Models
{
    public class DenizOtobusu
    {
        public int DenizOtobusuID { get; set; }
        public string DenizOtobusuAdi { get; set; }
        public int? ModelID { get; set; }
        public string ModelAdi { get; set; }
        public int? UretimYili { get; set; }
        public string Plaka { get; set; }
        public string SeriNo { get; set; }
        public int Kapasite { get; set; }
        public int? MaksimumHiz { get; set; }
        public DateTime? SonBakimTarihi { get; set; }
        public DateTime? SonrakiBakimTarihi { get; set; }
        public string Aciklama { get; set; }
        public int DurumID { get; set; }
        public string DurumAdi { get; set; }
        public bool AktifMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        // Deniz Otobüsü durumlarını tanımlayan sabitler
        public static class Durumlar
        {
            public const int Aktif = 1;
            public const int Bakimda = 2;
            public const int Arizali = 3;
            public const int HizmetDisi = 4;

            // Durum ID'sinden durum adını döndüren yardımcı metot
            public static string GetDurumAdi(int durumID)
            {
                switch (durumID)
                {
                    case Aktif:
                        return "Aktif";
                    case Bakimda:
                        return "Bakımda";
                    case Arizali:
                        return "Arızalı";
                    case HizmetDisi:
                        return "Hizmet Dışı";
                    default:
                        return "Bilinmiyor";
                }
            }
        }

        // Bakım durumunu kontrol eden metot
        public bool BakimDurumuKontrol()
        {
            // Eğer sonraki bakım tarihi geçmişse veya gelecek 7 gün içindeyse uyarı verilmeli
            if (SonrakiBakimTarihi.HasValue)
            {
                DateTime simdikiTarih = DateTime.Now.Date;
                DateTime bakimTarihi = SonrakiBakimTarihi.Value.Date;

                // Bakım tarihi geçmiş mi?
                if (bakimTarihi < simdikiTarih)
                {
                    return false;
                }

                // Bakım tarihi gelecek 7 gün içinde mi?
                if ((bakimTarihi - simdikiTarih).TotalDays <= 7)
                {
                    return false;
                }
            }

            return true;
        }

        // Deniz otobüsünün müsait olup olmadığını kontrol eden metot
        public bool MusaitMi()
        {
            return DurumID == Durumlar.Aktif && AktifMi;
        }

        // Tam bilgi metni
        public string TamBilgi()
        {
            string bilgi = $"{DenizOtobusuAdi} - Kapasite: {Kapasite} Yolcu";

            if (!string.IsNullOrEmpty(Plaka))
            {
                bilgi += $", Plaka: {Plaka}";
            }

            if (UretimYili.HasValue)
            {
                bilgi += $", Üretim Yılı: {UretimYili}";
            }

            return bilgi;
        }
    }
}