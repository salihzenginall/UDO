using System;
using System.Data;
using System.Data.SqlClient;
using UDO.Models;
using UDO.Data;

namespace UDO.Managers
{
    public class MusteriManager
    {
        private readonly DBConnection dbConnection;

        public MusteriManager()
        {
            dbConnection = new DBConnection();
        }

        // Tüm müşterileri getiren metot
        public DataTable TumMusterileriGetir()
        {
            string sorgu = @"SELECT m.MusteriID, m.KullaniciID, m.MusteriNo, m.DogumTarihi, 
                           m.UyrukID, u.UlkeAdi as UyrukAdi, m.ToplamSeyahat, m.ToplamHarcama, 
                           m.SadakatPuani, m.IndirimOrani, m.KayitKanali,
                           k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, k.Email, k.TelefonNumarasi,
                           k.KayitTarihi, k.SonGirisTarihi, k.Adres, k.Aktif
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID
                           LEFT JOIN Ulkeler u ON m.UyrukID = u.UlkeID
                           ORDER BY k.Ad, k.Soyad";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Müşteri arama metodu
        public DataTable MusteriAra(string aramaMetni)
        {
            string sorgu = @"SELECT m.MusteriID, m.KullaniciID, m.MusteriNo, m.DogumTarihi, 
                           m.UyrukID, u.UlkeAdi as UyrukAdi, m.ToplamSeyahat, m.ToplamHarcama, 
                           m.SadakatPuani, m.IndirimOrani, m.KayitKanali,
                           k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, k.Email, k.TelefonNumarasi,
                           k.KayitTarihi, k.SonGirisTarihi, k.Adres, k.Aktif
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID
                           LEFT JOIN Ulkeler u ON m.UyrukID = u.UlkeID
                           WHERE k.Ad LIKE @AramaMetni OR k.Soyad LIKE @AramaMetni 
                           OR k.TCKN LIKE @AramaMetni OR m.MusteriNo LIKE @AramaMetni
                           OR k.Email LIKE @AramaMetni OR k.TelefonNumarasi LIKE @AramaMetni
                           ORDER BY k.Ad, k.Soyad";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@AramaMetni", SqlDbType.VarChar) { Value = "%" + aramaMetni + "%" }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Müşteri durumuna göre filtreleme metodu
        public DataTable MusterileriDurumaGoreFiltrele(bool aktifMi)
        {
            string sorgu = @"SELECT m.MusteriID, m.KullaniciID, m.MusteriNo, m.DogumTarihi, 
                           m.UyrukID, u.UlkeAdi as UyrukAdi, m.ToplamSeyahat, m.ToplamHarcama, 
                           m.SadakatPuani, m.IndirimOrani, m.KayitKanali,
                           k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, k.Email, k.TelefonNumarasi,
                           k.KayitTarihi, k.SonGirisTarihi, k.Adres, k.Aktif
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID
                           LEFT JOIN Ulkeler u ON m.UyrukID = u.UlkeID
                           WHERE k.Aktif = @Aktif
                           ORDER BY k.Ad, k.Soyad";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = aktifMi }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // VIP müşterileri getiren metot
        public DataTable VipMusterileriGetir()
        {
            string sorgu = @"SELECT m.MusteriID, m.KullaniciID, m.MusteriNo, m.DogumTarihi, 
                           m.UyrukID, u.UlkeAdi as UyrukAdi, m.ToplamSeyahat, m.ToplamHarcama, 
                           m.SadakatPuani, m.IndirimOrani, m.KayitKanali,
                           k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, k.Email, k.TelefonNumarasi,
                           k.KayitTarihi, k.SonGirisTarihi, k.Adres, k.Aktif
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID
                           LEFT JOIN Ulkeler u ON m.UyrukID = u.UlkeID
                           WHERE (m.ToplamSeyahat >= 10 OR m.ToplamHarcama >= 1000) AND k.Aktif = 1
                           ORDER BY m.ToplamHarcama DESC";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Müşteri ID'sine göre getirme metodu
        public Musteri MusteriGetirById(int musteriId)
        {
            string sorgu = @"SELECT m.MusteriID, m.KullaniciID, m.MusteriNo, m.DogumTarihi, 
                           m.UyrukID, u.UlkeAdi as UyrukAdi, m.ToplamSeyahat, m.ToplamHarcama, 
                           m.SadakatPuani, m.IndirimOrani, m.KayitKanali,
                           k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, k.Email, k.TelefonNumarasi,
                           k.KayitTarihi, k.SonGirisTarihi, k.Adres, k.Aktif
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID
                           LEFT JOIN Ulkeler u ON m.UyrukID = u.UlkeID
                           WHERE m.MusteriID = @MusteriID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@MusteriID", SqlDbType.Int) { Value = musteriId }
            };

            DataTable sonuc = dbConnection.ExecuteQuery(sorgu, parametreler);
            Musteri musteri = null;

            if (sonuc != null && sonuc.Rows.Count > 0)
            {
                DataRow satir = sonuc.Rows[0];
                musteri = new Musteri
                {
                    MusteriID = Convert.ToInt32(satir["MusteriID"]),
                    KullaniciID = Convert.ToInt32(satir["KullaniciID"]),
                    MusteriNo = satir["MusteriNo"].ToString(),
                    DogumTarihi = satir["DogumTarihi"] != DBNull.Value ? Convert.ToDateTime(satir["DogumTarihi"]) : (DateTime?)null,
                    UyrukID = satir["UyrukID"] != DBNull.Value ? Convert.ToInt32(satir["UyrukID"]) : (int?)null,
                    UyrukAdi = satir["UyrukAdi"] != DBNull.Value ? satir["UyrukAdi"].ToString() : null,
                    ToplamSeyahat = Convert.ToInt32(satir["ToplamSeyahat"]),
                    ToplamHarcama = Convert.ToDecimal(satir["ToplamHarcama"]),
                    SadakatPuani = Convert.ToInt32(satir["SadakatPuani"]),
                    IndirimOrani = Convert.ToDecimal(satir["IndirimOrani"]),
                    KayitKanali = satir["KayitKanali"] != DBNull.Value ? satir["KayitKanali"].ToString() : null,
                    KullaniciAdi = satir["KullaniciAdi"].ToString(),
                    Ad = satir["Ad"].ToString(),
                    Soyad = satir["Soyad"].ToString(),
                    TCKN = satir["TCKN"] != DBNull.Value ? satir["TCKN"].ToString() : null,
                    Email = satir["Email"] != DBNull.Value ? satir["Email"].ToString() : null,
                    TelefonNumarasi = satir["TelefonNumarasi"] != DBNull.Value ? satir["TelefonNumarasi"].ToString() : null,
                    KayitTarihi = Convert.ToDateTime(satir["KayitTarihi"]),
                    SonGirisTarihi = satir["SonGirisTarihi"] != DBNull.Value ? Convert.ToDateTime(satir["SonGirisTarihi"]) : (DateTime?)null,
                    Adres = satir["Adres"] != DBNull.Value ? satir["Adres"].ToString() : null,
                    Aktif = Convert.ToBoolean(satir["Aktif"])
                };
            }

            return musteri;
        }

        // Yeni müşteri ekleme metodu
        public bool MusteriEkle(Musteri musteri, string sifre)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                connection = dbConnection.GetConnection();
                transaction = connection.BeginTransaction();

                // Önce Kullanicilar tablosuna ekle
                string kullaniciSorgu = @"INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, TCKN, Email, 
                                       TelefonNumarasi, RolID, KayitTarihi, Adres, Aktif)
                                       VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @TCKN, @Email, 
                                       @TelefonNumarasi, 3, GETDATE(), @Adres, @Aktif);
                                       SELECT SCOPE_IDENTITY()";

