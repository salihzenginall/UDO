using System;
using System.Data;
using System.Data.SqlClient;
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
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili, 
                           Marka, SeriNumarasi, YakitKapasitesi, MotorTipi, MaxHiz, Aktif, 
                           KayitTarihi, SonBakimTarihi, SonMuayeneTarihi, Aciklama, DurumNotu
                           FROM DenizOtobusleri
                           ORDER BY DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Aktif deniz otobüslerini getiren metot
        public DataTable AktifDenizOtobusleriniGetir()
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili,
                           Marka, SeriNumarasi, YakitKapasitesi, MotorTipi, MaxHiz,
                           KayitTarihi, SonBakimTarihi, SonMuayeneTarihi, Aciklama, DurumNotu
                           FROM DenizOtobusleri
                           WHERE Aktif = 1
                           ORDER BY DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Durum göre filtreleme metodu
        public DataTable DenizOtobusleriniDurumaGoreFiltrele(bool aktifMi)
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili,
                           Marka, SeriNumarasi, YakitKapasitesi, MotorTipi, MaxHiz, Aktif,
                           KayitTarihi, SonBakimTarihi, SonMuayeneTarihi, Aciklama, DurumNotu
                           FROM DenizOtobusleri
                           WHERE Aktif = @Aktif
                           ORDER BY DenizOtobusuAdi";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = aktifMi }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Deniz otobüsü arama metodu
        public DataTable DenizOtobusuAra(string aramaMetni)
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili,
                           Marka, SeriNumarasi, YakitKapasitesi, MotorTipi, MaxHiz, Aktif,
                           KayitTarihi, SonBakimTarihi, SonMuayeneTarihi, Aciklama, DurumNotu
                           FROM DenizOtobusleri
                           WHERE DenizOtobusuAdi LIKE @AramaMetni OR Model LIKE @AramaMetni 
                           OR Marka LIKE @AramaMetni OR SeriNumarasi LIKE @AramaMetni
                           ORDER BY DenizOtobusuAdi";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@AramaMetni", SqlDbType.VarChar) { Value = "%" + aramaMetni + "%" }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // ID'ye göre deniz otobüsü getiren metot
        public DenizOtobusu DenizOtobusuGetirById(int denizOtobusuId)
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili,
                           Marka, SeriNumarasi, YakitKapasitesi, MotorTipi, MaxHiz, Aktif,
                           KayitTarihi, SonBakimTarihi, SonMuayeneTarihi, Aciklama, DurumNotu
                           FROM DenizOtobusleri
                           WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuId }
            };

            DataTable sonuc = dbConnection.ExecuteQuery(sorgu, parametreler);
            DenizOtobusu denizOtobusu = null;

            if (sonuc != null && sonuc.Rows.Count > 0)
            {
                DataRow satir = sonuc.Rows[0];
                denizOtobusu = new DenizOtobusu
                {
                    DenizOtobusuID = Convert.ToInt32(satir["DenizOtobusuID"]),
                    DenizOtobusuAdi = satir["DenizOtobusuAdi"].ToString(),
                    Model = satir["Model"] != DBNull.Value ? satir["Model"].ToString() : null,
                    Kapasite = Convert.ToInt32(satir["Kapasite"]),
                    UretimYili = Convert.ToInt32(satir["UretimYili"]),
                    Marka = satir["Marka"] != DBNull.Value ? satir["Marka"].ToString() : null,
                    SeriNumarasi = satir["SeriNumarasi"] != DBNull.Value ? satir["SeriNumarasi"].ToString() : null,
                    YakitKapasitesi = satir["YakitKapasitesi"] != DBNull.Value ? Convert.ToDecimal(satir["YakitKapasitesi"]) : 0,
                    MotorTipi = satir["MotorTipi"] != DBNull.Value ? satir["MotorTipi"].ToString() : null,
                    MaxHiz = satir["MaxHiz"] != DBNull.Value ? Convert.ToInt32(satir["MaxHiz"]) : 0,
                    Aktif = Convert.ToBoolean(satir["Aktif"]),
                    KayitTarihi = Convert.ToDateTime(satir["KayitTarihi"]),
                    SonBakimTarihi = satir["SonBakimTarihi"] != DBNull.Value ? Convert.ToDateTime(satir["SonBakimTarihi"]) : (DateTime?)null,
                    SonMuayeneTarihi = satir["SonMuayeneTarihi"] != DBNull.Value ? Convert.ToDateTime(satir["SonMuayeneTarihi"]) : (DateTime?)null,
                    Aciklama = satir["Aciklama"] != DBNull.Value ? satir["Aciklama"].ToString() : null,
                    DurumNotu = satir["DurumNotu"] != DBNull.Value ? satir["DurumNotu"].ToString() : null
                };
            }

            return denizOtobusu;
        }

        // Yeni deniz otobüsü ekleme metodu
        public bool DenizOtobusuEkle(DenizOtobusu denizOtobusu)
        {
            string sorgu = @"INSERT INTO DenizOtobusleri (DenizOtobusuAdi, Model, Kapasite, UretimYili,
                           Marka, SeriNumarasi, YakitKapasitesi, MotorTipi, MaxHiz, Aktif,
                           KayitTarihi, SonBakimTarihi, SonMuayeneTarihi, Aciklama, DurumNotu)
                           VALUES (@DenizOtobusuAdi, @Model, @Kapasite, @UretimYili,
                           @Marka, @SeriNumarasi, @YakitKapasitesi, @MotorTipi, @MaxHiz, @Aktif,
                           GETDATE(), @SonBakimTarihi, @SonMuayeneTarihi, @Aciklama, @DurumNotu)";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuAdi", SqlDbType.VarChar) { Value = denizOtobusu.DenizOtobusuAdi },
                new SqlParameter("@Model", SqlDbType.VarChar) { Value = (object)denizOtobusu.Model ?? DBNull.Value },
                new SqlParameter("@Kapasite", SqlDbType.Int) { Value = denizOtobusu.Kapasite },
                new SqlParameter("@UretimYili", SqlDbType.Int) { Value = denizOtobusu.UretimYili },
                new SqlParameter("@Marka", SqlDbType.VarChar) { Value = (object)denizOtobusu.Marka ?? DBNull.Value },
                new SqlParameter("@SeriNumarasi", SqlDbType.VarChar) { Value = (object)denizOtobusu.SeriNumarasi ?? DBNull.Value },
                new SqlParameter("@YakitKapasitesi", SqlDbType.Decimal) { Value = denizOtobusu.YakitKapasitesi },
                new SqlParameter("@MotorTipi", SqlDbType.VarChar) { Value = (object)denizOtobusu.MotorTipi ?? DBNull.Value },
                new SqlParameter("@MaxHiz", SqlDbType.Int) { Value = denizOtobusu.MaxHiz },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = denizOtobusu.Aktif },
                new SqlParameter("@SonBakimTarihi", SqlDbType.DateTime) { Value = (object)denizOtobusu.SonBakimTarihi ?? DBNull.Value },
                new SqlParameter("@SonMuayeneTarihi", SqlDbType.DateTime) { Value = (object)denizOtobusu.SonMuayeneTarihi ?? DBNull.Value },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)denizOtobusu.Aciklama ?? DBNull.Value },
                new SqlParameter("@DurumNotu", SqlDbType.VarChar) { Value = (object)denizOtobusu.DurumNotu ?? DBNull.Value }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Deniz otobüsü güncelleme metodu
        public bool DenizOtobusuGuncelle(DenizOtobusu denizOtobusu)
        {
            string sorgu = @"UPDATE DenizOtobusleri 
                           SET DenizOtobusuAdi = @DenizOtobusuAdi,
                           Model = @Model,
                           Kapasite = @Kapasite,
                           UretimYili = @UretimYili,
                           Marka = @Marka,
                           SeriNumarasi = @SeriNumarasi,
                           YakitKapasitesi = @YakitKapasitesi,
                           MotorTipi = @MotorTipi,
                           MaxHiz = @MaxHiz,
                           Aktif = @Aktif,
                           SonBakimTarihi = @SonBakimTarihi,
                           SonMuayeneTarihi = @SonMuayeneTarihi,
                           Aciklama = @Aciklama,
                           DurumNotu = @DurumNotu
                           WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusu.DenizOtobusuID },
                new SqlParameter("@DenizOtobusuAdi", SqlDbType.VarChar) { Value = denizOtobusu.DenizOtobusuAdi },
                new SqlParameter("@Model", SqlDbType.VarChar) { Value = (object)denizOtobusu.Model ?? DBNull.Value },
                new SqlParameter("@Kapasite", SqlDbType.Int) { Value = denizOtobusu.Kapasite },
                new SqlParameter("@UretimYili", SqlDbType.Int) { Value = denizOtobusu.UretimYili },
                new SqlParameter("@Marka", SqlDbType.VarChar) { Value = (object)denizOtobusu.Marka ?? DBNull.Value },
                new SqlParameter("@SeriNumarasi", SqlDbType.VarChar) { Value = (object)denizOtobusu.SeriNumarasi ?? DBNull.Value },
                new SqlParameter("@YakitKapasitesi", SqlDbType.Decimal) { Value = denizOtobusu.YakitKapasitesi },
                new SqlParameter("@MotorTipi", SqlDbType.VarChar) { Value = (object)denizOtobusu.MotorTipi ?? DBNull.Value },
                new SqlParameter("@MaxHiz", SqlDbType.Int) { Value = denizOtobusu.MaxHiz },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = denizOtobusu.Aktif },
                new SqlParameter("@SonBakimTarihi", SqlDbType.DateTime) { Value = (object)denizOtobusu.SonBakimTarihi ?? DBNull.Value },
                new SqlParameter("@SonMuayeneTarihi", SqlDbType.DateTime) { Value = (object)denizOtobusu.SonMuayeneTarihi ?? DBNull.Value },
                new SqlParameter("@Aciklama", SqlDbType.VarChar) { Value = (object)denizOtobusu.Aciklama ?? DBNull.Value },
                new SqlParameter("@DurumNotu", SqlDbType.VarChar) { Value = (object)denizOtobusu.DurumNotu ?? DBNull.Value }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Deniz otobüsü durumunu değiştirme metodu
        public bool DenizOtobusuDurumDegistir(int denizOtobusuId, bool yeniDurum)
        {
            string sorgu = "UPDATE DenizOtobusleri SET Aktif = @Aktif WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuId },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = yeniDurum }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Bakım tarihi güncelleme metodu
        public bool BakimTarihiGuncelle(int denizOtobusuId, DateTime bakimTarihi)
        {
            string sorgu = "UPDATE DenizOtobusleri SET SonBakimTarihi = @BakimTarihi WHERE DenizOtobusuID = @DenizOtobusuID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@DenizOtobusuID", SqlDbType.Int) { Value = denizOtobusuId },
                new SqlParameter("@BakimTarihi", SqlDbType.DateTime) { Value = bakimTarihi }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // ComboBox için deniz otobüslerini getiren metot (mevcut)
        public DataTable DenizOtobusleriComboBoxIcinGetir()
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Kapasite 
                           FROM DenizOtobusleri 
                           WHERE Aktif = 1 
                           ORDER BY DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Bakım zamanı gelenler
        public DataTable BakimZamaniGelenler()
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, SonBakimTarihi,
                           DATEDIFF(DAY, SonBakimTarihi, GETDATE()) AS GunSayisi
                           FROM DenizOtobusleri
                           WHERE Aktif = 1 AND 
                           (SonBakimTarihi IS NULL OR DATEDIFF(MONTH, SonBakimTarihi, GETDATE()) >= 6)
                           ORDER BY SonBakimTarihi";

            return dbConnection.ExecuteQuery(sorgu);
        }
    }
}