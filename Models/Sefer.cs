using System;

namespace UDO.Models
{
    public class Sefer
    {
        public int SeferID { get; set; }
        public int KalkisLimaniID { get; set; }
        public string KalkisLimaniAdi { get; set; }
        public int VarisLimaniID { get; set; }
        public string VarisLimaniAdi { get; set; }
        public DateTime KalkisTarihi { get; set; }
        public TimeSpan KalkisSaati { get; set; }
        public DateTime TahminiVarisTarihi { get; set; }
        public TimeSpan TahminiVarisSaati { get; set; }
        public int DenizOtobusuID { get; set; }
        public string DenizOtobusuAdi { get; set; }
        public int KapasiteYolcu { get; set; }
        public int DoluKoltukSayisi { get; set; }
        public string SeferDurumu { get; set; } // Planlandi, Yolda, Tamamlandi, IptalEdildi
        public decimal BiletFiyati { get; set; }
        public decimal IndirimliBiletFiyati { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public int OlusturanKullaniciID { get; set; }

        // Yardımcı metodlar
        public string SeferKodu()
        {
            return $"{KalkisLimaniAdi.Substring(0, 3)}-{VarisLimaniAdi.Substring(0, 3)}-{KalkisTarihi.ToString("ddMMyy")}-{KalkisSaati.ToString("hhmm")}";
        }

        public string SeferBilgisi()
        {
            return $"{KalkisLimaniAdi} - {VarisLimaniAdi} | {KalkisTarihi.ToString("dd.MM.yyyy")} {KalkisSaati.ToString(@"hh\:mm")}";
        }

        public string DolulukOrani()
        {
            return $"{DoluKoltukSayisi}/{KapasiteYolcu} (%{(int)((double)DoluKoltukSayisi / KapasiteYolcu * 100)})";
        }
    }
}