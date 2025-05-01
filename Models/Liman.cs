using System;

namespace UDO.Models
{
    public class Liman
    {
        public int LimanID { get; set; }
        public string LimanAdi { get; set; }
        public string Sehir { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public bool Aktif { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}