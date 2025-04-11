using System;

namespace UDO.Models
{
    public class User
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public int RolID { get; set; }
        public string RolAdi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
        public string Adres { get; set; }
        public bool Aktif { get; set; }

        // Kullanıcının yönetici olup olmadığını kontrol eden fonksiyon
        public bool IsYonetici()
        {
            return RolAdi.Equals("Yonetici", StringComparison.OrdinalIgnoreCase);
        }

        // Kullanıcının personel olup olmadığını kontrol eden fonksiyon
        public bool IsPersonel()
        {
            return RolAdi.Equals("Personel", StringComparison.OrdinalIgnoreCase);
        }

        // Kullanıcının müşteri olup olmadığını kontrol eden fonksiyon
        public bool IsMusteri()
        {
            return RolAdi.Equals("Musteri", StringComparison.OrdinalIgnoreCase);
        }

        // Tam ad döndüren fonksiyon
        public string TamAd()
        {
            return $"{Ad} {Soyad}";
        }
    }
}