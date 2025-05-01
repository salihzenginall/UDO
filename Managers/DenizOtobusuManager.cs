using System;
using System.Data;
using System.Data.SqlClient;
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
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili, Aktif
                           FROM DenizOtobusleri
                           ORDER BY DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // Aktif deniz otobüslerini getiren metot
        public DataTable AktifDenizOtobusleriniGetir()
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Model, Kapasite, UretimYili
                           FROM DenizOtobusleri
                           WHERE Aktif = 1
                           ORDER BY DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }

        // ComboBox için deniz otobüslerini getiren metot
        public DataTable DenizOtobusleriComboBoxIcinGetir()
        {
            string sorgu = @"SELECT DenizOtobusuID, DenizOtobusuAdi, Kapasite 
                           FROM DenizOtobusleri 
                           WHERE Aktif = 1 
                           ORDER BY DenizOtobusuAdi";

            return dbConnection.ExecuteQuery(sorgu);
        }
    }
}