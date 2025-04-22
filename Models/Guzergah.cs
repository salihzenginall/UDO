using System;
using System.Collections.Generic;

namespace UDO.Models
{
    public class Guzergah
    {
        public int GuzergahID { get; set; }
        public string GuzergahKodu { get; set; }
        public string GuzergahAdi { get; set; }
        public string Aciklama { get; set; }
        public double MesafeKM { get; set; }
        public int TahminiSureDakika { get; set; }
        public bool AktifMi { get; set; }  // Bu özellik hatada belirtilmiş
        public DateTime EklenmeTarihi { get; set; }

        // Hata mesajında belirtilen eksik özellikler
        public string BaslangicIskeleAdi { get; set; }
        public string VarisIskeleAdi { get; set; }
        public double MesafeDenizMili { get; set; }
        public int AraIskeleSayisi { get; set; }
        public string AraIskeleListesi { get; set; }

        // Navigation properties
        public List<GuzergahIskele> Iskeleler { get; set; }

        public Guzergah()
        {
            Iskeleler = new List<GuzergahIskele>();
        }

        // Tahmini süreyi formatlayan metod
        public string TahminiSureyiFormatla()
        {
            int saat = TahminiSureDakika / 60;
            int dakika = TahminiSureDakika % 60;

            if (saat > 0)
            {
                return $"{saat} saat {dakika} dakika";
            }
            else
            {
                return $"{dakika} dakika";
            }
        }

        // Güzergah tam adını döndüren metod
        public string GuzergahTamAdi()
        {
            if (!string.IsNullOrEmpty(BaslangicIskeleAdi) && !string.IsNullOrEmpty(VarisIskeleAdi))
            {
                return $"{GuzergahAdi} ({BaslangicIskeleAdi} - {VarisIskeleAdi})";
            }

            return GuzergahAdi;
        }
    }
}