                SqlCommand kullaniciCommand = new SqlCommand(kullaniciSorgu, connection, transaction);
                kullaniciCommand.Parameters.AddWithValue("@KullaniciAdi", musteri.KullaniciAdi);
                kullaniciCommand.Parameters.AddWithValue("@Sifre", sifre);
                kullaniciCommand.Parameters.AddWithValue("@Ad", musteri.Ad);
                kullaniciCommand.Parameters.AddWithValue("@Soyad", musteri.Soyad);
                kullaniciCommand.Parameters.AddWithValue("@TCKN", (object)musteri.TCKN ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@Email", (object)musteri.Email ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@TelefonNumarasi", (object)musteri.TelefonNumarasi ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@Adres", (object)musteri.Adres ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@Aktif", musteri.Aktif);

                int yeniKullaniciID = Convert.ToInt32(kullaniciCommand.ExecuteScalar());

                // Sonra Musteriler tablosuna ekle
                string musteriSorgu = @"INSERT INTO Musteriler (KullaniciID, DogumTarihi, UyrukID, 
                                     ToplamSeyahat, ToplamHarcama, SadakatPuani, IndirimOrani, KayitKanali)
                                     VALUES (@KullaniciID, @DogumTarihi, @UyrukID, 
                                     @ToplamSeyahat, @ToplamHarcama, @SadakatPuani, @IndirimOrani, @KayitKanali)";

                SqlCommand musteriCommand = new SqlCommand(musteriSorgu, connection, transaction);
                musteriCommand.Parameters.AddWithValue("@KullaniciID", yeniKullaniciID);
                musteriCommand.Parameters.AddWithValue("@DogumTarihi", (object)musteri.DogumTarihi ?? DBNull.Value);
                musteriCommand.Parameters.AddWithValue("@UyrukID", (object)musteri.UyrukID ?? DBNull.Value);
                musteriCommand.Parameters.AddWithValue("@ToplamSeyahat", musteri.ToplamSeyahat);
                musteriCommand.Parameters.AddWithValue("@ToplamHarcama", musteri.ToplamHarcama);
                musteriCommand.Parameters.AddWithValue("@SadakatPuani", musteri.SadakatPuani);
                musteriCommand.Parameters.AddWithValue("@IndirimOrani", musteri.IndirimOrani);
                musteriCommand.Parameters.AddWithValue("@KayitKanali", (object)musteri.KayitKanali ?? DBNull.Value);

