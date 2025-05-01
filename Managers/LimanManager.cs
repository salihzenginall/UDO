using System;
using System.Data;
using System.Data.SqlClient;
using UDO.Models;
using UDO.Data;

namespace UDO.Managers
{
    public class LimanManager
    {
        private readonly DBConnection dbConnection;

        public LimanManager()
        {
            dbConnection = new DBConnection();
        }

        // Tüm limanları getiren metot
        public DataTable TumLimanlariGetir()
        {
            string sorgu = @"SELECT LimanID, LimanAdi, Sehir, Adres, Aciklama, Aktif, KayitTarihi
                           FROM Limanlar
                           ORDER BY LimanAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Sadece aktif limanları getiren metot
        public DataTable AktifLimanlariGetir()
        {
            string sorgu = @"SELECT LimanID, LimanAdi, Sehir, Adres, Aciklama, KayitTarihi
                           FROM Limanlar
                           WHERE Aktif = 1
                           ORDER BY LimanAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // ID'ye göre liman getiren metot
        public Liman LimanGetirById(int limanID)
        {
            string sorgu = @"SELECT LimanID, LimanAdi, Sehir, Adres, Aciklama, Aktif, KayitTarihi
                           FROM Limanlar
                           WHERE LimanID = @LimanID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@LimanID", SqlDbType.Int) { Value = limanID }
            };

            DataTable sonuc = dbConnection.ExecuteQuery(sorgu, parametreler);

            if (sonuc != null && sonuc.Rows.Count > 0)
            {
                DataRow row = sonuc.Rows[0];

                return new Liman
                {
                    LimanID = Convert.ToInt32(row["LimanID"]),
                    LimanAdi = row["LimanAdi"].ToString(),
                    Sehir = row["Sehir"].ToString(),
                    Adres = row["Adres"] != DBNull.Value ? row["Adres"].ToString() : null,
                    Aciklama = row["Aciklama"] != DBNull.Value ? row["Aciklama"].ToString() : null,
                    Aktif = Convert.ToBoolean(row["Aktif"]),
                    KayitTarihi = Convert.ToDateTime(row["KayitTarihi"])
                };
            }

            return null;
        }

        // ComboBox için limanları getir metodu
        public DataTable LimanlariComboBoxIcinGetir()
        {
            string sorgu = @"SELECT LimanID, LimanAdi 
                           FROM Limanlar 
                           WHERE Aktif = 1 
                           ORDER BY LimanAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }
    }
}