using System;

namespace UDO.Models
{
    public class Iskele
    {
        public int IskeleID { get; set; }
        public string IskeleAdi { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Koordinatlar { get; set; } // Enlem, boylam formatında
        public string Aciklama { get; set; }
        public bool YolcuKabulDurumu { get; set; }
        public bool AktifMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int KapasiteYolcu { get; set; }
        public int KapasiteArac { get; set; }

        // Tam adres bilgisini döndür
        public string TamAdres()
        {
            return $"{Adres}, {Sehir}";
        }

        // İskele tam adını formatla
        public string IskeleTamAdi()
        {
            return $"{IskeleAdi} ({Sehir})";
        }
    }

    // Güzergahlar ve İskeleler arasındaki ilişkiyi modellemek için yardımcı sınıf
    public class GuzergahIskele
    {
        public int GuzergahID { get; set; }
        public int IskeleID { get; set; }
        public string IskeleAdi { get; set; }
        public int SiraNo { get; set; }
        public int BeklemesDakika { get; set; }
        public string Aciklama { get; set; }
        public bool ZorunluDurak { get; set; }
    }
}