                musteriCommand.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction?.Rollback();
                return false;
            }
            finally
            {
                transaction?.Dispose();
                dbConnection.CloseConnection(connection);
            }
        }

        // Müşteri güncelleme metodu
        public bool MusteriGuncelle(Musteri musteri)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                connection = dbConnection.GetConnection();
                transaction = connection.BeginTransaction();

                // Önce Kullanicilar tablosunu güncelle
                string kullaniciSorgu = @"UPDATE Kullanicilar 
                                       SET KullaniciAdi = @KullaniciAdi, Ad = @Ad, Soyad = @Soyad,
                                       TCKN = @TCKN, Email = @Email, TelefonNumarasi = @TelefonNumarasi,
                                       Adres = @Adres, Aktif = @Aktif
                                       WHERE KullaniciID = @KullaniciID";

                SqlCommand kullaniciCommand = new SqlCommand(kullaniciSorgu, connection, transaction);
                kullaniciCommand.Parameters.AddWithValue("@KullaniciID", musteri.KullaniciID);
                kullaniciCommand.Parameters.AddWithValue("@KullaniciAdi", musteri.KullaniciAdi);
                kullaniciCommand.Parameters.AddWithValue("@Ad", musteri.Ad);
                kullaniciCommand.Parameters.AddWithValue("@Soyad", musteri.Soyad);
                kullaniciCommand.Parameters.AddWithValue("@TCKN", (object)musteri.TCKN ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@Email", (object)musteri.Email ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@TelefonNumarasi", (object)musteri.TelefonNumarasi ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@Adres", (object)musteri.Adres ?? DBNull.Value);
                kullaniciCommand.Parameters.AddWithValue("@Aktif", musteri.Aktif);

                kullaniciCommand.ExecuteNonQuery();

                // Sonra Musteriler tablosunu güncelle
                string musteriSorgu = @"UPDATE Musteriler 
                                     SET DogumTarihi = @DogumTarihi, UyrukID = @UyrukID,
                                     IndirimOrani = @IndirimOrani, KayitKanali = @KayitKanali
                                     WHERE KullaniciID = @KullaniciID";

                SqlCommand musteriCommand = new SqlCommand(musteriSorgu, connection, transaction);
                musteriCommand.Parameters.AddWithValue("@KullaniciID", musteri.KullaniciID);
                musteriCommand.Parameters.AddWithValue("@DogumTarihi", (object)musteri.DogumTarihi ?? DBNull.Value);
                musteriCommand.Parameters.AddWithValue("@UyrukID", (object)musteri.UyrukID ?? DBNull.Value);
                musteriCommand.Parameters.AddWithValue("@IndirimOrani", musteri.IndirimOrani);
                musteriCommand.Parameters.AddWithValue("@KayitKanali", (object)musteri.KayitKanali ?? DBNull.Value);

                musteriCommand.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction?.Rollback();
                return false;
            }
            finally
            {
                transaction?.Dispose();
                dbConnection.CloseConnection(connection);
            }
        }

        // Müşteri durumunu değiştirme metodu
        public bool MusteriDurumDegistir(int kullaniciID, bool yeniDurum)
        {
            string sorgu = "UPDATE Kullanicilar SET Aktif = @Aktif WHERE KullaniciID = @KullaniciID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@KullaniciID", SqlDbType.Int) { Value = kullaniciID },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = yeniDurum }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // ComboBox için ülkeleri getiren metot
        public DataTable UlkeleriGetir()
        {
            string sorgu = @"SELECT UlkeID, UlkeAdi 
                           FROM Ulkeler 
                           WHERE Aktif = 1 
                           ORDER BY UlkeAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // ComboBox için müşterileri getiren metot (bilet satışında kullanılacak)
        public DataTable MusterileriComboBoxIcinGetir()
        {
            string sorgu = @"SELECT m.MusteriID, m.MusteriNo, k.Ad + ' ' + k.Soyad as TamAd,
                           m.MusteriNo + ' - ' + k.Ad + ' ' + k.Soyad as MusteriTamBilgi
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID
                           WHERE k.Aktif = 1
                           ORDER BY k.Ad, k.Soyad";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Müşteri istatistikleri
        public DataTable MusteriIstatistikleriGetir()
        {
            string sorgu = @"SELECT 
                           COUNT(*) as ToplamMusteri,
                           COUNT(CASE WHEN k.Aktif = 1 THEN 1 END) as AktifMusteri,
                           COUNT(CASE WHEN k.Aktif = 0 THEN 1 END) as PasifMusteri,
                           COUNT(CASE WHEN m.ToplamSeyahat >= 10 OR m.ToplamHarcama >= 1000 THEN 1 END) as VipMusteri,
                           AVG(m.ToplamHarcama) as OrtalamaHarcama,
                           SUM(m.ToplamHarcama) as ToplamCiro
                           FROM Musteriler m
                           INNER JOIN Kullanicilar k ON m.KullaniciID = k.KullaniciID";

            return dbConnection.ExecuteQuery(sorgu);
        }
    }
}