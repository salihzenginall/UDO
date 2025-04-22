using System;
using System.Data;
using System.Data.SqlClient;
using UDO.Models;
using UDO.Data;

namespace UDO.Managers
{
    public class PersonelManager
    {
        private readonly DBConnection dbConnection;

        public PersonelManager()
        {
            dbConnection = new DBConnection();
        }

        // Tüm personeli getiren metot
        public DataTable TumPersoneliGetir()
        {
            string sorgu = @"SELECT k.KullaniciID, k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, 
                           k.Email, k.TelefonNumarasi, k.KayitTarihi, k.SonGirisTarihi, 
                           k.Adres, k.Aktif, r.RolAdi, k.RolID
                           FROM Kullanicilar k
                           INNER JOIN Roller r ON k.RolID = r.RolID
                           WHERE r.RolAdi = 'Personel'
                           ORDER BY k.Ad, k.Soyad";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Personel arama metodu
        public DataTable PersonelAra(string aramaMetni)
        {
            string sorgu = @"SELECT k.KullaniciID, k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, 
                           k.Email, k.TelefonNumarasi, k.KayitTarihi, k.SonGirisTarihi, 
                           k.Adres, k.Aktif, r.RolAdi, k.RolID 
                           FROM Kullanicilar k
                           INNER JOIN Roller r ON k.RolID = r.RolID
                           WHERE r.RolAdi = 'Personel' AND 
                           (k.Ad LIKE @AramaMetni OR k.Soyad LIKE @AramaMetni OR k.TCKN LIKE @AramaMetni)
                           ORDER BY k.Ad, k.Soyad";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@AramaMetni", SqlDbType.VarChar) { Value = "%" + aramaMetni + "%" }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Personel durumuna göre filtreleme metodu
        public DataTable PersoneliDurumaGoreFiltrele(bool aktifMi)
        {
            string sorgu = @"SELECT k.KullaniciID, k.KullaniciAdi, k.Ad, k.Soyad, k.TCKN, 
                           k.Email, k.TelefonNumarasi, k.KayitTarihi, k.SonGirisTarihi, 
                           k.Adres, k.Aktif, r.RolAdi, k.RolID 
                           FROM Kullanicilar k
                           INNER JOIN Roller r ON k.RolID = r.RolID
                           WHERE r.RolAdi = 'Personel' AND k.Aktif = @Aktif
                           ORDER BY k.Ad, k.Soyad";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = aktifMi }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Personel ID'sine göre getirme metodu
        public User PersonelGetirById(int personelId)
        {
            string sorgu = @"SELECT k.*, r.RolAdi 
                           FROM Kullanicilar k
                           INNER JOIN Roller r ON k.RolID = r.RolID
                           WHERE k.KullaniciID = @PersonelId";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@PersonelId", SqlDbType.Int) { Value = personelId }
            };

            DataTable sonuc = dbConnection.ExecuteQuery(sorgu, parametreler);
            User personel = null;

            if (sonuc != null && sonuc.Rows.Count > 0)
            {
                DataRow satir = sonuc.Rows[0];
                personel = new User
                {
                    KullaniciID = Convert.ToInt32(satir["KullaniciID"]),
                    KullaniciAdi = satir["KullaniciAdi"].ToString(),
                    Ad = satir["Ad"].ToString(),
                    Soyad = satir["Soyad"].ToString(),
                    TCKN = satir["TCKN"] != DBNull.Value ? satir["TCKN"].ToString() : null,
                    Email = satir["Email"] != DBNull.Value ? satir["Email"].ToString() : null,
                    TelefonNumarasi = satir["TelefonNumarasi"] != DBNull.Value ? satir["TelefonNumarasi"].ToString() : null,
                    RolID = Convert.ToInt32(satir["RolID"]),
                    RolAdi = satir["RolAdi"].ToString(),
                    KayitTarihi = Convert.ToDateTime(satir["KayitTarihi"]),
                    SonGirisTarihi = satir["SonGirisTarihi"] != DBNull.Value ? Convert.ToDateTime(satir["SonGirisTarihi"]) : (DateTime?)null,
                    Adres = satir["Adres"] != DBNull.Value ? satir["Adres"].ToString() : null,
                    Aktif = Convert.ToBoolean(satir["Aktif"])
                };
            }

            return personel;
        }

