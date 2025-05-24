using System;

namespace UDO.Models
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public int KullaniciID { get; set; }
        public string MusteriNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int? UyrukID { get; set; }
        public string UyrukAdi { get; set; } // Join ile gelecek
        public int ToplamSeyahat { get; set; }
        public decimal ToplamHarcama { get; set; }
        public int SadakatPuani { get; set; }
        public decimal IndirimOrani { get; set; }
        public string KayitKanali { get; set; }

        // User tablosundan gelecek bilgiler
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
        public string Adres { get; set; }
        public bool Aktif { get; set; }

        // Yardımcı metodlar
        public string TamAd()
        {
            return $"{Ad} {Soyad}";
        }

        public string MusteriTamBilgi()
        {
            return $"{MusteriNo} - {TamAd()}";
        }

        public int Yas()
        {
            if (DogumTarihi.HasValue)
            {
                return DateTime.Now.Year - DogumTarihi.Value.Year;
            }
            return 0;
        }

        public string SadakatSeviyesi()
        {
            if (SadakatPuani >= 1000) return "Altın";
            if (SadakatPuani >= 500) return "Gümüş";
            if (SadakatPuani >= 100) return "Bronz";
            return "Standart";
        }

        public string MusteriDurum()
        {
            return Aktif ? "Aktif" : "Pasif";
        }

        public bool VipMusteriMi()
        {
            return ToplamSeyahat >= 10 || ToplamHarcama >= 1000;
        }

        public decimal OrtalamaSeyahatTutari()
        {
            return ToplamSeyahat > 0 ? ToplamHarcama / ToplamSeyahat : 0;
        }
    }
}