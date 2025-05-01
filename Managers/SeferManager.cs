using System;
using System.Data;
using System.Data.SqlClient;
using UDO.Models;
using UDO.Data;

namespace UDO.Managers
{
    public class SeferManager
    {
        private readonly DBConnection dbConnection;

        public SeferManager()
        {
            dbConnection = new DBConnection();
        }

        // Tüm seferleri getiren metot
        public DataTable TumSeferleriGetir()
        {
            string sorgu = @"SELECT s.SeferID, kl.LimanAdi AS KalkisLimaniAdi, vl.LimanAdi AS VarisLimaniAdi, 
                           s.KalkisTarihi, s.KalkisSaati, s.TahminiVarisTarihi, s.TahminiVarisSaati, 
                           do.DenizOtobusuAdi, s.KapasiteYolcu, s.DoluKoltukSayisi, s.SeferDurumu, 
                           s.BiletFiyati, s.OlusturmaTarihi
                           FROM Seferler s
                           INNER JOIN Limanlar kl ON s.KalkisLimaniID = kl.LimanID
                           INNER JOIN Limanlar vl ON s.VarisLimaniID = vl.LimanID
                           INNER JOIN DenizOtobusleri do ON s.DenizOtobusuID = do.DenizOtobusuID
                           ORDER BY s.KalkisTarihi, s.KalkisSaati";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Sefer arama metodu
        public DataTable SeferAra(string aramaMetni)
        {
            string sorgu = @"SELECT s.SeferID, kl.LimanAdi AS KalkisLimaniAdi, vl.LimanAdi AS VarisLimaniAdi, 
                           s.KalkisTarihi, s.KalkisSaati, s.TahminiVarisTarihi, s.TahminiVarisSaati, 
                           do.DenizOtobusuAdi, s.KapasiteYolcu, s.DoluKoltukSayisi, s.SeferDurumu, 
                           s.BiletFiyati, s.OlusturmaTarihi
                           FROM Seferler s
                           INNER JOIN Limanlar kl ON s.KalkisLimaniID = kl.LimanID
                           INNER JOIN Limanlar vl ON s.VarisLimaniID = vl.LimanID
                           INNER JOIN DenizOtobusleri do ON s.DenizOtobusuID = do.DenizOtobusuID
                           WHERE kl.LimanAdi LIKE @AramaMetni OR vl.LimanAdi LIKE @AramaMetni 
                           OR do.DenizOtobusuAdi LIKE @AramaMetni OR s.SeferDurumu LIKE @AramaMetni
                           ORDER BY s.KalkisTarihi, s.KalkisSaati";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@AramaMetni", SqlDbType.VarChar) { Value = "%" + aramaMetni + "%" }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Sefer durumuna göre filtreleme metodu
        public DataTable SeferleriDurumaGoreFiltrele(string seferDurumu)
        {
            string sorgu = @"SELECT s.SeferID, kl.LimanAdi AS KalkisLimaniAdi, vl.LimanAdi AS VarisLimaniAdi, 
                           s.KalkisTarihi, s.KalkisSaati, s.TahminiVarisTarihi, s.TahminiVarisSaati, 
                           do.DenizOtobusuAdi, s.KapasiteYolcu, s.DoluKoltukSayisi, s.SeferDurumu, 
                           s.BiletFiyati, s.OlusturmaTarihi
                           FROM Seferler s
                           INNER JOIN Limanlar kl ON s.KalkisLimaniID = kl.LimanID
                           INNER JOIN Limanlar vl ON s.VarisLimaniID = vl.LimanID
                           INNER JOIN DenizOtobusleri do ON s.DenizOtobusuID = do.DenizOtobusuID
                           WHERE s.SeferDurumu = @SeferDurumu
                           ORDER BY s.KalkisTarihi, s.KalkisSaati";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@SeferDurumu", SqlDbType.VarChar) { Value = seferDurumu }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Sefer eklemek için metot
        public bool SeferEkle(Sefer sefer)
        {
            string sorgu = @"INSERT INTO Seferler (KalkisLimaniID, VarisLimaniID, KalkisTarihi, KalkisSaati, 
                           TahminiVarisTarihi, TahminiVarisSaati, DenizOtobusuID, KapasiteYolcu, 
                           DoluKoltukSayisi, SeferDurumu, BiletFiyati, IndirimliBiletFiyati, Aciklama, 
                           OlusturmaTarihi, OlusturanKullaniciID)
                           VALUES (@KalkisLimaniID, @VarisLimaniID, @KalkisTarihi, @KalkisSaati, 
                           @TahminiVarisTarihi, @TahminiVarisSaati, @DenizOtobusuID, @KapasiteYolcu, 
                           @DoluKoltukSayisi, @SeferDurumu, @BiletFiyati, @IndirimliBiletFiyati, @Aciklama, 
                           GETDATE(), @OlusturanKullaniciID)";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@KalkisLimaniID", SqlDbType.Int) { Value = sefer.KalkisLimaniID },
                new SqlParameter("@VarisLimaniID", SqlDbType.Int) { Value = sefer.VarisLimaniID },
                new SqlParameter("@KalkisTarihi", SqlDbType.Date) { Value = sefer.KalkisTarihi },
                new SqlParameter("@KalkisSaati", SqlDbType.Time) { Value = sefer.KalkisSaati },
                new SqlParameter("@TahminiVarisTarihi", SqlDbType.Date) { Value = sefer.TahminiVarisTarihi },
                new SqlParameter("@TahminiVarisSaati", SqlDbType.Time) { Value = sefer.TahminiVarisSaati },
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = sefer.DenizOtobusuID },
                new SqlParameter("@KapasiteYolcu", SqlDbType.Int) { Value = sefer.KapasiteYolcu },
                new SqlParameter("@DoluKoltukSayisi", SqlDbType.Int) { Value = sefer.DoluKoltukSayisi },
                new SqlParameter("@SeferDurumu", SqlDbType.VarChar) { Value = sefer.SeferDurumu },
                new SqlParameter("@BiletFiyati", SqlDbType.Decimal) { Value = sefer.BiletFiyati },
                new SqlParameter("@IndirimliBiletFiyati", SqlDbType.Decimal) { Value = sefer.IndirimliBiletFiyati },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)sefer.Aciklama ?? DBNull.Value },
                new SqlParameter("@OlusturanKullaniciID", SqlDbType.Int) { Value = sefer.OlusturanKullaniciID }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Sefer detayını getiren metot
        public Sefer SeferDetayGetirById(int seferID)
        {
            string sorgu = @"SELECT s.SeferID, s.KalkisLimaniID, kl.LimanAdi AS KalkisLimaniAdi, 
                   s.VarisLimaniID, vl.LimanAdi AS VarisLimaniAdi,
                   s.KalkisTarihi, s.KalkisSaati, s.TahminiVarisTarihi, s.TahminiVarisSaati,
                   s.DenizOtobusuID, do.DenizOtobusuAdi, s.KapasiteYolcu, s.DoluKoltukSayisi,
                   s.SeferDurumu, s.BiletFiyati, s.IndirimliBiletFiyati, s.Aciklama,
                   s.OlusturmaTarihi, s.GuncellenmeTarihi, s.OlusturanKullaniciID
                   FROM Seferler s
                   INNER JOIN Limanlar kl ON s.KalkisLimaniID = kl.LimanID
                   INNER JOIN Limanlar vl ON s.VarisLimaniID = vl.LimanID
                   INNER JOIN DenizOtobusleri do ON s.DenizOtobusuID = do.DenizOtobusuID
                   WHERE s.SeferID = @SeferID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
        new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID }
            };

            DataTable sonuc = dbConnection.ExecuteQuery(sorgu, parametreler);

            if (sonuc != null && sonuc.Rows.Count > 0)
            {
                DataRow row = sonuc.Rows[0];

                return new Sefer
                {
                    SeferID = Convert.ToInt32(row["SeferID"]),
                    KalkisLimaniID = Convert.ToInt32(row["KalkisLimaniID"]),
                    KalkisLimaniAdi = row["KalkisLimaniAdi"].ToString(),
                    VarisLimaniID = Convert.ToInt32(row["VarisLimaniID"]),
                    VarisLimaniAdi = row["VarisLimaniAdi"].ToString(),
                    KalkisTarihi = Convert.ToDateTime(row["KalkisTarihi"]),
                    KalkisSaati = (TimeSpan)row["KalkisSaati"],
                    TahminiVarisTarihi = Convert.ToDateTime(row["TahminiVarisTarihi"]),
                    TahminiVarisSaati = (TimeSpan)row["TahminiVarisSaati"],
                    DenizOtobusuID = Convert.ToInt32(row["DenizOtobusuID"]),
                    DenizOtobusuAdi = row["DenizOtobusuAdi"].ToString(),
                    KapasiteYolcu = Convert.ToInt32(row["KapasiteYolcu"]),
                    DoluKoltukSayisi = Convert.ToInt32(row["DoluKoltukSayisi"]),
                    SeferDurumu = row["SeferDurumu"].ToString(),
                    BiletFiyati = Convert.ToDecimal(row["BiletFiyati"]),
                    IndirimliBiletFiyati = row["IndirimliBiletFiyati"] != DBNull.Value ? Convert.ToDecimal(row["IndirimliBiletFiyati"]) : 0,
                    Aciklama = row["Aciklama"] != DBNull.Value ? row["Aciklama"].ToString() : null,
                    OlusturmaTarihi = Convert.ToDateTime(row["OlusturmaTarihi"]),
                    GuncellenmeTarihi = row["GuncellenmeTarihi"] != DBNull.Value ? Convert.ToDateTime(row["GuncellenmeTarihi"]) : (DateTime?)null,
                    OlusturanKullaniciID = Convert.ToInt32(row["OlusturanKullaniciID"])
                };
            }

            return null;
        }

        // Sefer güncelleme metodu
        public bool SeferGuncelle(Sefer sefer)
        {
            string sorgu = @"UPDATE Seferler SET 
                   KalkisLimaniID = @KalkisLimaniID,
                   VarisLimaniID = @VarisLimaniID,
                   KalkisTarihi = @KalkisTarihi,
                   KalkisSaati = @KalkisSaati,
                   TahminiVarisTarihi = @TahminiVarisTarihi,
                   TahminiVarisSaati = @TahminiVarisSaati,
                   DenizOtobusuID = @DenizOtobusuID,
                   KapasiteYolcu = @KapasiteYolcu,
                   BiletFiyati = @BiletFiyati,
                   IndirimliBiletFiyati = @IndirimliBiletFiyati,
                   Aciklama = @Aciklama,
                   GuncellenmeTarihi = GETDATE()
                   WHERE SeferID = @SeferID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
        new SqlParameter("@SeferID", SqlDbType.Int) { Value = sefer.SeferID },
        new SqlParameter("@KalkisLimaniID", SqlDbType.Int) { Value = sefer.KalkisLimaniID },
        new SqlParameter("@VarisLimaniID", SqlDbType.Int) { Value = sefer.VarisLimaniID },
        new SqlParameter("@KalkisTarihi", SqlDbType.Date) { Value = sefer.KalkisTarihi },
        new SqlParameter("@KalkisSaati", SqlDbType.Time) { Value = sefer.KalkisSaati },
        new SqlParameter("@TahminiVarisTarihi", SqlDbType.Date) { Value = sefer.TahminiVarisTarihi },
        new SqlParameter("@TahminiVarisSaati", SqlDbType.Time) { Value = sefer.TahminiVarisSaati },
        new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = sefer.DenizOtobusuID },
        new SqlParameter("@KapasiteYolcu", SqlDbType.Int) { Value = sefer.KapasiteYolcu },
        new SqlParameter("@BiletFiyati", SqlDbType.Decimal) { Value = sefer.BiletFiyati },
        new SqlParameter("@IndirimliBiletFiyati", SqlDbType.Decimal) { Value = sefer.IndirimliBiletFiyati > 0 ? (object)sefer.IndirimliBiletFiyati : DBNull.Value },
        new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)sefer.Aciklama ?? DBNull.Value }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Sefer durumunu güncelleyen metot
        public bool SeferDurumunuGuncelle(int seferID, string yeniDurum)
        {
            string sorgu = "UPDATE Seferler SET SeferDurumu = @SeferDurumu, GuncellenmeTarihi = GETDATE() WHERE SeferID = @SeferID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
        new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID },
        new SqlParameter("@SeferDurumu", SqlDbType.VarChar) { Value = yeniDurum }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

    }
}