        // Yeni personel ekleme metodu
        public bool PersonelEkle(User personel, string sifre)
        {
            string sorgu = @"INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, TCKN, Email, 
                           TelefonNumarasi, RolID, KayitTarihi, Adres, Aktif)
                           VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @TCKN, @Email, 
                           @TelefonNumarasi, @RolID, GETDATE(), @Adres, @Aktif)";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = personel.KullaniciAdi },
                new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = sifre },
                new SqlParameter("@Ad", SqlDbType.VarChar) { Value = personel.Ad },
                new SqlParameter("@Soyad", SqlDbType.VarChar) { Value = personel.Soyad },
                new SqlParameter("@TCKN", SqlDbType.VarChar) { Value = (object)personel.TCKN ?? DBNull.Value },
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = (object)personel.Email ?? DBNull.Value },
                new SqlParameter("@TelefonNumarasi", SqlDbType.VarChar) { Value = (object)personel.TelefonNumarasi ?? DBNull.Value },
                new SqlParameter("@RolID", SqlDbType.Int) { Value = personel.RolID },
                new SqlParameter("@Adres", SqlDbType.VarChar) { Value = (object)personel.Adres ?? DBNull.Value },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = personel.Aktif }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Personel güncelleme metodu
        public bool PersonelGuncelle(User personel)
        {
            string sorgu = @"UPDATE Kullanicilar 
                           SET KullaniciAdi = @KullaniciAdi,
                           Ad = @Ad,
                           Soyad = @Soyad,
                           TCKN = @TCKN,
                           Email = @Email,
                           TelefonNumarasi = @TelefonNumarasi,
                           Adres = @Adres,
                           Aktif = @Aktif
                           WHERE KullaniciID = @KullaniciID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@KullaniciID", SqlDbType.Int) { Value = personel.KullaniciID },
                new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = personel.KullaniciAdi },
                new SqlParameter("@Ad", SqlDbType.VarChar) { Value = personel.Ad },
                new SqlParameter("@Soyad", SqlDbType.VarChar) { Value = personel.Soyad },
                new SqlParameter("@TCKN", SqlDbType.VarChar) { Value = (object)personel.TCKN ?? DBNull.Value },
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = (object)personel.Email ?? DBNull.Value },
                new SqlParameter("@TelefonNumarasi", SqlDbType.VarChar) { Value = (object)personel.TelefonNumarasi ?? DBNull.Value },
                new SqlParameter("@Adres", SqlDbType.VarChar) { Value = (object)personel.Adres ?? DBNull.Value },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = personel.Aktif }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Personel durumunu değiştirme metodu
        public bool PersonelDurumDegistir(int personelId, bool yeniDurum)
        {
            string sorgu = "UPDATE Kullanicilar SET Aktif = @Aktif WHERE KullaniciID = @KullaniciID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@KullaniciID", SqlDbType.Int) { Value = personelId },
                new SqlParameter("@Aktif", SqlDbType.Bit) { Value = yeniDurum }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Personel şifre sıfırlama metodu
        public bool PersonelSifreSifirla(int personelId, string yeniSifre)
        {
            string sorgu = "UPDATE Kullanicilar SET Sifre = @YeniSifre WHERE KullaniciID = @KullaniciID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@KullaniciID", SqlDbType.Int) { Value = personelId },
                new SqlParameter("@YeniSifre", SqlDbType.VarChar) { Value = yeniSifre }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Rol ID'sine göre rol getirme metoduef
        public DataTable RolleriGetir()
        {
            string sorgu = "SELECT RolID, RolAdi FROM Roller WHERE RolAdi = 'Personel'";
            return dbConnection.ExecuteQuery(sorgu);
        }
    }
}