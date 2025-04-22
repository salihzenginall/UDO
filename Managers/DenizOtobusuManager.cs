using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using UDO.Models;
using UDO.Data;

namespace UDO.Managers
{
    public class DenizOtobusuManager
    {
        private readonly DBConnection dbConnection;

        public DenizOtobusuManager()
        {
            dbConnection = new DBConnection();
        }

        // Tüm deniz otobüslerini getiren metot
        public DataTable TumDenizOtobusleriniGetir()
        {
            string sorgu = @"SELECT d.DenizOtobusuID, d.DenizOtobusuAdi, d.ModelID, d.ModelAdi,
                            d.UretimYili, d.Plaka, d.SeriNo, d.Kapasite, d.MaksimumHiz, 
                            d.SonBakimTarihi, d.SonrakiBakimTarihi, d.Aciklama, d.DurumID, 
                            CASE d.DurumID 
                                WHEN 1 THEN 'Aktif' 
                                WHEN 2 THEN 'Bakımda' 
                                WHEN 3 THEN 'Arızalı' 
                                WHEN 4 THEN 'Hizmet Dışı' 
                                ELSE 'Bilinmiyor' 
                            END AS DurumAdi,
                            d.AktifMi, d.EklenmeTarihi
                            FROM DenizOtobusleri d
                            ORDER BY d.DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Aktif deniz otobüslerini getiren metot
        public DataTable AktifDenizOtobusleriniGetir()
        {
            string sorgu = @"SELECT d.DenizOtobusuID, d.DenizOtobusuAdi, d.ModelID, d.ModelAdi,
                            d.UretimYili, d.Plaka, d.SeriNo, d.Kapasite, d.MaksimumHiz, 
                            d.SonBakimTarihi, d.SonrakiBakimTarihi, d.Aciklama, d.DurumID, 
                            CASE d.DurumID 
                                WHEN 1 THEN 'Aktif' 
                                WHEN 2 THEN 'Bakımda' 
                                WHEN 3 THEN 'Arızalı' 
                                WHEN 4 THEN 'Hizmet Dışı' 
                                ELSE 'Bilinmiyor' 
                            END AS DurumAdi,
                            d.AktifMi, d.EklenmeTarihi
                            FROM DenizOtobusleri d
                            WHERE d.DurumID = 1 AND d.AktifMi = 1
                            ORDER BY d.DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Çalışmaya müsait deniz otobüslerini getiren metot (sadece Aktif durumdakiler)
        public DataTable MusaitDenizOtobusleriniGetir()
        {
            string sorgu = @"SELECT d.DenizOtobusuID, d.DenizOtobusuAdi, d.ModelID, d.ModelAdi,
                            d.UretimYili, d.Plaka, d.SeriNo, d.Kapasite, d.MaksimumHiz, 
                            d.SonBakimTarihi, d.SonrakiBakimTarihi, d.Aciklama, d.DurumID, 
                            CASE d.DurumID 
                                WHEN 1 THEN 'Aktif' 
                                WHEN 2 THEN 'Bakımda' 
                                WHEN 3 THEN 'Arızalı' 
                                WHEN 4 THEN 'Hizmet Dışı' 
                                ELSE 'Bilinmiyor' 
                            END AS DurumAdi,
                            d.AktifMi, d.EklenmeTarihi
                            FROM DenizOtobusleri d
                            WHERE d.DurumID = 1 AND d.AktifMi = 1
                            ORDER BY d.DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Belirli bir tarih aralığında müsait deniz otobüslerini getiren metot
        public DataTable MusaitDenizOtobusleriniGetirTarihAraligi(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            string sorgu = @"SELECT d.DenizOtobusuID, d.DenizOtobusuAdi, d.ModelID, d.ModelAdi,
                            d.UretimYili, d.Plaka, d.SeriNo, d.Kapasite, d.MaksimumHiz, 
                            d.SonBakimTarihi, d.SonrakiBakimTarihi, d.Aciklama, d.DurumID, 
                            CASE d.DurumID 
                                WHEN 1 THEN 'Aktif' 
                                WHEN 2 THEN 'Bakımda' 
                                WHEN 3 THEN 'Arızalı' 
                                WHEN 4 THEN 'Hizmet Dışı' 
                                ELSE 'Bilinmiyor' 
                            END AS DurumAdi,
                            d.AktifMi, d.EklenmeTarihi
                            FROM DenizOtobusleri d
                            WHERE d.DurumID = 1 AND d.AktifMi = 1
                            AND d.DenizOtobusuID NOT IN (
                                SELECT s.DenizOtobusuID 
                                FROM Seferler s
                                WHERE s.SeferDurumu NOT IN ('Tamamlandı', 'İptal Edildi')
                                AND (
                                    (s.KalkisTarihi <= @BaslangicTarihi AND s.TahminiVarisTarihi >= @BaslangicTarihi) OR
                                    (s.KalkisTarihi <= @BitisTarihi AND s.TahminiVarisTarihi >= @BitisTarihi) OR
                                    (s.KalkisTarihi >= @BaslangicTarihi AND s.TahminiVarisTarihi <= @BitisTarihi)
                                )
                            )
                            ORDER BY d.DenizOtobusuAdi";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BaslangicTarihi", SqlDbType.DateTime) { Value = baslangicTarihi },
                new SqlParameter("@BitisTarihi", SqlDbType.DateTime) { Value = bitisTarihi }
            };

            return dbConnection.ExecuteQuery(sorgu, parameters);
        }

        // ID'ye göre deniz otobüsü getiren metot
        public DenizOtobusu DenizOtobusuGetirById(int denizOtobusuID)
        {
            string sorgu = @"SELECT d.DenizOtobusuID, d.DenizOtobusuAdi, d.ModelID, d.ModelAdi,
                            d.UretimYili, d.Plaka, d.SeriNo, d.Kapasite, d.MaksimumHiz, 
                            d.SonBakimTarihi, d.SonrakiBakimTarihi, d.Aciklama, d.DurumID, 
                            CASE d.DurumID 
                                WHEN 1 THEN 'Aktif' 
                                WHEN 2 THEN 'Bakımda' 
                                WHEN 3 THEN 'Arızalı' 
                                WHEN 4 THEN 'Hizmet Dışı' 
                                ELSE 'Bilinmiyor' 
                            END AS DurumAdi,
                            d.AktifMi, d.EklenmeTarihi
                            FROM DenizOtobusleri d
                            WHERE d.DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID }
            };

