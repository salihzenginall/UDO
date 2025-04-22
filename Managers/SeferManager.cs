using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
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
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            ORDER BY s.KalkisTarihi DESC";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Belirli bir tarihe göre seferleri getiren metot
        public DataTable SeferleriTariheGoreGetir(DateTime tarih)
        {
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            WHERE CONVERT(date, s.KalkisTarihi) = CONVERT(date, @Tarih)
                            ORDER BY s.KalkisTarihi";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Tarih", SqlDbType.DateTime) { Value = tarih }
            };

            return dbConnection.ExecuteQuery(sorgu, parameters);
        }

        // Tarih aralığına göre seferleri getiren metot
        public DataTable SeferleriTarihAraliginaGoreGetir(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            WHERE s.KalkisTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi
                            ORDER BY s.KalkisTarihi";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BaslangicTarihi", SqlDbType.DateTime) { Value = baslangicTarihi },
                new SqlParameter("@BitisTarihi", SqlDbType.DateTime) { Value = bitisTarihi }
            };

            return dbConnection.ExecuteQuery(sorgu, parameters);
        }

        // Duruma göre seferleri getiren metot
        public DataTable SeferleriDurumaGoreGetir(string seferDurumu)
        {
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            WHERE s.SeferDurumu = @SeferDurumu
                            ORDER BY s.KalkisTarihi";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferDurumu", SqlDbType.VarChar) { Value = seferDurumu }
            };

            return dbConnection.ExecuteQuery(sorgu, parameters);
        }

        // Güzergaha göre seferleri getiren metot
        public DataTable SeferleriGuzergahaGoreGetir(int guzergahID)
        {
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            WHERE s.GuzergahID = @GuzergahID
                            ORDER BY s.KalkisTarihi";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID }
            };

            return dbConnection.ExecuteQuery(sorgu, parameters);
        }

        // Yaklaşan seferleri getiren metot (şu andan itibaren belirli bir saat içinde)
        public DataTable YaklasanSeferleriGetir(int saatIcinde = 24)
        {
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            WHERE s.KalkisTarihi BETWEEN GETDATE() AND DATEADD(hour, @SaatIcinde, GETDATE())
                            AND s.SeferDurumu NOT IN ('Tamamlandı', 'İptal Edildi')
                            ORDER BY s.KalkisTarihi";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SaatIcinde", SqlDbType.Int) { Value = saatIcinde }
            };

            return dbConnection.ExecuteQuery(sorgu, parameters);
        }

        // ID'ye göre sefer getiren metot
        public Sefer SeferGetirById(int seferID)
        {
            string sorgu = @"SELECT s.SeferID, s.GuzergahID, g.GuzergahAdi, s.DenizOtobusuID, 
                            d.DenizOtobusuAdi, s.KalkisTarihi, s.TahminiVarisTarihi, 
                            s.GercekVarisTarihi, s.SeferDurumu, s.Kapasite, s.DoluKoltukSayisi,
                            s.BiletFiyati, s.Aciklama, s.SeferSorumlusuID, 
                            (k.Ad + ' ' + k.Soyad) AS SeferSorumlusuAdSoyad, s.Aktif
                            FROM Seferler s
                            INNER JOIN Guzergahlar g ON s.GuzergahID = g.GuzergahID
                            INNER JOIN DenizOtobusleri d ON s.DenizOtobusuID = d.DenizOtobusuID
                            LEFT JOIN Kullanicilar k ON s.SeferSorumlusuID = k.KullaniciID
                            WHERE s.SeferID = @SeferID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID }
            };

            DataTable result = dbConnection.ExecuteQuery(sorgu, parameters);
            Sefer sefer = null;

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                sefer = new Sefer
                {
                    SeferID = Convert.ToInt32(row["SeferID"]),
                    GuzergahID = Convert.ToInt32(row["GuzergahID"]),
                    GuzergahAdi = row["GuzergahAdi"].ToString(),
                    DenizOtobusuID = Convert.ToInt32(row["DenizOtobusuID"]),
                    DenizOtobusuAdi = row["DenizOtobusuAdi"].ToString(),
                    KalkisTarihi = Convert.ToDateTime(row["KalkisTarihi"]),
                    TahminiVarisTarihi = Convert.ToDateTime(row["TahminiVarisTarihi"]),
                    GercekVarisTarihi = row["GercekVarisTarihi"] != DBNull.Value ?
                                        Convert.ToDateTime(row["GercekVarisTarihi"]) : (DateTime?)null,
                    SeferDurumu = row["SeferDurumu"].ToString(),
                    Kapasite = Convert.ToInt32(row["Kapasite"]),
                    DoluKoltukSayisi = Convert.ToInt32(row["DoluKoltukSayisi"]),
                    BiletFiyati = Convert.ToDecimal(row["BiletFiyati"]),
                    Aciklama = row["Aciklama"] != DBNull.Value ? row["Aciklama"].ToString() : null,
                    SeferSorumlusuID = Convert.ToInt32(row["SeferSorumlusuID"]),
                    SeferSorumlusuAdSoyad = row["SeferSorumlusuAdSoyad"].ToString(),
                    Aktif = Convert.ToBoolean(row["Aktif"])
                };
            }

            return sefer;
        }

        // Yeni sefer ekleme metodu
        public bool SeferEkle(Sefer sefer)
        {
            // İlk olarak, seçilen deniz otobüsünün belirtilen tarih aralığında başka bir seferi olup olmadığını kontrol et
            if (!DenizOtobusuMustaitMi(sefer.DenizOtobusuID, sefer.KalkisTarihi, sefer.TahminiVarisTarihi))
            {
                return false; // Deniz otobüsü uygun değil
            }

            string sorgu = @"INSERT INTO Seferler (GuzergahID, DenizOtobusuID, KalkisTarihi, 
                            TahminiVarisTarihi, SeferDurumu, Kapasite, DoluKoltukSayisi, 
                            BiletFiyati, Aciklama, SeferSorumlusuID, Aktif)
                            VALUES (@GuzergahID, @DenizOtobusuID, @KalkisTarihi, 
                            @TahminiVarisTarihi, @SeferDurumu, @Kapasite, @DoluKoltukSayisi, 
                            @BiletFiyati, @Aciklama, @SeferSorumlusuID, @Aktif)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = sefer.GuzergahID },
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = sefer.DenizOtobusuID },
                new SqlParameter("@KalkisTarihi", SqlDbType.DateTime) { Value = sefer.KalkisTarihi },
                new SqlParameter("@TahminiVarisTarihi", SqlDbType.DateTime) { Value = sefer.TahminiVarisTarihi },
                new SqlParameter("@SeferDurumu", SqlDbType.VarChar) { Value = sefer.SeferDurumu },
                new SqlParameter("@Kapasite", SqlDbType.Int) { Value = sefer.Kapasite },
                new SqlParameter("@DoluKoltukSayisi", SqlDbType.Int) { Value = sefer.DoluKoltukSayisi },
                new SqlParameter("@BiletFiyati", SqlDbType.Decimal) { Value = sefer.BiletFiyati },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)sefer.Aciklama ?? DBNull.Value },
                new SqlParameter("@SeferSorumlusuID", SqlDbType.Int) { Value = sefer.SeferSorumlusuID },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = sefer.Aktif }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Sefer güncelleme metodu
        public bool SeferGuncelle(Sefer sefer)
        {
            // Seçilen deniz otobüsünün belirtilen tarih aralığında başka bir seferi olup olmadığını kontrol et
            // Ancak mevcut seferi hariç tut
            if (!DenizOtobusuMustaitMi(sefer.DenizOtobusuID, sefer.KalkisTarihi, sefer.TahminiVarisTarihi, sefer.SeferID))
            {
                return false; // Deniz otobüsü uygun değil
            }

            string sorgu = @"UPDATE Seferler 
                            SET GuzergahID = @GuzergahID, 
                            DenizOtobusuID = @DenizOtobusuID, 
                            KalkisTarihi = @KalkisTarihi, 
                            TahminiVarisTarihi = @TahminiVarisTarihi, 
                            GercekVarisTarihi = @GercekVarisTarihi, 
                            SeferDurumu = @SeferDurumu, 
                            Kapasite = @Kapasite, 
                            DoluKoltukSayisi = @DoluKoltukSayisi, 
                            BiletFiyati = @BiletFiyati, 
                            Aciklama = @Aciklama, 
                            SeferSorumlusuID = @SeferSorumlusuID, 
                            Aktif = @Aktif
                            WHERE SeferID = @SeferID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferID", SqlDbType.Int) { Value = sefer.SeferID },
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = sefer.GuzergahID },
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = sefer.DenizOtobusuID },
                new SqlParameter("@KalkisTarihi", SqlDbType.DateTime) { Value = sefer.KalkisTarihi },
                new SqlParameter("@TahminiVarisTarihi", SqlDbType.DateTime) { Value = sefer.TahminiVarisTarihi },
                new SqlParameter("@GercekVarisTarihi", SqlDbType.DateTime) {
                    Value = sefer.GercekVarisTarihi.HasValue ? (object)sefer.GercekVarisTarihi : DBNull.Value },
                new SqlParameter("@SeferDurumu", SqlDbType.VarChar) { Value = sefer.SeferDurumu },
                new SqlParameter("@Kapasite", SqlDbType.Int) { Value = sefer.Kapasite },
                new SqlParameter("@DoluKoltukSayisi", SqlDbType.Int) { Value = sefer.DoluKoltukSayisi },
                new SqlParameter("@BiletFiyati", SqlDbType.Decimal) { Value = sefer.BiletFiyati },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)sefer.Aciklama ?? DBNull.Value },
                new SqlParameter("@SeferSorumlusuID", SqlDbType.Int) { Value = sefer.SeferSorumlusuID },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = sefer.Aktif }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Sefer durumunu güncelleme metodu
        public bool SeferDurumuGuncelle(int seferID, string yeniDurum, string aciklama = null)
        {
            string sorgu = "UPDATE Seferler SET SeferDurumu = @YeniDurum, Aciklama = @Aciklama WHERE SeferID = @SeferID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID },
                new SqlParameter("@YeniDurum", SqlDbType.VarChar) { Value = yeniDurum },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)aciklama ?? DBNull.Value }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Sefer tamamlandı olarak işaretleme metodu
        public bool SeferTamamlandi(int seferID, DateTime gercekVarisTarihi, string aciklama = null)
        {
            string sorgu = @"UPDATE Seferler 
                           SET SeferDurumu = @YeniDurum, 
                           GercekVarisTarihi = @GercekVarisTarihi, 
                           Aciklama = @Aciklama 
                           WHERE SeferID = @SeferID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID },
                new SqlParameter("@YeniDurum", SqlDbType.VarChar) { Value = Sefer.Durumlar.Tamamlandi },
                new SqlParameter("@GercekVarisTarihi", SqlDbType.DateTime) { Value = gercekVarisTarihi },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)aciklama ?? DBNull.Value }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Sefer iptal etme metodu
        public bool SeferIptalEt(int seferID, string iptalNedeni)
        {
            string sorgu = @"UPDATE Seferler 
                           SET SeferDurumu = @YeniDurum, 
                           Aciklama = @Aciklama 
                           WHERE SeferID = @SeferID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SeferID", SqlDbType.Int) { Value = seferID },
                new SqlParameter("@YeniDurum", SqlDbType.VarChar) { Value = Sefer.Durumlar.IptalEdildi },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = iptalNedeni }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Deniz otobüsünün belirtilen tarih aralığında müsait olup olmadığını kontrol eden metot
        private bool DenizOtobusuMustaitMi(int denizOtobusuID, DateTime baslangicTarihi, DateTime bitisTarihi, int haricSeferID = 0)
        {
            string sorgu = @"SELECT COUNT(*) FROM Seferler
                           WHERE DenizOtobusuID = @DenizOtobusuID 
                           AND SeferID <> @HaricSeferID
                           AND SeferDurumu NOT IN ('Tamamlandı', 'İptal Edildi')
                           AND (
                               (KalkisTarihi <= @BaslangicTarihi AND TahminiVarisTarihi >= @BaslangicTarihi) OR
                               (KalkisTarihi <= @BitisTarihi AND TahminiVarisTarihi >= @BitisTarihi) OR
                               (KalkisTarihi >= @BaslangicTarihi AND TahminiVarisTarihi <= @BitisTarihi)
                           )";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID },
                new SqlParameter("@HaricSeferID", SqlDbType.Int) { Value = haricSeferID },
                new SqlParameter("@BaslangicTarihi", SqlDbType.DateTime) { Value = baslangicTarihi },
                new SqlParameter("@BitisTarihi", SqlDbType.DateTime) { Value = bitisTarihi }
            };

            object result = dbConnection.ExecuteScalar(sorgu, parameters);
            int count = Convert.ToInt32(result);

            return count == 0; // Eğer başka sefer yoksa, deniz otobüsü müsaittir
        }
    }
}