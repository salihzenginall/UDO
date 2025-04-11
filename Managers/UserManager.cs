using System;
using System.Data;
using System.Data.SqlClient;
using UDO.Models;
using UDO.Data; // Bu satırı ekleyin

namespace UDO.Managers
{
    public class UserManager
    {
        private readonly DBConnection dbConnection;

        public UserManager()
        {
            dbConnection = new DBConnection();
        }

        public User Login(string kullaniciAdi, string sifre)
        {
            User user = null;
            string query = @"SELECT k.*, r.RolAdi 
                            FROM Kullanicilar k
                            INNER JOIN Roller r ON k.RolID = r.RolID
                            WHERE k.KullaniciAdi = @KullaniciAdi 
                            AND k.Sifre = @Sifre 
                            AND k.Aktif = 1";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = kullaniciAdi },
                new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = sifre }
            };

            DataTable result = dbConnection.ExecuteQuery(query, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                user = new User
                {
                    KullaniciID = Convert.ToInt32(row["KullaniciID"]),
                    KullaniciAdi = row["KullaniciAdi"].ToString(),
                    Ad = row["Ad"].ToString(),
                    Soyad = row["Soyad"].ToString(),
                    TCKN = row["TCKN"] != DBNull.Value ? row["TCKN"].ToString() : null,
                    Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : null,
                    TelefonNumarasi = row["TelefonNumarasi"] != DBNull.Value ? row["TelefonNumarasi"].ToString() : null,
                    RolID = Convert.ToInt32(row["RolID"]),
                    RolAdi = row["RolAdi"].ToString(),
                    KayitTarihi = Convert.ToDateTime(row["KayitTarihi"]),
                    SonGirisTarihi = row["SonGirisTarihi"] != DBNull.Value ? Convert.ToDateTime(row["SonGirisTarihi"]) : (DateTime?)null,
                    Adres = row["Adres"] != DBNull.Value ? row["Adres"].ToString() : null,
                    Aktif = Convert.ToBoolean(row["Aktif"])
                };

                // Son giriş tarihini güncelleme
                UpdateLastLoginDate(user.KullaniciID);

                // Kullanıcı giriş logunu kaydetme
                LogUserLogin(user.KullaniciID);
            }

            return user;
        }

        private void UpdateLastLoginDate(int kullaniciID)
        {
            string query = "UPDATE Kullanicilar SET SonGirisTarihi = GETDATE() WHERE KullaniciID = @KullaniciID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@KullaniciID", SqlDbType.Int) { Value = kullaniciID }
            };

            dbConnection.ExecuteNonQuery(query, parameters);
        }

        private void LogUserLogin(int kullaniciID)
        {
            string query = @"INSERT INTO Islemler (KullaniciID, IslemTipi, Aciklama, IPAdresi) 
                            VALUES (@KullaniciID, 'Giris', 'Kullanıcı sisteme giriş yaptı', @IPAdresi)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@KullaniciID", SqlDbType.Int) { Value = kullaniciID },
                new SqlParameter("@IPAdresi", SqlDbType.VarChar) { Value = GetUserIPAddress() }
            };

            dbConnection.ExecuteNonQuery(query, parameters);
        }

        private string GetUserIPAddress()
        {
            // Gerçek uygulamada kullanıcı IP adresi alınabilir
            // Bu örnekte localhost kullanıyoruz
            return "127.0.0.1";
        }
    }
}