            DataTable result = dbConnection.ExecuteQuery(sorgu, parameters);
            DenizOtobusu denizOtobusu = null;

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                denizOtobusu = new DenizOtobusu
                {
                    DenizOtobusuID = Convert.ToInt32(row["DenizOtobusuID"]),
                    DenizOtobusuAdi = row["DenizOtobusuAdi"].ToString(),
                    ModelID = row["ModelID"] != DBNull.Value ? Convert.ToInt32(row["ModelID"]) : (int?)null,
                    ModelAdi = row["ModelAdi"] != DBNull.Value ? row["ModelAdi"].ToString() : null,
                    UretimYili = row["UretimYili"] != DBNull.Value ? Convert.ToInt32(row["UretimYili"]) : (int?)null,
                    Plaka = row["Plaka"] != DBNull.Value ? row["Plaka"].ToString() : null,
                    SeriNo = row["SeriNo"] != DBNull.Value ? row["SeriNo"].ToString() : null,
                    Kapasite = Convert.ToInt32(row["Kapasite"]),
                    MaksimumHiz = row["MaksimumHiz"] != DBNull.Value ? Convert.ToInt32(row["MaksimumHiz"]) : (int?)null,
                    SonBakimTarihi = row["SonBakimTarihi"] != DBNull.Value ? Convert.ToDateTime(row["SonBakimTarihi"]) : (DateTime?)null,
                    SonrakiBakimTarihi = row["SonrakiBakimTarihi"] != DBNull.Value ? Convert.ToDateTime(row["SonrakiBakimTarihi"]) : (DateTime?)null,
                    Aciklama = row["Aciklama"] != DBNull.Value ? row["Aciklama"].ToString() : null,
                    DurumID = Convert.ToInt32(row["DurumID"]),
                    DurumAdi = row["DurumAdi"].ToString(),
                    AktifMi = Convert.ToBoolean(row["AktifMi"]),
                    EklenmeTarihi = Convert.ToDateTime(row["EklenmeTarihi"])
                };
            }

