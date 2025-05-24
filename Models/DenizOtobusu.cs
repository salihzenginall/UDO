using System;

namespace UDO.Models
{
    public class DenizOtobusu
    {
        public int DenizOtobusuID { get; set; }
        public string DenizOtobusuAdi { get; set; }
        public string Model { get; set; }
        public int Kapasite { get; set; }
        public int UretimYili { get; set; }
        public string Marka { get; set; }
        public string SeriNumarasi { get; set; }
        public decimal YakitKapasitesi { get; set; } // Litre cinsinden
        public string MotorTipi { get; set; }
        public int MaxHiz { get; set; } // Knot cinsinden
        public bool Aktif { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime? SonBakimTarihi { get; set; }
        public DateTime? SonMuayeneTarihi { get; set; }
        public string Aciklama { get; set; }
        public string DurumNotu { get; set; } // Bakım, Arıza vs.

        // Yardımcı metodlar
        public string TamBilgi()
        {
            return $"{DenizOtobusuAdi} ({Model}) - Kapasite: {Kapasite}";
        }

        public string DurumBilgisi()
        {
            return Aktif ? "Aktif" : "Pasif";
        }

        public bool BakimZamaniMi()
        {
            // Son bakımdan 6 ay geçtiyse bakım zamanı
            return SonBakimTarihi == null ||
                   SonBakimTarihi.Value.AddMonths(6) <= DateTime.Now;
        }

        public bool MuayeneZamaniMi()
        {
            // Son muayeneden 1 yıl geçtiyse muayene zamanı
            return SonMuayeneTarihi == null ||
                   SonMuayeneTarihi.Value.AddYears(1) <= DateTime.Now;
        }

        public int Yasi()
        {
            return DateTime.Now.Year - UretimYili;
        }

        public string YasBilgisi()
        {
            int yas = Yasi();
            if (yas <= 5) return "Yeni";
            if (yas <= 15) return "Orta";
            return "Eski";
        }
    }
}