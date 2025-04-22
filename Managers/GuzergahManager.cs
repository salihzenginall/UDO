using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using UDO.Data;
using UDO.Models;

namespace UDO.Managers
{
    public class GuzergahManager
    {
        private readonly DBConnection dbConnection;

        public GuzergahManager()
        {
            dbConnection = new DBConnection();
        }

        // Get all routes
        public DataTable TumGuzergahlariGetir()
        {
            string sorgu = @"SELECT g.GuzergahID, g.GuzergahKodu, g.GuzergahAdi, g.Aciklama, 
                           g.MesafeKM, g.TahminiSureDakika, g.AktifMi, g.EklenmeTarihi,
                           (SELECT COUNT(*) FROM GuzergahIskeleler gi WHERE gi.GuzergahID = g.GuzergahID) AS DurakSayisi
                           FROM Guzergahlar g
                           ORDER BY g.GuzergahKodu";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Get route by ID
        public DataTable GuzergahGetirById(int guzergahID)
        {
            string sorgu = @"SELECT g.GuzergahID, g.GuzergahKodu, g.GuzergahAdi, g.Aciklama, 
                           g.MesafeKM, g.TahminiSureDakika, g.AktifMi, g.EklenmeTarihi
                           FROM Guzergahlar g
                           WHERE g.GuzergahID = @GuzergahID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Get piers for a specific route
        public DataTable GuzergahIskeleleriniGetir(int guzergahID)
        {
            string sorgu = @"SELECT gi.GuzergahID, gi.IskeleID, i.IskeleAdi, gi.SiraNo, 
                           gi.BeklemesDakika, gi.Aciklama, gi.ZorunluDurak
                           FROM GuzergahIskeleler gi
                           INNER JOIN Iskeleler i ON gi.IskeleID = i.IskeleID
                           WHERE gi.GuzergahID = @GuzergahID
                           ORDER BY gi.SiraNo";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Get all piers
        public DataTable TumIskeleleriGetir()
        {
            string sorgu = @"SELECT i.IskeleID, i.IskeleAdi, i.Sehir, i.Bolge, i.Adres, i.Telefon,
                           i.Koordinatlar, i.Aciklama, i.YolcuKabulDurumu, i.AktifMi,
                           i.KapasiteYolcu, i.KapasiteArac
                           FROM Iskeleler i
                           WHERE i.AktifMi = 1
                           ORDER BY i.IskeleAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Get active routes
        public DataTable AktifGuzergahlariGetir()
        {
            string sorgu = @"SELECT g.GuzergahID, g.GuzergahKodu, g.GuzergahAdi, g.Aciklama, 
                           g.MesafeKM, g.TahminiSureDakika, g.AktifMi, g.EklenmeTarihi,
                           (SELECT COUNT(*) FROM GuzergahIskeleler gi WHERE gi.GuzergahID = g.GuzergahID) AS DurakSayisi
                           FROM Guzergahlar g
                           WHERE g.AktifMi = 1
                           ORDER BY g.GuzergahKodu";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Add a new route
        public bool GuzergahEkle(string guzergahKodu, string guzergahAdi, string aciklama, 
            double mesafeKM, int tahminiSureDakika, bool aktifMi, List<GuzergahIskele> iskeleler, out int guzergahID)
        {
            guzergahID = 0;

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert route
                    string sorguGuzergah = @"INSERT INTO Guzergahlar (GuzergahKodu, GuzergahAdi, Aciklama, 
                                           MesafeKM, TahminiSureDakika, AktifMi, EklenmeTarihi)
                                           VALUES (@GuzergahKodu, @GuzergahAdi, @Aciklama, 
                                           @MesafeKM, @TahminiSureDakika, @AktifMi, GETDATE());
                                           SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdGuzergah = new SqlCommand(sorguGuzergah, connection, transaction);
                    cmdGuzergah.Parameters.AddWithValue("@GuzergahKodu", guzergahKodu);
                    cmdGuzergah.Parameters.AddWithValue("@GuzergahAdi", guzergahAdi);
                    cmdGuzergah.Parameters.AddWithValue("@Aciklama", (object)aciklama ?? DBNull.Value);
                    cmdGuzergah.Parameters.AddWithValue("@MesafeKM", mesafeKM);
                    cmdGuzergah.Parameters.AddWithValue("@TahminiSureDakika", tahminiSureDakika);
                    cmdGuzergah.Parameters.AddWithValue("@AktifMi", aktifMi);

                    // Get the inserted ID
                    guzergahID = Convert.ToInt32(cmdGuzergah.ExecuteScalar());

                    // Insert piers
                    string sorguIskele = @"INSERT INTO GuzergahIskeleler (GuzergahID, IskeleID, SiraNo, 
                                        BeklemesDakika, Aciklama, ZorunluDurak)
                                        VALUES (@GuzergahID, @IskeleID, @SiraNo, 
                                        @BeklemesDakika, @Aciklama, @ZorunluDurak)";

                    foreach (GuzergahIskele iskele in iskeleler)
                    {
                        SqlCommand cmdIskele = new SqlCommand(sorguIskele, connection, transaction);
                        cmdIskele.Parameters.AddWithValue("@GuzergahID", guzergahID);
                        cmdIskele.Parameters.AddWithValue("@IskeleID", iskele.IskeleID);
                        cmdIskele.Parameters.AddWithValue("@SiraNo", iskele.SiraNo);
                        cmdIskele.Parameters.AddWithValue("@BeklemesDakika", iskele.BeklemesDakika);
                        cmdIskele.Parameters.AddWithValue("@Aciklama", (object)iskele.Aciklama ?? DBNull.Value);
                        cmdIskele.Parameters.AddWithValue("@ZorunluDurak", iskele.ZorunluDurak);

                        cmdIskele.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    // Rollback in case of error
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Update an existing route
        public bool GuzergahGuncelle(int guzergahID, string guzergahKodu, string guzergahAdi, string aciklama,
            double mesafeKM, int tahminiSureDakika, bool aktifMi, List<GuzergahIskele> iskeleler)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update route
                    string sorguGuzergah = @"UPDATE Guzergahlar 
                                           SET GuzergahKodu = @GuzergahKodu,
                                           GuzergahAdi = @GuzergahAdi,
                                           Aciklama = @Aciklama,
                                           MesafeKM = @MesafeKM,
                                           TahminiSureDakika = @TahminiSureDakika,
                                           AktifMi = @AktifMi
                                           WHERE GuzergahID = @GuzergahID";

                    SqlCommand cmdGuzergah = new SqlCommand(sorguGuzergah, connection, transaction);
                    cmdGuzergah.Parameters.AddWithValue("@GuzergahID", guzergahID);
                    cmdGuzergah.Parameters.AddWithValue("@GuzergahKodu", guzergahKodu);
                    cmdGuzergah.Parameters.AddWithValue("@GuzergahAdi", guzergahAdi);
                    cmdGuzergah.Parameters.AddWithValue("@Aciklama", (object)aciklama ?? DBNull.Value);
                    cmdGuzergah.Parameters.AddWithValue("@MesafeKM", mesafeKM);
                    cmdGuzergah.Parameters.AddWithValue("@TahminiSureDakika", tahminiSureDakika);
                    cmdGuzergah.Parameters.AddWithValue("@AktifMi", aktifMi);

                    cmdGuzergah.ExecuteNonQuery();

                    // Delete existing piers
                    string sorguSil = "DELETE FROM GuzergahIskeleler WHERE GuzergahID = @GuzergahID";
                    SqlCommand cmdSil = new SqlCommand(sorguSil, connection, transaction);
                    cmdSil.Parameters.AddWithValue("@GuzergahID", guzergahID);
                    cmdSil.ExecuteNonQuery();

                    // Insert updated piers
                    string sorguIskele = @"INSERT INTO GuzergahIskeleler (GuzergahID, IskeleID, SiraNo, 
                                        BeklemesDakika, Aciklama, ZorunluDurak)
                                        VALUES (@GuzergahID, @IskeleID, @SiraNo, 
                                        @BeklemesDakika, @Aciklama, @ZorunluDurak)";

                    foreach (GuzergahIskele iskele in iskeleler)
                    {
                        SqlCommand cmdIskele = new SqlCommand(sorguIskele, connection, transaction);
                        cmdIskele.Parameters.AddWithValue("@GuzergahID", guzergahID);
                        cmdIskele.Parameters.AddWithValue("@IskeleID", iskele.IskeleID);
                        cmdIskele.Parameters.AddWithValue("@SiraNo", iskele.SiraNo);
                        cmdIskele.Parameters.AddWithValue("@BeklemesDakika", iskele.BeklemesDakika);
                        cmdIskele.Parameters.AddWithValue("@Aciklama", (object)iskele.Aciklama ?? DBNull.Value);
                        cmdIskele.Parameters.AddWithValue("@ZorunluDurak", iskele.ZorunluDurak);

                        cmdIskele.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    // Rollback in case of error
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Delete a route
        public bool GuzergahSil(int guzergahID)
        {
            // Check if this route is used in any voyages
            string kontrolSorgu = @"SELECT COUNT(*) FROM Seferler WHERE GuzergahID = @GuzergahID";
            SqlParameter[] kontrolParametreler = new SqlParameter[]
            {
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID }
            };

            int seferSayisi = Convert.ToInt32(dbConnection.ExecuteScalar(kontrolSorgu, kontrolParametreler));

            if (seferSayisi > 0)
            {
                // Route is in use, just deactivate it
                string sorgu = "UPDATE Guzergahlar SET AktifMi = 0 WHERE GuzergahID = @GuzergahID";
                SqlParameter[] parametreler = new SqlParameter[]
                {
                    new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID }
                };

                int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
                return sonuc > 0;
            }
            else
            {
                // Route is not in use, can be completely deleted
                using (SqlConnection connection = dbConnection.GetConnection())
                {
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Delete piers first
                        string sorguIskeleler = "DELETE FROM GuzergahIskeleler WHERE GuzergahID = @GuzergahID";
                        SqlCommand cmdIskeleler = new SqlCommand(sorguIskeleler, connection, transaction);
                        cmdIskeleler.Parameters.AddWithValue("@GuzergahID", guzergahID);
                        cmdIskeleler.ExecuteNonQuery();

                        // Delete route
                        string sorguGuzergah = "DELETE FROM Guzergahlar WHERE GuzergahID = @GuzergahID";
                        SqlCommand cmdGuzergah = new SqlCommand(sorguGuzergah, connection, transaction);
                        cmdGuzergah.Parameters.AddWithValue("@GuzergahID", guzergahID);
                        cmdGuzergah.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        // Rollback in case of error
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // Change route status
        public bool GuzergahDurumDegistir(int guzergahID, bool yeniDurum)
        {
            string sorgu = "UPDATE Guzergahlar SET AktifMi = @AktifMi WHERE GuzergahID = @GuzergahID";
            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID },
                new SqlParameter("@AktifMi", SqlDbType.Bit) { Value = yeniDurum }
            };

            int sonuc = dbConnection.ExecuteNonQuery(sorgu, parametreler);
            return sonuc > 0;
        }

        // Search routes
        public DataTable GuzergahAra(string aramaMetni)
        {
            string sorgu = @"SELECT g.GuzergahID, g.GuzergahKodu, g.GuzergahAdi, g.Aciklama, 
                           g.MesafeKM, g.TahminiSureDakika, g.AktifMi, g.EklenmeTarihi,
                           (SELECT COUNT(*) FROM GuzergahIskeleler gi WHERE gi.GuzergahID = g.GuzergahID) AS DurakSayisi
                           FROM Guzergahlar g
                           WHERE g.GuzergahKodu LIKE @AramaMetni OR g.GuzergahAdi LIKE @AramaMetni
                           ORDER BY g.GuzergahKodu";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@AramaMetni", SqlDbType.VarChar) { Value = "%" + aramaMetni + "%" }
            };

            return dbConnection.ExecuteQuery(sorgu, parametreler);
        }

        // Check if route code already exists
        public bool GuzergahKoduKontrol(string guzergahKodu, int guzergahID = 0)
        {
            string sorgu = @"SELECT COUNT(*) FROM Guzergahlar 
                           WHERE GuzergahKodu = @GuzergahKodu AND GuzergahID <> @GuzergahID";

            SqlParameter[] parametreler = new SqlParameter[]
            {
                new SqlParameter("@GuzergahKodu", SqlDbType.VarChar) { Value = guzergahKodu },
                new SqlParameter("@GuzergahID", SqlDbType.Int) { Value = guzergahID }
            };

            int sonuc = Convert.ToInt32(dbConnection.ExecuteScalar(sorgu, parametreler));
            return sonuc > 0;
        }
    }
}