            return denizOtobusu;
        }

        // Yeni deniz otobüsü ekleme metodu
        public bool DenizOtobusuEkle(DenizOtobusu denizOtobusu)
        {
            string sorgu = @"INSERT INTO DenizOtobusleri (DenizOtobusuAdi, ModelID, ModelAdi, UretimYili, 
                            Plaka, SeriNo, Kapasite, MaksimumHiz, SonBakimTarihi, SonrakiBakimTarihi, 
                            Aciklama, DurumID, AktifMi)
                            VALUES (@DenizOtobusuAdi, @ModelID, @ModelAdi, @UretimYili, 
                            @Plaka, @SeriNo, @Kapasite, @MaksimumHiz, @SonBakimTarihi, @SonrakiBakimTarihi, 
                            @Aciklama, @DurumID, @AktifMi)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuAdi", SqlDbType.NVarChar) { Value = denizOtobusu.DenizOtobusuAdi },
                new SqlParameter("@ModelID", SqlDbType.Int) { Value = denizOtobusu.ModelID.HasValue ? (object)denizOtobusu.ModelID : DBNull.Value },
                new SqlParameter("@ModelAdi", SqlDbType.NVarChar) { Value = (object)denizOtobusu.ModelAdi ?? DBNull.Value },
                new SqlParameter("@UretimYili", SqlDbType.Int) { Value = denizOtobusu.UretimYili.HasValue ? (object)denizOtobusu.UretimYili : DBNull.Value },
                new SqlParameter("@Plaka", SqlDbType.NVarChar) { Value = (object)denizOtobusu.Plaka ?? DBNull.Value },
                new SqlParameter("@SeriNo", SqlDbType.NVarChar) { Value = (object)denizOtobusu.SeriNo ?? DBNull.Value },
                new SqlParameter("@Kapasite", SqlDbType.Int) { Value = denizOtobusu.Kapasite },
                new SqlParameter("@MaksimumHiz", SqlDbType.Int) { Value = denizOtobusu.MaksimumHiz.HasValue ? (object)denizOtobusu.MaksimumHiz : DBNull.Value },
                new SqlParameter("@SonBakimTarihi", SqlDbType.DateTime) { Value = denizOtobusu.SonBakimTarihi.HasValue ? (object)denizOtobusu.SonBakimTarihi : DBNull.Value },
                new SqlParameter("@SonrakiBakimTarihi", SqlDbType.DateTime) { Value = denizOtobusu.SonrakiBakimTarihi.HasValue ? (object)denizOtobusu.SonrakiBakimTarihi : DBNull.Value },
                new SqlParameter("@Aciklama", SqlDbType.NVarChar) { Value = (object)denizOtobusu.Aciklama ?? DBNull.Value },
                new SqlParameter("@DurumID", SqlDbType.Int) { Value = denizOtobusu.DurumID },
                new SqlParameter("@AktifMi", SqlDbType.Bit) { Value = denizOtobusu.AktifMi }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Deniz otobüsü güncelleme metodu
        public bool DenizOtobusuGuncelle(DenizOtobusu denizOtobusu)
        {
            string sorgu = @"UPDATE DenizOtobusleri
                            SET DenizOtobusuAdi = @DenizOtobusuAdi,
                            ModelID = @ModelID,
                            ModelAdi = @ModelAdi,
                            UretimYili = @UretimYili,
                            Plaka = @Plaka,
                            SeriNo = @SeriNo,
                            Kapasite = @Kapasite,
                            MaksimumHiz = @MaksimumHiz,
                            SonBakimTarihi = @SonBakimTarihi,
                            SonrakiBakimTarihi = @SonrakiBakimTarihi,
                            Aciklama = @Aciklama,
                            DurumID = @DurumID,
                            AktifMi = @AktifMi
                            WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusu.DenizOtobusuID },
                new SqlParameter("@DenizOtobusuAdi", SqlDbType.NVarChar) { Value = denizOtobusu.DenizOtobusuAdi },
                new SqlParameter("@ModelID", SqlDbType.Int) { Value = denizOtobusu.ModelID.HasValue ? (object)denizOtobusu.ModelID : DBNull.Value },
                new SqlParameter("@ModelAdi", SqlDbType.NVarChar) { Value = (object)denizOtobusu.ModelAdi ?? DBNull.Value },
                new SqlParameter("@UretimYili", SqlDbType.Int) { Value = denizOtobusu.UretimYili.HasValue ? (object)denizOtobusu.UretimYili : DBNull.Value },
                new SqlParameter("@Plaka", SqlDbType.NVarChar) { Value = (object)denizOtobusu.Plaka ?? DBNull.Value },
                new SqlParameter("@SeriNo", SqlDbType.NVarChar) { Value = (object)denizOtobusu.SeriNo ?? DBNull.Value },
                new SqlParameter("@Kapasite", SqlDbType.Int) { Value = denizOtobusu.Kapasite },
                new SqlParameter("@MaksimumHiz", SqlDbType.Int) { Value = denizOtobusu.MaksimumHiz.HasValue ? (object)denizOtobusu.MaksimumHiz : DBNull.Value },
                new SqlParameter("@SonBakimTarihi", SqlDbType.DateTime) { Value = denizOtobusu.SonBakimTarihi.HasValue ? (object)denizOtobusu.SonBakimTarihi : DBNull.Value },
                new SqlParameter("@SonrakiBakimTarihi", SqlDbType.DateTime) { Value = denizOtobusu.SonrakiBakimTarihi.HasValue ? (object)denizOtobusu.SonrakiBakimTarihi : DBNull.Value },
                new SqlParameter("@Aciklama", SqlDbType.NVarChar) { Value = (object)denizOtobusu.Aciklama ?? DBNull.Value },
                new SqlParameter("@DurumID", SqlDbType.Int) { Value = denizOtobusu.DurumID },
                new SqlParameter("@AktifMi", SqlDbType.Bit) { Value = denizOtobusu.AktifMi }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Deniz otobüsü durum güncelleme metodu
        public bool DenizOtobusuDurumGuncelle(int denizOtobusuID, int yeniDurumID, string aciklama = null)
        {
            string sorgu = "UPDATE DenizOtobusleri SET DurumID = @YeniDurumID, Aciklama = @Aciklama WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID },
                new SqlParameter("@YeniDurumID", SqlDbType.Int) { Value = yeniDurumID },
                new SqlParameter("@Aciklama", SqlDbType.NVarChar) { Value = (object)aciklama ?? DBNull.Value }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Bakım tarihlerini güncelleme metodu
        public bool BakimTarihiGuncelle(int denizOtobusuID, DateTime sonBakimTarihi, DateTime sonrakiBakimTarihi)
        {
            string sorgu = "UPDATE DenizOtobusleri SET SonBakimTarihi = @SonBakimTarihi, SonrakiBakimTarihi = @SonrakiBakimTarihi WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID },
                new SqlParameter("@SonBakimTarihi", SqlDbType.DateTime) { Value = sonBakimTarihi },
                new SqlParameter("@SonrakiBakimTarihi", SqlDbType.DateTime) { Value = sonrakiBakimTarihi }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Deniz otobüsünün aktif/pasif durumunu değiştirme metodu
        public bool DenizOtobusuAktifPasifYap(int denizOtobusuID, bool aktifMi)
        {
            string sorgu = "UPDATE DenizOtobusleri SET AktifMi = @AktifMi WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID },
                new SqlParameter("@AktifMi", SqlDbType.Bit) { Value = aktifMi }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }

        // Deniz otobüsü sil metodu (aktif seferlerde kullanılan deniz otobüsleri silinemez)
        public bool DenizOtobusuSil(int denizOtobusuID)
        {
            // Öncelikle bu deniz otobüsünün aktif bir seferde kullanılıp kullanılmadığını kontrol et
            string kontrolSorgu = @"SELECT COUNT(*) FROM Seferler 
                                   WHERE DenizOtobusuID = @DenizOtobusuID 
                                   AND SeferDurumu NOT IN ('Tamamlandı', 'İptal Edildi')";

            SqlParameter[] kontrolParam = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID }
            };

            object kontrolResult = dbConnection.ExecuteScalar(kontrolSorgu, kontrolParam);
            int seferSayisi = Convert.ToInt32(kontrolResult);

            if (seferSayisi > 0)
            {
                // Bu deniz otobüsü aktif seferlerde kullanılıyor, silme işlemi yapma
                return false;
            }

            string sorgu = "DELETE FROM DenizOtobusleri WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuID }
            };

            int result = dbConnection.ExecuteNonQuery(sorgu, parameters);
            return result > 0;
        }
    }
}