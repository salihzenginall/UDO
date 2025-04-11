using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace UDO.Data
{
    // Veritabanı bağlantısı ve sorgu işlemlerini yöneten sınıf
    public class DBConnection
    {
        // SQL Server bağlantı dizesi
        private readonly string connectionString;

        // Yapıcı metot - App.config/Web.config dosyasından bağlantı dizesini alır
        public DBConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["UDOConnectionString"].ConnectionString;
        }

        // Veritabanına bağlantı açar ve açık bağlantı nesnesini döndürür
        // Returns: Açık durumdaki SQL bağlantı nesnesi
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        // Açık durumdaki bağlantıyı kapatır
        // Param: connection - Kapatılacak SQL bağlantı nesnesi
        public void CloseConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // SELECT sorguları için kullanılır. Sorgu sonucunu bir DataTable olarak döndürür.
        // Param: query - Çalıştırılacak SQL sorgusu
        // Param: parameters - Sorgu parametreleri (SQL Injection'ı önlemek için)
        // Returns: Sorgu sonucunu içeren DataTable
        // 
        // Kullanım örneği:
        // string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";
        // SqlParameter[] parameters = new SqlParameter[]
        // {
        //     new SqlParameter("@KullaniciAdi", "admin")
        // };
        // DataTable sonuc = dbConnection.ExecuteQuery(query, parameters);
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi burada yapılabilir
                throw new Exception("Sorgu çalıştırılırken hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection(connection);
            }
            return dataTable;
        }

        // INSERT, UPDATE, DELETE gibi veri değiştiren sorgular için kullanılır.
        // Param: query - Çalıştırılacak SQL sorgusu
        // Param: parameters - Sorgu parametreleri (SQL Injection'ı önlemek için)
        // Returns: Etkilenen satır sayısı
        // 
        // Kullanım örneği:
        // string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre) VALUES (@KullaniciAdi, @Sifre)";
        // SqlParameter[] parameters = new SqlParameter[]
        // {
        //     new SqlParameter("@KullaniciAdi", "yenikullanici"),
        //     new SqlParameter("@Sifre", "sifre123")
        // };
        // int etkilenenSatir = dbConnection.ExecuteNonQuery(query, parameters);
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            SqlConnection connection = GetConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi burada yapılabilir
                throw new Exception("Sorgu çalıştırılırken hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection(connection);
            }
            return rowsAffected;
        }

        // Tekil değer döndüren sorgular için kullanılır (COUNT, SUM, AVG, MAX gibi).
        // Sorgunun ilk satırının ilk sütunundaki değeri döndürür.
        // Param: query - Çalıştırılacak SQL sorgusu
        // Param: parameters - Sorgu parametreleri (SQL Injection'ı önlemek için)
        // Returns: Sorgunun ilk satır ve ilk sütunundaki değer
        // 
        // Kullanım örneği:
        // string query = "SELECT COUNT(*) FROM Kullanicilar WHERE Aktif = @Aktif";
        // SqlParameter[] parameters = new SqlParameter[]
        // {
        //     new SqlParameter("@Aktif", true)
        // };
        // int kullaniciSayisi = Convert.ToInt32(dbConnection.ExecuteScalar(query, parameters));
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            SqlConnection connection = GetConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    result = command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi burada yapılabilir
                throw new Exception("Sorgu çalıştırılırken hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection(connection);
            }
            return result;
        }
    }
}